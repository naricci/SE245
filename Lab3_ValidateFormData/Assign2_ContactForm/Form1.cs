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
        string salutation;
        
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
                // Check to see which Radio Button is selected
                if (radMr.Checked)
                {
                    salutation = radMr.Text;
                }
                else if (radMrs.Checked)
                {
                    salutation = radMrs.Text;
                }
                else
                {
                    salutation = radMs.Text;
                }
               
                // Loop through the list and add the list to the listbox on the form
                lboxContacts.Items.Add(salutation + " " + txtFirstName.Text + " " + txtLastName.Text);
                lboxContacts.Items.Add(txtStreet1.Text + " " + txtStreet2.Text);
                lboxContacts.Items.Add(txtCity.Text + ", " + cmbState.SelectedItem.ToString());
                lboxContacts.Items.Add(txtEmail.Text);
                lboxContacts.Items.Add(txtHomePhone.Text);
                lboxContacts.Items.Add(txtWorkPhone.Text);
                lboxContacts.Items.Add(txtCellPhone.Text);
                lboxContacts.Items.Add(dtpBirthday.Value);
                lboxContacts.Items.Add(dtpAnniversary.Value);
                lboxContacts.Items.Add(chkCardWorthy.Text.ToString());
                lboxContacts.Items.Add(cmbRelationship.SelectedItem.ToString());
                lboxContacts.Items.Add(txtNotes.Text);

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
            
            // Loop to clear data from the form
            foreach (var c in this.Controls)
            {
                // Clear the TextBoxes
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                // Clear the DTPs
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Text = String.Empty;
                }
                // Clear the Checkboxes
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }

            // Clear the Comboboxes
            cmbState.SelectedIndex = 0;
            cmbRelationship.SelectedIndex = 0;

            // Clear all the items from the listbox
            lboxContacts.Items.Clear();
        }
    }
}
