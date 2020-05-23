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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportDialog));
            this.ExportButton = new System.Windows.Forms.Button();
            this.NWCCheckBox = new System.Windows.Forms.CheckBox();
            this.IFCCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.DWGCheckbox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DWGCombobox = new System.Windows.Forms.ComboBox();
            this.IFCCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InternalRadio = new System.Windows.Forms.RadioButton();
            this.SharedRadio = new System.Windows.Forms.RadioButton();
            this.DeleteLogFilesButton = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Path_Button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FilenameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.FlatAppearance.BorderSize = 0;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(35, 371);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(345, 36);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.TabStop = false;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // NWCCheckBox
            // 
            this.NWCCheckBox.AutoSize = true;
            this.NWCCheckBox.Location = new System.Drawing.Point(15, 56);
            this.NWCCheckBox.Name = "NWCCheckBox";
            this.NWCCheckBox.Size = new System.Drawing.Size(52, 17);
            this.NWCCheckBox.TabIndex = 29;
            this.NWCCheckBox.TabStop = false;
            this.NWCCheckBox.Text = "NWC";
            this.NWCCheckBox.UseVisualStyleBackColor = true;
            this.NWCCheckBox.CheckStateChanged += new System.EventHandler(this.NWCCheckBox_CheckStateChanged);
            // 
            // IFCCheckBox
            // 
            this.IFCCheckBox.AutoSize = true;
            this.IFCCheckBox.Location = new System.Drawing.Point(15, 86);
            this.IFCCheckBox.Name = "IFCCheckBox";
            this.IFCCheckBox.Size = new System.Drawing.Size(42, 17);
            this.IFCCheckBox.TabIndex = 30;
            this.IFCCheckBox.TabStop = false;
            this.IFCCheckBox.Text = "IFC";
            this.toolTip1.SetToolTip(this.IFCCheckBox, "Check if the IFC Export Settings are correct before.");
            this.IFCCheckBox.UseVisualStyleBackColor = true;
            this.IFCCheckBox.CheckStateChanged += new System.EventHandler(this.IFCCheckBox_CheckStateChanged);
            // 
            // ExportLabel
            // 
            this.ExportLabel.AutoSize = true;
            this.ExportLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportLabel.Location = new System.Drawing.Point(12, 23);
            this.ExportLabel.Name = "ExportLabel";
            this.ExportLabel.Size = new System.Drawing.Size(50, 13);
            this.ExportLabel.TabIndex = 31;
            this.ExportLabel.Text = "Export";
            this.ExportLabel.Click += new System.EventHandler(this.ExportLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Select 3DView ";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoEllipsis = true;
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(32, 316);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(85, 13);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "Destination Path";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(35, 334);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(301, 20);
            this.PathTextBox.TabIndex = 19;
            this.PathTextBox.TabStop = false;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // DWGCheckbox
            // 
            this.DWGCheckbox.AutoSize = true;
            this.DWGCheckbox.Location = new System.Drawing.Point(15, 114);
            this.DWGCheckbox.Name = "DWGCheckbox";
            this.DWGCheckbox.Size = new System.Drawing.Size(53, 17);
            this.DWGCheckbox.TabIndex = 37;
            this.DWGCheckbox.TabStop = false;
            this.DWGCheckbox.Text = "DWG";
            this.DWGCheckbox.UseVisualStyleBackColor = true;
            this.DWGCheckbox.CheckStateChanged += new System.EventHandler(this.DWGCheckbox_CheckStateChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // DWGCombobox
            // 
            this.DWGCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DWGCombobox.FormattingEnabled = true;
            this.DWGCombobox.Location = new System.Drawing.Point(89, 112);
            this.DWGCombobox.Name = "DWGCombobox";
            this.DWGCombobox.Size = new System.Drawing.Size(232, 21);
            this.DWGCombobox.TabIndex = 39;
            // 
            // IFCCombobox
            // 
            this.IFCCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IFCCombobox.FormattingEnabled = true;
            this.IFCCombobox.Location = new System.Drawing.Point(89, 85);
            this.IFCCombobox.Name = "IFCCombobox";
            this.IFCCombobox.Size = new System.Drawing.Size(232, 21);
            this.IFCCombobox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Settings";
            this.label1.Click += new System.EventHandler(this.ExportLabel_Click);
            // 
            // InternalRadio
            // 
            this.InternalRadio.AutoSize = true;
            this.InternalRadio.Location = new System.Drawing.Point(89, 55);
            this.InternalRadio.Name = "InternalRadio";
            this.InternalRadio.Size = new System.Drawing.Size(63, 17);
            this.InternalRadio.TabIndex = 41;
            this.InternalRadio.Text = "Internal ";
            this.InternalRadio.UseVisualStyleBackColor = true;
            // 
            // SharedRadio
            // 
            this.SharedRadio.AutoSize = true;
            this.SharedRadio.Checked = true;
            this.SharedRadio.Location = new System.Drawing.Point(158, 55);
            this.SharedRadio.Name = "SharedRadio";
            this.SharedRadio.Size = new System.Drawing.Size(59, 17);
            this.SharedRadio.TabIndex = 42;
            this.SharedRadio.TabStop = true;
            this.SharedRadio.Text = "Shared";
            this.SharedRadio.UseVisualStyleBackColor = true;
            this.SharedRadio.CheckedChanged += new System.EventHandler(this.SharedRadio_CheckedChanged);
            // 
            // DeleteLogFilesButton
            // 
            this.DeleteLogFilesButton.AutoSize = true;
            this.DeleteLogFilesButton.Location = new System.Drawing.Point(89, 146);
            this.DeleteLogFilesButton.Name = "DeleteLogFilesButton";
            this.DeleteLogFilesButton.Size = new System.Drawing.Size(144, 17);
            this.DeleteLogFilesButton.TabIndex = 43;
            this.DeleteLogFilesButton.Text = "Delete the additional files";
            this.toolTip1.SetToolTip(this.DeleteLogFilesButton, "Delete the additional .txt, log export files.");
            this.DeleteLogFilesButton.UseVisualStyleBackColor = true;
            // 
            // Path_Button
            // 
            this.Path_Button.Location = new System.Drawing.Point(348, 333);
            this.Path_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Path_Button.Name = "Path_Button";
            this.Path_Button.Size = new System.Drawing.Size(32, 21);
            this.Path_Button.TabIndex = 44;
            this.Path_Button.UseVisualStyleBackColor = true;
            this.Path_Button.Click += new System.EventHandler(this.Path_Button_Click);
            // 
            // FilenameTextbox
            // 
            this.FilenameTextbox.Location = new System.Drawing.Point(35, 282);
            this.FilenameTextbox.Name = "FilenameTextbox";
            this.FilenameTextbox.Size = new System.Drawing.Size(345, 20);
            this.FilenameTextbox.TabIndex = 45;
            this.FilenameTextbox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "File Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExportLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NWCCheckBox);
            this.groupBox1.Controls.Add(this.IFCCheckBox);
            this.groupBox1.Controls.Add(this.DeleteLogFilesButton);
            this.groupBox1.Controls.Add(this.DWGCheckbox);
            this.groupBox1.Controls.Add(this.IFCCombobox);
            this.groupBox1.Controls.Add(this.DWGCombobox);
            this.groupBox1.Controls.Add(this.SharedRadio);
            this.groupBox1.Controls.Add(this.InternalRadio);
            this.groupBox1.Location = new System.Drawing.Point(35, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 176);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // ExportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(413, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilenameTextbox);
            this.Controls.Add(this.Path_Button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.ExportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExportButton;
        public System.Windows.Forms.CheckBox NWCCheckBox;
        public System.Windows.Forms.CheckBox IFCCheckBox;
        private System.Windows.Forms.Label ExportLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PathLabel;
        public System.Windows.Forms.TextBox PathTextBox;
        public System.Windows.Forms.CheckBox DWGCheckbox;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox DWGCombobox;
        public System.Windows.Forms.ComboBox IFCCombobox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton InternalRadio;
        public System.Windows.Forms.RadioButton SharedRadio;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.CheckBox DeleteLogFilesButton;
        public System.Windows.Forms.Button Path_Button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.TextBox FilenameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}