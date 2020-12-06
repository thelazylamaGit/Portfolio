using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Csharp
{
    public partial class Calculator : Form
    {
        string input = string.Empty;
        string side1 = string.Empty;
        string side2 = string.Empty;
        char operation;
        double result = 0.0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //1
            this.textBox1.Clear();
            input += "1";
            this.textBox1.Text = input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //2
            this.textBox1.Clear();
            input += "2";
            this.textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //3
            this.textBox1.Clear();
            input += "3";
            this.textBox1.Text = input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //4
            this.textBox1.Clear();
            input += "4";
            this.textBox1.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //5
            this.textBox1.Clear();
            input += "5";
            this.textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //6
            this.textBox1.Clear();
            input += "6";
            this.textBox1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //7
            this.textBox1.Clear();
            input += "7";
            this.textBox1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //8
            this.textBox1.Clear();
            input += "8";
            this.textBox1.Text = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //9
            this.textBox1.Clear();
            input += "9";
            this.textBox1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //0
            this.textBox1.Clear();
            input += "0";
            this.textBox1.Text = input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Clear
            this.textBox1.Clear();
            this.input = string.Empty;
            this.side1 = string.Empty;
            this.side2 = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Divide
            side1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Subtract
            side1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Add
            side1 = input;
            operation = '+';
            input = string.Empty;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            //Times
            side1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Equals
            side2 = input;
            double num1, num2;
            double.TryParse(side1, out num1);
            double.TryParse(side2, out num2);
            if (operation == '+')
            {
               result = num1 + num2;
            }
            else if(operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                result = num1 / num2;
            }
            else
            {
                result = num1;
            }
            textBox1.Text = result.ToString();
            this.input = string.Empty;
            this.side1 = string.Empty;
            this.side2 = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Decimal
            this.textBox1.Clear();
            input += ".";
            this.textBox1.Text = input;
        }

    }
}
