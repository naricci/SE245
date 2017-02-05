namespace Lab5_MidtermExam
{
    partial class frmOrderForm
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
            this.gboxPizzaSizes = new System.Windows.Forms.GroupBox();
            this.radLargePizza = new System.Windows.Forms.RadioButton();
            this.radMediumPizza = new System.Windows.Forms.RadioButton();
            this.radSmallPizza = new System.Windows.Forms.RadioButton();
            this.gboxPizzaToppings = new System.Windows.Forms.GroupBox();
            this.chkSpit = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkBBQ = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkSpinach = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkMeatball = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lboxOrder = new System.Windows.Forms.ListBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gboxDeliveryInfo = new System.Windows.Forms.GroupBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.gboxPizzaSizes.SuspendLayout();
            this.gboxPizzaToppings.SuspendLayout();
            this.gboxDeliveryInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxPizzaSizes
            // 
            this.gboxPizzaSizes.Controls.Add(this.radLargePizza);
            this.gboxPizzaSizes.Controls.Add(this.radMediumPizza);
            this.gboxPizzaSizes.Controls.Add(this.radSmallPizza);
            this.gboxPizzaSizes.Location = new System.Drawing.Point(41, 48);
            this.gboxPizzaSizes.Name = "gboxPizzaSizes";
            this.gboxPizzaSizes.Size = new System.Drawing.Size(388, 80);
            this.gboxPizzaSizes.TabIndex = 0;
            this.gboxPizzaSizes.TabStop = false;
            this.gboxPizzaSizes.Text = "Pizza Sizes:";
            // 
            // radLargePizza
            // 
            this.radLargePizza.AutoSize = true;
            this.radLargePizza.Location = new System.Drawing.Point(262, 30);
            this.radLargePizza.Name = "radLargePizza";
            this.radLargePizza.Size = new System.Drawing.Size(92, 26);
            this.radLargePizza.TabIndex = 2;
            this.radLargePizza.TabStop = true;
            this.radLargePizza.Text = "Large ($12)";
            this.radLargePizza.UseVisualStyleBackColor = true;
            this.radLargePizza.CheckedChanged += new System.EventHandler(this.radLargePizza_CheckedChanged);
            // 
            // radMediumPizza
            // 
            this.radMediumPizza.AutoSize = true;
            this.radMediumPizza.Location = new System.Drawing.Point(137, 30);
            this.radMediumPizza.Name = "radMediumPizza";
            this.radMediumPizza.Size = new System.Drawing.Size(102, 26);
            this.radMediumPizza.TabIndex = 1;
            this.radMediumPizza.TabStop = true;
            this.radMediumPizza.Text = "Medium ($10)";
            this.radMediumPizza.UseVisualStyleBackColor = true;
            this.radMediumPizza.CheckedChanged += new System.EventHandler(this.radMediumPizza_CheckedChanged);
            // 
            // radSmallPizza
            // 
            this.radSmallPizza.AutoSize = true;
            this.radSmallPizza.Location = new System.Drawing.Point(30, 30);
            this.radSmallPizza.Name = "radSmallPizza";
            this.radSmallPizza.Size = new System.Drawing.Size(84, 26);
            this.radSmallPizza.TabIndex = 0;
            this.radSmallPizza.TabStop = true;
            this.radSmallPizza.Text = "Small ($7)";
            this.radSmallPizza.UseVisualStyleBackColor = true;
            this.radSmallPizza.CheckedChanged += new System.EventHandler(this.radSmallPizza_CheckedChanged);
            // 
            // gboxPizzaToppings
            // 
            this.gboxPizzaToppings.Controls.Add(this.chkSpit);
            this.gboxPizzaToppings.Controls.Add(this.chkExtraCheese);
            this.gboxPizzaToppings.Controls.Add(this.chkBBQ);
            this.gboxPizzaToppings.Controls.Add(this.chkPineapple);
            this.gboxPizzaToppings.Controls.Add(this.chkSpinach);
            this.gboxPizzaToppings.Controls.Add(this.chkOlives);
            this.gboxPizzaToppings.Controls.Add(this.chkOnions);
            this.gboxPizzaToppings.Controls.Add(this.chkPeppers);
            this.gboxPizzaToppings.Controls.Add(this.chkHam);
            this.gboxPizzaToppings.Controls.Add(this.chkMeatball);
            this.gboxPizzaToppings.Controls.Add(this.chkSausage);
            this.gboxPizzaToppings.Controls.Add(this.chkPepperoni);
            this.gboxPizzaToppings.Location = new System.Drawing.Point(41, 156);
            this.gboxPizzaToppings.Name = "gboxPizzaToppings";
            this.gboxPizzaToppings.Size = new System.Drawing.Size(388, 198);
            this.gboxPizzaToppings.TabIndex = 1;
            this.gboxPizzaToppings.TabStop = false;
            this.gboxPizzaToppings.Text = "Pizza Toppings ($0.50 per topping):";
            // 
            // chkSpit
            // 
            this.chkSpit.AutoSize = true;
            this.chkSpit.Location = new System.Drawing.Point(262, 141);
            this.chkSpit.Name = "chkSpit";
            this.chkSpit.Size = new System.Drawing.Size(57, 27);
            this.chkSpit.TabIndex = 11;
            this.chkSpit.Text = "Spit";
            this.chkSpit.UseVisualStyleBackColor = true;
            this.chkSpit.CheckedChanged += new System.EventHandler(this.chkSpit_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(262, 108);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(102, 27);
            this.chkExtraCheese.TabIndex = 10;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // chkBBQ
            // 
            this.chkBBQ.AutoSize = true;
            this.chkBBQ.Location = new System.Drawing.Point(262, 73);
            this.chkBBQ.Name = "chkBBQ";
            this.chkBBQ.Size = new System.Drawing.Size(95, 27);
            this.chkBBQ.TabIndex = 9;
            this.chkBBQ.Text = "BBQ Sauce";
            this.chkBBQ.UseVisualStyleBackColor = true;
            this.chkBBQ.CheckedChanged += new System.EventHandler(this.chkBBQ_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(262, 40);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(86, 27);
            this.chkPineapple.TabIndex = 8;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.chkPineapple_CheckedChanged);
            // 
            // chkSpinach
            // 
            this.chkSpinach.AutoSize = true;
            this.chkSpinach.Location = new System.Drawing.Point(137, 141);
            this.chkSpinach.Name = "chkSpinach";
            this.chkSpinach.Size = new System.Drawing.Size(78, 27);
            this.chkSpinach.TabIndex = 7;
            this.chkSpinach.Text = "Spinach";
            this.chkSpinach.UseVisualStyleBackColor = true;
            this.chkSpinach.CheckedChanged += new System.EventHandler(this.chkSpinach_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(137, 108);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(68, 27);
            this.chkOlives.TabIndex = 6;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(137, 73);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(72, 27);
            this.chkOnions.TabIndex = 5;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            this.chkOnions.CheckedChanged += new System.EventHandler(this.chkOnions_CheckedChanged);
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(137, 40);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(78, 27);
            this.chkPeppers.TabIndex = 4;
            this.chkPeppers.Text = "Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            this.chkPeppers.CheckedChanged += new System.EventHandler(this.chkPeppers_CheckedChanged);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(30, 141);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(61, 27);
            this.chkHam.TabIndex = 3;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.CheckedChanged += new System.EventHandler(this.chkHam_CheckedChanged);
            // 
            // chkMeatball
            // 
            this.chkMeatball.AutoSize = true;
            this.chkMeatball.Location = new System.Drawing.Point(30, 108);
            this.chkMeatball.Name = "chkMeatball";
            this.chkMeatball.Size = new System.Drawing.Size(79, 27);
            this.chkMeatball.TabIndex = 2;
            this.chkMeatball.Text = "Meatball";
            this.chkMeatball.UseVisualStyleBackColor = true;
            this.chkMeatball.CheckedChanged += new System.EventHandler(this.chkMeatball_CheckedChanged);
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(30, 73);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(81, 27);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            this.chkSausage.CheckedChanged += new System.EventHandler(this.chkSausage_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(30, 40);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(87, 27);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.chkPepperoni_CheckedChanged);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(459, 48);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(64, 13);
            this.lblTotalCost.TabIndex = 2;
            this.lblTotalCost.Text = "Total Cost:  ";
            // 
            // lboxOrder
            // 
            this.lboxOrder.FormattingEnabled = true;
            this.lboxOrder.Location = new System.Drawing.Point(462, 65);
            this.lboxOrder.Name = "lboxOrder";
            this.lboxOrder.Size = new System.Drawing.Size(314, 238);
            this.lboxOrder.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // gboxDeliveryInfo
            // 
            this.gboxDeliveryInfo.Controls.Add(this.cmbState);
            this.gboxDeliveryInfo.Controls.Add(this.lblState);
            this.gboxDeliveryInfo.Controls.Add(this.lblCity);
            this.gboxDeliveryInfo.Controls.Add(this.cmbCity);
            this.gboxDeliveryInfo.Controls.Add(this.txtStreet2);
            this.gboxDeliveryInfo.Controls.Add(this.txtStreet1);
            this.gboxDeliveryInfo.Controls.Add(this.lblStreet2);
            this.gboxDeliveryInfo.Controls.Add(this.lblStreet1);
            this.gboxDeliveryInfo.Controls.Add(this.txtLastName);
            this.gboxDeliveryInfo.Controls.Add(this.txtFirstName);
            this.gboxDeliveryInfo.Controls.Add(this.lblLastName);
            this.gboxDeliveryInfo.Controls.Add(this.lblFirstName);
            this.gboxDeliveryInfo.Location = new System.Drawing.Point(41, 378);
            this.gboxDeliveryInfo.Name = "gboxDeliveryInfo";
            this.gboxDeliveryInfo.Size = new System.Drawing.Size(429, 200);
            this.gboxDeliveryInfo.TabIndex = 5;
            this.gboxDeliveryInfo.TabStop = false;
            this.gboxDeliveryInfo.Text = "Delivery Info";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(319, 150);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(84, 21);
            this.cmbState.TabIndex = 15;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(270, 158);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 14;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(17, 153);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "City";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(80, 150);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(173, 21);
            this.cmbCity.TabIndex = 12;
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(80, 110);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(323, 20);
            this.txtStreet2.TabIndex = 11;
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(80, 71);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(323, 20);
            this.txtStreet1.TabIndex = 10;
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(17, 113);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(44, 13);
            this.lblStreet2.TabIndex = 9;
            this.lblStreet2.Text = "Street 2";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(17, 74);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(44, 13);
            this.lblStreet1.TabIndex = 8;
            this.lblStreet1.Text = "Street 1";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(273, 31);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(130, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(80, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(112, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(209, 34);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(462, 316);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(150, 37);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(626, 316);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(150, 37);
            this.btnClearOrder.TabIndex = 7;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // frmOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1001);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.gboxDeliveryInfo);
            this.Controls.Add(this.lboxOrder);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.gboxPizzaToppings);
            this.Controls.Add(this.gboxPizzaSizes);
            this.Name = "frmOrderForm";
            this.Text = "Pizza Order Entry System";
            this.Load += new System.EventHandler(this.frmOrderForm_Load);
            this.gboxPizzaSizes.ResumeLayout(false);
            this.gboxPizzaSizes.PerformLayout();
            this.gboxPizzaToppings.ResumeLayout(false);
            this.gboxPizzaToppings.PerformLayout();
            this.gboxDeliveryInfo.ResumeLayout(false);
            this.gboxDeliveryInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxPizzaSizes;
        private System.Windows.Forms.RadioButton radLargePizza;
        private System.Windows.Forms.RadioButton radMediumPizza;
        private System.Windows.Forms.RadioButton radSmallPizza;
        private System.Windows.Forms.GroupBox gboxPizzaToppings;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkSpit;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkBBQ;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkSpinach;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkMeatball;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ListBox lboxOrder;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gboxDeliveryInfo;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClearOrder;
    }
}

