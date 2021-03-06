﻿namespace Assign2_ContactForm
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.lboxContacts = new System.Windows.Forms.ListBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnReadWholeFile = new System.Windows.Forms.Button();
            this.btnListContactInfo = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.gboxSalutation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSalutation
            // 
            this.gboxSalutation.Controls.Add(this.radMs);
            this.gboxSalutation.Controls.Add(this.radMrs);
            this.gboxSalutation.Controls.Add(this.radMr);
            this.gboxSalutation.Location = new System.Drawing.Point(166, 50);
            this.gboxSalutation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gboxSalutation.Name = "gboxSalutation";
            this.gboxSalutation.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gboxSalutation.Size = new System.Drawing.Size(492, 160);
            this.gboxSalutation.TabIndex = 0;
            this.gboxSalutation.TabStop = false;
            // 
            // radMs
            // 
            this.radMs.AutoSize = true;
            this.radMs.Location = new System.Drawing.Point(366, 67);
            this.radMs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radMs.Name = "radMs";
            this.radMs.Size = new System.Drawing.Size(78, 29);
            this.radMs.TabIndex = 2;
            this.radMs.TabStop = true;
            this.radMs.Text = "Ms.";
            this.radMs.UseVisualStyleBackColor = true;
            // 
            // radMrs
            // 
            this.radMrs.AutoSize = true;
            this.radMrs.Location = new System.Drawing.Point(206, 67);
            this.radMrs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radMrs.Name = "radMrs";
            this.radMrs.Size = new System.Drawing.Size(85, 29);
            this.radMrs.TabIndex = 1;
            this.radMrs.TabStop = true;
            this.radMrs.Text = "Mrs.";
            this.radMrs.UseVisualStyleBackColor = true;
            // 
            // radMr
            // 
            this.radMr.AutoSize = true;
            this.radMr.Location = new System.Drawing.Point(40, 67);
            this.radMr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radMr.Name = "radMr";
            this.radMr.Size = new System.Drawing.Size(74, 29);
            this.radMr.TabIndex = 0;
            this.radMr.TabStop = true;
            this.radMr.Text = "Mr.";
            this.radMr.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(188, 242);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(324, 31);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "Nick";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(758, 242);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(324, 31);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "Ricci";
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(188, 327);
            this.txtStreet1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(324, 31);
            this.txtStreet1.TabIndex = 3;
            this.txtStreet1.Text = "261 Bayview Avenue";
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(188, 417);
            this.txtStreet2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(324, 31);
            this.txtStreet2.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(188, 519);
            this.txtCity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(324, 31);
            this.txtCity.TabIndex = 5;
            this.txtCity.Text = "Warwick";
            // 
            // lblSalutation
            // 
            this.lblSalutation.AutoSize = true;
            this.lblSalutation.Location = new System.Drawing.Point(46, 50);
            this.lblSalutation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSalutation.Name = "lblSalutation";
            this.lblSalutation.Size = new System.Drawing.Size(108, 25);
            this.lblSalutation.TabIndex = 6;
            this.lblSalutation.Text = "Salutation";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(46, 248);
            this.lblFName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(116, 25);
            this.lblFName.TabIndex = 7;
            this.lblFName.Text = "First Name";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(46, 333);
            this.lblStreet1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(87, 25);
            this.lblStreet1.TabIndex = 8;
            this.lblStreet1.Text = "Street 1";
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(46, 423);
            this.lblStreet2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(87, 25);
            this.lblStreet2.TabIndex = 9;
            this.lblStreet2.Text = "Street 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(46, 525);
            this.lblCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(49, 25);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(560, 248);
            this.lblLName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(115, 25);
            this.lblLName.TabIndex = 11;
            this.lblLName.Text = "Last Name";
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(758, 325);
            this.cmbState.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(324, 33);
            this.cmbState.TabIndex = 6;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(560, 329);
            this.lblState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(62, 25);
            this.lblState.TabIndex = 13;
            this.lblState.Text = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(560, 423);
            this.lblZip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(99, 25);
            this.lblZip.TabIndex = 14;
            this.lblZip.Text = "Zip Code";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(758, 417);
            this.txtZip.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(324, 31);
            this.txtZip.TabIndex = 7;
            this.txtZip.Text = "02818";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 617);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 25);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(188, 612);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 31);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "nick@ricci.com";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(36, 719);
            this.lblHomePhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(136, 25);
            this.lblHomePhone.TabIndex = 18;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(188, 713);
            this.txtHomePhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(324, 31);
            this.txtHomePhone.TabIndex = 9;
            this.txtHomePhone.Text = "4018854548";
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(36, 812);
            this.lblWorkPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(136, 25);
            this.lblWorkPhone.TabIndex = 20;
            this.lblWorkPhone.Text = "Work  Phone";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(36, 917);
            this.lblCellPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(117, 25);
            this.lblCellPhone.TabIndex = 21;
            this.lblCellPhone.Text = "Cell Phone";
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(188, 806);
            this.txtWorkPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(324, 31);
            this.txtWorkPhone.TabIndex = 10;
            this.txtWorkPhone.Text = "4018854548";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(188, 912);
            this.txtCellPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(324, 31);
            this.txtCellPhone.TabIndex = 11;
            this.txtCellPhone.Text = "4018854548";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(560, 613);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(91, 25);
            this.lblBirthday.TabIndex = 24;
            this.lblBirthday.Text = "Birthday";
            // 
            // lblAnniversary
            // 
            this.lblAnniversary.AutoSize = true;
            this.lblAnniversary.Location = new System.Drawing.Point(560, 716);
            this.lblAnniversary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnniversary.Name = "lblAnniversary";
            this.lblAnniversary.Size = new System.Drawing.Size(126, 25);
            this.lblAnniversary.TabIndex = 25;
            this.lblAnniversary.Text = "Anniversary";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(686, 611);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(396, 31);
            this.dtpBirthday.TabIndex = 12;
            // 
            // dtpAnniversary
            // 
            this.dtpAnniversary.Location = new System.Drawing.Point(686, 714);
            this.dtpAnniversary.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpAnniversary.Name = "dtpAnniversary";
            this.dtpAnniversary.Size = new System.Drawing.Size(396, 31);
            this.dtpAnniversary.TabIndex = 13;
            // 
            // chkCardWorthy
            // 
            this.chkCardWorthy.AutoSize = true;
            this.chkCardWorthy.Location = new System.Drawing.Point(565, 808);
            this.chkCardWorthy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkCardWorthy.Name = "chkCardWorthy";
            this.chkCardWorthy.Size = new System.Drawing.Size(164, 29);
            this.chkCardWorthy.TabIndex = 14;
            this.chkCardWorthy.Text = "Card Worthy";
            this.chkCardWorthy.UseVisualStyleBackColor = true;
            // 
            // lblRelationship
            // 
            this.lblRelationship.AutoSize = true;
            this.lblRelationship.Location = new System.Drawing.Point(560, 917);
            this.lblRelationship.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRelationship.Name = "lblRelationship";
            this.lblRelationship.Size = new System.Drawing.Size(131, 25);
            this.lblRelationship.TabIndex = 29;
            this.lblRelationship.Text = "Relationship";
            // 
            // cmbRelationship
            // 
            this.cmbRelationship.FormattingEnabled = true;
            this.cmbRelationship.Location = new System.Drawing.Point(758, 909);
            this.cmbRelationship.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbRelationship.Name = "cmbRelationship";
            this.cmbRelationship.Size = new System.Drawing.Size(324, 33);
            this.cmbRelationship.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1121, 493);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(238, 48);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1364, 544);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(242, 48);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(1116, 54);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(86, 25);
            this.lblOutput.TabIndex = 37;
            this.lblOutput.Text = "Contact";
            // 
            // lboxContacts
            // 
            this.lboxContacts.FormattingEnabled = true;
            this.lboxContacts.ItemHeight = 25;
            this.lboxContacts.Location = new System.Drawing.Point(1122, 85);
            this.lboxContacts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lboxContacts.Name = "lboxContacts";
            this.lboxContacts.ScrollAlwaysVisible = true;
            this.lboxContacts.Size = new System.Drawing.Size(484, 354);
            this.lboxContacts.TabIndex = 38;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(1116, 613);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(107, 25);
            this.lblFeedback.TabIndex = 39;
            this.lblFeedback.Text = "Feedback";
            // 
            // btnReadWholeFile
            // 
            this.btnReadWholeFile.Location = new System.Drawing.Point(1364, 493);
            this.btnReadWholeFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReadWholeFile.Name = "btnReadWholeFile";
            this.btnReadWholeFile.Size = new System.Drawing.Size(242, 48);
            this.btnReadWholeFile.TabIndex = 40;
            this.btnReadWholeFile.Text = "Read Whole File";
            this.btnReadWholeFile.UseVisualStyleBackColor = true;
            this.btnReadWholeFile.Click += new System.EventHandler(this.btnReadWholeFile_Click);
            // 
            // btnListContactInfo
            // 
            this.btnListContactInfo.Location = new System.Drawing.Point(1122, 544);
            this.btnListContactInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnListContactInfo.Name = "btnListContactInfo";
            this.btnListContactInfo.Size = new System.Drawing.Size(238, 48);
            this.btnListContactInfo.TabIndex = 41;
            this.btnListContactInfo.Text = "List Contact Info";
            this.btnListContactInfo.UseVisualStyleBackColor = true;
            this.btnListContactInfo.Click += new System.EventHandler(this.btnListContactInfo_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(1122, 442);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(238, 48);
            this.btnPrevious.TabIndex = 42;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1364, 442);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(242, 48);
            this.btnNext.TabIndex = 43;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(1121, 744);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(485, 198);
            this.txtNotes.TabIndex = 44;
            // 
            // frmContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 985);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnListContactInfo);
            this.Controls.Add(this.btnReadWholeFile);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lboxContacts);
            this.Controls.Add(this.lblOutput);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ListBox lboxContacts;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnReadWholeFile;
        private System.Windows.Forms.Button btnListContactInfo;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtNotes;
    }
}

