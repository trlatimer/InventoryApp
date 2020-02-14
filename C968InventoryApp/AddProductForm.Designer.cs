namespace InventoryApp
{
    partial class AddProductForm
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
            this.addProductFormPanel = new System.Windows.Forms.Panel();
            this.addProductAssociatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProductPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProductMinLabel = new System.Windows.Forms.Label();
            this.addProductSaveButton = new System.Windows.Forms.Button();
            this.addProductMaxLabel = new System.Windows.Forms.Label();
            this.addProductCancelButton = new System.Windows.Forms.Button();
            this.addProductPriceLabel = new System.Windows.Forms.Label();
            this.addProductDeleteButton = new System.Windows.Forms.Button();
            this.addProductInvLabel = new System.Windows.Forms.Label();
            this.addProductNameLabel = new System.Windows.Forms.Label();
            this.addProductAddButton = new System.Windows.Forms.Button();
            this.addProductIDLabel = new System.Windows.Forms.Label();
            this.addProductSearchTextBox = new System.Windows.Forms.TextBox();
            this.addProductSearchButton = new System.Windows.Forms.Button();
            this.addProductMinTextBox = new System.Windows.Forms.TextBox();
            this.addProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.addProductIDTextBox = new System.Windows.Forms.TextBox();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.addProductInvTextBox = new System.Windows.Forms.TextBox();
            this.addProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.addProductFormLabel = new System.Windows.Forms.Label();
            this.addProductFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addProductAssociatedPartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductFormPanel
            // 
            this.addProductFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductFormPanel.Controls.Add(this.addProductAssociatedPartsDataGridView);
            this.addProductFormPanel.Controls.Add(this.addProductPartsDataGridView);
            this.addProductFormPanel.Controls.Add(this.addProductMinLabel);
            this.addProductFormPanel.Controls.Add(this.addProductSaveButton);
            this.addProductFormPanel.Controls.Add(this.addProductMaxLabel);
            this.addProductFormPanel.Controls.Add(this.addProductCancelButton);
            this.addProductFormPanel.Controls.Add(this.addProductPriceLabel);
            this.addProductFormPanel.Controls.Add(this.addProductDeleteButton);
            this.addProductFormPanel.Controls.Add(this.addProductInvLabel);
            this.addProductFormPanel.Controls.Add(this.addProductNameLabel);
            this.addProductFormPanel.Controls.Add(this.addProductAddButton);
            this.addProductFormPanel.Controls.Add(this.addProductIDLabel);
            this.addProductFormPanel.Controls.Add(this.addProductSearchTextBox);
            this.addProductFormPanel.Controls.Add(this.addProductSearchButton);
            this.addProductFormPanel.Controls.Add(this.addProductMinTextBox);
            this.addProductFormPanel.Controls.Add(this.addProductMaxTextBox);
            this.addProductFormPanel.Controls.Add(this.addProductIDTextBox);
            this.addProductFormPanel.Controls.Add(this.addProductNameTextBox);
            this.addProductFormPanel.Controls.Add(this.addProductInvTextBox);
            this.addProductFormPanel.Controls.Add(this.addProductPriceTextBox);
            this.addProductFormPanel.Controls.Add(this.addProductFormLabel);
            this.addProductFormPanel.Location = new System.Drawing.Point(12, 12);
            this.addProductFormPanel.Name = "addProductFormPanel";
            this.addProductFormPanel.Size = new System.Drawing.Size(678, 334);
            this.addProductFormPanel.TabIndex = 0;
            // 
            // addProductAssociatedPartsDataGridView
            // 
            this.addProductAssociatedPartsDataGridView.AllowUserToAddRows = false;
            this.addProductAssociatedPartsDataGridView.AllowUserToDeleteRows = false;
            this.addProductAssociatedPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addProductAssociatedPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductAssociatedPartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.addProductAssociatedPartsDataGridView.Location = new System.Drawing.Point(288, 172);
            this.addProductAssociatedPartsDataGridView.Name = "addProductAssociatedPartsDataGridView";
            this.addProductAssociatedPartsDataGridView.RowHeadersVisible = false;
            this.addProductAssociatedPartsDataGridView.Size = new System.Drawing.Size(379, 95);
            this.addProductAssociatedPartsDataGridView.TabIndex = 74;
            this.addProductAssociatedPartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addProductAssociatedPartsDataGridView_CellClick);
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
            // addProductPartsDataGridView
            // 
            this.addProductPartsDataGridView.AllowUserToAddRows = false;
            this.addProductPartsDataGridView.AllowUserToDeleteRows = false;
            this.addProductPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addProductPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductPartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.inv,
            this.price});
            this.addProductPartsDataGridView.Location = new System.Drawing.Point(288, 46);
            this.addProductPartsDataGridView.MultiSelect = false;
            this.addProductPartsDataGridView.Name = "addProductPartsDataGridView";
            this.addProductPartsDataGridView.ReadOnly = true;
            this.addProductPartsDataGridView.RowHeadersVisible = false;
            this.addProductPartsDataGridView.Size = new System.Drawing.Size(379, 91);
            this.addProductPartsDataGridView.TabIndex = 73;
            this.addProductPartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addProductPartsDataGridView_CellClick);
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
            // addProductMinLabel
            // 
            this.addProductMinLabel.AutoSize = true;
            this.addProductMinLabel.Location = new System.Drawing.Point(155, 237);
            this.addProductMinLabel.Name = "addProductMinLabel";
            this.addProductMinLabel.Size = new System.Drawing.Size(24, 13);
            this.addProductMinLabel.TabIndex = 72;
            this.addProductMinLabel.Text = "Min";
            // 
            // addProductSaveButton
            // 
            this.addProductSaveButton.Location = new System.Drawing.Point(498, 302);
            this.addProductSaveButton.Name = "addProductSaveButton";
            this.addProductSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addProductSaveButton.TabIndex = 14;
            this.addProductSaveButton.Text = "Save";
            this.addProductSaveButton.UseVisualStyleBackColor = true;
            this.addProductSaveButton.Click += new System.EventHandler(this.addProductSaveButton_Click);
            // 
            // addProductMaxLabel
            // 
            this.addProductMaxLabel.AutoSize = true;
            this.addProductMaxLabel.Location = new System.Drawing.Point(16, 237);
            this.addProductMaxLabel.Name = "addProductMaxLabel";
            this.addProductMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.addProductMaxLabel.TabIndex = 71;
            this.addProductMaxLabel.Text = "Max";
            // 
            // addProductCancelButton
            // 
            this.addProductCancelButton.Location = new System.Drawing.Point(579, 302);
            this.addProductCancelButton.Name = "addProductCancelButton";
            this.addProductCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addProductCancelButton.TabIndex = 13;
            this.addProductCancelButton.Text = "Cancel";
            this.addProductCancelButton.UseVisualStyleBackColor = true;
            this.addProductCancelButton.Click += new System.EventHandler(this.addProductCancelButton_Click);
            // 
            // addProductPriceLabel
            // 
            this.addProductPriceLabel.AutoSize = true;
            this.addProductPriceLabel.Location = new System.Drawing.Point(16, 202);
            this.addProductPriceLabel.Name = "addProductPriceLabel";
            this.addProductPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.addProductPriceLabel.TabIndex = 70;
            this.addProductPriceLabel.Text = "Price";
            // 
            // addProductDeleteButton
            // 
            this.addProductDeleteButton.Location = new System.Drawing.Point(579, 273);
            this.addProductDeleteButton.Name = "addProductDeleteButton";
            this.addProductDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.addProductDeleteButton.TabIndex = 12;
            this.addProductDeleteButton.Text = "Delete";
            this.addProductDeleteButton.UseVisualStyleBackColor = true;
            this.addProductDeleteButton.Click += new System.EventHandler(this.addProductDeleteButton_Click);
            // 
            // addProductInvLabel
            // 
            this.addProductInvLabel.AutoSize = true;
            this.addProductInvLabel.Location = new System.Drawing.Point(16, 169);
            this.addProductInvLabel.Name = "addProductInvLabel";
            this.addProductInvLabel.Size = new System.Drawing.Size(22, 13);
            this.addProductInvLabel.TabIndex = 69;
            this.addProductInvLabel.Text = "Inv";
            // 
            // addProductNameLabel
            // 
            this.addProductNameLabel.AutoSize = true;
            this.addProductNameLabel.Location = new System.Drawing.Point(16, 137);
            this.addProductNameLabel.Name = "addProductNameLabel";
            this.addProductNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addProductNameLabel.TabIndex = 68;
            this.addProductNameLabel.Text = "Name";
            // 
            // addProductAddButton
            // 
            this.addProductAddButton.Location = new System.Drawing.Point(579, 143);
            this.addProductAddButton.Name = "addProductAddButton";
            this.addProductAddButton.Size = new System.Drawing.Size(75, 23);
            this.addProductAddButton.TabIndex = 10;
            this.addProductAddButton.Text = "Add";
            this.addProductAddButton.UseVisualStyleBackColor = true;
            this.addProductAddButton.Click += new System.EventHandler(this.addProductAddButton_Click);
            // 
            // addProductIDLabel
            // 
            this.addProductIDLabel.AutoSize = true;
            this.addProductIDLabel.Location = new System.Drawing.Point(16, 103);
            this.addProductIDLabel.Name = "addProductIDLabel";
            this.addProductIDLabel.Size = new System.Drawing.Size(18, 13);
            this.addProductIDLabel.TabIndex = 67;
            this.addProductIDLabel.Text = "ID";
            // 
            // addProductSearchTextBox
            // 
            this.addProductSearchTextBox.Location = new System.Drawing.Point(482, 15);
            this.addProductSearchTextBox.Name = "addProductSearchTextBox";
            this.addProductSearchTextBox.Size = new System.Drawing.Size(144, 20);
            this.addProductSearchTextBox.TabIndex = 8;
            // 
            // addProductSearchButton
            // 
            this.addProductSearchButton.Location = new System.Drawing.Point(401, 13);
            this.addProductSearchButton.Name = "addProductSearchButton";
            this.addProductSearchButton.Size = new System.Drawing.Size(75, 23);
            this.addProductSearchButton.TabIndex = 7;
            this.addProductSearchButton.Text = "Search";
            this.addProductSearchButton.UseVisualStyleBackColor = true;
            this.addProductSearchButton.Click += new System.EventHandler(this.addProductSearchButton_Click);
            // 
            // addProductMinTextBox
            // 
            this.addProductMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMinTextBox.Location = new System.Drawing.Point(185, 234);
            this.addProductMinTextBox.Name = "addProductMinTextBox";
            this.addProductMinTextBox.Size = new System.Drawing.Size(60, 20);
            this.addProductMinTextBox.TabIndex = 6;
            this.addProductMinTextBox.Text = "Min";
            this.addProductMinTextBox.TextChanged += new System.EventHandler(this.addProductMinTextBox_TextChanged);
            // 
            // addProductMaxTextBox
            // 
            this.addProductMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMaxTextBox.Location = new System.Drawing.Point(78, 234);
            this.addProductMaxTextBox.Name = "addProductMaxTextBox";
            this.addProductMaxTextBox.Size = new System.Drawing.Size(61, 20);
            this.addProductMaxTextBox.TabIndex = 5;
            this.addProductMaxTextBox.Text = "Max";
            this.addProductMaxTextBox.TextChanged += new System.EventHandler(this.addProductMaxTextBox_TextChanged);
            // 
            // addProductIDTextBox
            // 
            this.addProductIDTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addProductIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductIDTextBox.Location = new System.Drawing.Point(78, 100);
            this.addProductIDTextBox.Name = "addProductIDTextBox";
            this.addProductIDTextBox.ReadOnly = true;
            this.addProductIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.addProductIDTextBox.TabIndex = 4;
            this.addProductIDTextBox.Text = "Auto Gen - Disabled";
            this.addProductIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductNameTextBox.Location = new System.Drawing.Point(78, 134);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.addProductNameTextBox.TabIndex = 3;
            this.addProductNameTextBox.Text = "Product Name";
            this.addProductNameTextBox.TextChanged += new System.EventHandler(this.addProductNameTextBox_TextChanged);
            // 
            // addProductInvTextBox
            // 
            this.addProductInvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductInvTextBox.Location = new System.Drawing.Point(78, 166);
            this.addProductInvTextBox.Name = "addProductInvTextBox";
            this.addProductInvTextBox.Size = new System.Drawing.Size(61, 20);
            this.addProductInvTextBox.TabIndex = 2;
            this.addProductInvTextBox.Text = "Inv";
            this.addProductInvTextBox.TextChanged += new System.EventHandler(this.addProductInvTextBox_TextChanged);
            // 
            // addProductPriceTextBox
            // 
            this.addProductPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductPriceTextBox.Location = new System.Drawing.Point(78, 199);
            this.addProductPriceTextBox.Name = "addProductPriceTextBox";
            this.addProductPriceTextBox.Size = new System.Drawing.Size(61, 20);
            this.addProductPriceTextBox.TabIndex = 1;
            this.addProductPriceTextBox.Text = "Price";
            this.addProductPriceTextBox.TextChanged += new System.EventHandler(this.addProductPriceTextBox_TextChanged);
            // 
            // addProductFormLabel
            // 
            this.addProductFormLabel.AutoSize = true;
            this.addProductFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductFormLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addProductFormLabel.Location = new System.Drawing.Point(13, 13);
            this.addProductFormLabel.Name = "addProductFormLabel";
            this.addProductFormLabel.Size = new System.Drawing.Size(108, 20);
            this.addProductFormLabel.TabIndex = 0;
            this.addProductFormLabel.Text = "Add Product";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(699, 356);
            this.Controls.Add(this.addProductFormPanel);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            this.addProductFormPanel.ResumeLayout(false);
            this.addProductFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addProductAssociatedPartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductPartsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addProductFormPanel;
        private System.Windows.Forms.Label addProductFormLabel;
        private System.Windows.Forms.TextBox addProductSearchTextBox;
        private System.Windows.Forms.Button addProductSearchButton;
        private System.Windows.Forms.TextBox addProductMinTextBox;
        private System.Windows.Forms.TextBox addProductMaxTextBox;
        private System.Windows.Forms.TextBox addProductIDTextBox;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.TextBox addProductInvTextBox;
        private System.Windows.Forms.TextBox addProductPriceTextBox;
        private System.Windows.Forms.Button addProductSaveButton;
        private System.Windows.Forms.Button addProductCancelButton;
        private System.Windows.Forms.Button addProductDeleteButton;
        private System.Windows.Forms.Button addProductAddButton;
        private System.Windows.Forms.Label addProductMinLabel;
        private System.Windows.Forms.Label addProductMaxLabel;
        private System.Windows.Forms.Label addProductPriceLabel;
        private System.Windows.Forms.Label addProductInvLabel;
        private System.Windows.Forms.Label addProductNameLabel;
        private System.Windows.Forms.Label addProductIDLabel;
        private System.Windows.Forms.DataGridView addProductAssociatedPartsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView addProductPartsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}