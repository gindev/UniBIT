using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double l;
        char oper;

        public Form1()
        {
            InitializeComponent();
        }

        private void Digits_Click(object sender, EventArgs e)
        {
            // Digit click
            Button btn = (Button)sender;
            TRes.Text += btn.Text;
        }

        private void BPt_Click(object sender, EventArgs e)
        {
            if (!TRes.Text.Contains(","))
            {
                TRes.Text += ","; // Might be "."
            }
        }

        private void MathOps_Click(object sender, EventArgs e)
        {
            l = double.Parse(TRes.Text);
            oper = ((Button)sender).Text.ToCharArray()[0];
            // Button btn = (Button)sender;
            // oper = Convert.ToChar(btn.Text);
            TRes.Text = "0";
        }

        private void BEq_Click(object sender, EventArgs e)
        {
            double r = double.Parse(TRes.Text);
            switch (oper)
            {
                case '+': TRes.Text = (l + r).ToString(); break;
                case '-': TRes.Text = (l - r).ToString(); break;
                case '*': TRes.Text = (l * r).ToString(); break;
                case '/':
                    if(r != 0)
                    {
                        TRes.Text = (l / r).ToString(); break;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero!");
                    }
                    break;
                case '^': TRes.Text = Math.Pow(l, r).ToString(); break;
            }
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            TRes.Text = "0";
            l = 0;
            oper = ' ';
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            if(TRes.Text.Length > 1)
            {
                TRes.Text = TRes.Text.Remove(TRes.Text.Length - 1);
            }
            else
            {
                TRes.Text = "0";
            }
        }
    }
}
