namespace InventoryApp
{
    partial class ModifyPartForm
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
            this.modifyPartCancelButton = new System.Windows.Forms.Button();
            this.modifyPartOutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.modifyPartInHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.modifyPartSaveButton = new System.Windows.Forms.Button();
            this.modifyPartOutsourcedPanel = new System.Windows.Forms.Panel();
            this.modifyPartCompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartCompanyNameLabel = new System.Windows.Forms.Label();
            this.modifyPartMinTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartInHousePanel = new System.Windows.Forms.Panel();
            this.modifyPartMachineIDTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartMachineIDLabel = new System.Windows.Forms.Label();
            this.modifyPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartInvTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartIDTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartFormLabel = new System.Windows.Forms.Label();
            this.modifyPartMinLabel = new System.Windows.Forms.Label();
            this.modifyPartMaxLabel = new System.Windows.Forms.Label();
            this.modifyPartPriceLabel = new System.Windows.Forms.Label();
            this.modifyPartInvLabel = new System.Windows.Forms.Label();
            this.modifyPartNameLabel = new System.Windows.Forms.Label();
            this.modifyPartIDLabel = new System.Windows.Forms.Label();
            this.modifyPartOutsourcedPanel.SuspendLayout();
            this.modifyPartInHousePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // modifyPartCancelButton
            // 
            this.modifyPartCancelButton.AllowDrop = true;
            this.modifyPartCancelButton.Location = new System.Drawing.Point(213, 246);
            this.modifyPartCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyPartCancelButton.Name = "modifyPartCancelButton";
            this.modifyPartCancelButton.Size = new System.Drawing.Size(75, 23);
            this.modifyPartCancelButton.TabIndex = 70;
            this.modifyPartCancelButton.Text = "Cancel";
            this.modifyPartCancelButton.UseVisualStyleBackColor = true;
            this.modifyPartCancelButton.Click += new System.EventHandler(this.modifyPartCancelButton_Click);
            // 
            // modifyPartOutsourcedRadioButton
            // 
            this.modifyPartOutsourcedRadioButton.AutoSize = true;
            this.modifyPartOutsourcedRadioButton.Location = new System.Drawing.Point(206, 11);
            this.modifyPartOutsourcedRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyPartOutsourcedRadioButton.Name = "modifyPartOutsourcedRadioButton";
            this.modifyPartOutsourcedRadioButton.Size = new System.Drawing.Size(80, 17);
            this.modifyPartOutsourcedRadioButton.TabIndex = 72;
            this.modifyPartOutsourcedRadioButton.TabStop = true;
            this.modifyPartOutsourcedRadioButton.Text = "Outsourced";
            this.modifyPartOutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.modifyPartOutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.modifyPartOutsourcedRadioButton_CheckedChanged);
            // 
            // modifyPartInHouseRadioButton
            // 
            this.modifyPartInHouseRadioButton.AutoSize = true;
            this.modifyPartInHouseRadioButton.Checked = true;
            this.modifyPartInHouseRadioButton.Location = new System.Drawing.Point(125, 11);
            this.modifyPartInHouseRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyPartInHouseRadioButton.Name = "modifyPartInHouseRadioButton";
            this.modifyPartInHouseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.modifyPartInHouseRadioButton.TabIndex = 71;
            this.modifyPartInHouseRadioButton.TabStop = true;
            this.modifyPartInHouseRadioButton.Text = "In-House";
            this.modifyPartInHouseRadioButton.UseVisualStyleBackColor = true;
            this.modifyPartInHouseRadioButton.CheckedChanged += new System.EventHandler(this.modifyPartInHouseRadioButton_CheckedChanged);
            // 
            // modifyPartSaveButton
            // 
            this.modifyPartSaveButton.Location = new System.Drawing.Point(134, 246);
            this.modifyPartSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyPartSaveButton.Name = "modifyPartSaveButton";
            this.modifyPartSaveButton.Size = new System.Drawing.Size(75, 23);
            this.modifyPartSaveButton.TabIndex = 68;
            this.modifyPartSaveButton.Text = "Save";
            this.modifyPartSaveButton.UseVisualStyleBackColor = true;
            this.modifyPartSaveButton.Click += new System.EventHandler(this.modifyPartSaveButton_Click);
            // 
            // modifyPartOutsourcedPanel
            // 
            this.modifyPartOutsourcedPanel.Controls.Add(this.modifyPartCompanyNameTextBox);
            this.modifyPartOutsourcedPanel.Controls.Add(this.modifyPartCompanyNameLabel);
            this.modifyPartOutsourcedPanel.Location = new System.Drawing.Point(21, 235);
            this.modifyPartOutsourcedPanel.Margin = new System.Windows.Forms.Padding(2);
            this.modifyPartOutsourcedPanel.Name = "modifyPartOutsourcedPanel";
            this.modifyPartOutsourcedPanel.Size = new System.Drawing.Size(265, 28);
            this.modifyPartOutsourcedPanel.TabIndex = 69;
            this.modifyPartOutsourcedPanel.Visible = false;
            // 
            // modifyPartCompanyNameTextBox
            // 
            this.modifyPartCompanyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartCompanyNameTextBox.Location = new System.Drawing.Point(91, 5);
            this.modifyPartCompanyNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modifyPartCompanyNameTextBox.Name = "modifyPartCompanyNameTextBox";
            this.modifyPartCompanyNameTextBox.Size = new System.Drawing.Size(108, 20);
            this.modifyPartCompanyNameTextBox.TabIndex = 1;
            this.modifyPartCompanyNameTextBox.TextChanged += new System.EventHandler(this.modifyPartCompanyNameTextBox_TextChanged);
            // 
            // modifyPartCompanyNameLabel
            // 
            this.modifyPartCompanyNameLabel.AutoSize = true;
            this.modifyPartCompanyNameLabel.Location = new System.Drawing.Point(2, 8);
            this.modifyPartCompanyNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modifyPartCompanyNameLabel.Name = "modifyPartCompanyNameLabel";
            this.modifyPartCompanyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.modifyPartCompanyNameLabel.TabIndex = 0;
            this.modifyPartCompanyNameLabel.Text = "Company Name";
            // 
            // modifyPartMinTextBox
            // 
            this.modifyPartMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMinTextBox.Location = new System.Drawing.Point(219, 181);
            this.modifyPartMinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modifyPartMinTextBox.Name = "modifyPartMinTextBox";
            this.modifyPartMinTextBox.Size = new System.Drawing.Size(67, 20);
            this.modifyPartMinTextBox.TabIndex = 67;
            this.modifyPartMinTextBox.TextChanged += new System.EventHandler(this.modifyPartMinTextBox_TextChanged);
            // 
            // modifyPartInHousePanel
            // 
            this.modifyPartInHousePanel.Controls.Add(this.modifyPartMachineIDTextBox);
            this.modifyPartInHousePanel.Controls.Add(this.modifyPartMachineIDLabel);
            this.modifyPartInHousePanel.Location = new System.Drawing.Point(23, 207);
            this.modifyPartInHousePanel.Margin = new System.Windows.Forms.Padding(2);
            this.modifyPartInHousePanel.Name = "modifyPartInHousePanel";
            this.modifyPartInHousePanel.Size = new System.Drawing.Size(265, 26);
            this.modifyPartInHousePanel.TabIndex = 66;
            this.modifyPartInHousePanel.Visible = false;
            // 
            // modifyPartMachineIDTextBox
            // 
            this.modifyPartMachineIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMachineIDTextBox.Location = new System.Drawing.Point(91, 5);
            this.modifyPartMachineIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modifyPartMachineIDTextBox.Name = "modifyPartMachineIDTextBox";
            this.modifyPartMachineIDTextBox.Size = new System.Drawing.Size(108, 20);
            this.modifyPartMachineIDTextBox.TabIndex = 1;
            this.modifyPartMachineIDTextBox.TextChanged += new System.EventHandler(this.modifyPartMachineIDTextBox_TextChanged);
            // 
            // modifyPartMachineIDLabel
            // 
            this.modifyPartMachineIDLabel.AutoSize = true;
            this.modifyPartMachineIDLabel.Location = new System.Drawing.Point(-1, 8);
            this.modifyPartMachineIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modifyPartMachineIDLabel.Name = "modifyPartMachineIDLabel";
            this.modifyPartMachineIDLabel.Size = new System.Drawing.Size(62, 13);
            this.modifyPartMachineIDLabel.TabIndex = 0;
            this.modifyPartMachineIDLabel.Text = "Machine ID";
            // 
            // modifyPartMaxTextBox
            // 
            this.modifyPartMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMaxTextBox.Location = new System.Drawing.Point(114, 181);
            this.modifyPartMaxTextBox.Name = "modifyPartMaxTextBox";
            this.modifyPartMaxTextBox.Size = new System.Drawing.Size(68, 20);
            this.modifyPartMaxTextBox.TabIndex = 65;
            this.modifyPartMaxTextBox.TextChanged += new System.EventHandler(this.modifyPartMaxTextBox_TextChanged);
            // 
            // modifyPartPriceTextBox
            // 
            this.modifyPartPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartPriceTextBox.Location = new System.Drawing.Point(114, 149);
            this.modifyPartPriceTextBox.Name = "modifyPartPriceTextBox";
            this.modifyPartPriceTextBox.Size = new System.Drawing.Size(108, 20);
            this.modifyPartPriceTextBox.TabIndex = 64;
            this.modifyPartPriceTextBox.TextChanged += new System.EventHandler(this.modifyPartPriceTextBox_TextChanged);
            // 
            // modifyPartInvTextBox
            // 
            this.modifyPartInvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartInvTextBox.Location = new System.Drawing.Point(114, 116);
            this.modifyPartInvTextBox.Name = "modifyPartInvTextBox";
            this.modifyPartInvTextBox.Size = new System.Drawing.Size(108, 20);
            this.modifyPartInvTextBox.TabIndex = 63;
            this.modifyPartInvTextBox.TextChanged += new System.EventHandler(this.modifyPartInvTextBox_TextChanged);
            // 
            // modifyPartNameTextBox
            // 
            this.modifyPartNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartNameTextBox.Location = new System.Drawing.Point(114, 84);
            this.modifyPartNameTextBox.Name = "modifyPartNameTextBox";
            this.modifyPartNameTextBox.Size = new System.Drawing.Size(108, 20);
            this.modifyPartNameTextBox.TabIndex = 62;
            this.modifyPartNameTextBox.TextChanged += new System.EventHandler(this.modifyPartNameTextBox_TextChanged);
            // 
            // modifyPartIDTextBox
            // 
            this.modifyPartIDTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.modifyPartIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartIDTextBox.Location = new System.Drawing.Point(114, 50);
            this.modifyPartIDTextBox.Name = "modifyPartIDTextBox";
            this.modifyPartIDTextBox.ReadOnly = true;
            this.modifyPartIDTextBox.Size = new System.Drawing.Size(108, 20);
            this.modifyPartIDTextBox.TabIndex = 61;
            this.modifyPartIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modifyPartFormLabel
            // 
            this.modifyPartFormLabel.AutoSize = true;
            this.modifyPartFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartFormLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.modifyPartFormLabel.Location = new System.Drawing.Point(12, 9);
            this.modifyPartFormLabel.Name = "modifyPartFormLabel";
            this.modifyPartFormLabel.Size = new System.Drawing.Size(99, 20);
            this.modifyPartFormLabel.TabIndex = 73;
            this.modifyPartFormLabel.Text = "Modify Part";
            // 
            // modifyPartMinLabel
            // 
            this.modifyPartMinLabel.AutoSize = true;
            this.modifyPartMinLabel.Location = new System.Drawing.Point(188, 184);
            this.modifyPartMinLabel.Name = "modifyPartMinLabel";
            this.modifyPartMinLabel.Size = new System.Drawing.Size(24, 13);
            this.modifyPartMinLabel.TabIndex = 79;
            this.modifyPartMinLabel.Text = "Min";
            // 
            // modifyPartMaxLabel
            // 
            this.modifyPartMaxLabel.AutoSize = true;
            this.modifyPartMaxLabel.Location = new System.Drawing.Point(23, 184);
            this.modifyPartMaxLabel.Name = "modifyPartMaxLabel";
            this.modifyPartMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.modifyPartMaxLabel.TabIndex = 78;
            this.modifyPartMaxLabel.Text = "Max";
            // 
            // modifyPartPriceLabel
            // 
            this.modifyPartPriceLabel.AutoSize = true;
            this.modifyPartPriceLabel.Location = new System.Drawing.Point(23, 152);
            this.modifyPartPriceLabel.Name = "modifyPartPriceLabel";
            this.modifyPartPriceLabel.Size = new System.Drawing.Size(57, 13);
            this.modifyPartPriceLabel.TabIndex = 77;
            this.modifyPartPriceLabel.Text = "Price/Cost";
            // 
            // modifyPartInvLabel
            // 
            this.modifyPartInvLabel.AutoSize = true;
            this.modifyPartInvLabel.Location = new System.Drawing.Point(23, 119);
            this.modifyPartInvLabel.Name = "modifyPartInvLabel";
            this.modifyPartInvLabel.Size = new System.Drawing.Size(22, 13);
            this.modifyPartInvLabel.TabIndex = 76;
            this.modifyPartInvLabel.Text = "Inv";
            // 
            // modifyPartNameLabel
            // 
            this.modifyPartNameLabel.AutoSize = true;
            this.modifyPartNameLabel.Location = new System.Drawing.Point(23, 87);
            this.modifyPartNameLabel.Name = "modifyPartNameLabel";
            this.modifyPartNameLabel.Size = new System.Drawing.Size(35, 13);
            this.modifyPartNameLabel.TabIndex = 75;
            this.modifyPartNameLabel.Text = "Name";
            // 
            // modifyPartIDLabel
            // 
            this.modifyPartIDLabel.AutoSize = true;
            this.modifyPartIDLabel.Location = new System.Drawing.Point(23, 53);
            this.modifyPartIDLabel.Name = "modifyPartIDLabel";
            this.modifyPartIDLabel.Size = new System.Drawing.Size(18, 13);
            this.modifyPartIDLabel.TabIndex = 74;
            this.modifyPartIDLabel.Text = "ID";
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 286);
            this.Controls.Add(this.modifyPartMinLabel);
            this.Controls.Add(this.modifyPartMaxLabel);
            this.Controls.Add(this.modifyPartPriceLabel);
            this.Controls.Add(this.modifyPartInvLabel);
            this.Controls.Add(this.modifyPartNameLabel);
            this.Controls.Add(this.modifyPartIDLabel);
            this.Controls.Add(this.modifyPartFormLabel);
            this.Controls.Add(this.modifyPartCancelButton);
            this.Controls.Add(this.modifyPartOutsourcedRadioButton);
            this.Controls.Add(this.modifyPartInHouseRadioButton);
            this.Controls.Add(this.modifyPartSaveButton);
            this.Controls.Add(this.modifyPartOutsourcedPanel);
            this.Controls.Add(this.modifyPartMinTextBox);
            this.Controls.Add(this.modifyPartInHousePanel);
            this.Controls.Add(this.modifyPartMaxTextBox);
            this.Controls.Add(this.modifyPartPriceTextBox);
            this.Controls.Add(this.modifyPartInvTextBox);
            this.Controls.Add(this.modifyPartNameTextBox);
            this.Controls.Add(this.modifyPartIDTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyPartForm";
            this.Text = "ModifyPartForm";
            this.modifyPartOutsourcedPanel.ResumeLayout(false);
            this.modifyPartOutsourcedPanel.PerformLayout();
            this.modifyPartInHousePanel.ResumeLayout(false);
            this.modifyPartInHousePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyPartCancelButton;
        private System.Windows.Forms.RadioButton modifyPartOutsourcedRadioButton;
        private System.Windows.Forms.RadioButton modifyPartInHouseRadioButton;
        private System.Windows.Forms.Button modifyPartSaveButton;
        private System.Windows.Forms.Panel modifyPartOutsourcedPanel;
        private System.Windows.Forms.TextBox modifyPartCompanyNameTextBox;
        private System.Windows.Forms.Label modifyPartCompanyNameLabel;
        private System.Windows.Forms.TextBox modifyPartMinTextBox;
        private System.Windows.Forms.Panel modifyPartInHousePanel;
        private System.Windows.Forms.TextBox modifyPartMachineIDTextBox;
        private System.Windows.Forms.Label modifyPartMachineIDLabel;
        private System.Windows.Forms.TextBox modifyPartMaxTextBox;
        private System.Windows.Forms.TextBox modifyPartPriceTextBox;
        private System.Windows.Forms.TextBox modifyPartInvTextBox;
        private System.Windows.Forms.TextBox modifyPartNameTextBox;
        private System.Windows.Forms.TextBox modifyPartIDTextBox;
        private System.Windows.Forms.Label modifyPartFormLabel;
        private System.Windows.Forms.Label modifyPartMinLabel;
        private System.Windows.Forms.Label modifyPartMaxLabel;
        private System.Windows.Forms.Label modifyPartPriceLabel;
        private System.Windows.Forms.Label modifyPartInvLabel;
        private System.Windows.Forms.Label modifyPartNameLabel;
        private System.Windows.Forms.Label modifyPartIDLabel;
    }
}