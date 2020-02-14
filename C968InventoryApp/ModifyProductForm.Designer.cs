namespace InventoryApp
{
    partial class ModifyProductForm
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
            this.modifyProductFormPanel = new System.Windows.Forms.Panel();
            this.modifyProductAssociatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyProductPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyProductMinLabel = new System.Windows.Forms.Label();
            this.modifyProductSaveButton = new System.Windows.Forms.Button();
            this.modifyProductMaxLabel = new System.Windows.Forms.Label();
            this.modifyProductCancelButton = new System.Windows.Forms.Button();
            this.modifyProductPriceLabel = new System.Windows.Forms.Label();
            this.modifyProductDeleteButton = new System.Windows.Forms.Button();
            this.modifyProductInvLabel = new System.Windows.Forms.Label();
            this.modifyProductNameLabel = new System.Windows.Forms.Label();
            this.modifyProductAddButton = new System.Windows.Forms.Button();
            this.modifyProductIDLabel = new System.Windows.Forms.Label();
            this.modifyProductSearchTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductSearchButton = new System.Windows.Forms.Button();
            this.modifyProductMinTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductIDTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductInvTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductFormLabel = new System.Windows.Forms.Label();
            this.modifyProductFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductAssociatedPartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyProductFormPanel
            // 
            this.modifyProductFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modifyProductFormPanel.Controls.Add(this.modifyProductAssociatedPartsDataGridView);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductPartsDataGridView);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductMinLabel);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductSaveButton);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductMaxLabel);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductCancelButton);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductPriceLabel);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductDeleteButton);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductInvLabel);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductNameLabel);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductAddButton);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductIDLabel);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductSearchTextBox);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductSearchButton);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductMinTextBox);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductMaxTextBox);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductIDTextBox);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductNameTextBox);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductInvTextBox);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductPriceTextBox);
            this.modifyProductFormPanel.Controls.Add(this.modifyProductFormLabel);
            this.modifyProductFormPanel.Location = new System.Drawing.Point(24, 23);
            this.modifyProductFormPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductFormPanel.Name = "modifyProductFormPanel";
            this.modifyProductFormPanel.Size = new System.Drawing.Size(1378, 698);
            this.modifyProductFormPanel.TabIndex = 1;
            // 
            // modifyProductAssociatedPartsDataGridView
            // 
            this.modifyProductAssociatedPartsDataGridView.AllowUserToAddRows = false;
            this.modifyProductAssociatedPartsDataGridView.AllowUserToDeleteRows = false;
            this.modifyProductAssociatedPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modifyProductAssociatedPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductAssociatedPartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.inv,
            this.price});
            this.modifyProductAssociatedPartsDataGridView.Location = new System.Drawing.Point(592, 383);
            this.modifyProductAssociatedPartsDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductAssociatedPartsDataGridView.MultiSelect = false;
            this.modifyProductAssociatedPartsDataGridView.Name = "modifyProductAssociatedPartsDataGridView";
            this.modifyProductAssociatedPartsDataGridView.ReadOnly = true;
            this.modifyProductAssociatedPartsDataGridView.RowHeadersVisible = false;
            this.modifyProductAssociatedPartsDataGridView.Size = new System.Drawing.Size(758, 183);
            this.modifyProductAssociatedPartsDataGridView.TabIndex = 74;
            this.modifyProductAssociatedPartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modifyProductAssociatedPartsDataGridView_CellClick);
            // 
            // partID
            // 
            this.partID.HeaderText = "Part ID";
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            // 
            // partName
            // 
            this.partName.HeaderText = "Part Name";
            this.partName.Name = "partName";
            this.partName.ReadOnly = true;
            // 
            // inv
            // 
            this.inv.HeaderText = "Inventory Level";
            this.inv.Name = "inv";
            this.inv.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price per Unit";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // modifyProductPartsDataGridView
            // 
            this.modifyProductPartsDataGridView.AllowUserToAddRows = false;
            this.modifyProductPartsDataGridView.AllowUserToDeleteRows = false;
            this.modifyProductPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modifyProductPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductPartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.modifyProductPartsDataGridView.Location = new System.Drawing.Point(592, 133);
            this.modifyProductPartsDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductPartsDataGridView.MultiSelect = false;
            this.modifyProductPartsDataGridView.Name = "modifyProductPartsDataGridView";
            this.modifyProductPartsDataGridView.ReadOnly = true;
            this.modifyProductPartsDataGridView.RowHeadersVisible = false;
            this.modifyProductPartsDataGridView.Size = new System.Drawing.Size(758, 183);
            this.modifyProductPartsDataGridView.TabIndex = 73;
            this.modifyProductPartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modifyProductPartsDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price per Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // modifyProductMinLabel
            // 
            this.modifyProductMinLabel.AutoSize = true;
            this.modifyProductMinLabel.Location = new System.Drawing.Point(326, 508);
            this.modifyProductMinLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductMinLabel.Name = "modifyProductMinLabel";
            this.modifyProductMinLabel.Size = new System.Drawing.Size(47, 25);
            this.modifyProductMinLabel.TabIndex = 72;
            this.modifyProductMinLabel.Text = "Min";
            // 
            // modifyProductSaveButton
            // 
            this.modifyProductSaveButton.Location = new System.Drawing.Point(1012, 633);
            this.modifyProductSaveButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductSaveButton.Name = "modifyProductSaveButton";
            this.modifyProductSaveButton.Size = new System.Drawing.Size(150, 44);
            this.modifyProductSaveButton.TabIndex = 14;
            this.modifyProductSaveButton.Text = "Save";
            this.modifyProductSaveButton.UseVisualStyleBackColor = true;
            this.modifyProductSaveButton.Click += new System.EventHandler(this.modifyProductSaveButton_Click);
            // 
            // modifyProductMaxLabel
            // 
            this.modifyProductMaxLabel.AutoSize = true;
            this.modifyProductMaxLabel.Location = new System.Drawing.Point(48, 508);
            this.modifyProductMaxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductMaxLabel.Name = "modifyProductMaxLabel";
            this.modifyProductMaxLabel.Size = new System.Drawing.Size(53, 25);
            this.modifyProductMaxLabel.TabIndex = 71;
            this.modifyProductMaxLabel.Text = "Max";
            // 
            // modifyProductCancelButton
            // 
            this.modifyProductCancelButton.Location = new System.Drawing.Point(1174, 633);
            this.modifyProductCancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductCancelButton.Name = "modifyProductCancelButton";
            this.modifyProductCancelButton.Size = new System.Drawing.Size(150, 44);
            this.modifyProductCancelButton.TabIndex = 13;
            this.modifyProductCancelButton.Text = "Cancel";
            this.modifyProductCancelButton.UseVisualStyleBackColor = true;
            this.modifyProductCancelButton.Click += new System.EventHandler(this.modifyProductCancelButton_Click);
            // 
            // modifyProductPriceLabel
            // 
            this.modifyProductPriceLabel.AutoSize = true;
            this.modifyProductPriceLabel.Location = new System.Drawing.Point(48, 440);
            this.modifyProductPriceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductPriceLabel.Name = "modifyProductPriceLabel";
            this.modifyProductPriceLabel.Size = new System.Drawing.Size(61, 25);
            this.modifyProductPriceLabel.TabIndex = 70;
            this.modifyProductPriceLabel.Text = "Price";
            // 
            // modifyProductDeleteButton
            // 
            this.modifyProductDeleteButton.Location = new System.Drawing.Point(1174, 577);
            this.modifyProductDeleteButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductDeleteButton.Name = "modifyProductDeleteButton";
            this.modifyProductDeleteButton.Size = new System.Drawing.Size(150, 44);
            this.modifyProductDeleteButton.TabIndex = 12;
            this.modifyProductDeleteButton.Text = "Delete";
            this.modifyProductDeleteButton.UseVisualStyleBackColor = true;
            this.modifyProductDeleteButton.Click += new System.EventHandler(this.modifyProductDeleteButton_Click);
            // 
            // modifyProductInvLabel
            // 
            this.modifyProductInvLabel.AutoSize = true;
            this.modifyProductInvLabel.Location = new System.Drawing.Point(48, 377);
            this.modifyProductInvLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductInvLabel.Name = "modifyProductInvLabel";
            this.modifyProductInvLabel.Size = new System.Drawing.Size(40, 25);
            this.modifyProductInvLabel.TabIndex = 69;
            this.modifyProductInvLabel.Text = "Inv";
            // 
            // modifyProductNameLabel
            // 
            this.modifyProductNameLabel.AutoSize = true;
            this.modifyProductNameLabel.Location = new System.Drawing.Point(48, 315);
            this.modifyProductNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductNameLabel.Name = "modifyProductNameLabel";
            this.modifyProductNameLabel.Size = new System.Drawing.Size(68, 25);
            this.modifyProductNameLabel.TabIndex = 68;
            this.modifyProductNameLabel.Text = "Name";
            // 
            // modifyProductAddButton
            // 
            this.modifyProductAddButton.Location = new System.Drawing.Point(1174, 327);
            this.modifyProductAddButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductAddButton.Name = "modifyProductAddButton";
            this.modifyProductAddButton.Size = new System.Drawing.Size(150, 44);
            this.modifyProductAddButton.TabIndex = 10;
            this.modifyProductAddButton.Text = "Add";
            this.modifyProductAddButton.UseVisualStyleBackColor = true;
            this.modifyProductAddButton.Click += new System.EventHandler(this.modifyProductAddButton_Click);
            // 
            // modifyProductIDLabel
            // 
            this.modifyProductIDLabel.AutoSize = true;
            this.modifyProductIDLabel.Location = new System.Drawing.Point(48, 250);
            this.modifyProductIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductIDLabel.Name = "modifyProductIDLabel";
            this.modifyProductIDLabel.Size = new System.Drawing.Size(32, 25);
            this.modifyProductIDLabel.TabIndex = 67;
            this.modifyProductIDLabel.Text = "ID";
            // 
            // modifyProductSearchTextBox
            // 
            this.modifyProductSearchTextBox.Location = new System.Drawing.Point(980, 81);
            this.modifyProductSearchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductSearchTextBox.Name = "modifyProductSearchTextBox";
            this.modifyProductSearchTextBox.Size = new System.Drawing.Size(284, 31);
            this.modifyProductSearchTextBox.TabIndex = 8;
            // 
            // modifyProductSearchButton
            // 
            this.modifyProductSearchButton.Location = new System.Drawing.Point(818, 77);
            this.modifyProductSearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductSearchButton.Name = "modifyProductSearchButton";
            this.modifyProductSearchButton.Size = new System.Drawing.Size(150, 44);
            this.modifyProductSearchButton.TabIndex = 7;
            this.modifyProductSearchButton.Text = "Search";
            this.modifyProductSearchButton.UseVisualStyleBackColor = true;
            this.modifyProductSearchButton.Click += new System.EventHandler(this.modifyProductSearchButton_Click);
            // 
            // modifyProductMinTextBox
            // 
            this.modifyProductMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductMinTextBox.Location = new System.Drawing.Point(386, 502);
            this.modifyProductMinTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductMinTextBox.Name = "modifyProductMinTextBox";
            this.modifyProductMinTextBox.Size = new System.Drawing.Size(116, 32);
            this.modifyProductMinTextBox.TabIndex = 6;
            this.modifyProductMinTextBox.TextChanged += new System.EventHandler(this.modifyProductMinTextBox_TextChanged);
            // 
            // modifyProductMaxTextBox
            // 
            this.modifyProductMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductMaxTextBox.Location = new System.Drawing.Point(172, 502);
            this.modifyProductMaxTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductMaxTextBox.Name = "modifyProductMaxTextBox";
            this.modifyProductMaxTextBox.Size = new System.Drawing.Size(118, 32);
            this.modifyProductMaxTextBox.TabIndex = 5;
            this.modifyProductMaxTextBox.TextChanged += new System.EventHandler(this.modifyProductMaxTextBox_TextChanged);
            // 
            // modifyProductIDTextBox
            // 
            this.modifyProductIDTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.modifyProductIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductIDTextBox.Location = new System.Drawing.Point(172, 244);
            this.modifyProductIDTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductIDTextBox.Name = "modifyProductIDTextBox";
            this.modifyProductIDTextBox.ReadOnly = true;
            this.modifyProductIDTextBox.Size = new System.Drawing.Size(238, 32);
            this.modifyProductIDTextBox.TabIndex = 4;
            this.modifyProductIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modifyProductNameTextBox
            // 
            this.modifyProductNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductNameTextBox.Location = new System.Drawing.Point(172, 310);
            this.modifyProductNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductNameTextBox.Name = "modifyProductNameTextBox";
            this.modifyProductNameTextBox.Size = new System.Drawing.Size(238, 32);
            this.modifyProductNameTextBox.TabIndex = 3;
            this.modifyProductNameTextBox.TextChanged += new System.EventHandler(this.modifyProductNameTextBox_TextChanged);
            // 
            // modifyProductInvTextBox
            // 
            this.modifyProductInvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductInvTextBox.Location = new System.Drawing.Point(172, 371);
            this.modifyProductInvTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductInvTextBox.Name = "modifyProductInvTextBox";
            this.modifyProductInvTextBox.Size = new System.Drawing.Size(118, 32);
            this.modifyProductInvTextBox.TabIndex = 2;
            this.modifyProductInvTextBox.TextChanged += new System.EventHandler(this.modifyProductInvTextBox_TextChanged);
            // 
            // modifyProductPriceTextBox
            // 
            this.modifyProductPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductPriceTextBox.Location = new System.Drawing.Point(172, 435);
            this.modifyProductPriceTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifyProductPriceTextBox.Name = "modifyProductPriceTextBox";
            this.modifyProductPriceTextBox.Size = new System.Drawing.Size(118, 32);
            this.modifyProductPriceTextBox.TabIndex = 1;
            this.modifyProductPriceTextBox.TextChanged += new System.EventHandler(this.modifyProductPriceTextBox_TextChanged);
            // 
            // modifyProductFormLabel
            // 
            this.modifyProductFormLabel.AutoSize = true;
            this.modifyProductFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductFormLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.modifyProductFormLabel.Location = new System.Drawing.Point(42, 77);
            this.modifyProductFormLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modifyProductFormLabel.Name = "modifyProductFormLabel";
            this.modifyProductFormLabel.Size = new System.Drawing.Size(244, 37);
            this.modifyProductFormLabel.TabIndex = 0;
            this.modifyProductFormLabel.Text = "Modify Product";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1432, 742);
            this.Controls.Add(this.modifyProductFormPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ModifyProductForm";
            this.Text = "ModifyProduct";
            this.modifyProductFormPanel.ResumeLayout(false);
            this.modifyProductFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductAssociatedPartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductPartsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel modifyProductFormPanel;
        private System.Windows.Forms.Label modifyProductMinLabel;
        private System.Windows.Forms.Button modifyProductSaveButton;
        private System.Windows.Forms.Label modifyProductMaxLabel;
        private System.Windows.Forms.Button modifyProductCancelButton;
        private System.Windows.Forms.Label modifyProductPriceLabel;
        private System.Windows.Forms.Button modifyProductDeleteButton;
        private System.Windows.Forms.Label modifyProductInvLabel;
        private System.Windows.Forms.Label modifyProductNameLabel;
        private System.Windows.Forms.Button modifyProductAddButton;
        private System.Windows.Forms.Label modifyProductIDLabel;
        private System.Windows.Forms.TextBox modifyProductSearchTextBox;
        private System.Windows.Forms.Button modifyProductSearchButton;
        private System.Windows.Forms.TextBox modifyProductMinTextBox;
        private System.Windows.Forms.TextBox modifyProductMaxTextBox;
        private System.Windows.Forms.TextBox modifyProductIDTextBox;
        private System.Windows.Forms.TextBox modifyProductNameTextBox;
        private System.Windows.Forms.TextBox modifyProductInvTextBox;
        private System.Windows.Forms.TextBox modifyProductPriceTextBox;
        private System.Windows.Forms.Label modifyProductFormLabel;
        private System.Windows.Forms.DataGridView modifyProductAssociatedPartsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridView modifyProductPartsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}