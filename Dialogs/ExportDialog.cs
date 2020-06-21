using Autodesk.Revit.UI;
using System;
using System.IO;
using System.Windows.Forms;

namespace RevitBatchExporter.Dialogs
{
    public partial class ExportDialog : Form
    {
        public ExportDialog()
        {
            InitializeComponent();
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (Export.DestinationPath == string.Empty)
            {
                TaskDialog.Show("Export", "Set a valid destination folder to continue.");
                return;
            }
            if (Export.Documents.Count == 0)
            {
                TaskDialog.Show("Export", "Add Documents to continue.");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void DocumentListBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (file.EndsWith(".rvt") && !Export.Documents.Contains(file))
                {
                    DocumentListBox.Items.Add(file);
                    Export.Documents.Add(file);
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
                Export.DestinationPath = PathTextBox.Text + "\\";
            }
            else
            {
                Export.DestinationPath = string.Empty;
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (DocumentListBox.SelectedItem != null)
            {
                string selected = DocumentListBox.SelectedItem.ToString();
                DocumentListBox.Items.Remove(selected);
                Export.Documents.Remove(selected);
            }
        }
    }
}
