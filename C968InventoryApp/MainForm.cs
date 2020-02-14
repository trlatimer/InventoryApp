using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class MainForm : Form
    {
        // Variables to track selected indexes of parts and products
        public static int partIndex { get; set; }
        public static int productIndex { get; set; }
        
        // Variables to hold selected Parts and index within Lists
        public static Part selectedPart { get; set; }
        public static int selectedPartIndex { get; set; }

        // Variables to hold selected Proucts and index within Lists
        public static Product selectedProduct { get; set; }
        public static int selectedProductIndex { get; set; }

        // Initialize form, build examples, format DataGridViews, and display data
        public MainForm()
        {
            InitializeComponent();
            buildExampleObjects();
            formatDataGridView(mainPartsDataGridView);
            formatDataGridView(mainProductsDataGridView);
            displayLists();
        }

        // Format DataGridViews
        public static void formatDataGridView(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgv.RowHeadersVisible = false;
        }

        // Build exmaple objects
        private void buildExampleObjects()
        {
            Inventory.Products.Clear();
            Inventory.addProduct(new Product(10, "Mouse", 15, 10.00, 99, 0));
            Inventory.addProduct(new Product(1, "Keyboard", 6, 6.00, 9999, 0));
            Inventory.addProduct(new Product(2, "Monitor", 10, 78.00, 99, 0));
            Inventory.addProduct(new Product(3, "Computer", 7, 128.00, 99, 0));

            Inventory.addPart(new Inhouse(15, "Wheel", 20, 0.25, 99, 0, 20));
            Inventory.addPart(new Inhouse(1, "Mouse Body", 10, 4.50, 99, 0, 1));
            Inventory.addPart(new Inhouse(2, "Mouse Cable", 20, 1.00, 999, 0, 1));
            Inventory.addPart(new Outsourced(3, "Graphics Card", 15, 60.00, 99, 0, "An Outside Company"));
            Inventory.addPart(new Outsourced(4, "Power Supply", 10, 20.00, 99, 0, "Outside Comp"));
        }

        // Display data
        public void displayLists()
        {
            // Display AllParts List
            // Clear previously displayed data
            mainPartsDataGridView.Rows.Clear();
            mainPartsDataGridView.Refresh();
            // Loop through all parts and display data in each column, 1 part per row
            for(int i=0; i<Inventory.AllParts.Count; i++)
            {
                mainPartsDataGridView.Rows.Add();
                mainPartsDataGridView.Rows[i].Cells[0].Value = Inventory.AllParts[i].getPartID();
                mainPartsDataGridView.Rows[i].Cells[1].Value = Inventory.AllParts[i].getName();
                mainPartsDataGridView.Rows[i].Cells[2].Value = Inventory.AllParts[i].getInStock();
                mainPartsDataGridView.Rows[i].Cells[3].Value = Inventory.AllParts[i].getPrice();
            }
            // Format price column to currency
            mainPartsDataGridView.Columns[3].DefaultCellStyle.Format = "c";
            // Clear any selections
            mainPartsDataGridView.ClearSelection();

            // Display Products List
            // Clear any previously displayed data
            mainProductsDataGridView.Rows.Clear();
            mainProductsDataGridView.Refresh();
            // Loop through all Products and display data in each column, 1 product per row
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                mainProductsDataGridView.Rows.Add();
                mainProductsDataGridView.Rows[i].Cells[0].Value = Inventory.Products[i].getProductID();
                mainProductsDataGridView.Rows[i].Cells[1].Value = Inventory.Products[i].getName();
                mainProductsDataGridView.Rows[i].Cells[2].Value = Inventory.Products[i].getInStock();
                mainProductsDataGridView.Rows[i].Cells[3].Value = Inventory.Products[i].getPrice();
            }
            // Format price column to currency
            mainProductsDataGridView.Columns[3].DefaultCellStyle.Format = "c";
            mainProductsDataGridView.ClearSelection();

            // Clear Selections
            partIndex = -1;
            productIndex = -1;
        }

        // Add Parts button click
        private void partsAddButton_Click(object sender, EventArgs e)
        {
            // Call new Add Part Form
            AddPartForm addPartForm = new AddPartForm();
            // Create EventHandler to reload lists on when closing form
            addPartForm.FormClosing += new FormClosingEventHandler(addPartForm_Closing);
            // Show new form
            addPartForm.Show();
        }

        // Event handler to redisplay DataGridView data when closing addPartForm
        private void addPartForm_Closing(object sender, FormClosingEventArgs e)
        {
            displayLists();
        }

        // Main Exit button click
        private void mainExitButton_Click(object sender, EventArgs e)
        {
            // Close application
            Application.Exit();
        }

        // Main Load event handler
        private void Main_Load(object sender, EventArgs e)
        {
            // Reload DataGridViews
            displayLists();

            // Reset selections
            partIndex = -1;
            productIndex = -1;
        }

        // Modify Parts button click
        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            // Ensure that a part is selected
            if (partIndex >= 0)
            {
                // Create new Modify Part form
                ModifyPartForm modifyPartForm = new ModifyPartForm();
                // Create event handler for when form closes
                modifyPartForm.FormClosing += new FormClosingEventHandler(modifyPartForm_Closing);
                // Show new form
                modifyPartForm.Show();
            }
            // If no part selected, display dialogue
            else
            {
                MessageBox.Show("Please select a part to modify and try again.");
            }
        }

        // modifyPartForm Closing Event Handler -- Redisplay DataGridView data
        private void modifyPartForm_Closing(object sender, FormClosingEventArgs e)
        {
            displayLists();
        }

        // Add Products button click
        private void productsAddButton_Click(object sender, EventArgs e)
        {
            // Create new addProductForm
            AddProductForm addProductForm = new AddProductForm();
            // Create new event handler for when form closes
            addProductForm.FormClosing += new FormClosingEventHandler(addProductForm_Closing);
            // Show new form
            addProductForm.Show();
        }

        // Add Product Form Closing Event Handler -- Redisplay DataGridView data
        private void addProductForm_Closing(object sender, FormClosingEventArgs e)
        {
            displayLists();
        }

        // Modify Product button click
        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that a product is selected
                if (productIndex >= 0)
                {
                    // Create new modifyProductForm
                    ModifyProductForm modifyProductForm = new ModifyProductForm();
                    // Create new event handler for when form closes
                    modifyProductForm.FormClosing += new FormClosingEventHandler(modifyProductForm_Closing);
                    // Show new form
                    modifyProductForm.Show();
                }
                // If no product selected, display dialogue
                else
                {
                    MessageBox.Show("Please select a product and try again.");
                }
                
            }
            // Ensure that a product is selected
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a product and try again.");
            }
            
        }

        // modifyProductForm_Closing Event Handler -- Redisplay DataGridView data
        private void modifyProductForm_Closing(object sender, FormClosingEventArgs e)
        {
            displayLists();
        }

        // Click within Parts DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set partIndex to currently selected row
            partIndex = mainPartsDataGridView.CurrentCell.RowIndex;
            // Lookup part based on ID and set it as the selected part
            selectedPart = Inventory.LookupPart((int)mainPartsDataGridView.Rows[partIndex].Cells[0].Value);
        }

        // Delete part button click
        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            // Ensure index is a valid selection in DataGridView
            if (partIndex >= 0)
            {
                // Delete selected part
                Console.WriteLine("Attempting to delete part with ID " + $"{(int)mainPartsDataGridView.Rows[partIndex].Cells[0].Value}");
                Inventory.deletePart(selectedPart);
                // Redisplay DataGridView data
                displayLists();
                // Reset partIndex
                partIndex = -1;
            }
            // If no part selected, display dialogue and cancel click
            else
            {
                MessageBox.Show("Please select a part and try again");
                return;
            }
        }

        // Parts search button click
        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            // Obtain input from user
            int searchID = int.Parse(partsSearchTextBox.Text);
            // Clear user input
            partsSearchTextBox.Clear();

            // Loop through rows in the DataGridView displaying parts
            foreach (DataGridViewRow row in mainPartsDataGridView.Rows)
            {
                // If ID provided by user matches an ID within the DataGridView, select row, record index, and set selectedPart
                if ((int)row.Cells[0].Value == searchID)
                {
                    row.Selected = true;
                    partIndex = row.Cells[0].RowIndex;
                    selectedPart = Inventory.LookupPart((int)mainPartsDataGridView.Rows[partIndex].Cells[0].Value);
                    return;
                }
            }
            // If no matching ID's found, display dialogue
            MessageBox.Show("No Part with matching Part ID found. Please try again.");
        }

        // Click within Products DataGridView
        private void mainProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set index to row index and lookup corresponding product by ID
            productIndex = mainProductsDataGridView.CurrentCell.RowIndex;
            selectedProduct = Inventory.lookupProduct((int)mainProductsDataGridView.Rows[productIndex].Cells[0].Value);
        }

        // Delete Product button click
        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete selected Product based on ID returned by selection
                Console.WriteLine("Attempting to delete product with ID " + $"{(int)mainProductsDataGridView.Rows[productIndex].Cells[0].Value}");
                Inventory.removeProduct(selectedProduct.getProductID());
                // Redisplay DataGridView Data
                displayLists();
                // Reset product index
                productIndex = -1;
            }
            // If no product is selected, display dialogue and cancel click
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a part and try again");
                return;
            }
        }

        // Product search button click
        private void productSearchButton_Click(object sender, EventArgs e)
        {
            // Obtain input from user
            int searchID = int.Parse(productSearchTextBox.Text);
            // Clear user input
            productSearchTextBox.Clear();

            // Loop through rows in DataGridView displaying products
            foreach (DataGridViewRow row in mainProductsDataGridView.Rows)
            {
                if ((int)row.Cells[0].Value == searchID)
                {
                    // If ID within row matches ID entered by user, select row, set index to RowIndex, and lookup product by ID
                    row.Selected = true;
                    productIndex = row.Cells[0].RowIndex;
                    selectedProduct = Inventory.lookupProduct((int)mainProductsDataGridView.Rows[productIndex].Cells[0].Value);
                    return;
                }
            }
            // If no matching ID's found, display dialogue
            MessageBox.Show("No Product with matching Product ID found. Please try again.");
        }
    }
}
