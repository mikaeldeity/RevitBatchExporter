namespace XPORT.Dialogs
{
    partial class ExportDialog
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
            this.PurgeCheckBox = new System.Windows.Forms.CheckBox();
            this.UngroupCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveSchedulesCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveCADLinksCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveRVTLinksCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.IssueReasonTextBox = new System.Windows.Forms.TextBox();
            this.IssueReasonLabel = new System.Windows.Forms.Label();
            this.DocumentListBox = new System.Windows.Forms.ListBox();
            this.DocsLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.AutoCheckBox = new System.Windows.Forms.CheckBox();
            this.PrefixLabel = new System.Windows.Forms.Label();
            this.PrefixTextBox = new System.Windows.Forms.TextBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.SuffixLabel = new System.Windows.Forms.Label();
            this.SuffixTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ViewsNotSheetsCheckBox = new System.Windows.Forms.CheckBox();
            this.SheetsCheckBox = new System.Windows.Forms.CheckBox();
            this.ViewsONSheetsCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PurgeCheckBox
            // 
            this.PurgeCheckBox.AutoSize = true;
            this.PurgeCheckBox.Location = new System.Drawing.Point(37, 464);
            this.PurgeCheckBox.Name = "PurgeCheckBox";
            this.PurgeCheckBox.Size = new System.Drawing.Size(86, 17);
            this.PurgeCheckBox.TabIndex = 1;
            this.PurgeCheckBox.TabStop = false;
            this.PurgeCheckBox.Text = "Purge Model";
            this.PurgeCheckBox.UseVisualStyleBackColor = true;
            // 
            // UngroupCheckBox
            // 
            this.UngroupCheckBox.AutoSize = true;
            this.UngroupCheckBox.Location = new System.Drawing.Point(37, 487);
            this.UngroupCheckBox.Name = "UngroupCheckBox";
            this.UngroupCheckBox.Size = new System.Drawing.Size(104, 17);
            this.UngroupCheckBox.TabIndex = 2;
            this.UngroupCheckBox.TabStop = false;
            this.UngroupCheckBox.Text = "Ungroup Groups";
            this.UngroupCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveSchedulesCheckBox
            // 
            this.RemoveSchedulesCheckBox.AutoSize = true;
            this.RemoveSchedulesCheckBox.Location = new System.Drawing.Point(212, 487);
            this.RemoveSchedulesCheckBox.Name = "RemoveSchedulesCheckBox";
            this.RemoveSchedulesCheckBox.Size = new System.Drawing.Size(76, 17);
            this.RemoveSchedulesCheckBox.TabIndex = 4;
            this.RemoveSchedulesCheckBox.TabStop = false;
            this.RemoveSchedulesCheckBox.Text = "Schedules";
            this.RemoveSchedulesCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveCADLinksCheckBox
            // 
            this.RemoveCADLinksCheckBox.AutoSize = true;
            this.RemoveCADLinksCheckBox.Location = new System.Drawing.Point(37, 441);
            this.RemoveCADLinksCheckBox.Name = "RemoveCADLinksCheckBox";
            this.RemoveCADLinksCheckBox.Size = new System.Drawing.Size(76, 17);
            this.RemoveCADLinksCheckBox.TabIndex = 5;
            this.RemoveCADLinksCheckBox.TabStop = false;
            this.RemoveCADLinksCheckBox.Text = "CAD Links";
            this.RemoveCADLinksCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveRVTLinksCheckBox
            // 
            this.RemoveRVTLinksCheckBox.AutoSize = true;
            this.RemoveRVTLinksCheckBox.Location = new System.Drawing.Point(37, 418);
            this.RemoveRVTLinksCheckBox.Name = "RemoveRVTLinksCheckBox";
            this.RemoveRVTLinksCheckBox.Size = new System.Drawing.Size(79, 17);
            this.RemoveRVTLinksCheckBox.TabIndex = 6;
            this.RemoveRVTLinksCheckBox.TabStop = false;
            this.RemoveRVTLinksCheckBox.Text = "Revit Links";
            this.RemoveRVTLinksCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.FlatAppearance.BorderSize = 0;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(37, 530);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(320, 36);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.TabStop = false;
            this.ExportButton.Text = "Export Documents";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // IssueReasonTextBox
            // 
            this.IssueReasonTextBox.Location = new System.Drawing.Point(113, 276);
            this.IssueReasonTextBox.Name = "IssueReasonTextBox";
            this.IssueReasonTextBox.Size = new System.Drawing.Size(244, 20);
            this.IssueReasonTextBox.TabIndex = 9;
            this.IssueReasonTextBox.TabStop = false;
            // 
            // IssueReasonLabel
            // 
            this.IssueReasonLabel.AutoSize = true;
            this.IssueReasonLabel.Location = new System.Drawing.Point(34, 279);
            this.IssueReasonLabel.Name = "IssueReasonLabel";
            this.IssueReasonLabel.Size = new System.Drawing.Size(72, 13);
            this.IssueReasonLabel.TabIndex = 10;
            this.IssueReasonLabel.Text = "Issue Reason";
            // 
            // DocumentListBox
            // 
            this.DocumentListBox.AllowDrop = true;
            this.DocumentListBox.FormattingEnabled = true;
            this.DocumentListBox.HorizontalScrollbar = true;
            this.DocumentListBox.Location = new System.Drawing.Point(37, 38);
            this.DocumentListBox.Name = "DocumentListBox";
            this.DocumentListBox.ScrollAlwaysVisible = true;
            this.DocumentListBox.Size = new System.Drawing.Size(320, 160);
            this.DocumentListBox.TabIndex = 11;
            this.DocumentListBox.TabStop = false;
            this.DocumentListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DocumentListBox_DragDrop);
            this.DocumentListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DocumentListBox_DragEnter);
            // 
            // DocsLabel
            // 
            this.DocsLabel.AutoSize = true;
            this.DocsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocsLabel.Location = new System.Drawing.Point(34, 12);
            this.DocsLabel.Name = "DocsLabel";
            this.DocsLabel.Size = new System.Drawing.Size(191, 13);
            this.DocsLabel.TabIndex = 12;
            this.DocsLabel.Text = "Drag and Drop Revit Documents";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoEllipsis = true;
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(34, 214);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(101, 13);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "Destination Path";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(34, 305);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(58, 13);
            this.DateLabel.TabIndex = 15;
            this.DateLabel.Text = "Issue Date";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(113, 302);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(183, 20);
            this.DateTextBox.TabIndex = 14;
            this.DateTextBox.TabStop = false;
            // 
            // AutoCheckBox
            // 
            this.AutoCheckBox.AutoSize = true;
            this.AutoCheckBox.Checked = true;
            this.AutoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoCheckBox.Location = new System.Drawing.Point(309, 305);
            this.AutoCheckBox.Name = "AutoCheckBox";
            this.AutoCheckBox.Size = new System.Drawing.Size(48, 17);
            this.AutoCheckBox.TabIndex = 16;
            this.AutoCheckBox.TabStop = false;
            this.AutoCheckBox.Text = "Auto";
            this.AutoCheckBox.UseVisualStyleBackColor = true;
            this.AutoCheckBox.CheckedChanged += new System.EventHandler(this.AutoCheckBox_CheckedChanged);
            // 
            // PrefixLabel
            // 
            this.PrefixLabel.AutoSize = true;
            this.PrefixLabel.Location = new System.Drawing.Point(34, 331);
            this.PrefixLabel.Name = "PrefixLabel";
            this.PrefixLabel.Size = new System.Drawing.Size(64, 13);
            this.PrefixLabel.TabIndex = 18;
            this.PrefixLabel.Text = "Name Prefix";
            // 
            // PrefixTextBox
            // 
            this.PrefixTextBox.Location = new System.Drawing.Point(113, 328);
            this.PrefixTextBox.Name = "PrefixTextBox";
            this.PrefixTextBox.Size = new System.Drawing.Size(244, 20);
            this.PrefixTextBox.TabIndex = 17;
            this.PrefixTextBox.TabStop = false;
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(37, 237);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(320, 20);
            this.PathTextBox.TabIndex = 19;
            this.PathTextBox.TabStop = false;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // SuffixLabel
            // 
            this.SuffixLabel.AutoSize = true;
            this.SuffixLabel.Location = new System.Drawing.Point(34, 357);
            this.SuffixLabel.Name = "SuffixLabel";
            this.SuffixLabel.Size = new System.Drawing.Size(64, 13);
            this.SuffixLabel.TabIndex = 21;
            this.SuffixLabel.Text = "Name Suffix";
            // 
            // SuffixTextBox
            // 
            this.SuffixTextBox.Location = new System.Drawing.Point(113, 354);
            this.SuffixTextBox.Name = "SuffixTextBox";
            this.SuffixTextBox.Size = new System.Drawing.Size(244, 20);
            this.SuffixTextBox.TabIndex = 20;
            this.SuffixTextBox.TabStop = false;
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(290, 8);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(67, 20);
            this.RemoveButton.TabIndex = 22;
            this.RemoveButton.TabStop = false;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ViewsNotSheetsCheckBox
            // 
            this.ViewsNotSheetsCheckBox.AutoSize = true;
            this.ViewsNotSheetsCheckBox.Location = new System.Drawing.Point(212, 418);
            this.ViewsNotSheetsCheckBox.Name = "ViewsNotSheetsCheckBox";
            this.ViewsNotSheetsCheckBox.Size = new System.Drawing.Size(123, 17);
            this.ViewsNotSheetsCheckBox.TabIndex = 23;
            this.ViewsNotSheetsCheckBox.TabStop = false;
            this.ViewsNotSheetsCheckBox.Text = "Views not on Sheets";
            this.ViewsNotSheetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SheetsCheckBox
            // 
            this.SheetsCheckBox.AutoSize = true;
            this.SheetsCheckBox.Location = new System.Drawing.Point(212, 464);
            this.SheetsCheckBox.Name = "SheetsCheckBox";
            this.SheetsCheckBox.Size = new System.Drawing.Size(59, 17);
            this.SheetsCheckBox.TabIndex = 24;
            this.SheetsCheckBox.TabStop = false;
            this.SheetsCheckBox.Text = "Sheets";
            this.SheetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewsONSheetsCheckBox
            // 
            this.ViewsONSheetsCheckBox.AutoSize = true;
            this.ViewsONSheetsCheckBox.Location = new System.Drawing.Point(212, 441);
            this.ViewsONSheetsCheckBox.Name = "ViewsONSheetsCheckBox";
            this.ViewsONSheetsCheckBox.Size = new System.Drawing.Size(105, 17);
            this.ViewsONSheetsCheckBox.TabIndex = 25;
            this.ViewsONSheetsCheckBox.TabStop = false;
            this.ViewsONSheetsCheckBox.Text = "Views on Sheets";
            this.ViewsONSheetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Remove";
            // 
            // ExportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(394, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewsONSheetsCheckBox);
            this.Controls.Add(this.SheetsCheckBox);
            this.Controls.Add(this.ViewsNotSheetsCheckBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.SuffixLabel);
            this.Controls.Add(this.SuffixTextBox);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.PrefixLabel);
            this.Controls.Add(this.PrefixTextBox);
            this.Controls.Add(this.AutoCheckBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.DocsLabel);
            this.Controls.Add(this.DocumentListBox);
            this.Controls.Add(this.IssueReasonLabel);
            this.Controls.Add(this.IssueReasonTextBox);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.RemoveRVTLinksCheckBox);
            this.Controls.Add(this.RemoveCADLinksCheckBox);
            this.Controls.Add(this.RemoveSchedulesCheckBox);
            this.Controls.Add(this.UngroupCheckBox);
            this.Controls.Add(this.PurgeCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XPORT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label IssueReasonLabel;
        private System.Windows.Forms.ListBox DocumentListBox;
        private System.Windows.Forms.Label DocsLabel;
        public System.Windows.Forms.CheckBox RemoveSchedulesCheckBox;
        public System.Windows.Forms.CheckBox RemoveCADLinksCheckBox;
        public System.Windows.Forms.CheckBox RemoveRVTLinksCheckBox;
        public System.Windows.Forms.TextBox IssueReasonTextBox;
        public System.Windows.Forms.CheckBox PurgeCheckBox;
        public System.Windows.Forms.CheckBox UngroupCheckBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label DateLabel;
        public System.Windows.Forms.TextBox DateTextBox;
        public System.Windows.Forms.CheckBox AutoCheckBox;
        private System.Windows.Forms.Label PrefixLabel;
        public System.Windows.Forms.TextBox PrefixTextBox;
        public System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label SuffixLabel;
        public System.Windows.Forms.TextBox SuffixTextBox;
        private System.Windows.Forms.Button RemoveButton;
        public System.Windows.Forms.CheckBox ViewsNotSheetsCheckBox;
        public System.Windows.Forms.CheckBox SheetsCheckBox;
        public System.Windows.Forms.CheckBox ViewsONSheetsCheckBox;
        private System.Windows.Forms.Label label1;
    }
}