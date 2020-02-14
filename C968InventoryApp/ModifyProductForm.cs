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
    public partial class ModifyProductForm : Form
    {
        // Temporary list of parts to be associated with Product
        private static BindingList<Part> partsToAssociate = new BindingList<Part>();
        public static BindingList<Part> partsAssociated { get { return partsToAssociate; } set { partsToAssociate = value; } }

        // Variable to track total
        private double partsTotal = 0;

        // Initialize Form
        public ModifyProductForm()
        {
            InitializeComponent();
            // Format both DataGridViews
            MainForm.formatDataGridView(modifyProductPartsDataGridView);
            MainForm.formatDataGridView(modifyProductAssociatedPartsDataGridView);
            // Populate TextBoxes with current data
            populateTextBoxes();
            // Insert pre-existing associated parts to partsAssociated list
            populatePartsAssociated();
            // Populate DataGridViews with data
            displayDataGridViews();
        }

        // Obtain data from selected Product and set TextBoxes to display the data
        private void populateTextBoxes()
        {
            modifyProductIDTextBox.Text = MainForm.selectedProduct.getProductID().ToString();
            modifyProductNameTextBox.Text = MainForm.selectedProduct.getName();
            modifyProductInvTextBox.Text = MainForm.selectedProduct.getInStock().ToString();
            modifyProductPriceTextBox.Text = MainForm.selectedProduct.getPrice().ToString();
            modifyProductMaxTextBox.Text = MainForm.selectedProduct.getMax().ToString();
            modifyProductMinTextBox.Text = MainForm.selectedProduct.getMin().ToString();
        }

        // Populate partsAssociated list with previously associated parts
        private void populatePartsAssociated()
        {
            // Loop through the selected Products list of associated parts
            for (int i = 0; i < MainForm.selectedProduct.getAssociatedPartCount(); i++)
            {
                // Add each part to partsAssociated list to add to new product when saved
                partsAssociated.Add(MainForm.selectedProduct.getAssociatedPart(i));
            }
        }

        // Populate DataGridViews with data
        private void displayDataGridViews()
        {
            // Clear previously displayed parts
            modifyProductPartsDataGridView.Rows.Clear();
            modifyProductPartsDataGridView.Refresh();
            // Loop through all parts and populate rows with data
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                modifyProductPartsDataGridView.Rows.Add();
                modifyProductPartsDataGridView.Rows[i].Cells[0].Value = Inventory.AllParts[i].getPartID();
                modifyProductPartsDataGridView.Rows[i].Cells[1].Value = Inventory.AllParts[i].getName();
                modifyProductPartsDataGridView.Rows[i].Cells[2].Value = Inventory.AllParts[i].getInStock();
                modifyProductPartsDataGridView.Rows[i].Cells[3].Value = Inventory.AllParts[i].getPrice();
            }
            // Format price column to currency
            modifyProductPartsDataGridView.Columns[3].DefaultCellStyle.Format = "c";
            modifyProductPartsDataGridView.ClearSelection();

            // Clear previously associated parts
            modifyProductAssociatedPartsDataGridView.Rows.Clear();
            modifyProductAssociatedPartsDataGridView.Refresh();
            // Loop through temporary list of parts to associate
            for (int i = 0; i < partsAssociated.Count; i++)
            {
                // Display data in appropriate cells
                modifyProductAssociatedPartsDataGridView.Rows.Add();
                modifyProductAssociatedPartsDataGridView.Rows[i].Cells[0].Value = partsAssociated[i].getPartID();
                modifyProductAssociatedPartsDataGridView.Rows[i].Cells[1].Value = partsAssociated[i].getName();
                modifyProductAssociatedPartsDataGridView.Rows[i].Cells[2].Value = partsAssociated[i].getInStock();
                modifyProductAssociatedPartsDataGridView.Rows[i].Cells[3].Value = partsAssociated[i].getPrice();
            }
            // Format price column as currency
            modifyProductAssociatedPartsDataGridView.Columns[3].DefaultCellStyle.Format = "c";
            modifyProductAssociatedPartsDataGridView.ClearSelection();
        }

        // Modify Product Cancel click
        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            // Clear any parts added to temporary list of parts to associate
            partsAssociated.Clear();
            // Close form
            ModifyProductForm.ActiveForm.Close();
        }

        // Modify Product Add Part click
        private void modifyProductAddButton_Click(object sender, EventArgs e)
        {
            // Ensure that a part is selected
            if (MainForm.partIndex >= 0)
            {
                // Loop through currently associated products
                for (int i = 0; i < partsAssociated.Count; i++)
                {
                    // If an ID match is found, display dialogue and cancel addition of part
                    if (partsAssociated[i].getPartID() == MainForm.selectedPart.getPartID())
                    {
                        MessageBox.Show("Unable to add Part. It is already associated with this product.");
                        return;
                    }
                }
                // If no match is found, add part to temporary list of parts to associate
                partsAssociated.Add(Inventory.AllParts[MainForm.partIndex]);
                // Redisplay DataGridView data
                displayDataGridViews();
                // Reset partIndex
                MainForm.partIndex = -1;
            }
            // If no part selected, display dialogue and cancel click
            else
            {
                MessageBox.Show("Please select a part and try again.");
                return;
            }
        }

        // Parts DataGridView Click
        private void modifyProductPartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set index to selected Row's index
            MainForm.partIndex = modifyProductPartsDataGridView.CurrentCell.RowIndex;
            // Obtain part by looking up based on ID returned by row
            MainForm.selectedPart = Inventory.LookupPart((int)modifyProductPartsDataGridView.Rows[MainForm.partIndex].Cells[0].Value);
        }

        // Delete Part click
        private void modifyProductDeleteButton_Click(object sender, EventArgs e)
        {
            // Ensure index is a valid selection in DataGridView
            if (MainForm.partIndex >= 0)
            {
                // Loop through previously associated parts
                for (int i = 0; i < partsAssociated.Count; i++)
                {
                    // If ID match is found, remove association
                    if (partsAssociated[i].getPartID() == (int)modifyProductAssociatedPartsDataGridView.Rows[MainForm.partIndex].Cells[0].Value)
                    {
                        Console.WriteLine("Attempting to remove part with ID " + $"{(int)modifyProductAssociatedPartsDataGridView.Rows[MainForm.partIndex].Cells[0].Value}" + " from Associated Parts.");
                        partsAssociated.Remove(partsAssociated[i]);
                    }
                } 
                // Refresh DataGridView Data
                displayDataGridViews();
                // Reset partIndex
                MainForm.partIndex = -1;
            }
            // If no selected part, display dialogue and return
            else
            {
                MessageBox.Show("Please select a part from the associated parts and try again");
                return;
            }
        }

        // Associated Parts DataGridView Click
        private void modifyProductAssociatedPartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set partIndex to clicked row index
            MainForm.partIndex = modifyProductAssociatedPartsDataGridView.CurrentCell.RowIndex;
            // Loop through previosly associated parts
            for (int i = 0; i < partsAssociated.Count; i++)
            {
                // If ID match, set selected part to clicked part
                if ((int)modifyProductAssociatedPartsDataGridView.Rows[MainForm.partIndex].Cells[0].Value == partsAssociated[i].getPartID())
                {
                    MainForm.selectedPart = partsAssociated[i];
                }
            }
        }

        // Search Button click
        private void modifyProductSearchButton_Click(object sender, EventArgs e)
        {
            // Obtain input from user
            int searchID = int.Parse(modifyProductSearchTextBox.Text);
            // Clear textbox
            modifyProductSearchTextBox.Clear();
            // Loop through DataGridView data
            foreach (DataGridViewRow row in modifyProductPartsDataGridView.Rows)
            {
                // If value of Part ID matches ID provided by user
                if ((int)row.Cells[0].Value == searchID)
                {
                    // Select row, set index to RowIndex, and lookup part and set as selectedPart
                    row.Selected = true;
                    MainForm.partIndex = row.Cells[0].RowIndex;
                    MainForm.selectedPart = Inventory.LookupPart((int)modifyProductPartsDataGridView.Rows[MainForm.partIndex].Cells[0].Value);
                    return;
                }
            }
            // If no match found, display dialogue
            MessageBox.Show("No Part with matching Part ID found. Please try again.");
        }

        // Save button click
        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Bool to enable/disable save ability
                bool saveEnabled = true;

                // Loop through all controls on form
                foreach (Control control in this.Controls)
                {
                    // If a control's BackColor is Salmon, disable save and display Dialogue
                    if (control.BackColor == Color.Salmon)
                    {
                        saveEnabled = false;
                        MessageBox.Show("Please ensure all inputs are valid and try again.");
                        return;
                    }
                }
                
                // Ensure Min is less than Max, if not, disable save and display dialogue
                if (int.Parse(modifyProductMaxTextBox.Text) < int.Parse(modifyProductMinTextBox.Text))
                {
                    saveEnabled = false;
                    MessageBox.Show("The Maximum inventory must be greater than the Minimum inventory.");
                }
                
                // If previous tests pass, continue with save
                if (saveEnabled == true)
                {
                    // Create new Product object
                    Product modifiedProduct = new Product(
                       int.Parse(modifyProductIDTextBox.Text),
                       modifyProductNameTextBox.Text,
                       int.Parse(modifyProductInvTextBox.Text),
                       double.Parse(modifyProductPriceTextBox.Text),
                       int.Parse(modifyProductMaxTextBox.Text),
                       int.Parse(modifyProductMinTextBox.Text)
                       );

                    // Loop through partsAssociated list and add to the new product's associated parts
                    for (int i = 0; i < partsAssociated.Count; i++)
                    {
                        modifiedProduct.addAssociatedPart(partsAssociated[i]);
                    }

                    // Loop through DataGridView rows and add up Price column to obtain total for parts
                    foreach (DataGridViewRow row in modifyProductAssociatedPartsDataGridView.Rows)
                    {
                        partsTotal += (double)row.Cells[3].Value;
                    }
                    
                    // Check that the total cost of parts is not greater than the price of the product
                    if (partsTotal > modifiedProduct.getPrice())
                    {
                        MessageBox.Show("The total cost of parts for this product is greater than the price of the product itself. Please increase price or remove parts.");
                        partsTotal = 0;
                        return;
                    }
                    // Replace old product with updated product
                    Inventory.updateProduct(MainForm.selectedProductIndex, modifiedProduct);
                    // Update selectedProduct to reflect changes -- If user clicks modify again without selecting a different product
                    MainForm.selectedProduct = modifiedProduct;
                    // Reset productIndex
                    MainForm.productIndex = -1;
                    // Remove all parts in temporary partsAssociated list
                    partsAssociated.Clear();
                    // Close form
                    this.Close();
                }
            }
            // If invalid input provided, display dialogue and cancel
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please try again.");
                return;
            }
            // If too large of an input is provided, display dialogue and cancel
            catch (OverflowException)
            {
                MessageBox.Show("Input overflow. Please lower input and try again.");
                return;
            }
        }

        // Input validations when typing in TextBoxes
        private void modifyProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.stringInputValidation(modifyProductNameTextBox);
        }

        private void modifyProductInvTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.intInputValidation(modifyProductInvTextBox);
        }

        private void modifyProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.doubleInputValidation(modifyProductPriceTextBox);
        }

        private void modifyProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.intInputValidation(modifyProductMaxTextBox);
        }

        private void modifyProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.intInputValidation(modifyProductMinTextBox);
        }
    }
}
