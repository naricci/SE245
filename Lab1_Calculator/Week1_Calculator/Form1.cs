using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_Calculator
{
    public partial class Form1 : Form
    {
        // Variables
        double num1, num2, result;
        string strOperand;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // txtLCD.Text = txtLCD.Text + "1";
            txtLCD.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "9";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // Store the second number
            num2 = double.Parse(txtLCD.Text);
            // Perform the math and store result
            if (strOperand == "plus")
            {
                result = num1 + num2;
            }
            else if (strOperand == "minus")
            {
                result = num1 - num2;
            }
            else if (strOperand == "multiply")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }
            // Display result
            txtLCD.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLCD.Text = "";
            num1 = 0;
            num2 = 0;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtLCD.Text += ".";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            // Get the first number in equation
            num1 = double.Parse(txtLCD.Text);    // Converts string variable to double
            // Get the operand
            strOperand = "minus";
            // Clear the display
            txtLCD.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            // Get the first number in equation
            num1 = double.Parse(txtLCD.Text);    // Converts string variable to double
            // Get the operand
            strOperand = "multiply";
            // Clear the display
            txtLCD.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            // Get the first number in equation
            num1 = double.Parse(txtLCD.Text);    // Converts string variable to double
            // Get the operand
            strOperand = "divide";
            // Clear the display
            txtLCD.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            // Get the first number in equation
            num1 = double.Parse(txtLCD.Text);    // Converts string variable to double
            // Get the operand
            strOperand = "plus";
            // Clear the display
            txtLCD.Text = "";
        }
    }
}
