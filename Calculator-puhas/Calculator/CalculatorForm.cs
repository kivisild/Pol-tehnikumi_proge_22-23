using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {

        private Double currentValue = 0;
        private string operation = "";
        private bool isNewValue = true;

        public CalculatorForm()
        {
            InitializeComponent();
        }
        private void lisaNumber(string number)
        {
            if (isNewValue)
            {
                txtResult.Text = number;
                isNewValue = false;
            }
            else { txtResult.Text += number;}

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lisaNumber("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lisaNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lisaNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lisaNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lisaNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lisaNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lisaNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lisaNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lisaNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lisaNumber("9");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            calculate();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calculate();
            operation = "-";
            
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calculate();
            operation = "*";
            
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculate();
            operation = "/";
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            calculate();
            operation = "";
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            currentValue = 0;
            isNewValue = true;
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
        private void calculate()
        {
            if (operation == "+")
            {
                currentValue += Double.Parse(txtResult.Text); 
            }
            else if (operation == "-")
            {
                currentValue -= Double.Parse(txtResult.Text);
            }
            else if (operation == "*")
            {
                currentValue *= Double.Parse(txtResult.Text);
            }
            else if (operation == "/") 
            { 
                currentValue /= Double.Parse(txtResult.Text);
            }
            else
            {
                currentValue = Double.Parse(txtResult.Text);
            }
            txtResult.Text = currentValue.ToString();
            isNewValue = true;
        }
    }
}