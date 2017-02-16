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
            // Populate State combobox with items
            cmbState.Items.Add("Pick a State...");
            cmbState.Items.Add("CT");
            cmbState.Items.Add("MA");
            cmbState.Items.Add("ME");
            cmbState.Items.Add("NH");
            cmbState.Items.Add("NY");
            cmbState.Items.Add("CT");
            cmbState.Items.Add("RI");
            cmbState.Items.Add("VT");

            // Populate Relationship combobox with items
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
            // Make sure the feedback/output labels is cleared from any previous attempts
            lblFeedback.Text = "Feedback";
            lblOutput.Text = "Contact";

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

                /* Loop through the list and add the list to the listbox on the form
                lboxContacts.Items.Add(salutation + " " + txtFirstName.Text + " " + txtLastName.Text);
                lboxContacts.Items.Add(txtStreet1.Text + " " + txtStreet2.Text);
                lboxContacts.Items.Add(txtCity.Text + ", " + cmbState.SelectedItem.ToString() + ", " + txtZip.Text);
                lboxContacts.Items.Add(txtEmail.Text);
                lboxContacts.Items.Add(txtHomePhone.Text);
                lboxContacts.Items.Add(txtWorkPhone.Text);
                lboxContacts.Items.Add(txtCellPhone.Text);
                lboxContacts.Items.Add(dtpBirthday.Value);
                lboxContacts.Items.Add(dtpAnniversary.Value);
                lboxContacts.Items.Add(chkCardWorthy.Text.ToString());
                lboxContacts.Items.Add(cmbRelationship.SelectedItem.ToString());
                

                DateTime dtBDay = new DateTime();
                // dtBDay = Convert.ToDateTime(dtpBirthday.Text);
                dtBDay = dtpBirthday.Value;
                 */
                // lblFeedback.Text = dtBDay.ToShortDateString();
            }

            /**************************** FORM VALIDATION ********************************/

            // First Name Validation
            if (!Validators.IsItFilledIn(txtFirstName.Text))
            {
                isValid = false;
                lblFeedback.Text += "Error:  Please enter a first name.\n";
            }

            // Last Name Validation 
            if (!Validators.IsItFilledIn(txtLastName.Text))
            {
                isValid = false;
                lblFeedback.Text += "Error:  Please enter a last name.\n";
            }  

            // State Validator
            if (cmbState.SelectedIndex == 0)
            {
                isValid = false;
                lblFeedback.Text += "Error:  Please select a state from the dropdown menu.\n";
            }

            // Zip Code Validation
            if (!Validators.IsValidZip(txtZip.Text))
            {
                isValid = true;
                lblFeedback.Text += "Error:  Must enter a valid zip code.\n";
            }

            // Email Validation
            if (!Validators.IsValidEmail(txtEmail.Text))
            {
                isValid = true;
                lblFeedback.Text += "Error:  Please enter a valid email address.\n";
            }

            // Home Phone Validator
            if (!Validators.IsValidPhoneNumber(txtHomePhone.Text))
            {
                isValid = false;
                lblFeedback.Text += "Error:  Please enter a valid home phone number.\n";
            }

            // Work Phone Validator
            if (!Validators.IsValidPhoneNumber(txtWorkPhone.Text))
            {
                isValid = false;
                lblFeedback.Text += "Error:  Please enter a valid work phone number.\n";
            }

            // Cell Phone Validator
            if (!Validators.IsValidPhoneNumber(txtCellPhone.Text))
            {
                isValid = false;
                lblFeedback.Text += "Error:  Please enter a valid cell phone number.\n";
            }

            // Set values for both Checkbox States
            if (chkCardWorthy.Checked)
            {
                chkCardWorthy.Text = "Card Worthy";
            }
            else
            {
                chkCardWorthy.Text = "Not Card Worthy";
            }

            /************************* Open/Append Data to File *************************/

            // create a string to gather the data
            string contactRecord;

            // Start storing contact info
            contactRecord = DateTime.Now.ToShortDateString() + "," + txtFirstName.Text + "," + txtLastName.Text + "," + txtStreet1.Text + "," + txtStreet2.Text + "," + txtCity.Text + "," + cmbState.Text.ToString() + "," + txtZip.Text + "," + txtEmail.Text + "," + txtHomePhone.Text + "," + txtWorkPhone.Text + "," + txtCellPhone.Text + "," + dtpBirthday.Text.ToString() + "," + dtpAnniversary.Text.ToString() + "," + chkCardWorthy.Text.ToString() + "," + cmbRelationship.Text.ToString();

            // Display Successful Storage Message
            lblOutput.Text = "Contact Stored Successfully";
            // Display Contact Name in Output/Feedback Label
            // lblOutput.Text = DateTime.Now.ToShortDateString() + " " + txtFirstName.Text + " " + txtLastName.Text;

            // Display Contact Info in Output Textbox
            // lboxContacts.Items.Add(contactRecord);

            FileIO.writeFile(@"Contacts.csv", contactRecord);
        } 

        private void btnClear_Click(object sender, EventArgs e)
        {
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

            // Reset Feedback/Output Labels
            lblFeedback.Text = "Feedback";
            lblOutput.Text = "Contact";

            // Clear the Comboboxes
            cmbState.SelectedIndex = 0;
            cmbRelationship.SelectedIndex = 0;

            // Clear all the items from the listbox
            lboxContacts.Items.Clear();
        }

        private void btnReadWholeFile_Click(object sender, EventArgs e)
        {
            // Create string to hold data/feedback
            string strData = "";

            // Grab data from the file
            strData = FileIO.readFile(@"Contacts.csv");

            // If any error occurs...display in Label
            if (strData.Contains("ERROR:"))
            {
                lblFeedback.Text = strData;
            }
            else // else...display in Listbox
            {
                
            }
        }
    }
}
