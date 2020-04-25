using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RevitBatchExporter.Dialogs
{
    public partial class BatchExportDialog : Form
    {
        internal static List<string> doclist = new List<string>();
        public BatchExportDialog()
        {
            InitializeComponent();
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (RevitBatchExporter.BatchExport.destinationpath == "")
            {
                TaskDialog.Show("Revit Batch Exporter", "Set a valid destination folder to continue.");
            }
            else if(RevitBatchExporter.BatchExport.documents.Count == 0)
            {
                TaskDialog.Show("Revit Batch Exporter", "Add Documents to continue.");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }            
        }
        private void DocumentListBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (file.EndsWith(".rvt") && !RevitBatchExporter.BatchExport.documents.Contains(file))
                {
                    DocumentListBox.Items.Add(file);
                    RevitBatchExporter.BatchExport.documents.Add(file);                    
                }
            }                
        }
        private void DocumentListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }                
        }
        private void AutoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoCheckBox.Checked)
            {
                DateTimePickerIssue.Enabled = false;
            }
            else
            {
                DateTimePickerIssue.Enabled = true;
            }
        }
        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(PathTextBox.Text))
            {
                RevitBatchExporter.BatchExport.destinationpath = PathTextBox.Text + "\\";
            }
            else
            {
                RevitBatchExporter.BatchExport.destinationpath = "";
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = DocumentListBox.SelectedItem.ToString();
                DocumentListBox.Items.Remove(selected);
                RevitBatchExporter.BatchExport.documents.Remove(selected);
            }
            catch { }
            
        }
        private void ExportSettingsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(IssueReasonTextBox.Text);
            sb.AppendLine(DateTimePickerIssue.Value.ToString("yyyy/MM/dd"));
            sb.AppendLine(PrefixTextBox.Text);
            sb.AppendLine(SuffixTextBox.Text);
            sb.AppendLine(SafeNameTextbox.Text);
            sb.AppendLine(AutoCheckBox.Checked.ToString());
            sb.AppendLine(RemoveRVTLinksCheckBox.Checked.ToString());
            sb.AppendLine(RemoveCADLinksCheckBox.Checked.ToString());
            sb.AppendLine(RemoveCADImportsCheckBox.Checked.ToString());
            sb.AppendLine(PurgeCheckBox.Checked.ToString());
            sb.AppendLine(UngroupCheckBox.Checked.ToString());
            sb.AppendLine(ViewsNotSheetsCheckBox.Checked.ToString());
            sb.AppendLine(ViewsONSheetsCheckBox.Checked.ToString());
            sb.AppendLine(SheetsCheckBox.Checked.ToString());
            sb.AppendLine(SchedulesCheckBox.Checked.ToString());
            sb.AppendLine(PathTextBox.Text.ToString());
            sb.AppendLine(RVTCheckBox.Checked.ToString());
            sb.AppendLine(NWCCheckBox.Checked.ToString());
            sb.AppendLine(IFCCheckBox.Checked.ToString());
            sb.AppendLine(AuditCheckBox.Checked.ToString());

            if (RevitBatchExporter.BatchExport.documents.Count > 0)
            {
                foreach (string file in RevitBatchExporter.BatchExport.documents)
                {
                    sb.AppendLine(file);
                }
            }

            string settings = sb.ToString();

            var filedialog = new SaveFileDialog();

            filedialog.InitialDirectory = "c:\\";

            filedialog.Filter = "txt files (*.txt)|*.txt";

            var dialog = filedialog.ShowDialog();

            if (dialog != DialogResult.OK)
            {
                return;
            }            
            try
            {
                File.WriteAllText(filedialog.FileName, settings);
            }
            catch 
            {
                TaskDialog.Show("Revit Batch Exporter", "Cannot overwrite the file.");                    
            }
        }
        private void ImportSettingsButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";

            openFileDialog.Filter = "txt files (*.txt)|*.txt";            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string settingsfile = File.ReadAllText(openFileDialog.FileName);
                    string[] settings = settingsfile.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                    IssueReasonTextBox.Text = settings[0];
                    DateTimePickerIssue.Value = DateTime.Parse(settings[1]);
                    PrefixTextBox.Text = settings[2];
                    SuffixTextBox.Text = settings[3];
                    
                    AutoCheckBox.Checked = bool.Parse(settings[5]);
                    RemoveRVTLinksCheckBox.Checked = bool.Parse(settings[6]);
                    RemoveCADLinksCheckBox.Checked = bool.Parse(settings[7]);
                    RemoveCADImportsCheckBox.Checked = bool.Parse(settings[8]);
                    PurgeCheckBox.Checked = bool.Parse(settings[9]);
                    UngroupCheckBox.Checked = bool.Parse(settings[10]);
                    ViewsNotSheetsCheckBox.Checked = bool.Parse(settings[11]);
                    ViewsONSheetsCheckBox.Checked = bool.Parse(settings[12]);
                    SheetsCheckBox.Checked = bool.Parse(settings[13]);
                    SchedulesCheckBox.Checked = bool.Parse(settings[14]);
                    PathTextBox.Text = settings[15];
                    RVTCheckBox.Checked = bool.Parse(settings[16]);
                    NWCCheckBox.Checked = bool.Parse(settings[17]);
                    IFCCheckBox.Checked = bool.Parse(settings[18]);
                    AuditCheckBox.Checked = bool.Parse(settings[19]);


                    RevitBatchExporter.BatchExport.documents.Clear();
                    DocumentListBox.Items.Clear();

                    for (int i = 20; i < settings.Count() - 1; i++)
                    {
                        if(settings[i] != "")
                        {
                            RevitBatchExporter.BatchExport.documents.Add(settings[i]);
                            DocumentListBox.Items.Add(settings[i]);
                        }                        
                    }
                }
                catch
                {
                    TaskDialog.Show("Revit Batch Exporter", "Cannot read the file.");
                }
            }
        }

        private void BatchExportDialog_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Subcategories Manager", "Developed by Mikael Santrolli\n\nmikael.santrolli@gmail.com");
        }
    }
}
