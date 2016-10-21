using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseApp161020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TCount.Text))
            {
                MessageBox.Show("Липса на данни");
                TCount.Focus();
            }
            else
            {
                int n = int.Parse(TCount.Text);
                listBox1.Items.Clear();
                if (REven.Checked)
                {
                    int num = 2;
                    for (int i = 0; i < n; i++)
                    {
                        listBox1.Items.Add(num);
                        num += 2;
                    }
                }
                else
                {
                    Random rn = new Random();
                    int dobavka;
                    if (checkBox1.Checked)
                    {
                        dobavka = 666;
                    }
                    else
                    {
                        dobavka = 0;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        listBox1.Items.Add(rn.NextDouble() + dobavka);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // da se proveri dali moje da se prehwyrli cqla kolekciq ot edin list kym drug
            foreach(object el in listBox1.SelectedItems)
            {
                listBox2.Items.Add(el);
            }

            while(listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void REven_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox1.Enabled = false;
        }

        private void RRand_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
        }

        private void BLeft_Click(object sender, EventArgs e)
        {
            foreach (object el in listBox2.SelectedItems)
            {
                listBox1.Items.Add(el);
            }

            while (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void TCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if((ch < '0' || ch > '9') && (ch != (char) 8))
            {
                e.Handled = true;
            }
        }
    }
}
