using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPORT.Dialogs
{
    public partial class ExportDialog : Form
    {
        internal static List<string> doclist = new List<string>();
        public ExportDialog()
        {
            InitializeComponent();
            DateTextBox.Enabled = false;
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (XPORT.Export.destinationpath == "")
            {
                TaskDialog.Show("XPORT", "Set a valid destination folder to continue.");
            }
            else if(XPORT.Export.documents.Count == 0)
            {
                TaskDialog.Show("XPORT", "Add Documents to continue.");
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
                if (file.EndsWith(".rvt") && !XPORT.Export.documents.Contains(file))
                {
                    DocumentListBox.Items.Add(file);
                    XPORT.Export.documents.Add(file);                    
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
                DateTextBox.Text = "";
                DateTextBox.Enabled = false;
            }
            else
            {
                DateTextBox.Enabled = true;
            }
        }
        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(PathTextBox.Text))
            {
                XPORT.Export.destinationpath = PathTextBox.Text + "\\";
            }
            else
            {
                XPORT.Export.destinationpath = "";
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = DocumentListBox.SelectedItem.ToString();
                DocumentListBox.Items.Remove(selected);
                XPORT.Export.documents.Remove(selected);
            }
            catch { }
            
        }
        private void ExportSettingsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(IssueReasonTextBox.Text);
            sb.AppendLine(DateTextBox.Text);
            sb.AppendLine(PrefixTextBox.Text);
            sb.AppendLine(SuffixTextBox.Text);
            sb.AppendLine(AutoCheckBox.Checked.ToString());
            sb.AppendLine(RemoveRVTLinksCheckBox.Checked.ToString());
            sb.AppendLine(RemoveCADLinksCheckBox.Checked.ToString());
            sb.AppendLine(PurgeCheckBox.Checked.ToString());
            sb.AppendLine(UngroupCheckBox.Checked.ToString());
            sb.AppendLine(ViewsNotSheetsCheckBox.Checked.ToString());
            sb.AppendLine(ViewsONSheetsCheckBox.Checked.ToString());
            sb.AppendLine(SheetsCheckBox.Checked.ToString());
            sb.AppendLine(SchedulesCheckBox.Checked.ToString());
            sb.AppendLine(PathTextBox.Text.ToString());

            if (XPORT.Export.documents.Count > 0)
            {
                foreach (string file in XPORT.Export.documents)
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
                TaskDialog.Show("XPORT", "Cannot overwrite the file.");                    
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
                    DateTextBox.Text = settings[1];
                    PrefixTextBox.Text = settings[2];
                    SuffixTextBox.Text = settings[3];
                    AutoCheckBox.Checked = bool.Parse(settings[4]);
                    RemoveRVTLinksCheckBox.Checked = bool.Parse(settings[5]);
                    RemoveCADLinksCheckBox.Checked = bool.Parse(settings[6]);
                    PurgeCheckBox.Checked = bool.Parse(settings[7]);
                    UngroupCheckBox.Checked = bool.Parse(settings[8]);
                    ViewsNotSheetsCheckBox.Checked = bool.Parse(settings[9]);
                    ViewsONSheetsCheckBox.Checked = bool.Parse(settings[10]);
                    SheetsCheckBox.Checked = bool.Parse(settings[11]);
                    SchedulesCheckBox.Checked = bool.Parse(settings[12]);
                    PathTextBox.Text = settings[13];

                    XPORT.Export.documents.Clear();
                    DocumentListBox.Items.Clear();

                    for (int i = 14; i < settings.Count() - 1; i++)
                    {
                        if(settings[i] != "")
                        {
                            XPORT.Export.documents.Add(settings[i]);
                            DocumentListBox.Items.Add(settings[i]);
                        }                        
                    }
                }
                catch
                {
                    TaskDialog.Show("XPORT", "Cannot read the file.");
                }
            }
        }
    }
}
