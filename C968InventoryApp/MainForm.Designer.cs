namespace InventoryApp
{
    partial class MainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.partsPanel = new System.Windows.Forms.Panel();
            this.mainPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsAddButton = new System.Windows.Forms.Button();
            this.partsModifyButton = new System.Windows.Forms.Button();
            this.partsDeleteButton = new System.Windows.Forms.Button();
            this.partsSearchTextBox = new System.Windows.Forms.TextBox();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partsPanelLabel = new System.Windows.Forms.Label();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.mainProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsAddButton = new System.Windows.Forms.Button();
            this.productsModifyButton = new System.Windows.Forms.Button();
            this.productsDeleteButton = new System.Windows.Forms.Button();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.productsPanelLabel = new System.Windows.Forms.Label();
            this.mainExitButton = new System.Windows.Forms.Button();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsDataGridView)).BeginInit();
            this.productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titleLabel.Location = new System.Drawing.Point(11, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(295, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Inventory Management System";
            // 
            // partsPanel
            // 
            this.partsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsPanel.Controls.Add(this.mainPartsDataGridView);
            this.partsPanel.Controls.Add(this.partsAddButton);
            this.partsPanel.Controls.Add(this.partsModifyButton);
            this.partsPanel.Controls.Add(this.partsDeleteButton);
            this.partsPanel.Controls.Add(this.partsSearchTextBox);
            this.partsPanel.Controls.Add(this.partsSearchButton);
            this.partsPanel.Controls.Add(this.partsPanelLabel);
            this.partsPanel.Location = new System.Drawing.Point(15, 43);
            this.partsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.partsPanel.Name = "partsPanel";
            this.partsPanel.Size = new System.Drawing.Size(400, 251);
            this.partsPanel.TabIndex = 1;
            // 
            // mainPartsDataGridView
            // 
            this.mainPartsDataGridView.AllowUserToAddRows = false;
            this.mainPartsDataGridView.AllowUserToDeleteRows = false;
            this.mainPartsDataGridView.AllowUserToOrderColumns = true;
            this.mainPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainPartsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.mainPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainPartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.Inv,
            this.PriceCost,
            this.Max,
            this.Min});
            this.mainPartsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.mainPartsDataGridView.Location = new System.Drawing.Point(22, 44);
            this.mainPartsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.mainPartsDataGridView.MultiSelect = false;
            this.mainPartsDataGridView.Name = "mainPartsDataGridView";
            this.mainPartsDataGridView.RowHeadersVisible = false;
            this.mainPartsDataGridView.RowTemplate.ReadOnly = true;
            this.mainPartsDataGridView.Size = new System.Drawing.Size(356, 147);
            this.mainPartsDataGridView.TabIndex = 7;
            this.mainPartsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PartID
            // 
            this.PartID.DataPropertyName = "partID";
            this.PartID.HeaderText = "Part ID";
            this.PartID.Name = "PartID";
            this.PartID.ReadOnly = true;
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "partName";
            this.PartName.HeaderText = "Part Name";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // Inv
            // 
            this.Inv.DataPropertyName = "inStock";
            this.Inv.HeaderText = "Inventory Level";
            this.Inv.Name = "Inv";
            this.Inv.ReadOnly = true;
            // 
            // PriceCost
            // 
            this.PriceCost.DataPropertyName = "price";
            this.PriceCost.HeaderText = "Price/Cost per Unit";
            this.PriceCost.Name = "PriceCost";
            this.PriceCost.ReadOnly = true;
            // 
            // Max
            // 
            this.Max.DataPropertyName = "max";
            this.Max.HeaderText = "Max";
            this.Max.Name = "Max";
            this.Max.ReadOnly = true;
            this.Max.Visible = false;
            // 
            // Min
            // 
            this.Min.DataPropertyName = "min";
            this.Min.HeaderText = "Min";
            this.Min.Name = "Min";
            this.Min.ReadOnly = true;
            this.Min.Visible = false;
            // 
            // partsAddButton
            // 
            this.partsAddButton.Location = new System.Drawing.Point(180, 205);
            this.partsAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(64, 31);
            this.partsAddButton.TabIndex = 6;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            this.partsAddButton.Click += new System.EventHandler(this.partsAddButton_Click);
            // 
            // partsModifyButton
            // 
            this.partsModifyButton.Location = new System.Drawing.Point(247, 205);
            this.partsModifyButton.Margin = new System.Windows.Forms.Padding(2);
            this.partsModifyButton.Name = "partsModifyButton";
            this.partsModifyButton.Size = new System.Drawing.Size(64, 31);
            this.partsModifyButton.TabIndex = 5;
            this.partsModifyButton.Text = "Modify";
            this.partsModifyButton.UseVisualStyleBackColor = true;
            this.partsModifyButton.Click += new System.EventHandler(this.partsModifyButton_Click);
            // 
            // partsDeleteButton
            // 
            this.partsDeleteButton.Location = new System.Drawing.Point(314, 205);
            this.partsDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.partsDeleteButton.Name = "partsDeleteButton";
            this.partsDeleteButton.Size = new System.Drawing.Size(64, 31);
            this.partsDeleteButton.TabIndex = 4;
            this.partsDeleteButton.Text = "Delete";
            this.partsDeleteButton.UseVisualStyleBackColor = true;
            this.partsDeleteButton.Click += new System.EventHandler(this.partsDeleteButton_Click);
            // 
            // partsSearchTextBox
            // 
            this.partsSearchTextBox.Location = new System.Drawing.Point(265, 14);
            this.partsSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partsSearchTextBox.Name = "partsSearchTextBox";
            this.partsSearchTextBox.Size = new System.Drawing.Size(102, 20);
            this.partsSearchTextBox.TabIndex = 2;
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(190, 12);
            this.partsSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(53, 22);
            this.partsSearchButton.TabIndex = 1;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // partsPanelLabel
            // 
            this.partsPanelLabel.AutoSize = true;
            this.partsPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsPanelLabel.Location = new System.Drawing.Point(18, 14);
            this.partsPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partsPanelLabel.Name = "partsPanelLabel";
            this.partsPanelLabel.Size = new System.Drawing.Size(51, 20);
            this.partsPanelLabel.TabIndex = 0;
            this.partsPanelLabel.Text = "Parts";
            // 
            // productsPanel
            // 
            this.productsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsPanel.Controls.Add(this.mainProductsDataGridView);
            this.productsPanel.Controls.Add(this.productsAddButton);
            this.productsPanel.Controls.Add(this.productsModifyButton);
            this.productsPanel.Controls.Add(this.productsDeleteButton);
            this.productsPanel.Controls.Add(this.productSearchTextBox);
            this.productsPanel.Controls.Add(this.productSearchButton);
            this.productsPanel.Controls.Add(this.productsPanelLabel);
            this.productsPanel.Location = new System.Drawing.Point(434, 43);
            this.productsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(392, 251);
            this.productsPanel.TabIndex = 3;
            // 
            // mainProductsDataGridView
            // 
            this.mainProductsDataGridView.AllowUserToAddRows = false;
            this.mainProductsDataGridView.AllowUserToDeleteRows = false;
            this.mainProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainProductsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.mainProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.invLevel,
            this.productPrice});
            this.mainProductsDataGridView.Location = new System.Drawing.Point(18, 44);
            this.mainProductsDataGridView.MultiSelect = false;
            this.mainProductsDataGridView.Name = "mainProductsDataGridView";
            this.mainProductsDataGridView.ReadOnly = true;
            this.mainProductsDataGridView.RowHeadersVisible = false;
            this.mainProductsDataGridView.RowTemplate.ReadOnly = true;
            this.mainProductsDataGridView.Size = new System.Drawing.Size(358, 147);
            this.mainProductsDataGridView.TabIndex = 7;
            this.mainProductsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainProductsDataGridView_CellClick);
            // 
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // invLevel
            // 
            this.invLevel.HeaderText = "Inventory Level";
            this.invLevel.Name = "invLevel";
            this.invLevel.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price per Unit";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // productsAddButton
            // 
            this.productsAddButton.Location = new System.Drawing.Point(178, 205);
            this.productsAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.productsAddButton.Name = "productsAddButton";
            this.productsAddButton.Size = new System.Drawing.Size(64, 31);
            this.productsAddButton.TabIndex = 6;
            this.productsAddButton.Text = "Add";
            this.productsAddButton.UseVisualStyleBackColor = true;
            this.productsAddButton.Click += new System.EventHandler(this.productsAddButton_Click);
            // 
            // productsModifyButton
            // 
            this.productsModifyButton.Location = new System.Drawing.Point(245, 205);
            this.productsModifyButton.Margin = new System.Windows.Forms.Padding(2);
            this.productsModifyButton.Name = "productsModifyButton";
            this.productsModifyButton.Size = new System.Drawing.Size(64, 31);
            this.productsModifyButton.TabIndex = 5;
            this.productsModifyButton.Text = "Modify";
            this.productsModifyButton.UseVisualStyleBackColor = true;
            this.productsModifyButton.Click += new System.EventHandler(this.productsModifyButton_Click);
            // 
            // productsDeleteButton
            // 
            this.productsDeleteButton.Location = new System.Drawing.Point(312, 205);
            this.productsDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.productsDeleteButton.Name = "productsDeleteButton";
            this.productsDeleteButton.Size = new System.Drawing.Size(64, 31);
            this.productsDeleteButton.TabIndex = 4;
            this.productsDeleteButton.Text = "Delete";
            this.productsDeleteButton.UseVisualStyleBackColor = true;
            this.productsDeleteButton.Click += new System.EventHandler(this.productsDeleteButton_Click);
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Location = new System.Drawing.Point(260, 16);
            this.productSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(102, 20);
            this.productSearchTextBox.TabIndex = 2;
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(202, 14);
            this.productSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(54, 22);
            this.productSearchButton.TabIndex = 1;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.productSearchButton_Click);
            // 
            // productsPanelLabel
            // 
            this.productsPanelLabel.AutoSize = true;
            this.productsPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsPanelLabel.Location = new System.Drawing.Point(14, 14);
            this.productsPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productsPanelLabel.Name = "productsPanelLabel";
            this.productsPanelLabel.Size = new System.Drawing.Size(80, 20);
            this.productsPanelLabel.TabIndex = 0;
            this.productsPanelLabel.Text = "Products";
            // 
            // mainExitButton
            // 
            this.mainExitButton.Location = new System.Drawing.Point(746, 298);
            this.mainExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.mainExitButton.Name = "mainExitButton";
            this.mainExitButton.Size = new System.Drawing.Size(65, 28);
            this.mainExitButton.TabIndex = 5;
            this.mainExitButton.Text = "Exit";
            this.mainExitButton.UseVisualStyleBackColor = true;
            this.mainExitButton.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(InventoryApp.Inventory);
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataSource = typeof(InventoryApp.Inventory);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(839, 336);
            this.Controls.Add(this.mainExitButton);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.partsPanel);
            this.Controls.Add(this.titleLabel);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.partsPanel.ResumeLayout(false);
            this.partsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsDataGridView)).EndInit();
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel partsPanel;
        private System.Windows.Forms.Button partsAddButton;
        private System.Windows.Forms.Button partsModifyButton;
        private System.Windows.Forms.Button partsDeleteButton;
        private System.Windows.Forms.TextBox partsSearchTextBox;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.Label partsPanelLabel;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Button productsAddButton;
        private System.Windows.Forms.Button productsModifyButton;
        private System.Windows.Forms.Button productsDeleteButton;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.Label productsPanelLabel;
        private System.Windows.Forms.Button mainExitButton;
        private System.Windows.Forms.DataGridView mainPartsDataGridView;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridView mainProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
    }
}

