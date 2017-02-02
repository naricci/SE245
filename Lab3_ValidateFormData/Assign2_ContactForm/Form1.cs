﻿using System;
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

            // if/else statement for names validation go here
            /**
             *  else if (!Validators.IsItFilledIn(txtFirstName.Text) && !Validators.IsItFilledIn(txtLastName.Text))
             *  {
             *      isValid = false;
             *      lblFeedback.Text += "Error:  Please enter either a first or last name.\n";
             *  }
             * 
             */
           

            // State Validator
            if (cmbState.SelectedIndex == 0)
            {
                isValid = false;
                lblFeedback.Text += "Error:  Please select a state from the dropdown menu.\n";
            }

            // Zip Code Validation
            if (Validators.IsItFilledIn(txtZip.Text))
            {
                isValid = false;
                lblFeedback.Text += "Error:  Must enter a zip code.\n";
            }
            if (Validators.IsValidZip(txtZip.Text))
            {
                isValid = false;
                lblFeedback.Text += "Error:  Please enter a 5 digit zip code.\n";
            }
            

            // Email Validation
            if (!Validators.IsValidEmail(txtEmail.Text))
            {
                isValid = true;
                lblFeedback.Text += "Error:  Please enter a valid email address.\n";
            }
            
            // Home Phone Validator
            if (Validators.IsItFilledIn(txtHomePhone.Text))
            {
                if (!Validators.IsValidPhoneNumber(txtHomePhone.Text))
                {
                    isValid = false;
                    lblFeedback.Text += "Error:  Please enter a valid home phone number.\n";
                }
            }

            // Work Phone Validator
            if (Validators.IsItFilledIn(txtWorkPhone.Text))
            {
                if (!Validators.IsValidPhoneNumber(txtWorkPhone.Text) == false)
                {
                    isValid = false;
                    lblFeedback.Text += "Error:  Please enter a valid work phone number.\n";
                }
            }

            // Cell Phone Validator
            if (Validators.IsItFilledIn(txtCellPhone.Text))
            {
                if (!Validators.IsValidPhoneNumber(txtCellPhone.Text) == false)
                {
                    isValid = false;
                    lblFeedback.Text += "Error:  Please enter a valid cell phone number.\n";
                }
            }

            /** Relationship Validator
             *  if (cmbRelationship.SelectedIndex == 0)
             *  {
             *      isValid = false;
             *      lblFeedback.Text += "Error: Please select a relationship from the dropdown menu.\n";
             *  } 
             */


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
                lboxContacts.Items.Add(txtCity.Text + ", " + cmbState.SelectedItem.ToString() + ", " + txtZip.Text);
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

            // Clear the Feedback Label
            lblFeedback.Text = "";
        }
    }
}
