using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool operatorPerformed = false;
        String operand = "";
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumEvent(object sender, EventArgs e)
        {
            if(textBox1.Text == "0"|| operatorPerformed)
            {
                textBox1.Clear();
            }
            Button AButton = (Button)sender;
            textBox1.Text += AButton.Text;
            operatorPerformed = false;
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            operatorPerformed = true;
            Button AButton = (Button)sender;
            String TheOperator = AButton.Text;

            label1.Text = label1.Text + " " + textBox1.Text + " " + TheOperator;

            switch (operand) 
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default: break;
            }
            result = Double.Parse(textBox1.Text);
            operand = TheOperator;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            result = 0;
            operand = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operatorPerformed = true;
            label1.Text = "";
            switch (operand)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default: break;
            }
            result = Double.Parse(textBox1.Text);
            textBox1.Text = result.ToString();
            result = 0;
            operand = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(!operatorPerformed && textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
            else if (operatorPerformed)
            {
                textBox1.Text = "0";
            }
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
            operatorPerformed = false;
        }
    }
}
