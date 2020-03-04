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
            this.NWCCheckBox = new System.Windows.Forms.CheckBox();
            this.IFCCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.FlatAppearance.BorderSize = 0;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(42, 251);
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
            this.NWCCheckBox.Location = new System.Drawing.Point(37, 102);
            this.NWCCheckBox.Name = "NWCCheckBox";
            this.NWCCheckBox.Size = new System.Drawing.Size(52, 17);
            this.NWCCheckBox.TabIndex = 29;
            this.NWCCheckBox.TabStop = false;
            this.NWCCheckBox.Text = "NWC";
            this.NWCCheckBox.UseVisualStyleBackColor = true;
            this.NWCCheckBox.CheckedChanged += new System.EventHandler(this.NWCCheckBox_CheckedChanged);
            // 
            // IFCCheckBox
            // 
            this.IFCCheckBox.AutoSize = true;
            this.IFCCheckBox.Location = new System.Drawing.Point(37, 125);
            this.IFCCheckBox.Name = "IFCCheckBox";
            this.IFCCheckBox.Size = new System.Drawing.Size(42, 17);
            this.IFCCheckBox.TabIndex = 30;
            this.IFCCheckBox.TabStop = false;
            this.IFCCheckBox.Text = "IFC";
            this.IFCCheckBox.UseVisualStyleBackColor = true;
            this.IFCCheckBox.CheckedChanged += new System.EventHandler(this.IFCCheckBox_CheckedChanged);
            // 
            // ExportLabel
            // 
            this.ExportLabel.AutoSize = true;
            this.ExportLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportLabel.Location = new System.Drawing.Point(34, 76);
            this.ExportLabel.Name = "ExportLabel";
            this.ExportLabel.Size = new System.Drawing.Size(50, 13);
            this.ExportLabel.TabIndex = 31;
            this.ExportLabel.Text = "Export";
            this.ExportLabel.Click += new System.EventHandler(this.ExportLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
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
            this.PathLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(34, 188);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(114, 13);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "Destination Path";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(37, 209);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(320, 20);
            this.PathTextBox.TabIndex = 19;
            this.PathTextBox.TabStop = false;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(37, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "DWG";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // ExportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(394, 329);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
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
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}