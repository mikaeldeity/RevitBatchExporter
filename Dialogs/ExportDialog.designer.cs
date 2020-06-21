namespace RevitBatchExporter.Dialogs
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
            this.ExportButton = new System.Windows.Forms.Button();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Data = new System.Windows.Forms.TableLayoutPanel();
            this.AuditCheckBox = new System.Windows.Forms.CheckBox();
            this.SafeNameTextbox = new System.Windows.Forms.TextBox();
            this.KeepViewLabel = new System.Windows.Forms.Label();
            this.PrefixLabel = new System.Windows.Forms.Label();
            this.PrefixTextBox = new System.Windows.Forms.TextBox();
            this.SuffixLabel = new System.Windows.Forms.Label();
            this.SuffixTextBox = new System.Windows.Forms.TextBox();
            this.RemoveGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Remove = new System.Windows.Forms.TableLayoutPanel();
            this.TemplatesCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveRVTLinksCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveCADLinksCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveCADImportsCheckBox = new System.Windows.Forms.CheckBox();
            this.PurgeCheckBox = new System.Windows.Forms.CheckBox();
            this.UngroupCheckBox = new System.Windows.Forms.CheckBox();
            this.SheetsCheckBox = new System.Windows.Forms.CheckBox();
            this.ViewsONSheetsCheckBox = new System.Windows.Forms.CheckBox();
            this.ViewsNOTSheetsCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveSchedulesCheckBox = new System.Windows.Forms.CheckBox();
            this.IssueDateGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Date = new System.Windows.Forms.TableLayoutPanel();
            this.DateTimePickerIssue = new System.Windows.Forms.DateTimePicker();
            this.AutoCheckBox = new System.Windows.Forms.CheckBox();
            this.DocumentListBox = new System.Windows.Forms.ListBox();
            this.DestinationGroupBox = new System.Windows.Forms.GroupBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.Panel_White = new System.Windows.Forms.Panel();
            this.DetachGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscardRadioButton = new System.Windows.Forms.RadioButton();
            this.PreserveRadioButton = new System.Windows.Forms.RadioButton();
            this.DataGroupBox.SuspendLayout();
            this.tableLayoutPanel_Data.SuspendLayout();
            this.RemoveGroupBox.SuspendLayout();
            this.tableLayoutPanel_Remove.SuspendLayout();
            this.IssueDateGroupBox.SuspendLayout();
            this.tableLayoutPanel_Date.SuspendLayout();
            this.DestinationGroupBox.SuspendLayout();
            this.Panel_White.SuspendLayout();
            this.DetachGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.Color.Black;
            this.ExportButton.Location = new System.Drawing.Point(10, 476);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(310, 35);
            this.ExportButton.TabIndex = 19;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.BackColor = System.Drawing.Color.White;
            this.DataGroupBox.Controls.Add(this.tableLayoutPanel_Data);
            this.DataGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataGroupBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.DataGroupBox.Location = new System.Drawing.Point(10, 132);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(310, 127);
            this.DataGroupBox.TabIndex = 0;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "Options";
            // 
            // tableLayoutPanel_Data
            // 
            this.tableLayoutPanel_Data.ColumnCount = 2;
            this.tableLayoutPanel_Data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel_Data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Data.Controls.Add(this.AuditCheckBox, 0, 3);
            this.tableLayoutPanel_Data.Controls.Add(this.SafeNameTextbox, 1, 2);
            this.tableLayoutPanel_Data.Controls.Add(this.KeepViewLabel, 0, 2);
            this.tableLayoutPanel_Data.Controls.Add(this.PrefixLabel, 0, 0);
            this.tableLayoutPanel_Data.Controls.Add(this.PrefixTextBox, 1, 0);
            this.tableLayoutPanel_Data.Controls.Add(this.SuffixLabel, 0, 1);
            this.tableLayoutPanel_Data.Controls.Add(this.SuffixTextBox, 1, 1);
            this.tableLayoutPanel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Data.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel_Data.Name = "tableLayoutPanel_Data";
            this.tableLayoutPanel_Data.RowCount = 4;
            this.tableLayoutPanel_Data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel_Data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel_Data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel_Data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel_Data.Size = new System.Drawing.Size(304, 106);
            this.tableLayoutPanel_Data.TabIndex = 20;
            // 
            // AuditCheckBox
            // 
            this.AuditCheckBox.AutoSize = true;
            this.tableLayoutPanel_Data.SetColumnSpan(this.AuditCheckBox, 2);
            this.AuditCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuditCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuditCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.AuditCheckBox.Location = new System.Drawing.Point(5, 81);
            this.AuditCheckBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.AuditCheckBox.Name = "AuditCheckBox";
            this.AuditCheckBox.Size = new System.Drawing.Size(296, 22);
            this.AuditCheckBox.TabIndex = 16;
            this.AuditCheckBox.TabStop = false;
            this.AuditCheckBox.Text = "Audit";
            this.AuditCheckBox.UseVisualStyleBackColor = true;
            // 
            // SafeNameTextbox
            // 
            this.SafeNameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SafeNameTextbox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.SafeNameTextbox.Location = new System.Drawing.Point(95, 55);
            this.SafeNameTextbox.MaxLength = 100;
            this.SafeNameTextbox.Name = "SafeNameTextbox";
            this.SafeNameTextbox.Size = new System.Drawing.Size(206, 22);
            this.SafeNameTextbox.TabIndex = 5;
            this.SafeNameTextbox.Text = "Splash";
            // 
            // KeepViewLabel
            // 
            this.KeepViewLabel.AutoSize = true;
            this.KeepViewLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeepViewLabel.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.KeepViewLabel.Location = new System.Drawing.Point(5, 57);
            this.KeepViewLabel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.KeepViewLabel.Name = "KeepViewLabel";
            this.KeepViewLabel.Size = new System.Drawing.Size(84, 18);
            this.KeepViewLabel.TabIndex = 0;
            this.KeepViewLabel.Text = "Keep Sheets";
            // 
            // PrefixLabel
            // 
            this.PrefixLabel.AutoSize = true;
            this.PrefixLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrefixLabel.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.PrefixLabel.Location = new System.Drawing.Point(5, 5);
            this.PrefixLabel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.PrefixLabel.Name = "PrefixLabel";
            this.PrefixLabel.Size = new System.Drawing.Size(84, 18);
            this.PrefixLabel.TabIndex = 0;
            this.PrefixLabel.Text = "Prefix";
            // 
            // PrefixTextBox
            // 
            this.PrefixTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrefixTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.PrefixTextBox.Location = new System.Drawing.Point(95, 3);
            this.PrefixTextBox.Name = "PrefixTextBox";
            this.PrefixTextBox.Size = new System.Drawing.Size(206, 22);
            this.PrefixTextBox.TabIndex = 3;
            // 
            // SuffixLabel
            // 
            this.SuffixLabel.AutoSize = true;
            this.SuffixLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuffixLabel.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.SuffixLabel.Location = new System.Drawing.Point(5, 31);
            this.SuffixLabel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.SuffixLabel.Name = "SuffixLabel";
            this.SuffixLabel.Size = new System.Drawing.Size(84, 18);
            this.SuffixLabel.TabIndex = 0;
            this.SuffixLabel.Text = "Suffix";
            // 
            // SuffixTextBox
            // 
            this.SuffixTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuffixTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.SuffixTextBox.Location = new System.Drawing.Point(95, 29);
            this.SuffixTextBox.Name = "SuffixTextBox";
            this.SuffixTextBox.Size = new System.Drawing.Size(206, 22);
            this.SuffixTextBox.TabIndex = 4;
            // 
            // RemoveGroupBox
            // 
            this.RemoveGroupBox.BackColor = System.Drawing.Color.White;
            this.RemoveGroupBox.Controls.Add(this.tableLayoutPanel_Remove);
            this.RemoveGroupBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoveGroupBox.Location = new System.Drawing.Point(10, 269);
            this.RemoveGroupBox.Name = "RemoveGroupBox";
            this.RemoveGroupBox.Size = new System.Drawing.Size(310, 149);
            this.RemoveGroupBox.TabIndex = 38;
            this.RemoveGroupBox.TabStop = false;
            this.RemoveGroupBox.Text = "Remove";
            // 
            // tableLayoutPanel_Remove
            // 
            this.tableLayoutPanel_Remove.ColumnCount = 2;
            this.tableLayoutPanel_Remove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Remove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Remove.Controls.Add(this.TemplatesCheckBox, 0, 4);
            this.tableLayoutPanel_Remove.Controls.Add(this.RemoveRVTLinksCheckBox, 0, 0);
            this.tableLayoutPanel_Remove.Controls.Add(this.RemoveCADLinksCheckBox, 0, 1);
            this.tableLayoutPanel_Remove.Controls.Add(this.RemoveCADImportsCheckBox, 0, 2);
            this.tableLayoutPanel_Remove.Controls.Add(this.PurgeCheckBox, 0, 3);
            this.tableLayoutPanel_Remove.Controls.Add(this.UngroupCheckBox, 0, 4);
            this.tableLayoutPanel_Remove.Controls.Add(this.SheetsCheckBox, 1, 2);
            this.tableLayoutPanel_Remove.Controls.Add(this.ViewsONSheetsCheckBox, 1, 1);
            this.tableLayoutPanel_Remove.Controls.Add(this.ViewsNOTSheetsCheckBox, 1, 0);
            this.tableLayoutPanel_Remove.Controls.Add(this.RemoveSchedulesCheckBox, 1, 3);
            this.tableLayoutPanel_Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Remove.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel_Remove.Name = "tableLayoutPanel_Remove";
            this.tableLayoutPanel_Remove.RowCount = 5;
            this.tableLayoutPanel_Remove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Remove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Remove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Remove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Remove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Remove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Remove.Size = new System.Drawing.Size(304, 128);
            this.tableLayoutPanel_Remove.TabIndex = 2;
            // 
            // TemplatesCheckBox
            // 
            this.TemplatesCheckBox.AutoSize = true;
            this.TemplatesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TemplatesCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.TemplatesCheckBox.Location = new System.Drawing.Point(5, 103);
            this.TemplatesCheckBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.TemplatesCheckBox.Name = "TemplatesCheckBox";
            this.TemplatesCheckBox.Size = new System.Drawing.Size(73, 19);
            this.TemplatesCheckBox.TabIndex = 10;
            this.TemplatesCheckBox.TabStop = false;
            this.TemplatesCheckBox.Text = "Templates";
            this.TemplatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveRVTLinksCheckBox
            // 
            this.RemoveRVTLinksCheckBox.AutoSize = true;
            this.RemoveRVTLinksCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveRVTLinksCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRVTLinksCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.RemoveRVTLinksCheckBox.Location = new System.Drawing.Point(5, 3);
            this.RemoveRVTLinksCheckBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.RemoveRVTLinksCheckBox.Name = "RemoveRVTLinksCheckBox";
            this.RemoveRVTLinksCheckBox.Size = new System.Drawing.Size(144, 19);
            this.RemoveRVTLinksCheckBox.TabIndex = 6;
            this.RemoveRVTLinksCheckBox.TabStop = false;
            this.RemoveRVTLinksCheckBox.Text = "Revit Links";
            this.RemoveRVTLinksCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveCADLinksCheckBox
            // 
            this.RemoveCADLinksCheckBox.AutoSize = true;
            this.RemoveCADLinksCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveCADLinksCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCADLinksCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.RemoveCADLinksCheckBox.Location = new System.Drawing.Point(5, 28);
            this.RemoveCADLinksCheckBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.RemoveCADLinksCheckBox.Name = "RemoveCADLinksCheckBox";
            this.RemoveCADLinksCheckBox.Size = new System.Drawing.Size(144, 19);
            this.RemoveCADLinksCheckBox.TabIndex = 7;
            this.RemoveCADLinksCheckBox.TabStop = false;
            this.RemoveCADLinksCheckBox.Text = "CAD Links";
            this.RemoveCADLinksCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveCADImportsCheckBox
            // 
            this.RemoveCADImportsCheckBox.AutoSize = true;
            this.RemoveCADImportsCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveCADImportsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCADImportsCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.RemoveCADImportsCheckBox.Location = new System.Drawing.Point(5, 53);
            this.RemoveCADImportsCheckBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.RemoveCADImportsCheckBox.Name = "RemoveCADImportsCheckBox";
            this.RemoveCADImportsCheckBox.Size = new System.Drawing.Size(144, 19);
            this.RemoveCADImportsCheckBox.TabIndex = 8;
            this.RemoveCADImportsCheckBox.TabStop = false;
            this.RemoveCADImportsCheckBox.Text = "CAD Imports";
            this.RemoveCADImportsCheckBox.UseVisualStyleBackColor = true;
            // 
            // PurgeCheckBox
            // 
            this.PurgeCheckBox.AutoSize = true;
            this.PurgeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurgeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurgeCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.PurgeCheckBox.Location = new System.Drawing.Point(5, 78);
            this.PurgeCheckBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.PurgeCheckBox.Name = "PurgeCheckBox";
            this.PurgeCheckBox.Size = new System.Drawing.Size(144, 19);
            this.PurgeCheckBox.TabIndex = 9;
            this.PurgeCheckBox.TabStop = false;
            this.PurgeCheckBox.Text = "Purge";
            this.PurgeCheckBox.UseVisualStyleBackColor = true;
            // 
            // UngroupCheckBox
            // 
            this.UngroupCheckBox.AutoSize = true;
            this.UngroupCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UngroupCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UngroupCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.UngroupCheckBox.Location = new System.Drawing.Point(157, 103);
            this.UngroupCheckBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.UngroupCheckBox.Name = "UngroupCheckBox";
            this.UngroupCheckBox.Size = new System.Drawing.Size(144, 22);
            this.UngroupCheckBox.TabIndex = 15;
            this.UngroupCheckBox.TabStop = false;
            this.UngroupCheckBox.Text = "Ungroup Groups";
            this.UngroupCheckBox.UseVisualStyleBackColor = true;
            // 
            // SheetsCheckBox
            // 
            this.SheetsCheckBox.AutoSize = true;
            this.SheetsCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SheetsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SheetsCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.SheetsCheckBox.Location = new System.Drawing.Point(157, 53);
            this.SheetsCheckBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.SheetsCheckBox.Name = "SheetsCheckBox";
            this.SheetsCheckBox.Size = new System.Drawing.Size(144, 19);
            this.SheetsCheckBox.TabIndex = 13;
            this.SheetsCheckBox.TabStop = false;
            this.SheetsCheckBox.Text = "Sheets";
            this.SheetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewsONSheetsCheckBox
            // 
            this.ViewsONSheetsCheckBox.AutoSize = true;
            this.ViewsONSheetsCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewsONSheetsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewsONSheetsCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.ViewsONSheetsCheckBox.Location = new System.Drawing.Point(157, 28);
            this.ViewsONSheetsCheckBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.ViewsONSheetsCheckBox.Name = "ViewsONSheetsCheckBox";
            this.ViewsONSheetsCheckBox.Size = new System.Drawing.Size(144, 19);
            this.ViewsONSheetsCheckBox.TabIndex = 12;
            this.ViewsONSheetsCheckBox.TabStop = false;
            this.ViewsONSheetsCheckBox.Text = "Views on Sheets";
            this.ViewsONSheetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewsNOTSheetsCheckBox
            // 
            this.ViewsNOTSheetsCheckBox.AutoSize = true;
            this.ViewsNOTSheetsCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewsNOTSheetsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewsNOTSheetsCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.ViewsNOTSheetsCheckBox.Location = new System.Drawing.Point(157, 3);
            this.ViewsNOTSheetsCheckBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.ViewsNOTSheetsCheckBox.Name = "ViewsNOTSheetsCheckBox";
            this.ViewsNOTSheetsCheckBox.Size = new System.Drawing.Size(144, 19);
            this.ViewsNOTSheetsCheckBox.TabIndex = 11;
            this.ViewsNOTSheetsCheckBox.TabStop = false;
            this.ViewsNOTSheetsCheckBox.Text = "Views not on Sheets";
            this.ViewsNOTSheetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoveSchedulesCheckBox
            // 
            this.RemoveSchedulesCheckBox.AutoSize = true;
            this.RemoveSchedulesCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveSchedulesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSchedulesCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.RemoveSchedulesCheckBox.Location = new System.Drawing.Point(157, 78);
            this.RemoveSchedulesCheckBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.RemoveSchedulesCheckBox.Name = "RemoveSchedulesCheckBox";
            this.RemoveSchedulesCheckBox.Size = new System.Drawing.Size(144, 19);
            this.RemoveSchedulesCheckBox.TabIndex = 14;
            this.RemoveSchedulesCheckBox.TabStop = false;
            this.RemoveSchedulesCheckBox.Text = "Schedules";
            this.RemoveSchedulesCheckBox.UseVisualStyleBackColor = true;
            // 
            // IssueDateGroupBox
            // 
            this.IssueDateGroupBox.BackColor = System.Drawing.Color.White;
            this.IssueDateGroupBox.Controls.Add(this.tableLayoutPanel_Date);
            this.IssueDateGroupBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.IssueDateGroupBox.Location = new System.Drawing.Point(10, 69);
            this.IssueDateGroupBox.Name = "IssueDateGroupBox";
            this.IssueDateGroupBox.Size = new System.Drawing.Size(310, 55);
            this.IssueDateGroupBox.TabIndex = 0;
            this.IssueDateGroupBox.TabStop = false;
            this.IssueDateGroupBox.Text = "Issue Date";
            // 
            // tableLayoutPanel_Date
            // 
            this.tableLayoutPanel_Date.ColumnCount = 2;
            this.tableLayoutPanel_Date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel_Date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Date.Controls.Add(this.DateTimePickerIssue, 0, 0);
            this.tableLayoutPanel_Date.Controls.Add(this.AutoCheckBox, 1, 0);
            this.tableLayoutPanel_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Date.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel_Date.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.tableLayoutPanel_Date.Name = "tableLayoutPanel_Date";
            this.tableLayoutPanel_Date.RowCount = 1;
            this.tableLayoutPanel_Date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Date.Size = new System.Drawing.Size(304, 34);
            this.tableLayoutPanel_Date.TabIndex = 21;
            // 
            // DateTimePickerIssue
            // 
            this.DateTimePickerIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePickerIssue.Enabled = false;
            this.DateTimePickerIssue.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.DateTimePickerIssue.Location = new System.Drawing.Point(5, 5);
            this.DateTimePickerIssue.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.DateTimePickerIssue.Name = "DateTimePickerIssue";
            this.DateTimePickerIssue.Size = new System.Drawing.Size(232, 22);
            this.DateTimePickerIssue.TabIndex = 1;
            this.DateTimePickerIssue.TabStop = false;
            // 
            // AutoCheckBox
            // 
            this.AutoCheckBox.AutoSize = true;
            this.AutoCheckBox.Checked = true;
            this.AutoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoCheckBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.AutoCheckBox.Location = new System.Drawing.Point(250, 3);
            this.AutoCheckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.AutoCheckBox.Name = "AutoCheckBox";
            this.AutoCheckBox.Size = new System.Drawing.Size(51, 28);
            this.AutoCheckBox.TabIndex = 2;
            this.AutoCheckBox.TabStop = false;
            this.AutoCheckBox.Text = "Auto";
            this.AutoCheckBox.UseVisualStyleBackColor = true;
            this.AutoCheckBox.CheckedChanged += new System.EventHandler(this.AutoCheckBox_CheckedChanged);
            // 
            // DocumentListBox
            // 
            this.DocumentListBox.AllowDrop = true;
            this.DocumentListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocumentListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.DocumentListBox.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentListBox.FormattingEnabled = true;
            this.DocumentListBox.HorizontalScrollbar = true;
            this.DocumentListBox.ItemHeight = 18;
            this.DocumentListBox.Location = new System.Drawing.Point(0, 0);
            this.DocumentListBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.DocumentListBox.Name = "DocumentListBox";
            this.DocumentListBox.ScrollAlwaysVisible = true;
            this.DocumentListBox.Size = new System.Drawing.Size(275, 523);
            this.DocumentListBox.TabIndex = 0;
            this.DocumentListBox.TabStop = false;
            this.DocumentListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DocumentListBox_DragDrop);
            this.DocumentListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DocumentListBox_DragEnter);
            // 
            // DestinationGroupBox
            // 
            this.DestinationGroupBox.BackColor = System.Drawing.Color.White;
            this.DestinationGroupBox.Controls.Add(this.PathTextBox);
            this.DestinationGroupBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.DestinationGroupBox.Location = new System.Drawing.Point(10, 10);
            this.DestinationGroupBox.Name = "DestinationGroupBox";
            this.DestinationGroupBox.Size = new System.Drawing.Size(310, 50);
            this.DestinationGroupBox.TabIndex = 0;
            this.DestinationGroupBox.TabStop = false;
            this.DestinationGroupBox.Text = "Destination Path";
            // 
            // PathTextBox
            // 
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.PathTextBox.Location = new System.Drawing.Point(8, 21);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(294, 22);
            this.PathTextBox.TabIndex = 0;
            this.PathTextBox.TabStop = false;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(193, 476);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(60, 25);
            this.RemoveButton.TabIndex = 0;
            this.RemoveButton.TabStop = false;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Panel_White
            // 
            this.Panel_White.BackColor = System.Drawing.Color.White;
            this.Panel_White.Controls.Add(this.DetachGroupBox);
            this.Panel_White.Controls.Add(this.IssueDateGroupBox);
            this.Panel_White.Controls.Add(this.DestinationGroupBox);
            this.Panel_White.Controls.Add(this.ExportButton);
            this.Panel_White.Controls.Add(this.RemoveGroupBox);
            this.Panel_White.Controls.Add(this.DataGroupBox);
            this.Panel_White.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_White.Location = new System.Drawing.Point(282, 0);
            this.Panel_White.Name = "Panel_White";
            this.Panel_White.Size = new System.Drawing.Size(330, 523);
            this.Panel_White.TabIndex = 44;
            // 
            // DetachGroupBox
            // 
            this.DetachGroupBox.BackColor = System.Drawing.Color.White;
            this.DetachGroupBox.Controls.Add(this.DiscardRadioButton);
            this.DetachGroupBox.Controls.Add(this.PreserveRadioButton);
            this.DetachGroupBox.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetachGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DetachGroupBox.Location = new System.Drawing.Point(10, 426);
            this.DetachGroupBox.Name = "DetachGroupBox";
            this.DetachGroupBox.Size = new System.Drawing.Size(310, 41);
            this.DetachGroupBox.TabIndex = 0;
            this.DetachGroupBox.TabStop = false;
            this.DetachGroupBox.Text = "Detach";
            // 
            // DiscardRadioButton
            // 
            this.DiscardRadioButton.AutoSize = true;
            this.DiscardRadioButton.Location = new System.Drawing.Point(134, 16);
            this.DiscardRadioButton.Name = "DiscardRadioButton";
            this.DiscardRadioButton.Size = new System.Drawing.Size(113, 19);
            this.DiscardRadioButton.TabIndex = 18;
            this.DiscardRadioButton.Text = "Discard Worksets";
            this.DiscardRadioButton.UseVisualStyleBackColor = true;
            // 
            // PreserveRadioButton
            // 
            this.PreserveRadioButton.AutoSize = true;
            this.PreserveRadioButton.Checked = true;
            this.PreserveRadioButton.Location = new System.Drawing.Point(8, 16);
            this.PreserveRadioButton.Name = "PreserveRadioButton";
            this.PreserveRadioButton.Size = new System.Drawing.Size(120, 19);
            this.PreserveRadioButton.TabIndex = 17;
            this.PreserveRadioButton.TabStop = true;
            this.PreserveRadioButton.Text = "Preserve Worksets";
            this.PreserveRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 523);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.Panel_White);
            this.Controls.Add(this.DocumentListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revit Batch Exporter";
            this.DataGroupBox.ResumeLayout(false);
            this.tableLayoutPanel_Data.ResumeLayout(false);
            this.tableLayoutPanel_Data.PerformLayout();
            this.RemoveGroupBox.ResumeLayout(false);
            this.tableLayoutPanel_Remove.ResumeLayout(false);
            this.tableLayoutPanel_Remove.PerformLayout();
            this.IssueDateGroupBox.ResumeLayout(false);
            this.tableLayoutPanel_Date.ResumeLayout(false);
            this.tableLayoutPanel_Date.PerformLayout();
            this.DestinationGroupBox.ResumeLayout(false);
            this.DestinationGroupBox.PerformLayout();
            this.Panel_White.ResumeLayout(false);
            this.DetachGroupBox.ResumeLayout(false);
            this.DetachGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Data;
        public System.Windows.Forms.TextBox SafeNameTextbox;
        private System.Windows.Forms.Label KeepViewLabel;
        private System.Windows.Forms.Label PrefixLabel;
        public System.Windows.Forms.TextBox PrefixTextBox;
        private System.Windows.Forms.Label SuffixLabel;
        public System.Windows.Forms.TextBox SuffixTextBox;
        private System.Windows.Forms.GroupBox RemoveGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Remove;
        public System.Windows.Forms.CheckBox AuditCheckBox;
        public System.Windows.Forms.CheckBox RemoveRVTLinksCheckBox;
        public System.Windows.Forms.CheckBox RemoveCADLinksCheckBox;
        public System.Windows.Forms.CheckBox RemoveCADImportsCheckBox;
        public System.Windows.Forms.CheckBox PurgeCheckBox;
        public System.Windows.Forms.CheckBox UngroupCheckBox;
        public System.Windows.Forms.CheckBox SheetsCheckBox;
        public System.Windows.Forms.CheckBox ViewsONSheetsCheckBox;
        public System.Windows.Forms.CheckBox ViewsNOTSheetsCheckBox;
        public System.Windows.Forms.CheckBox RemoveSchedulesCheckBox;
        private System.Windows.Forms.GroupBox IssueDateGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Date;
        public System.Windows.Forms.DateTimePicker DateTimePickerIssue;
        public System.Windows.Forms.CheckBox AutoCheckBox;
        private System.Windows.Forms.ListBox DocumentListBox;
        private System.Windows.Forms.GroupBox DestinationGroupBox;
        public System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Panel Panel_White;
        private System.Windows.Forms.GroupBox DetachGroupBox;
        public System.Windows.Forms.RadioButton DiscardRadioButton;
        public System.Windows.Forms.RadioButton PreserveRadioButton;
        public System.Windows.Forms.CheckBox TemplatesCheckBox;
    }
}