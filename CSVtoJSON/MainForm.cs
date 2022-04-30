using CsvHelper;
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
            DialogResult dialog_result = this.openFileDialog.ShowDialog();

            if (dialog_result == DialogResult.OK)
            {
                string filename = this.openFileDialog.FileName;

                using StreamReader reader = new StreamReader(filename);
                using CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                IEnumerable<dynamic> records = csv.GetRecords<dynamic>();

                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(records, options);

                this.resultRichTextBox.Text = json;
            }
        }

        private void convertJsonToCsvButton_Click(object sender, EventArgs e)
        {

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