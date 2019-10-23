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
            if (XPORT.Start.destinationpath == "")
            {
                TaskDialog.Show("XPORT", "Set a valid destination folder to continue.");
            }
            else if(XPORT.Start.documents.Count == 0)
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
                if (file.EndsWith(".rvt") && !XPORT.Start.documents.Contains(file))
                {
                    DocumentListBox.Items.Add(file);
                    XPORT.Start.documents.Add(file);                    
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
                XPORT.Start.destinationpath = PathTextBox.Text + "\\";
            }
            else
            {
                XPORT.Start.destinationpath = "";
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = DocumentListBox.SelectedItem.ToString();
                DocumentListBox.Items.Remove(selected);
                XPORT.Start.documents.Remove(selected);
            }
            catch { }
            
        }
    }
}
