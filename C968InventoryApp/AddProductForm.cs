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
    public partial class AddProductForm : Form
    {
        // Variable to store parts total
        private double partsTotal = 0;

        // Temporary parts list for storing parts to add before committing
        private static BindingList<Part> partsToAssociate = new BindingList<Part>();
        public static BindingList<Part> partsAssociated { get { return partsToAssociate; } set { partsToAssociate = value; } }

        // Initialize form, format DataGridViews, display Parts
        public AddProductForm()
        {
            InitializeComponent();
            MainForm.formatDataGridView(addProductPartsDataGridView);
            MainForm.formatDataGridView(addProductAssociatedPartsDataGridView);
            displayDataGridViews();
        }

        // Cancel click
        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            // Clear temporary associated parts, not needed if cancelling
            partsAssociated.Clear();
            AddProductForm.ActiveForm.Close();
        }

        // Display parts
        private void displayDataGridViews()
        {
            // Clear previous info in DataGridViews
            addProductPartsDataGridView.Rows.Clear();
            addProductPartsDataGridView.Refresh();
            // Loop through AllParts List and display data
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                addProductPartsDataGridView.Rows.Add();
                addProductPartsDataGridView.Rows[i].Cells[0].Value = Inventory.AllParts[i].getPartID();
                addProductPartsDataGridView.Rows[i].Cells[1].Value = Inventory.AllParts[i].getName();
                addProductPartsDataGridView.Rows[i].Cells[2].Value = Inventory.AllParts[i].getInStock();
                addProductPartsDataGridView.Rows[i].Cells[3].Value = Inventory.AllParts[i].getPrice();
            }
            // Format Price column to Currency
            addProductPartsDataGridView.Columns[3].DefaultCellStyle.Format = "c";
            // Ensure that selections are cleared
            addProductPartsDataGridView.ClearSelection();

            // Clear previous associated parts
            addProductAssociatedPartsDataGridView.Rows.Clear();
            addProductAssociatedPartsDataGridView.Refresh();
            // Loop through temporary parts lists and display parts that have been added
            for (int i = 0; i < partsAssociated.Count; i++)
            {
                addProductAssociatedPartsDataGridView.Rows.Add();
                addProductAssociatedPartsDataGridView.Rows[i].Cells[0].Value = partsAssociated[i].getPartID();
                addProductAssociatedPartsDataGridView.Rows[i].Cells[1].Value = partsAssociated[i].getName();
                addProductAssociatedPartsDataGridView.Rows[i].Cells[2].Value = partsAssociated[i].getInStock();
                addProductAssociatedPartsDataGridView.Rows[i].Cells[3].Value = partsAssociated[i].getPrice();
            }
            // Format Price column to currency
            addProductAssociatedPartsDataGridView.Columns[3].DefaultCellStyle.Format = "c";
            addProductAssociatedPartsDataGridView.ClearSelection();
        }

        // Add button click
        private void addProductAddButton_Click(object sender, EventArgs e)
        {
            // Ensure that a part is selected
            if(MainForm.partIndex >= 0)
            {
                // Loop through temporary partsAssociated list
                for (int i = 0; i < partsAssociated.Count; i++)
                {
                    // If selected part's ID matcheds a partID in the temporary list, display dialogue and cancel
                    if (partsAssociated[i].getPartID() == MainForm.selectedPart.getPartID())
                    {
                        MessageBox.Show("Unable to add Part. It is already associated with this product.");
                        return;
                    }
                }
                // If no matching ID's found in temporary list, add part to list
                partsAssociated.Add(Inventory.AllParts[MainForm.partIndex]);
                // Refresh DataGridView to reflect changes
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

        // Click in DataGridView
        private void addProductPartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set selected part based on RowIndex clicked and lookupPart function
            MainForm.partIndex = addProductPartsDataGridView.CurrentCell.RowIndex;
            MainForm.selectedPart = Inventory.LookupPart((int)addProductPartsDataGridView.Rows[MainForm.partIndex].Cells[0].Value);
        }

        // Delete button click
        private void addProductDeleteButton_Click(object sender, EventArgs e)
        {
            // Ensure a part is selected
            if (MainForm.partIndex >= 0)
            {
                // Loop through temporary partsAssociated list
                for (int i = 0; i < partsAssociated.Count; i++)
                {
                    // TODO Fix check
                    // If an ID in the DataGridView displaying associated parts matches ID of selected part, remove part
                    if (partsAssociated[i].getPartID() == (int)addProductAssociatedPartsDataGridView.Rows[MainForm.partIndex].Cells[0].Value)
                    {
                        Console.WriteLine("Attempting to remove part with ID " + $"{(int)addProductAssociatedPartsDataGridView.Rows[MainForm.partIndex].Cells[0].Value}" + " from Associated Parts.");
                        partsAssociated.Remove(partsAssociated[i]);
                    }
                }
                // Refresh DataGridViews
                displayDataGridViews();
                // Reset partIndex
                MainForm.partIndex = -1;
            }
            // If no part is selected, display dialogue and cancel click
            else
            {
                MessageBox.Show("Please select a part from the associated parts and try again");
                return;
            }
        }

        // Click in associatedParts DataGridView
        private void addProductAssociatedPartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set index to RowIndex of part clicked
            MainForm.partIndex = addProductAssociatedPartsDataGridView.CurrentCell.RowIndex;
            // Loop through temporary list of associated parts
            for (int i = 0; i < partsAssociated.Count; i++)
            {
                // If selected part ID matches an ID in the list, set that part as selectedPart
                if ((int)addProductAssociatedPartsDataGridView.Rows[MainForm.partIndex].Cells[0].Value == partsAssociated[i].getPartID())
                {
                    MainForm.selectedPart = partsAssociated[i];
                }
            }
        }

        // Search button click
        private void addProductSearchButton_Click(object sender, EventArgs e)
        {
            // Obtain ID entered in Search TextBox
            int searchID = int.Parse(addProductSearchTextBox.Text);
            // Clear input in TextBox
            addProductSearchTextBox.Clear();
            // Loop through rows in the DataGridView displaying all parts
            foreach (DataGridViewRow row in addProductPartsDataGridView.Rows)
            {
                // If ID of part in displayed in row matches ID entered, lookup part and set as selected part
                if ((int)row.Cells[0].Value == searchID)
                {
                    row.Selected = true;
                    MainForm.partIndex = row.Cells[0].RowIndex;
                    MainForm.selectedPart = Inventory.LookupPart((int)addProductPartsDataGridView.Rows[MainForm.partIndex].Cells[0].Value);
                    return;
                }
            }
            // If no matching ID found, display dialogue
            MessageBox.Show("No Part with matching Part ID found. Please try again.");
        }

        // Save button click
        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Bool variable to enable/disable Save ability
                bool saveEnabled = true;

                // Loop through controls on form
                foreach (Control control in this.Controls)
                {
                    // Check if any controls are Salmon color, if so, disable Save and display MessageBox
                    if (control.BackColor == Color.Salmon)
                    {
                        saveEnabled = false;
                        MessageBox.Show("Please ensure all inputs are valid and try again.");
                        return;
                    }
                }

                // Ensure that Min is less than Max, disable save and display dialogue if not
                if (int.Parse(addProductMaxTextBox.Text) < int.Parse(addProductMinTextBox.Text))
                {
                    saveEnabled = false;
                    MessageBox.Show("The Maximum inventory must be greater than the Minimum inventory.");
                }

                // Ensure that earlier checks passed
                if (saveEnabled == true)
                {
                    // Create new Product instance with values provided by user
                    Product newProduct = new Product(
                       (Inventory.productsCount + 1),
                       addProductNameTextBox.Text,
                       int.Parse(addProductInvTextBox.Text),
                       double.Parse(addProductPriceTextBox.Text),
                       int.Parse(addProductMaxTextBox.Text),
                       int.Parse(addProductMinTextBox.Text)
                       );
                    // Loop through partsAssociated list and add to new Product
                    for (int i = 0; i < partsAssociated.Count; i++)
                    {
                        newProduct.addAssociatedPart(partsAssociated[i]);
                        partsTotal += partsAssociated[i].getPrice();
                    }
                    // Check that the total cost of parts is not greater than the price of the product
                    if (partsTotal > newProduct.getPrice())
                    {
                        MessageBox.Show("The total cost of parts for this product is greater than the price of the product itself. Please increase price or remove parts.");
                        return;
                    }

                    // TODO Fix associatedProducts
                    // Add new product
                    Inventory.addProduct(newProduct);
                    Console.WriteLine("Added new product");
                    // Clear partsAssociated list for new addProductForm
                    partsAssociated.Clear();
                    // Close form
                    this.Close();
                }
            }
            // Display dialogue and cancel click if and invalid input is provided
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input. Please try again.");
                return;
            }
            // Display dialogue and cancel click if too large of an input is provided
            catch (OverflowException)
            {
                MessageBox.Show("Input overflow. Please lower input and try again.");
                return;
            }
        }

        // Input Validation when typing
        private void addProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.stringInputValidation(addProductNameTextBox);
        }

        private void addProductInvTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.intInputValidation(addProductInvTextBox);
        }

        private void addProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.doubleInputValidation(addProductPriceTextBox);
        }

        private void addProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.intInputValidation(addProductMaxTextBox);
        }

        private void addProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.intInputValidation(addProductMinTextBox);
        }
    }
}
