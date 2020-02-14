namespace InventoryApp
{
    partial class AddPartForm
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.addPartIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartInvTextBox = new System.Windows.Forms.TextBox();
            this.addPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPartInHousePanel = new System.Windows.Forms.Panel();
            this.addPartMachineIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartMachineIDLabel = new System.Windows.Forms.Label();
            this.addPartMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartSaveButton = new System.Windows.Forms.Button();
            this.addPartOutsourcedPanel = new System.Windows.Forms.Panel();
            this.addPartCompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartCompanyNameLabel = new System.Windows.Forms.Label();
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.addPartInHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.addPartOutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.addPartIDLabel = new System.Windows.Forms.Label();
            this.addPartNameLabel = new System.Windows.Forms.Label();
            this.addPartInvLabel = new System.Windows.Forms.Label();
            this.addPartPriceLabel = new System.Windows.Forms.Label();
            this.addPartMaxLabel = new System.Windows.Forms.Label();
            this.addPartMinLabel = new System.Windows.Forms.Label();
            this.addPartInHousePanel.SuspendLayout();
            this.addPartOutsourcedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addPartLabel.Location = new System.Drawing.Point(8, 14);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(79, 20);
            this.addPartLabel.TabIndex = 49;
            this.addPartLabel.Text = "Add Part";
            // 
            // addPartIDTextBox
            // 
            this.addPartIDTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addPartIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartIDTextBox.Location = new System.Drawing.Point(115, 51);
            this.addPartIDTextBox.Name = "addPartIDTextBox";
            this.addPartIDTextBox.ReadOnly = true;
            this.addPartIDTextBox.Size = new System.Drawing.Size(108, 20);
            this.addPartIDTextBox.TabIndex = 50;
            this.addPartIDTextBox.Text = "Auto Gen - Disabled";
            this.addPartIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addPartNameTextBox
            // 
            this.addPartNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartNameTextBox.Location = new System.Drawing.Point(115, 77);
            this.addPartNameTextBox.Name = "addPartNameTextBox";
            this.addPartNameTextBox.Size = new System.Drawing.Size(108, 20);
            this.addPartNameTextBox.TabIndex = 51;
            this.addPartNameTextBox.Text = "Part Name";
            this.addPartNameTextBox.TextChanged += new System.EventHandler(this.addPartNameTextBox_TextChanged);
            // 
            // addPartInvTextBox
            // 
            this.addPartInvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInvTextBox.Location = new System.Drawing.Point(115, 103);
            this.addPartInvTextBox.Name = "addPartInvTextBox";
            this.addPartInvTextBox.Size = new System.Drawing.Size(108, 20);
            this.addPartInvTextBox.TabIndex = 52;
            this.addPartInvTextBox.Text = "Inv";
            this.addPartInvTextBox.TextChanged += new System.EventHandler(this.addPartInvTextBox_TextChanged);
            // 
            // addPartPriceTextBox
            // 
            this.addPartPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartPriceTextBox.Location = new System.Drawing.Point(115, 129);
            this.addPartPriceTextBox.Name = "addPartPriceTextBox";
            this.addPartPriceTextBox.Size = new System.Drawing.Size(108, 20);
            this.addPartPriceTextBox.TabIndex = 53;
            this.addPartPriceTextBox.Text = "Price/Cost";
            this.addPartPriceTextBox.TextChanged += new System.EventHandler(this.addPartPriceTextBox_TextChanged);
            // 
            // addPartMaxTextBox
            // 
            this.addPartMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMaxTextBox.Location = new System.Drawing.Point(115, 154);
            this.addPartMaxTextBox.Name = "addPartMaxTextBox";
            this.addPartMaxTextBox.Size = new System.Drawing.Size(68, 20);
            this.addPartMaxTextBox.TabIndex = 54;
            this.addPartMaxTextBox.Text = "Max";
            this.addPartMaxTextBox.TextChanged += new System.EventHandler(this.addPartMaxTextBox_TextChanged);
            // 
            // addPartInHousePanel
            // 
            this.addPartInHousePanel.Controls.Add(this.addPartMachineIDTextBox);
            this.addPartInHousePanel.Controls.Add(this.addPartMachineIDLabel);
            this.addPartInHousePanel.Location = new System.Drawing.Point(22, 177);
            this.addPartInHousePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPartInHousePanel.Name = "addPartInHousePanel";
            this.addPartInHousePanel.Size = new System.Drawing.Size(265, 28);
            this.addPartInHousePanel.TabIndex = 55;
            this.addPartInHousePanel.Visible = false;
            // 
            // addPartMachineIDTextBox
            // 
            this.addPartMachineIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMachineIDTextBox.Location = new System.Drawing.Point(93, 5);
            this.addPartMachineIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPartMachineIDTextBox.Name = "addPartMachineIDTextBox";
            this.addPartMachineIDTextBox.Size = new System.Drawing.Size(108, 19);
            this.addPartMachineIDTextBox.TabIndex = 1;
            this.addPartMachineIDTextBox.Text = "Machine ID";
            this.addPartMachineIDTextBox.TextChanged += new System.EventHandler(this.addPartMachineIDTextBox_TextChanged);
            // 
            // addPartMachineIDLabel
            // 
            this.addPartMachineIDLabel.AutoSize = true;
            this.addPartMachineIDLabel.Location = new System.Drawing.Point(3, 8);
            this.addPartMachineIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addPartMachineIDLabel.Name = "addPartMachineIDLabel";
            this.addPartMachineIDLabel.Size = new System.Drawing.Size(62, 13);
            this.addPartMachineIDLabel.TabIndex = 0;
            this.addPartMachineIDLabel.Text = "Machine ID";
            // 
            // addPartMinTextBox
            // 
            this.addPartMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMinTextBox.Location = new System.Drawing.Point(220, 154);
            this.addPartMinTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPartMinTextBox.Name = "addPartMinTextBox";
            this.addPartMinTextBox.Size = new System.Drawing.Size(67, 19);
            this.addPartMinTextBox.TabIndex = 55;
            this.addPartMinTextBox.Text = "Min";
            this.addPartMinTextBox.TextChanged += new System.EventHandler(this.addPartMinTextBox_TextChanged);
            // 
            // addPartSaveButton
            // 
            this.addPartSaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addPartSaveButton.Location = new System.Drawing.Point(133, 209);
            this.addPartSaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPartSaveButton.Name = "addPartSaveButton";
            this.addPartSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addPartSaveButton.TabIndex = 56;
            this.addPartSaveButton.Text = "Save";
            this.addPartSaveButton.UseVisualStyleBackColor = true;
            this.addPartSaveButton.Click += new System.EventHandler(this.addPartSaveButton_Click);
            // 
            // addPartOutsourcedPanel
            // 
            this.addPartOutsourcedPanel.Controls.Add(this.addPartCompanyNameTextBox);
            this.addPartOutsourcedPanel.Controls.Add(this.addPartCompanyNameLabel);
            this.addPartOutsourcedPanel.Location = new System.Drawing.Point(22, 218);
            this.addPartOutsourcedPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPartOutsourcedPanel.Name = "addPartOutsourcedPanel";
            this.addPartOutsourcedPanel.Size = new System.Drawing.Size(265, 28);
            this.addPartOutsourcedPanel.TabIndex = 58;
            this.addPartOutsourcedPanel.Visible = false;
            // 
            // addPartCompanyNameTextBox
            // 
            this.addPartCompanyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartCompanyNameTextBox.Location = new System.Drawing.Point(93, 5);
            this.addPartCompanyNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPartCompanyNameTextBox.Name = "addPartCompanyNameTextBox";
            this.addPartCompanyNameTextBox.Size = new System.Drawing.Size(108, 19);
            this.addPartCompanyNameTextBox.TabIndex = 1;
            this.addPartCompanyNameTextBox.Text = "Company Name";
            this.addPartCompanyNameTextBox.TextChanged += new System.EventHandler(this.addPartCompanyNameTextBox_TextChanged);
            // 
            // addPartCompanyNameLabel
            // 
            this.addPartCompanyNameLabel.AutoSize = true;
            this.addPartCompanyNameLabel.Location = new System.Drawing.Point(3, 8);
            this.addPartCompanyNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addPartCompanyNameLabel.Name = "addPartCompanyNameLabel";
            this.addPartCompanyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.addPartCompanyNameLabel.TabIndex = 0;
            this.addPartCompanyNameLabel.Text = "Company Name";
            // 
            // addPartCancelButton
            // 
            this.addPartCancelButton.AllowDrop = true;
            this.addPartCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addPartCancelButton.Location = new System.Drawing.Point(212, 209);
            this.addPartCancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPartCancelButton.Name = "addPartCancelButton";
            this.addPartCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addPartCancelButton.TabIndex = 57;
            this.addPartCancelButton.Text = "Cancel";
            this.addPartCancelButton.UseVisualStyleBackColor = true;
            this.addPartCancelButton.Click += new System.EventHandler(this.addPartCancelButton_Click);
            // 
            // addPartInHouseRadioButton
            // 
            this.addPartInHouseRadioButton.AutoSize = true;
            this.addPartInHouseRadioButton.Checked = true;
            this.addPartInHouseRadioButton.Location = new System.Drawing.Point(117, 18);
            this.addPartInHouseRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPartInHouseRadioButton.Name = "addPartInHouseRadioButton";
            this.addPartInHouseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.addPartInHouseRadioButton.TabIndex = 59;
            this.addPartInHouseRadioButton.TabStop = true;
            this.addPartInHouseRadioButton.Text = "In-House";
            this.addPartInHouseRadioButton.UseVisualStyleBackColor = true;
            this.addPartInHouseRadioButton.CheckedChanged += new System.EventHandler(this.addPartInHouseRadioButton_CheckedChanged);
            // 
            // addPartOutsourcedRadioButton
            // 
            this.addPartOutsourcedRadioButton.AutoSize = true;
            this.addPartOutsourcedRadioButton.Location = new System.Drawing.Point(194, 18);
            this.addPartOutsourcedRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPartOutsourcedRadioButton.Name = "addPartOutsourcedRadioButton";
            this.addPartOutsourcedRadioButton.Size = new System.Drawing.Size(80, 17);
            this.addPartOutsourcedRadioButton.TabIndex = 60;
            this.addPartOutsourcedRadioButton.TabStop = true;
            this.addPartOutsourcedRadioButton.Text = "Outsourced";
            this.addPartOutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.addPartOutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.addPartOutsourcedRadioButton_CheckedChanged);
            // 
            // addPartIDLabel
            // 
            this.addPartIDLabel.AutoSize = true;
            this.addPartIDLabel.Location = new System.Drawing.Point(25, 54);
            this.addPartIDLabel.Name = "addPartIDLabel";
            this.addPartIDLabel.Size = new System.Drawing.Size(18, 13);
            this.addPartIDLabel.TabIndex = 61;
            this.addPartIDLabel.Text = "ID";
            // 
            // addPartNameLabel
            // 
            this.addPartNameLabel.AutoSize = true;
            this.addPartNameLabel.Location = new System.Drawing.Point(25, 80);
            this.addPartNameLabel.Name = "addPartNameLabel";
            this.addPartNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addPartNameLabel.TabIndex = 62;
            this.addPartNameLabel.Text = "Name";
            // 
            // addPartInvLabel
            // 
            this.addPartInvLabel.AutoSize = true;
            this.addPartInvLabel.Location = new System.Drawing.Point(25, 106);
            this.addPartInvLabel.Name = "addPartInvLabel";
            this.addPartInvLabel.Size = new System.Drawing.Size(22, 13);
            this.addPartInvLabel.TabIndex = 63;
            this.addPartInvLabel.Text = "Inv";
            // 
            // addPartPriceLabel
            // 
            this.addPartPriceLabel.AutoSize = true;
            this.addPartPriceLabel.Location = new System.Drawing.Point(25, 132);
            this.addPartPriceLabel.Name = "addPartPriceLabel";
            this.addPartPriceLabel.Size = new System.Drawing.Size(57, 13);
            this.addPartPriceLabel.TabIndex = 64;
            this.addPartPriceLabel.Text = "Price/Cost";
            // 
            // addPartMaxLabel
            // 
            this.addPartMaxLabel.AutoSize = true;
            this.addPartMaxLabel.Location = new System.Drawing.Point(25, 157);
            this.addPartMaxLabel.Name = "addPartMaxLabel";
            this.addPartMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.addPartMaxLabel.TabIndex = 65;
            this.addPartMaxLabel.Text = "Max";
            // 
            // addPartMinLabel
            // 
            this.addPartMinLabel.AutoSize = true;
            this.addPartMinLabel.Location = new System.Drawing.Point(188, 157);
            this.addPartMinLabel.Name = "addPartMinLabel";
            this.addPartMinLabel.Size = new System.Drawing.Size(24, 13);
            this.addPartMinLabel.TabIndex = 66;
            this.addPartMinLabel.Text = "Min";
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 249);
            this.Controls.Add(this.addPartMinLabel);
            this.Controls.Add(this.addPartMaxLabel);
            this.Controls.Add(this.addPartOutsourcedPanel);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPartPriceLabel);
            this.Controls.Add(this.addPartSaveButton);
            this.Controls.Add(this.addPartInvLabel);
            this.Controls.Add(this.addPartNameLabel);
            this.Controls.Add(this.addPartIDLabel);
            this.Controls.Add(this.addPartOutsourcedRadioButton);
            this.Controls.Add(this.addPartInHouseRadioButton);
            this.Controls.Add(this.addPartMinTextBox);
            this.Controls.Add(this.addPartInHousePanel);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.addPartPriceTextBox);
            this.Controls.Add(this.addPartInvTextBox);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.addPartIDTextBox);
            this.Controls.Add(this.addPartLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddPartForm";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPartsForm_Load);
            this.addPartInHousePanel.ResumeLayout(false);
            this.addPartInHousePanel.PerformLayout();
            this.addPartOutsourcedPanel.ResumeLayout(false);
            this.addPartOutsourcedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.TextBox addPartIDTextBox;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.TextBox addPartInvTextBox;
        private System.Windows.Forms.TextBox addPartPriceTextBox;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.Panel addPartInHousePanel;
        private System.Windows.Forms.TextBox addPartMachineIDTextBox;
        private System.Windows.Forms.Label addPartMachineIDLabel;
        private System.Windows.Forms.TextBox addPartMinTextBox;
        private System.Windows.Forms.Button addPartSaveButton;
        private System.Windows.Forms.Panel addPartOutsourcedPanel;
        private System.Windows.Forms.TextBox addPartCompanyNameTextBox;
        private System.Windows.Forms.Label addPartCompanyNameLabel;
        private System.Windows.Forms.Button addPartCancelButton;
        private System.Windows.Forms.RadioButton addPartInHouseRadioButton;
        private System.Windows.Forms.RadioButton addPartOutsourcedRadioButton;
        private System.Windows.Forms.Label addPartIDLabel;
        private System.Windows.Forms.Label addPartNameLabel;
        private System.Windows.Forms.Label addPartInvLabel;
        private System.Windows.Forms.Label addPartPriceLabel;
        private System.Windows.Forms.Label addPartMaxLabel;
        private System.Windows.Forms.Label addPartMinLabel;
    }
}