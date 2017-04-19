using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Assign2_ContactForm
{
    public partial class frmContactForm : Form
    {
        // Variables
        string salutation;          // String to hold Radio Button Value
        string contactRecord;

        // Create dynamic arrays called Lists
        List<string> mr = new List<string>(); // holds mr
        List<string> mrs = new List<string>(); // holds mrs
        List<string> ms = new List<string>(); // holds ms
        List<string> fname = new List<string>(); // holds first name 
        List<string> lname = new List<string>(); // holds the last name
        List<string> street1 = new List<string>(); // holds the street
        List<string> street2 = new List<string>(); //holds street2
        List<string> city = new List<string>(); // holds the city
        List<string> state = new List<string>(); // holds fthe state 
        List<string> zipcode = new List<string>(); // holds the zip code
        List<string> email = new List<string>(); // holds email
        List<string> hphone = new List<string>(); // holds the house phone
        List<string> wphone = new List<string>(); // holds the work phone
        List<string> cphone = new List<string>(); // holds the cell phone 
        List<string> cardworthy = new List<string>(); // holds the cardworthy
        List<string> relationship = new List<string>(); // holds relationship
        //List<double> birthday = new List<double>(); // holds birthday
        //List<double> anniversary = new List<double>(); // holds anniversary

        int Index;

        public frmContactForm()
        {
            InitializeComponent();
            Index = 0;  // Initialize
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
            lblFeedback.Text = "";
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
                
                // lblFeedback.Text = dtBDay.ToShortDateString*/
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

            /****************************** Open/Append Data to File ******************************/

            // Start storing contact info
            contactRecord = txtFirstName.Text + "," + txtLastName.Text + "," + txtStreet1.Text + "," + txtStreet2.Text + "," + txtCity.Text + "," + cmbState.Text.ToString() + "," + txtZip.Text + "," + txtEmail.Text + "," + txtHomePhone.Text + "," + txtWorkPhone.Text + "," + txtCellPhone.Text + "," + /*dtpBirthday.Value.ToShortDateString() + "," + dtpAnniversary.Value.ToShortDateString() + "," +*/ chkCardWorthy.Text.ToString() + "," + cmbRelationship.Text.ToString();

            // Display Successful Storage Message
            lblOutput.Text = "Contact Stored Successfully";

            // Display Contact Name in Output/Feedback Label
            lblFeedback.Text = DateTime.Now.ToShortDateString() + " " + txtFirstName.Text + " " + txtLastName.Text;

            // Display Contact Info in Output Textbox
            // lboxContacts.Items.Add(contactRecord);

            FileIO.writeFile(@"contactbook.csv", contactRecord);

            // Display contact info in Notes TextBox
            txtNotes.Text = contactRecord;
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
            FillLists(@"contactbook.csv", fname, lname, street1, street2, city, state, zipcode, email, hphone, wphone, cphone, cardworthy, relationship);

            // Reads the file
            // strData = FileIO.readFile(@"contactbook.csv");
            /*
            // If any error occurs...display in Label 
            if (strData.Contains("ERROR:"))
            {
                lblFeedback.Text = strData;
            }
            else // else...display in Listbox
            {
                lboxContacts.Items.Add(strData);
            } */
        }

        private void btnListContactInfo_Click(object sender, EventArgs e)
        {
            // Method #1 (using ListAllContacts function and ListBox)
            // lboxContacts.Items.AddRange(FileIO.ListAllContacts(@"Payroll.csv").Items);

            // Method #2 (using ListAllRecords function and List)
            // Store the list from the function in our own local list variable
            List<string> myList = FileIO.ListAllRecords(@"contactbook.csv");

            // Loop through list (AKA Dynamic Array) and post each item to the ListBox
            foreach (string s in myList)
            {
                // Phase #1:  Output to ListBox
                // lboxContacts.Items.Add(s);

                // Phase #2:  Split up data
                string[] columns = s.Split(',');

                // Concatenate just for knowing we got individual data
                string info = columns[1] + " " + columns[2] + " " + columns[3];
                lboxContacts.Items.Add(info);

                // Phase #3:  Try moving data to the form
                // txtFirstName.Text = columns[1];
            }
        }

        // Function that changes the variable back to normal
        public void FillMyForm(int index)
        { 
            txtFirstName.Text = fname[index];
            txtLastName.Text = lname[index];
            txtStreet1.Text = street1[index];
            txtStreet2.Text = street2[index];
            txtCity.Text = city[index];
            cmbState.Text = state[index].ToString();
            txtZip.Text = zipcode[index];
            txtEmail.Text = email[index];
            txtHomePhone.Text = hphone[index];
            txtWorkPhone.Text = wphone[index];
            txtCellPhone.Text = cphone[index];
            chkCardWorthy.Text = cardworthy[index];
            cmbRelationship.Text = relationship[index].ToString();
        }

        public void FillLists(string myFileName, List<string> Fname, List<string> Lname, List<string> Street1, List<string> Street2, List<string> City, List<string> State, List<string> Zipcode, List<string> Email, List<string> Hphone, List<string> Wphone, List<string> Cphone, List<string> CardWorthy, List<string> Relationship)
        { 
            // Clears all Lists back to 0 index
            Fname.Clear();
            Lname.Clear();
            Street1.Clear();
            Street2.Clear();
            City.Clear();
            State.Clear();
            Zipcode.Clear();
            Email.Clear();
            Hphone.Clear();
            Wphone.Clear();
            Cphone.Clear();
            CardWorthy.Clear();
            Relationship.Clear();

            StreamReader sr;

            try
            {
                sr = new StreamReader(File.Open(@myFileName,
                    FileMode.Open));

                try
                {

                    while (sr.Peek() != -1)
                    {
                        string row = sr.ReadLine();

                        string[] columns = row.Split(',');

                        // Breaks Data in pieces based on commas...
                        Fname.Add(columns[1]);
                        Lname.Add(columns[2]);
                        Street1.Add(columns[3]);
                        Street2.Add(columns[4]);
                        City.Add(columns[5]);
                        State.Add(columns[6]);
                        Zipcode.Add(columns[7]);
                        Email.Add(columns[8]);
                        Hphone.Add(columns[9]);
                        Wphone.Add(columns[10]);
                        Cphone.Add(columns[11]);
                        CardWorthy.Add(columns[12]);
                        Relationship.Add(columns[13]);
                    }

                }
                finally
                {
                    sr.Close();
                }
            }
            catch (Exception exc)
            {
                string x = exc.Message;
            }

            FillMyForm(Index);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Index++;

            if (Index >= fname.Count)
            {
                Index = fname.Count - 1;
            }

            FillMyForm(Index);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Index--;

            if (Index < 0)
            {
                Index = 0;
            }

            FillMyForm(Index);
        }
    }
}
