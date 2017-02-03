using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4StringFuncsAndParsing
{
    public partial class frmJediForm : Form
    {
        public frmJediForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // String to hold all output
            string result = "";

            // Find first 3 letters of Last Name
            string lastName = txtLastName.Text;
            string strLastName = lastName.Substring(0, 3);

            // Find last 2 letters of First Name
            string firstName = txtFirstName.Text;
            string strFirstName = firstName.Substring(firstName.Length - 2);

            // Find first 2 letters of Mother's Maiden Name
            string maidenName = txtMaidenName.Text;
            string strMaidenName = maidenName.Substring(0, 2);

            // Find last 3 letters of Birthplace
            string birthplace = txtBirthplace.Text;
            string strBirthplace = birthplace.Substring(birthplace.Length - 3);

            // Calculate Output
            result += strLastName + strFirstName + "-" + strMaidenName + strBirthplace;

            // Display Output
            lblOutput.Text += result;
        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            // Clear the Output Label
            lblOutput.Text = "Your Jedi Name:  ";
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            // Clear the Form's Textboxes
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMaidenName.Text = "";
            txtBirthplace.Text = "";
        }
    }
}
