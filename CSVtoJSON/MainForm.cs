using CsvHelper;
using System.Dynamic;
using System.Globalization;
using System.Text.Json;

namespace CSVtoJSON
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void convertCsvToJsonButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog_result = this.CSVtoJSONopenFileDialog.ShowDialog();

            if (dialog_result == DialogResult.OK)
            {
                string fileName = this.CSVtoJSONopenFileDialog.FileName;

                using StreamReader reader = new StreamReader(fileName);
                using CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                IEnumerable<dynamic> records = csv.GetRecords<dynamic>();

                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(records, options);

                this.resultRichTextBox.Text = json;
            }
        }

        private void convertJsonToCsvButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog_result = this.JSONtoCSVopenFileDialog.ShowDialog();

            if (dialog_result == DialogResult.OK)
            {
                string fileName = this.JSONtoCSVopenFileDialog.FileName;

                string json = File.ReadAllText(fileName);

                IEnumerable<dynamic> records = JsonSerializer.Deserialize<ExpandoObject[]>(json)!;

                using StringWriter writer = new StringWriter();
                using CsvWriter csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(records);

                string csv = writer.ToString();
                this.resultRichTextBox.Text = csv;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string content = this.resultRichTextBox.Text;
            
            if (string.IsNullOrEmpty(content) == false)
            {
                Clipboard.SetText(content);
            }
        }
    }
}