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
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void AddPartsForm_Load(object sender, EventArgs e)
        {
            // Show Machine ID by default
            addPartInHousePanel.Visible = true;
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            // Close form
            AddPartForm.ActiveForm.Close();
        }

        protected void addPartInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Remove Company Name from form and show Machine ID
            if (sender == addPartInHouseRadioButton)
            {
                addPartOutsourcedPanel.Visible = false;
                addPartInHousePanel.Visible = true;
            }
        }

        private void addPartOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Remove Machine ID from from and show Company Name
            if (sender == addPartOutsourcedRadioButton)
            {
                addPartInHousePanel.Visible = false;
                addPartOutsourcedPanel.Location = addPartInHousePanel.Location;
                addPartOutsourcedPanel.Visible = true;
            }
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Bool variable to enable/disable save ability
                bool saveEnabled = true;

                // Loop through controls on form
                foreach (Control control in this.Controls)
                {
                    // If controls color is Salmon, disable save and display dialogue
                    if (control.BackColor == Color.Salmon)
                    {
                        saveEnabled = false;
                        MessageBox.Show("Please ensure all inputs are valid and try again.");
                        return;
                    }
                }

                // Ensure that Min is less than Max, if not, disable save and display dialogue
                if (int.Parse(addPartMaxTextBox.Text) < int.Parse(addPartMinTextBox.Text))
                {
                    saveEnabled = false;
                    MessageBox.Show("The Maximum inventory must be greater than the Minimum inventory.");
                }

                // If inputs pass earlier test, proceed with save
                if (saveEnabled == true)
                {
                    // Submit new Part with TextBox inputs

                    // If Inhouse is checked, use this constructor
                    if (addPartInHouseRadioButton.Checked)
                    {
                        Part newInhousePart = new Inhouse(
                            (Inventory.partsCount + 1),
                            addPartNameTextBox.Text,
                            int.Parse(addPartInvTextBox.Text),
                            double.Parse(addPartPriceTextBox.Text),
                            int.Parse(addPartMaxTextBox.Text),
                            int.Parse(addPartMinTextBox.Text),
                            int.Parse(addPartMachineIDTextBox.Text)
                            );
                        Inventory.addPart(newInhousePart);
                        Console.WriteLine("Added new inhouse part");
                    }

                    // If Outsourced is checked, use this constructor
                    if (addPartOutsourcedRadioButton.Checked)
                    {
                        Part newOutsourcedPart = new Outsourced(
                            (Inventory.AllParts.Count + 1),
                            addPartNameTextBox.Text,
                            int.Parse(addPartInvTextBox.Text),
                            double.Parse(addPartPriceTextBox.Text),
                            int.Parse(addPartMaxTextBox.Text),
                            int.Parse(addPartMinTextBox.Text),
                            addPartCompanyNameTextBox.Text
                            );
                        Inventory.addPart(newOutsourcedPart);
                        Console.WriteLine("Added new outsourced part");
                    }
                    // Close form
                    this.Close();
                }
                else
                {
                    // Cancel save, input not valid
                    return;
                }
            }
            // Display dialogue and cancel save if invalid format in a textbox
            catch (FormatException)
            {
                MessageBox.Show("Invalid Format in input. Please try again.");
                return;
            }
            // Display dialogue and cancel save if input is too large
            catch (OverflowException)
            {
                MessageBox.Show("Input too large. Please lower input and try again.");
                return;
            }
        }

        // General function to validate string inputs
        public static void stringInputValidation(Control control)
        {
            // If nothing is in string, TextBox turns Salmon
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                control.BackColor = Color.Salmon;
            }
            // If something is entered, returns to white
            else
            {
                control.BackColor = SystemColors.Window;
            }
        }


        // General function to validate int inputs
        public static void intInputValidation(Control control)
        {
            // If unable to Parse to int or null/empty, turn background to Salmon
            if (!int.TryParse(control.Text, out int isValid))
            {
                control.BackColor = Color.Salmon;
            }
            // If valid int input is entered, return to white
            else
            {
                control.BackColor = SystemColors.Window;
            }
        }

        // General function to validate double inputs
        public static void doubleInputValidation(Control control)
        {
            // If unable to parse to double or null/empty, turn background Salmon
            if (!double.TryParse(control.Text, out double isValid))
            {
                control.BackColor = Color.Salmon;
            }
            // If valid double is entered, return to white
            else
            {
                control.BackColor = SystemColors.Window;
            }
        }
        
        // Input validatiosn when typing in TextBoxes
        private void addPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            stringInputValidation(addPartNameTextBox);
        }

        private void addPartInvTextBox_TextChanged(object sender, EventArgs e)
        {
            intInputValidation(addPartInvTextBox);
        }

        private void addPartPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            doubleInputValidation(addPartPriceTextBox);
        }

        private void addPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            intInputValidation(addPartMaxTextBox);
        }

        private void addPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            intInputValidation(addPartMinTextBox);
        }

        private void addPartMachineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            intInputValidation(addPartMachineIDTextBox);
        }

        private void addPartCompanyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            stringInputValidation(addPartCompanyNameTextBox);
        }
    }
}
