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
    public partial class ModifyPartForm : Form
    {
        // Bool to determine if selected part is Inhouse or not
        private bool isInhousePart;

        // Initialize form and check the type of Part to be modified
        public ModifyPartForm()
        {
            InitializeComponent();
            checkClass();
        }

        // Checks what type of Part is selected
        private void checkClass()
        {
            // Check if selectedPart is Inhouse or Outsourced
            if (MainForm.selectedPart is Inhouse)
            {
                // Set Inhouse to checked
                modifyPartInHouseRadioButton.Checked = true;
                modifyPartInHousePanel.Visible = true;
                // Ensure proper conversion
                Inhouse part = (Inhouse)MainForm.selectedPart;
                // Populate TextBoxes with current values
                modifyPartIDTextBox.Text = part.getPartID().ToString();
                modifyPartNameTextBox.Text = part.getName();
                modifyPartInvTextBox.Text = part.getInStock().ToString();
                modifyPartPriceTextBox.Text = part.getPrice().ToString();
                modifyPartMaxTextBox.Text = part.getMax().ToString();
                modifyPartMinTextBox.Text = part.getMin().ToString();
                modifyPartMachineIDTextBox.Text = part.getMachineID().ToString();
            }
            else if (MainForm.selectedPart is Outsourced)
            {
                // Set Outsourced to checked
                modifyPartOutsourcedRadioButton.Checked = true;
                // Ensure proper conversion
                Outsourced part = (Outsourced)MainForm.selectedPart;
                // Populate TextBoxes with current values
                modifyPartIDTextBox.Text = part.getPartID().ToString();
                modifyPartNameTextBox.Text = part.getName();
                modifyPartInvTextBox.Text = part.getInStock().ToString();
                modifyPartPriceTextBox.Text = part.getPrice().ToString();
                modifyPartMaxTextBox.Text = part.getMax().ToString();
                modifyPartMinTextBox.Text = part.getMin().ToString();
                modifyPartCompanyNameTextBox.Text = part.getCompanyName();
            }
            // If unable to determine type, display dialogue and close form
            else
            {
                MessageBox.Show("Unable to determine Part Type");
                this.Hide();
            }

        }

        // If Inhouse is checked after opening form, set isInHousePart to true for conversion
        private void modifyPartInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == modifyPartInHouseRadioButton)
            {
                modifyPartOutsourcedPanel.Visible = false;
                modifyPartInHousePanel.Visible = true;
                isInhousePart = true;
            }
        }

        // If Outsourced is checked after opening form, set isInHousePart to false for conversion
        private void modifyPartOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == modifyPartOutsourcedRadioButton)
            {
                modifyPartOutsourcedPanel.Location = modifyPartInHousePanel.Location;
                modifyPartInHousePanel.Visible = false;
                modifyPartOutsourcedPanel.Visible = true;
                isInhousePart = false;
            }
        }

        // Modify Part Cancel click
        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            // Close form
            ModifyPartForm.ActiveForm.Close();
        }

        // Modify Part Save click
        private void modifyPartSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Bool to enable/disable save ability
                bool saveEnabled = true;
                
                // Loop through all controls on form
                foreach (Control control in this.Controls)
                {
                    // If a control has BackColor of Salmon, disable save and display dialogue
                    if (control.BackColor == Color.Salmon)
                    {
                        saveEnabled = false;
                        MessageBox.Show("Please ensure all inputs are valid and try again.");
                        return;
                    }
                }

                // If Min is greater than Max, disable save and display dialogue
                if (int.Parse(modifyPartMaxTextBox.Text) < int.Parse(modifyPartMinTextBox.Text))
                {
                    saveEnabled = false;
                    MessageBox.Show("The Maximum inventory must be greater than the Minimum inventory.");
                }

                // If earlier tests are passed, continue with save
                if (saveEnabled == true)
                {
                    // Check if part is Inhouse or Outsourced
                    if (isInhousePart)
                    {
                        // Create new Inhouse object
                        Inhouse modifiedPart = new Inhouse(
                            int.Parse(modifyPartIDTextBox.Text),
                            modifyPartNameTextBox.Text,
                            int.Parse(modifyPartInvTextBox.Text),
                            double.Parse(modifyPartPriceTextBox.Text),
                            int.Parse(modifyPartMaxTextBox.Text),
                            int.Parse(modifyPartMinTextBox.Text),
                            int.Parse(modifyPartMachineIDTextBox.Text)
                            );
                        // Replace old part with new part
                        Inventory.updatePart(MainForm.selectedPartIndex, modifiedPart);
                        // Set selected part to reflect changes
                        MainForm.selectedPart = modifiedPart;
                        // Close form
                        this.Close();
                    }
                    // If part is Outsourced
                    else if (!isInhousePart)
                    {
                        // Create new Outsourced object
                        Outsourced modifiedPart = new Outsourced(
                            int.Parse(modifyPartIDTextBox.Text),
                            modifyPartNameTextBox.Text,
                            int.Parse(modifyPartInvTextBox.Text),
                            double.Parse(modifyPartPriceTextBox.Text),
                            int.Parse(modifyPartMaxTextBox.Text),
                            int.Parse(modifyPartMinTextBox.Text),
                            modifyPartCompanyNameTextBox.Text
                            );
                        // Replace old part with new part
                        Inventory.updatePart(MainForm.selectedPartIndex, modifiedPart);
                        // Set selectedPart to reflect changes
                        MainForm.selectedPart = modifiedPart;
                        // Close form
                        this.Close();
                    }
                    // If unable to determine part type, display dialogue and return
                    else
                    {
                        MessageBox.Show("Unable to determine Part Type");
                        return;
                    }
                }
            }
            // If invalid input provided, display dialogue and cancel save
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please try again.");
                return;
            }
            // If input is too large, display dialogue and cancel save
            catch (OverflowException)
            {
                MessageBox.Show("Input overflow. Please lower input and try again.");
                return;
            }
        }

        // Input validations when typing in TextBoxes
        private void modifyPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.stringInputValidation(modifyPartNameTextBox);
        }

        private void modifyPartInvTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.intInputValidation(modifyPartInvTextBox);
        }

        private void modifyPartPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.doubleInputValidation(modifyPartPriceTextBox);
        }

        private void modifyPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.intInputValidation(modifyPartMaxTextBox);
        }

        private void modifyPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.intInputValidation(modifyPartMinTextBox);
        }

        private void modifyPartMachineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.intInputValidation(modifyPartMachineIDTextBox);
        }

        private void modifyPartCompanyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            AddPartForm.stringInputValidation(modifyPartCompanyNameTextBox);
        }
    }
}
