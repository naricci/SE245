using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign2_ContactForm
{
    public partial class frmContactForm : Form
    {
        public frmContactForm()
        {
            InitializeComponent();
        }

        private void frmContactForm_Load(object sender, EventArgs e)
        {
            // Populate combobox with items
            cmbRelationship.Items.Add("Choose Relationship");
            cmbRelationship.Items.Add("Spouse");
            cmbRelationship.Items.Add("Parent");
            cmbRelationship.Items.Add("Sibling");
            cmbRelationship.Items.Add("Friend");
            cmbRelationship.Items.Add("Co-worker");
            cmbRelationship.Items.Add("Arch Nemesis");

            // Set which combobox item to display as default 
            cmbRelationship.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Make sure the feedback label is cleared from any previous attempts
            lblFeedback.Text = "";

            bool isValid = true;

            if (isValid)
            {
                // Loop through the list and add the list to the listbox on the form

                lboxContacts.Items.Add(txtFirstName.Text + " " + txtLastName.Text + "(" + cmbState.SelectedItem.ToString() + ")");

                DateTime dtBDay = new DateTime();
                // dtBDay = Convert.ToDateTime(dtpBirthday.Text);
                dtBDay = dtpBirthday.Value;

                lblFeedback.Text = dtBDay.ToShortDateString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /**
             * Clear the textboxes individually
             *
             * txtFirstName.Text = "";
             * txtFirstName.Clear();       // Another way to clear 
             * txtLastName.Text = "";
             * txtStreet1.Text = "";
             * txtStreet2.Text = "";
             * txtCity.Text = "";
             * txtZip.Text = "";
             * txtEmail.Text = "";
             * txtHomePhone.Text = "";
             * txtWorkPhone.Text = "";
             * txtCellPhone.Text = "";
             * 
             */
            
            // Clear ALL the textboxes together
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }

            // Clear the comboboxes
            cmbState.SelectedIndex = 0;
            cmbRelationship.SelectedIndex = 0;

            // Clear the checkboxes
            chkCardWorthy.Checked = false;

            // Clear all the items from the listbox
            lboxContacts.Items.Clear();
        }
    }
}
