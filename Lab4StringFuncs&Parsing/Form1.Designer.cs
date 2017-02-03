namespace Lab4StringFuncsAndParsing
{
    partial class frmJediForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMaidenName = new System.Windows.Forms.Label();
            this.lblBirthplace = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMaidenName = new System.Windows.Forms.TextBox();
            this.txtBirthplace = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.gboxJediForm = new System.Windows.Forms.GroupBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.gboxJediForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(39, 75);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(116, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(39, 138);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(115, 25);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblMaidenName
            // 
            this.lblMaidenName.AutoSize = true;
            this.lblMaidenName.Location = new System.Drawing.Point(39, 211);
            this.lblMaidenName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaidenName.Name = "lblMaidenName";
            this.lblMaidenName.Size = new System.Drawing.Size(145, 25);
            this.lblMaidenName.TabIndex = 2;
            this.lblMaidenName.Text = "Maiden Name";
            // 
            // lblBirthplace
            // 
            this.lblBirthplace.AutoSize = true;
            this.lblBirthplace.Location = new System.Drawing.Point(39, 281);
            this.lblBirthplace.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBirthplace.Name = "lblBirthplace";
            this.lblBirthplace.Size = new System.Drawing.Size(157, 25);
            this.lblBirthplace.TabIndex = 3;
            this.lblBirthplace.Text = "Birth City/Town";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(215, 69);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(276, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(215, 133);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(276, 31);
            this.txtLastName.TabIndex = 2;
            // 
            // txtMaidenName
            // 
            this.txtMaidenName.Location = new System.Drawing.Point(215, 205);
            this.txtMaidenName.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaidenName.Name = "txtMaidenName";
            this.txtMaidenName.Size = new System.Drawing.Size(276, 31);
            this.txtMaidenName.TabIndex = 3;
            // 
            // txtBirthplace
            // 
            this.txtBirthplace.Location = new System.Drawing.Point(215, 275);
            this.txtBirthplace.Margin = new System.Windows.Forms.Padding(6);
            this.txtBirthplace.Name = "txtBirthplace";
            this.txtBirthplace.Size = new System.Drawing.Size(276, 31);
            this.txtBirthplace.TabIndex = 4;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(646, 116);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(6);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(370, 139);
            this.txtOutput.TabIndex = 7;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(641, 85);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(172, 25);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Your Jedi Name:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(646, 267);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(176, 49);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create Name";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(840, 267);
            this.btnClearResult.Margin = new System.Windows.Forms.Padding(6);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(176, 49);
            this.btnClearResult.TabIndex = 9;
            this.btnClearResult.Text = "Clear Results";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // gboxJediForm
            // 
            this.gboxJediForm.Controls.Add(this.btnClearForm);
            this.gboxJediForm.Controls.Add(this.txtFirstName);
            this.gboxJediForm.Controls.Add(this.lblFirstName);
            this.gboxJediForm.Controls.Add(this.lblLastName);
            this.gboxJediForm.Controls.Add(this.lblMaidenName);
            this.gboxJediForm.Controls.Add(this.txtBirthplace);
            this.gboxJediForm.Controls.Add(this.lblBirthplace);
            this.gboxJediForm.Controls.Add(this.txtMaidenName);
            this.gboxJediForm.Controls.Add(this.txtLastName);
            this.gboxJediForm.Location = new System.Drawing.Point(69, 85);
            this.gboxJediForm.Name = "gboxJediForm";
            this.gboxJediForm.Size = new System.Drawing.Size(536, 457);
            this.gboxJediForm.TabIndex = 10;
            this.gboxJediForm.TabStop = false;
            this.gboxJediForm.Text = "Please fill out the following:";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(315, 354);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(6);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(176, 49);
            this.btnClearForm.TabIndex = 5;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // frmJediForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 624);
            this.Controls.Add(this.btnClearResult);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.gboxJediForm);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmJediForm";
            this.Text = "Jedi Name Form";
            this.gboxJediForm.ResumeLayout(false);
            this.gboxJediForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMaidenName;
        private System.Windows.Forms.Label lblBirthplace;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMaidenName;
        private System.Windows.Forms.TextBox txtBirthplace;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClearResult;
        private System.Windows.Forms.GroupBox gboxJediForm;
        private System.Windows.Forms.Button btnClearForm;
    }
}

