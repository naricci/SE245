using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_MidtermExam
{
    public partial class frmOrderForm : Form
    {
        public frmOrderForm()
        {
            InitializeComponent();
        }

        // Variables
        double pizzaPrice, toppingPrice;
        string pizzaSize, pizzaTopping;

        private void chkMeatball_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " Meatball";
            pizzaPrice += 0.50;
        }

        private void chkHam_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " Ham";
            pizzaPrice += 0.50;
        }

        private void frmOrderForm_Load(object sender, EventArgs e)
        {
            // Populate ComboBoxes
            cmbCity.Items.Add("East Greenwich");
            cmbCity.Items.Add("Warwick");
            cmbCity.Items.Add("West Warwick");
            cmbState.Items.Add("CT");
            cmbState.Items.Add("MA");
            cmbState.Items.Add("ME");
            cmbState.Items.Add("NH");
            cmbState.Items.Add("RI");
            cmbState.Items.Add("VT");

            // Set ComboBox defaults
            cmbCity.SelectedIndex = 0;
            cmbState.SelectedIndex = 4;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Check if First Name is filled in
            if (!ValidationLibrary.IsItFilledIn(txtFirstName.Text))
            {
                isValid = false;
                lboxOrder.Items.Add("Please enter a First Name.\n");
            }
            
            // Check if Last Name is filled in
            if (!ValidationLibrary.IsItFilledIn(txtLastName.Text))
            {
                isValid = false;
                lboxOrder.Items.Add("Please enter a Last Name.\n");
            }

            // Check if Email Address is Valid
            if (!ValidationLibrary.IsValidEmail(txtEmail.Text))
            {
                isValid = false;
                lboxOrder.Items.Add("Please enter a valid Email Address.\n");
            }

            // Check if Phone Number is Valid
            if (!ValidationLibrary.IsValidPhoneNumber(txtPhone.Text))
            {
                isValid = false;
                lboxOrder.Items.Add("Please enter a valid Phone Number.\n");
            }

            if (isValid) //Adds Everything together
            {
                // Display Total Cost of Pizza in Label
                lblTotalCost.Text += (pizzaPrice + toppingPrice).ToString("c");

                // Display Order info in ListBox
                lboxOrder.Items.Add("Your Order:");
                lboxOrder.Items.Add(pizzaSize + " Pizza with" + pizzaTopping);
                lboxOrder.Items.Add("Delivery Info:");
                lboxOrder.Items.Add(txtFirstName.Text + " " + txtLastName.Text);
                lboxOrder.Items.Add(txtStreet1.Text + txtStreet2.Text);
                lboxOrder.Items.Add(cmbCity.Text + ", " + cmbState.Text);
            }
        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " Peppers";
            toppingPrice += 0.50;
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " Onions";
            toppingPrice += 0.50;
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " Olives";
            toppingPrice += 0.50;
        }

        private void chkSpinach_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " Spinach";
            toppingPrice += 0.50;
        }

        private void chkPineapple_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " Pineapple";
            toppingPrice += 0.50;
        }

        private void chkBBQ_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " BBQ Sauce";
            toppingPrice += 0.50;
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " Extra Cheese";
            toppingPrice += 0.50;
        }

        private void chkSpit_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " Spit";
            toppingPrice += 0.50;
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            lblTotalCost.Text = "Total Cost:  ";
            lboxOrder.Items.Clear();

            // Reset variable values
            pizzaPrice = 0;
            toppingPrice = 0;
            pizzaTopping = "";

            // Clear Radio Buttons (Pizza Size)
            foreach (Control c in gboxPizzaSizes.Controls)
            {
                if (c is RadioButton)                   // If Control true, then...
                    ((RadioButton)c).Checked = false;   // Uncheck RadioButton
            }

            // Clear Checkboxes (Pizza Toppings)        
            foreach (Control c in gboxPizzaToppings.Controls)
            {
                if (c is CheckBox)                      // If Control true, then...
                    ((CheckBox)c).Checked = false;      // Uncheck All Checkboxes
            }
            /*
            // Clear Checkboxes (Pizza Toppings)        
            foreach (Control c in gboxDeliveryInfo.Controls)
            {
                if (c is TextBox)                      // If Control true, then...
                    ((TextBox)c).Checked = false;      // Uncheck All Checkboxes
            }
            */
            // Clear City/State Drop-Downs Back to Default
            cmbCity.SelectedIndex = 0;
            cmbState.SelectedIndex = 4;
        }

        private void chkSausage_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " Sausage";
            toppingPrice += 0.50;
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping += " Pepperoni";
            toppingPrice += 0.50;
        }

        private void radLargePizza_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = 12;
            pizzaSize = "Large";
        }

        private void radMediumPizza_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = 10;
            pizzaSize = "Medium";
        }

        private void radSmallPizza_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = 7;
            pizzaSize = "Small";
        }
    }
}
