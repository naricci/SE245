using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_MidtermExam
{
    public partial class frmOrderForm : Form
    {     
        public frmOrderForm()
        {
            InitializeComponent();
        }

        // Variables
        double pizzaPrice, toppingPrice, totalPrice;
        int emailMin, phoneMin;
        string pizzaSize, pizzaTopping, salutation;

        private void chkMeatball_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping = " Meatball";
            pizzaPrice = 0.50;
        }

        private void chkHam_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping = " Ham";
            pizzaPrice = 0.50;
        }

        private void chkSausage_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping = " Sausage";
            pizzaPrice = 0.50;
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            pizzaTopping = " Pepperoni";
            toppingPrice = 0.50;
        }

        private void radLargePizza_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = 12;
            pizzaSize = "Large";
        }

        private void radMediumPizza_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = 10;
            pizzaSize = "Medium";
        }

        private void radSmallPizza_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = 7;
            pizzaSize = "Small";
        }

        

    }
}
