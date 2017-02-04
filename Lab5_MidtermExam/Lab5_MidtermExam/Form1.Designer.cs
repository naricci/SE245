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
            this.radSmallPizza = new System.Windows.Forms.RadioButton();
            this.radMediumPizza = new System.Windows.Forms.RadioButton();
            this.radLargePizza = new System.Windows.Forms.RadioButton();
            this.gboxPizzaToppings = new System.Windows.Forms.GroupBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkMeatball = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkSpinach = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkBBQ = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkSpit = new System.Windows.Forms.CheckBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gboxPizzaSizes.SuspendLayout();
            this.gboxPizzaToppings.SuspendLayout();
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
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(137, 40);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(78, 27);
            this.chkPeppers.TabIndex = 4;
            this.chkPeppers.Text = "Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
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
            // 
            // chkBBQ
            // 
            this.chkBBQ.AutoSize = true;
            this.chkBBQ.Location = new System.Drawing.Point(262, 73);
            this.chkBBQ.Name = "chkBBQ";
            this.chkBBQ.Size = new System.Drawing.Size(61, 27);
            this.chkBBQ.TabIndex = 9;
            this.chkBBQ.Text = "BBQ";
            this.chkBBQ.UseVisualStyleBackColor = true;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(462, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 290);
            this.listBox1.TabIndex = 3;
            // 
            // frmOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1001);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.gboxPizzaToppings);
            this.Controls.Add(this.gboxPizzaSizes);
            this.Name = "frmOrderForm";
            this.Text = "Pizza Order Entry System";
            this.gboxPizzaSizes.ResumeLayout(false);
            this.gboxPizzaSizes.PerformLayout();
            this.gboxPizzaToppings.ResumeLayout(false);
            this.gboxPizzaToppings.PerformLayout();
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
        private System.Windows.Forms.ListBox listBox1;
    }
}

