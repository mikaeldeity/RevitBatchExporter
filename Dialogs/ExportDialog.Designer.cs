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
            this.SuspendLayout();
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.FlatAppearance.BorderSize = 0;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(37, 301);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(320, 36);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.TabStop = false;
            this.ExportButton.Text = "Export Documents";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // NWCCheckBox
            // 
            this.NWCCheckBox.AutoSize = true;
            this.NWCCheckBox.Location = new System.Drawing.Point(35, 114);
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
            this.IFCCheckBox.Location = new System.Drawing.Point(35, 140);
            this.IFCCheckBox.Name = "IFCCheckBox";
            this.IFCCheckBox.Size = new System.Drawing.Size(42, 17);
            this.IFCCheckBox.TabIndex = 30;
            this.IFCCheckBox.TabStop = false;
            this.IFCCheckBox.Text = "IFC";
            this.IFCCheckBox.UseVisualStyleBackColor = true;
            this.IFCCheckBox.CheckStateChanged += new System.EventHandler(this.IFCCheckBox_CheckStateChanged);
            // 
            // ExportLabel
            // 
            this.ExportLabel.AutoSize = true;
            this.ExportLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportLabel.Location = new System.Drawing.Point(32, 85);
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
            this.label2.Location = new System.Drawing.Point(34, 39);
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
            this.PathLabel.Location = new System.Drawing.Point(34, 238);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(85, 13);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "Destination Path";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(37, 260);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(320, 20);
            this.PathTextBox.TabIndex = 19;
            this.PathTextBox.TabStop = false;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // DWGCheckbox
            // 
            this.DWGCheckbox.AutoSize = true;
            this.DWGCheckbox.Location = new System.Drawing.Point(35, 167);
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
            this.comboBox1.Location = new System.Drawing.Point(120, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // DWGCombobox
            // 
            this.DWGCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DWGCombobox.FormattingEnabled = true;
            this.DWGCombobox.Location = new System.Drawing.Point(119, 165);
            this.DWGCombobox.Name = "DWGCombobox";
            this.DWGCombobox.Size = new System.Drawing.Size(232, 21);
            this.DWGCombobox.TabIndex = 39;
            // 
            // IFCCombobox
            // 
            this.IFCCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IFCCombobox.FormattingEnabled = true;
            this.IFCCombobox.Location = new System.Drawing.Point(119, 138);
            this.IFCCombobox.Name = "IFCCombobox";
            this.IFCCombobox.Size = new System.Drawing.Size(232, 21);
            this.IFCCombobox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Settings";
            this.label1.Click += new System.EventHandler(this.ExportLabel_Click);
            // 
            // InternalRadio
            // 
            this.InternalRadio.AutoSize = true;
            this.InternalRadio.Location = new System.Drawing.Point(119, 114);
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
            this.SharedRadio.Location = new System.Drawing.Point(188, 114);
            this.SharedRadio.Name = "SharedRadio";
            this.SharedRadio.Size = new System.Drawing.Size(59, 17);
            this.SharedRadio.TabIndex = 42;
            this.SharedRadio.TabStop = true;
            this.SharedRadio.Text = "Shared";
            this.SharedRadio.UseVisualStyleBackColor = true;
            // 
            // DeleteLogFilesButton
            // 
            this.DeleteLogFilesButton.AutoSize = true;
            this.DeleteLogFilesButton.Checked = true;
            this.DeleteLogFilesButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DeleteLogFilesButton.Location = new System.Drawing.Point(119, 203);
            this.DeleteLogFilesButton.Name = "DeleteLogFilesButton";
            this.DeleteLogFilesButton.Size = new System.Drawing.Size(144, 17);
            this.DeleteLogFilesButton.TabIndex = 43;
            this.DeleteLogFilesButton.Text = "Delete the additional files";
            this.toolTip1.SetToolTip(this.DeleteLogFilesButton, "Delete the additional .txt, log export files.");
            this.DeleteLogFilesButton.UseVisualStyleBackColor = true;
            // 
            // ExportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(394, 366);
            this.Controls.Add(this.DeleteLogFilesButton);
            this.Controls.Add(this.SharedRadio);
            this.Controls.Add(this.InternalRadio);
            this.Controls.Add(this.IFCCombobox);
            this.Controls.Add(this.DWGCombobox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DWGCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportLabel);
            this.Controls.Add(this.IFCCheckBox);
            this.Controls.Add(this.NWCCheckBox);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.ExportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weekly Export";
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
    }
}