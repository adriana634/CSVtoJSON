namespace CSVtoJSON
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.convertCsvToJsonButton = new System.Windows.Forms.Button();
            this.convertJsonToCsvButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "CSV files|*.csv";
            // 
            // convertCsvToJsonButton
            // 
            this.convertCsvToJsonButton.Location = new System.Drawing.Point(37, 41);
            this.convertCsvToJsonButton.Name = "convertCsvToJsonButton";
            this.convertCsvToJsonButton.Size = new System.Drawing.Size(622, 66);
            this.convertCsvToJsonButton.TabIndex = 0;
            this.convertCsvToJsonButton.Text = "Convert CSV to JSON";
            this.convertCsvToJsonButton.UseVisualStyleBackColor = true;
            this.convertCsvToJsonButton.Click += new System.EventHandler(this.convertCsvToJsonButton_Click);
            // 
            // convertJsonToCsvButton
            // 
            this.convertJsonToCsvButton.Location = new System.Drawing.Point(37, 113);
            this.convertJsonToCsvButton.Name = "convertJsonToCsvButton";
            this.convertJsonToCsvButton.Size = new System.Drawing.Size(622, 66);
            this.convertJsonToCsvButton.TabIndex = 1;
            this.convertJsonToCsvButton.Text = "Convert JSON to CSV";
            this.convertJsonToCsvButton.UseVisualStyleBackColor = true;
            this.convertJsonToCsvButton.Click += new System.EventHandler(this.convertJsonToCsvButton_Click);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.ContextMenuStrip = this.contextMenuStrip;
            this.resultRichTextBox.Location = new System.Drawing.Point(37, 212);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.Size = new System.Drawing.Size(622, 274);
            this.resultRichTextBox.TabIndex = 2;
            this.resultRichTextBox.Text = "";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(135, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.copyToolStripMenuItem.Text = "Copy result";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 498);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.convertJsonToCsvButton);
            this.Controls.Add(this.convertCsvToJsonButton);
            this.Name = "MainForm";
            this.Text = "CSV/JSON converter";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button convertCsvToJsonButton;
        private Button convertJsonToCsvButton;
        private RichTextBox resultRichTextBox;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem copyToolStripMenuItem;
    }
}