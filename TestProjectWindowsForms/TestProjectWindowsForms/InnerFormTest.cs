using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjectWindowsForms
{
    public partial class InnerFormTest : Form
    {
        public InnerFormTest()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
        }

        private void InnerFormTest_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = CreateGraphics();
            gr.DrawLine(Pens.Red, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as  TestProjectWindowsForms.Form1;
            label1.Text = f.label1.Text;
            f.textBox1.Text = textBox1.Text;
        }
    }
}
