using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b9_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "9";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "7";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "5";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "3";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "1";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "2";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "4";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "6";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "8";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "0";
        }
        public int num1, num2;

        private void Sub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(maskedTextBox1.Text);
            maskedTextBox1.Text = "";
            currentSym = Symbol.Sub;

        }
        enum Symbol
        {
            Div, Mult, Add, Sub
        }

        Symbol currentSym;
        private void Mul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(maskedTextBox1.Text);
            maskedTextBox1.Text = "";
            currentSym = Symbol.Mult;
        }

        private void Dev_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(maskedTextBox1.Text);
            maskedTextBox1.Text = "";
            currentSym = Symbol.Div;
        }

        private void C_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            num1 = 0;
            num2 = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(maskedTextBox1.Text);
            switch (currentSym)
            {
                case Symbol.Div:
                    if (num2 != 0)
                        maskedTextBox1.Text = $"{num1 / num2}";
                    else
                    {
                        MessageBox.Show("!!!!!");
                        maskedTextBox1.Text = "";
                        num1 = 0;
                        num2 = 0;
                    }
                    break;
                case Symbol.Mult:
                    if (num1 != 0 && num2 != 0)
                        maskedTextBox1.Text = $"{num1 * num2}";
                    else
                    {
                        MessageBox.Show("!!!!!!");
                        maskedTextBox1.Text = "";
                        num1 = 0;
                        num2 = 0;
                    }
                    maskedTextBox1.Text = $"{num1 * num2}";
                    break;

                case Symbol.Add:
                    maskedTextBox1.Text = $"{num1 + num2}";
                    break;
                case Symbol.Sub:
                    if (num1 == 0)
                    {
                        maskedTextBox1.Text = $"{-(num1 - num2)}";
                    }
                    maskedTextBox1.Text = $"{num1 - num2}";
                    break;
                default:
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(maskedTextBox1.Text);
            maskedTextBox1.Text = "";
            currentSym = Symbol.Add;

        }
    }
}
