namespace Assign2_ContactForm
{
    partial class frmContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxSalutation = new System.Windows.Forms.GroupBox();
            this.radMs = new System.Windows.Forms.RadioButton();
            this.radMrs = new System.Windows.Forms.RadioButton();
            this.radMr = new System.Windows.Forms.RadioButton();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblSalutation = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblAnniversary = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.dtpAnniversary = new System.Windows.Forms.DateTimePicker();
            this.chkCardWorthy = new System.Windows.Forms.CheckBox();
            this.lblRelationship = new System.Windows.Forms.Label();
            this.cmbRelationship = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.gboxSalutation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSalutation
            // 
            this.gboxSalutation.Controls.Add(this.radMs);
            this.gboxSalutation.Controls.Add(this.radMrs);
            this.gboxSalutation.Controls.Add(this.radMr);
            this.gboxSalutation.Location = new System.Drawing.Point(83, 26);
            this.gboxSalutation.Name = "gboxSalutation";
            this.gboxSalutation.Size = new System.Drawing.Size(246, 83);
            this.gboxSalutation.TabIndex = 0;
            this.gboxSalutation.TabStop = false;
            // 
            // radMs
            // 
            this.radMs.AutoSize = true;
            this.radMs.Location = new System.Drawing.Point(183, 35);
            this.radMs.Name = "radMs";
            this.radMs.Size = new System.Drawing.Size(42, 17);
            this.radMs.TabIndex = 2;
            this.radMs.TabStop = true;
            this.radMs.Text = "Ms.";
            this.radMs.UseVisualStyleBackColor = true;
            // 
            // radMrs
            // 
            this.radMrs.AutoSize = true;
            this.radMrs.Location = new System.Drawing.Point(103, 35);
            this.radMrs.Name = "radMrs";
            this.radMrs.Size = new System.Drawing.Size(45, 17);
            this.radMrs.TabIndex = 1;
            this.radMrs.TabStop = true;
            this.radMrs.Text = "Mrs.";
            this.radMrs.UseVisualStyleBackColor = true;
            // 
            // radMr
            // 
            this.radMr.AutoSize = true;
            this.radMr.Location = new System.Drawing.Point(20, 35);
            this.radMr.Name = "radMr";
            this.radMr.Size = new System.Drawing.Size(40, 17);
            this.radMr.TabIndex = 0;
            this.radMr.TabStop = true;
            this.radMr.Text = "Mr.";
            this.radMr.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(94, 126);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(164, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "Nick";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(379, 126);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(164, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "Ricci";
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(94, 170);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(164, 20);
            this.txtStreet1.TabIndex = 3;
            this.txtStreet1.Text = "261 bayview avenue";
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(94, 217);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(164, 20);
            this.txtStreet2.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(94, 270);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(164, 20);
            this.txtCity.TabIndex = 5;
            this.txtCity.Text = "Warwick";
            // 
            // lblSalutation
            // 
            this.lblSalutation.AutoSize = true;
            this.lblSalutation.Location = new System.Drawing.Point(23, 26);
            this.lblSalutation.Name = "lblSalutation";
            this.lblSalutation.Size = new System.Drawing.Size(54, 13);
            this.lblSalutation.TabIndex = 6;
            this.lblSalutation.Text = "Salutation";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(23, 129);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 7;
            this.lblFName.Text = "First Name";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(23, 173);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(44, 13);
            this.lblStreet1.TabIndex = 8;
            this.lblStreet1.Text = "Street 1";
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(23, 220);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(44, 13);
            this.lblStreet2.TabIndex = 9;
            this.lblStreet2.Text = "Street 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(23, 273);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(280, 129);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 11;
            this.lblLName.Text = "Last Name";
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(379, 169);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(164, 21);
            this.cmbState.TabIndex = 6;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(280, 171);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 13;
            this.lblState.Text = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(280, 220);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(50, 13);
            this.lblZip.TabIndex = 14;
            this.lblZip.Text = "Zip Code";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(379, 217);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(164, 20);
            this.txtZip.TabIndex = 7;
            this.txtZip.Text = "02818";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 321);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 318);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "nicholasaricci@gmail.com";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(18, 374);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(69, 13);
            this.lblHomePhone.TabIndex = 18;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(94, 371);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(164, 20);
            this.txtHomePhone.TabIndex = 9;
            this.txtHomePhone.Text = "4018854548";
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(18, 422);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(70, 13);
            this.lblWorkPhone.TabIndex = 20;
            this.lblWorkPhone.Text = "Work  Phone";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(18, 477);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(58, 13);
            this.lblCellPhone.TabIndex = 21;
            this.lblCellPhone.Text = "Cell Phone";
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(94, 419);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(164, 20);
            this.txtWorkPhone.TabIndex = 10;
            this.txtWorkPhone.Text = "4018854548";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(94, 474);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(164, 20);
            this.txtCellPhone.TabIndex = 11;
            this.txtCellPhone.Text = "4018854548";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(280, 271);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblBirthday.TabIndex = 24;
            this.lblBirthday.Text = "Birthday";
            // 
            // lblAnniversary
            // 
            this.lblAnniversary.AutoSize = true;
            this.lblAnniversary.Location = new System.Drawing.Point(280, 321);
            this.lblAnniversary.Name = "lblAnniversary";
            this.lblAnniversary.Size = new System.Drawing.Size(62, 13);
            this.lblAnniversary.TabIndex = 25;
            this.lblAnniversary.Text = "Anniversary";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(343, 270);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthday.TabIndex = 12;
            // 
            // dtpAnniversary
            // 
            this.dtpAnniversary.Location = new System.Drawing.Point(343, 321);
            this.dtpAnniversary.Name = "dtpAnniversary";
            this.dtpAnniversary.Size = new System.Drawing.Size(200, 20);
            this.dtpAnniversary.TabIndex = 13;
            // 
            // chkCardWorthy
            // 
            this.chkCardWorthy.AutoSize = true;
            this.chkCardWorthy.Location = new System.Drawing.Point(282, 373);
            this.chkCardWorthy.Name = "chkCardWorthy";
            this.chkCardWorthy.Size = new System.Drawing.Size(85, 17);
            this.chkCardWorthy.TabIndex = 14;
            this.chkCardWorthy.Text = "Card Worthy";
            this.chkCardWorthy.UseVisualStyleBackColor = true;
            // 
            // lblRelationship
            // 
            this.lblRelationship.AutoSize = true;
            this.lblRelationship.Location = new System.Drawing.Point(280, 422);
            this.lblRelationship.Name = "lblRelationship";
            this.lblRelationship.Size = new System.Drawing.Size(65, 13);
            this.lblRelationship.TabIndex = 29;
            this.lblRelationship.Text = "Relationship";
            // 
            // cmbRelationship
            // 
            this.cmbRelationship.FormattingEnabled = true;
            this.cmbRelationship.Location = new System.Drawing.Point(379, 418);
            this.cmbRelationship.Name = "cmbRelationship";
            this.cmbRelationship.Size = new System.Drawing.Size(164, 21);
            this.cmbRelationship.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(568, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 24);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(692, 280);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 24);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(568, 50);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(243, 224);
            this.txtOutput.TabIndex = 36;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(565, 35);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(44, 13);
            this.lblOutput.TabIndex = 37;
            this.lblOutput.Text = "Contact";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(565, 321);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(55, 13);
            this.lblFeedback.TabIndex = 38;
            this.lblFeedback.Text = "Feedback";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(568, 338);
            this.txtFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFeedback.Size = new System.Drawing.Size(243, 156);
            this.txtFeedback.TabIndex = 39;
            // 
            // frmContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 519);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbRelationship);
            this.Controls.Add(this.lblRelationship);
            this.Controls.Add(this.chkCardWorthy);
            this.Controls.Add(this.dtpAnniversary);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lblAnniversary);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(this.txtWorkPhone);
            this.Controls.Add(this.lblCellPhone);
            this.Controls.Add(this.lblWorkPhone);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet2);
            this.Controls.Add(this.lblStreet1);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblSalutation);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet2);
            this.Controls.Add(this.txtStreet1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.gboxSalutation);
            this.Name = "frmContactForm";
            this.Text = "A2 - Contact Form";
            this.Load += new System.EventHandler(this.frmContactForm_Load);
            this.gboxSalutation.ResumeLayout(false);
            this.gboxSalutation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxSalutation;
        private System.Windows.Forms.RadioButton radMs;
        private System.Windows.Forms.RadioButton radMrs;
        private System.Windows.Forms.RadioButton radMr;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblSalutation;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblAnniversary;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.DateTimePicker dtpAnniversary;
        private System.Windows.Forms.CheckBox chkCardWorthy;
        private System.Windows.Forms.Label lblRelationship;
        private System.Windows.Forms.ComboBox cmbRelationship;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.TextBox txtFeedback;
    }
}

