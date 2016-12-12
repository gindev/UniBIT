using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingDocs
{
    public partial class Form2EditDocument : Form
    {
        public Form2EditDocument(Document document)
        {
            InitializeComponent();
            this.textBoxDocNumber.Text = document.Number;
            this.textBoxDocDate.Text = document.IssueDate.ToShortDateString();
        }
    }
}
