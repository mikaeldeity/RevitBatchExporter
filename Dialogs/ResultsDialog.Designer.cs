namespace RevitBatchExporter.Dialogs
{
    partial class ResultsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultsView = new System.Windows.Forms.ListView();
            this.DocumentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RVTHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NWCHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IFCHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResultsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ResultsView
            // 
            this.ResultsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DocumentHeader,
            this.RVTHeader,
            this.NWCHeader,
            this.IFCHeader,
            this.ResultsHeader,
            this.TimeHeader});
            this.ResultsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ResultsView.HideSelection = false;
            this.ResultsView.Location = new System.Drawing.Point(0, 0);
            this.ResultsView.Margin = new System.Windows.Forms.Padding(0);
            this.ResultsView.MultiSelect = false;
            this.ResultsView.Name = "ResultsView";
            this.ResultsView.Size = new System.Drawing.Size(459, 333);
            this.ResultsView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ResultsView.TabIndex = 0;
            this.ResultsView.UseCompatibleStateImageBehavior = false;
            this.ResultsView.View = System.Windows.Forms.View.Details;
            // 
            // DocumentHeader
            // 
            this.DocumentHeader.Text = "Document";
            this.DocumentHeader.Width = 120;
            // 
            // RVTHeader
            // 
            this.RVTHeader.Text = "RVT";
            this.RVTHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RVTHeader.Width = 50;
            // 
            // NWCHeader
            // 
            this.NWCHeader.Text = "NWC";
            this.NWCHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NWCHeader.Width = 50;
            // 
            // IFCHeader
            // 
            this.IFCHeader.Text = "IFC";
            this.IFCHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IFCHeader.Width = 50;
            // 
            // ResultsHeader
            // 
            this.ResultsHeader.Text = "Results";
            this.ResultsHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResultsHeader.Width = 80;
            // 
            // TimeHeader
            // 
            this.TimeHeader.Text = "Time";
            this.TimeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeHeader.Width = 100;
            // 
            // ResultsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 333);
            this.Controls.Add(this.ResultsView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultsDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revit Batch Exporter";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView ResultsView;
        private System.Windows.Forms.ColumnHeader DocumentHeader;
        private System.Windows.Forms.ColumnHeader RVTHeader;
        private System.Windows.Forms.ColumnHeader NWCHeader;
        private System.Windows.Forms.ColumnHeader IFCHeader;
        private System.Windows.Forms.ColumnHeader ResultsHeader;
        private System.Windows.Forms.ColumnHeader TimeHeader;
    }
}