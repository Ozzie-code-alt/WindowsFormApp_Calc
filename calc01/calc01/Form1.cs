using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc01
{
    public partial class Form1 : Form
    {
        double result = 0; // double variable
        string operation = "";  // for operations
        bool performed = false; // check if button is pressed 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if((textBoxResult.Text == "0") || (performed))
                textBoxResult.Clear();
            Button button = (Button)sender;
            

            if (button.Text == ".") // method for stop repeating dots
            {
                if (!textBoxResult.Text.Contains(".")) // stop reiteration of dot.
                    textBoxResult.Text = textBoxResult.Text + button.Text;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + button.Text;
            }

            performed = false;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // gets text 

            if (result != 0) // method for allowing me to use arithmetic operations more
            {
                button17.PerformClick();
                operation = button.Text;
                performed = true;
                labelOperation.Text = result + "" + operation;
            }
            else
            {
                operation = button.Text;
                result = Convert.ToDouble(textBoxResult.Text); // convertdouble value to string soo can show on textbox
                performed = true;
                labelOperation.Text = result + "" + operation;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            result = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (operation == "+") // brainded arithmetic operators
            {
                textBoxResult.Text = (result + double.Parse(textBoxResult.Text)).ToString();
            }
            else if (operation == "-")
            {
                textBoxResult.Text = (result - double.Parse(textBoxResult.Text)).ToString();
            }
            else if (operation == "*")
            {
                textBoxResult.Text = (result * double.Parse(textBoxResult.Text)).ToString();
            }
            else if (operation == "/")
            {
                textBoxResult.Text = (result / double.Parse(textBoxResult.Text)).ToString();
            }
            result = double.Parse(textBoxResult.Text);
            labelOperation.Text = "";
        }
        
    }
}
