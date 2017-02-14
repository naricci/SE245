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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
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
            this.gboxPizzaSizes.Location = new System.Drawing.Point(82, 92);
            this.gboxPizzaSizes.Margin = new System.Windows.Forms.Padding(6);
            this.gboxPizzaSizes.Name = "gboxPizzaSizes";
            this.gboxPizzaSizes.Padding = new System.Windows.Forms.Padding(6);
            this.gboxPizzaSizes.Size = new System.Drawing.Size(776, 154);
            this.gboxPizzaSizes.TabIndex = 0;
            this.gboxPizzaSizes.TabStop = false;
            this.gboxPizzaSizes.Text = "Pizza Sizes:";
            // 
            // radLargePizza
            // 
            this.radLargePizza.AutoSize = true;
            this.radLargePizza.Location = new System.Drawing.Point(524, 58);
            this.radLargePizza.Margin = new System.Windows.Forms.Padding(6);
            this.radLargePizza.Name = "radLargePizza";
            this.radLargePizza.Size = new System.Drawing.Size(141, 29);
            this.radLargePizza.TabIndex = 2;
            this.radLargePizza.TabStop = true;
            this.radLargePizza.Text = "Large ($12)";
            this.radLargePizza.UseVisualStyleBackColor = true;
            this.radLargePizza.CheckedChanged += new System.EventHandler(this.radLargePizza_CheckedChanged);
            // 
            // radMediumPizza
            // 
            this.radMediumPizza.AutoSize = true;
            this.radMediumPizza.Location = new System.Drawing.Point(274, 58);
            this.radMediumPizza.Margin = new System.Windows.Forms.Padding(6);
            this.radMediumPizza.Name = "radMediumPizza";
            this.radMediumPizza.Size = new System.Drawing.Size(162, 29);
            this.radMediumPizza.TabIndex = 1;
            this.radMediumPizza.TabStop = true;
            this.radMediumPizza.Text = "Medium ($10)";
            this.radMediumPizza.UseVisualStyleBackColor = true;
            this.radMediumPizza.CheckedChanged += new System.EventHandler(this.radMediumPizza_CheckedChanged);
            // 
            // radSmallPizza
            // 
            this.radSmallPizza.AutoSize = true;
            this.radSmallPizza.Location = new System.Drawing.Point(60, 58);
            this.radSmallPizza.Margin = new System.Windows.Forms.Padding(6);
            this.radSmallPizza.Name = "radSmallPizza";
            this.radSmallPizza.Size = new System.Drawing.Size(127, 29);
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
            this.gboxPizzaToppings.Location = new System.Drawing.Point(82, 300);
            this.gboxPizzaToppings.Margin = new System.Windows.Forms.Padding(6);
            this.gboxPizzaToppings.Name = "gboxPizzaToppings";
            this.gboxPizzaToppings.Padding = new System.Windows.Forms.Padding(6);
            this.gboxPizzaToppings.Size = new System.Drawing.Size(776, 381);
            this.gboxPizzaToppings.TabIndex = 1;
            this.gboxPizzaToppings.TabStop = false;
            this.gboxPizzaToppings.Text = "Pizza Toppings ($0.50 per topping):";
            // 
            // chkSpit
            // 
            this.chkSpit.AutoSize = true;
            this.chkSpit.Location = new System.Drawing.Point(524, 271);
            this.chkSpit.Margin = new System.Windows.Forms.Padding(6);
            this.chkSpit.Name = "chkSpit";
            this.chkSpit.Size = new System.Drawing.Size(68, 29);
            this.chkSpit.TabIndex = 11;
            this.chkSpit.Text = "Spit";
            this.chkSpit.UseVisualStyleBackColor = true;
            this.chkSpit.CheckedChanged += new System.EventHandler(this.chkSpit_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(524, 208);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(6);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(161, 29);
            this.chkExtraCheese.TabIndex = 10;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // chkBBQ
            // 
            this.chkBBQ.AutoSize = true;
            this.chkBBQ.Location = new System.Drawing.Point(524, 140);
            this.chkBBQ.Margin = new System.Windows.Forms.Padding(6);
            this.chkBBQ.Name = "chkBBQ";
            this.chkBBQ.Size = new System.Drawing.Size(142, 29);
            this.chkBBQ.TabIndex = 9;
            this.chkBBQ.Text = "BBQ Sauce";
            this.chkBBQ.UseVisualStyleBackColor = true;
            this.chkBBQ.CheckedChanged += new System.EventHandler(this.chkBBQ_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(524, 77);
            this.chkPineapple.Margin = new System.Windows.Forms.Padding(6);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(127, 29);
            this.chkPineapple.TabIndex = 8;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.chkPineapple_CheckedChanged);
            // 
            // chkSpinach
            // 
            this.chkSpinach.AutoSize = true;
            this.chkSpinach.Location = new System.Drawing.Point(274, 271);
            this.chkSpinach.Margin = new System.Windows.Forms.Padding(6);
            this.chkSpinach.Name = "chkSpinach";
            this.chkSpinach.Size = new System.Drawing.Size(109, 29);
            this.chkSpinach.TabIndex = 7;
            this.chkSpinach.Text = "Spinach";
            this.chkSpinach.UseVisualStyleBackColor = true;
            this.chkSpinach.CheckedChanged += new System.EventHandler(this.chkSpinach_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(274, 208);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(6);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(91, 29);
            this.chkOlives.TabIndex = 6;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(274, 140);
            this.chkOnions.Margin = new System.Windows.Forms.Padding(6);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(99, 29);
            this.chkOnions.TabIndex = 5;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            this.chkOnions.CheckedChanged += new System.EventHandler(this.chkOnions_CheckedChanged);
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(274, 77);
            this.chkPeppers.Margin = new System.Windows.Forms.Padding(6);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(111, 29);
            this.chkPeppers.TabIndex = 4;
            this.chkPeppers.Text = "Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            this.chkPeppers.CheckedChanged += new System.EventHandler(this.chkPeppers_CheckedChanged);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(60, 271);
            this.chkHam.Margin = new System.Windows.Forms.Padding(6);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(75, 29);
            this.chkHam.TabIndex = 3;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.CheckedChanged += new System.EventHandler(this.chkHam_CheckedChanged);
            // 
            // chkMeatball
            // 
            this.chkMeatball.AutoSize = true;
            this.chkMeatball.Location = new System.Drawing.Point(60, 208);
            this.chkMeatball.Margin = new System.Windows.Forms.Padding(6);
            this.chkMeatball.Name = "chkMeatball";
            this.chkMeatball.Size = new System.Drawing.Size(113, 29);
            this.chkMeatball.TabIndex = 2;
            this.chkMeatball.Text = "Meatball";
            this.chkMeatball.UseVisualStyleBackColor = true;
            this.chkMeatball.CheckedChanged += new System.EventHandler(this.chkMeatball_CheckedChanged);
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(60, 140);
            this.chkSausage.Margin = new System.Windows.Forms.Padding(6);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(116, 29);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            this.chkSausage.CheckedChanged += new System.EventHandler(this.chkSausage_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(60, 77);
            this.chkPepperoni.Margin = new System.Windows.Forms.Padding(6);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(129, 29);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.chkPepperoni_CheckedChanged);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(918, 92);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(128, 25);
            this.lblTotalCost.TabIndex = 2;
            this.lblTotalCost.Text = "Total Cost:  ";
            // 
            // lboxOrder
            // 
            this.lboxOrder.FormattingEnabled = true;
            this.lboxOrder.ItemHeight = 25;
            this.lboxOrder.Location = new System.Drawing.Point(924, 125);
            this.lboxOrder.Margin = new System.Windows.Forms.Padding(6);
            this.lboxOrder.Name = "lboxOrder";
            this.lboxOrder.Size = new System.Drawing.Size(624, 454);
            this.lboxOrder.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(34, 66);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(116, 25);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // gboxDeliveryInfo
            // 
            this.gboxDeliveryInfo.Controls.Add(this.txtEmail);
            this.gboxDeliveryInfo.Controls.Add(this.lblEmail);
            this.gboxDeliveryInfo.Controls.Add(this.txtPhone);
            this.gboxDeliveryInfo.Controls.Add(this.lblPhone);
            this.gboxDeliveryInfo.Controls.Add(this.lblState);
            this.gboxDeliveryInfo.Controls.Add(this.cmbState);
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
            this.gboxDeliveryInfo.Location = new System.Drawing.Point(82, 727);
            this.gboxDeliveryInfo.Margin = new System.Windows.Forms.Padding(6);
            this.gboxDeliveryInfo.Name = "gboxDeliveryInfo";
            this.gboxDeliveryInfo.Padding = new System.Windows.Forms.Padding(6);
            this.gboxDeliveryInfo.Size = new System.Drawing.Size(858, 470);
            this.gboxDeliveryInfo.TabIndex = 5;
            this.gboxDeliveryInfo.TabStop = false;
            this.gboxDeliveryInfo.Text = "Delivery Info";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(509, 357);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 31);
            this.txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(419, 363);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(201, 357);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(194, 31);
            this.txtPhone.TabIndex = 18;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(34, 360);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(155, 25);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(564, 296);
            this.lblState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(62, 25);
            this.lblState.TabIndex = 16;
            this.lblState.Text = "State";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(638, 288);
            this.cmbState.Margin = new System.Windows.Forms.Padding(6);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(164, 33);
            this.cmbState.TabIndex = 15;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(34, 296);
            this.lblCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(49, 25);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "City";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(160, 288);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(342, 33);
            this.cmbCity.TabIndex = 12;
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(160, 212);
            this.txtStreet2.Margin = new System.Windows.Forms.Padding(6);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(642, 31);
            this.txtStreet2.TabIndex = 11;
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(160, 137);
            this.txtStreet1.Margin = new System.Windows.Forms.Padding(6);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(642, 31);
            this.txtStreet1.TabIndex = 10;
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(34, 218);
            this.lblStreet2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(87, 25);
            this.lblStreet2.TabIndex = 9;
            this.lblStreet2.Text = "Street 2";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(34, 143);
            this.lblStreet1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(87, 25);
            this.lblStreet1.TabIndex = 8;
            this.lblStreet1.Text = "Street 1";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(546, 60);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(256, 31);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(160, 60);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 31);
            this.txtFirstName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(419, 66);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(115, 25);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(924, 608);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(6);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(300, 71);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(1252, 608);
            this.btnClearOrder.Margin = new System.Windows.Forms.Padding(6);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(300, 71);
            this.btnClearOrder.TabIndex = 7;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // frmOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 1329);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.gboxDeliveryInfo);
            this.Controls.Add(this.lboxOrder);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.gboxPizzaToppings);
            this.Controls.Add(this.gboxPizzaSizes);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblState;
    }
}

