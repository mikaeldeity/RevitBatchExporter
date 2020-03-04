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
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI.Events;
using Autodesk.Revit.DB;

namespace RevitBatchExporter.Dialogs
{
    public partial class ExportDialog : System.Windows.Forms.Form
    {
        internal static List<string> doclist = new List<string>();

        public ExportDialog()
        {

            InitializeComponent();
            
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (RevitBatchExporter.Export.destinationpath == "")
            {
                TaskDialog.Show("Revit Batch Exporter", "Set a valid destination folder to continue.");
            }
            //else if(RevitBatchExporter.Export.documents.Count == 0)
            //{
            //    TaskDialog.Show("Revit Batch Exporter", "Add Documents to continue.");
            //}
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }            
        }
        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(PathTextBox.Text))
            {
                RevitBatchExporter.Export.destinationpath = PathTextBox.Text + "\\";
            }
            else
            {
                RevitBatchExporter.Export.destinationpath = "";
            }
        }
        private void ExportSettingsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(PathTextBox.Text.ToString());
            sb.AppendLine(NWCCheckBox.Checked.ToString());
            sb.AppendLine(IFCCheckBox.Checked.ToString());

            if (RevitBatchExporter.Export.documents.Count > 0)
            {
                foreach (string file in RevitBatchExporter.Export.documents)
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
                    PathTextBox.Text = settings[14];
                    NWCCheckBox.Checked = bool.Parse(settings[16]);
                    IFCCheckBox.Checked = bool.Parse(settings[17]);


                    RevitBatchExporter.Export.documents.Clear();

                    for (int i = 18; i < settings.Count() - 1; i++)
                    {
                        if(settings[i] != "")
                        {
                            RevitBatchExporter.Export.documents.Add(settings[i]);
                        }                        
                    }
                }
                catch
                {
                    TaskDialog.Show("XPORT", "Cannot read the file.");
                }
            }
        }

        private void ExportLabel_Click(object sender, EventArgs e)
        {

        }

        private void DWGCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            DWGCombobox.Enabled = DWGCheckbox.Checked;
        }

        private void IFCCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            IFCCombobox.Enabled = IFCCheckBox.Checked;
        }
    }
}
