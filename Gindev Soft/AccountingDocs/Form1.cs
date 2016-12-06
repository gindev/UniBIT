namespace AccountingDocs
{
    using Models;
    using System;
    using JsonReader;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.ListView;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Get a list of documents to show
            List<Document> foundDocuments = Json.ReadFromJsonFile<List<Document>>("../../../Documents.txt");
            foreach (var foundDocument in foundDocuments)
            {
                ListViewItem item = new ListViewItem()
                {
                    Text = foundDocument.Type,
                    Tag = foundDocument
                };

                item.SubItems.Add(foundDocument.Number);
                item.SubItems.Add(foundDocument.IssueDate.ToString());
                decimal itemTotalSum = 0m;
                foreach (var itemInInvoice in foundDocument.ProductsList)
                {
                    itemTotalSum += itemInInvoice.ProductSinglePrice * itemInInvoice.ProductQuantity;
                }
                item.SubItems.Add(itemTotalSum.ToString());
                item.SubItems.Add(foundDocument.Client.Name);
                listView1.Items.Add(item);
            }
<<<<<<< HEAD
=======
            
>>>>>>> origin/master

            // Write a list of documents
            List<Document> documents = new List<Document>();
            foreach (ListViewItem convertedItem in listView1.Items)
            {
                documents.Add((Document)convertedItem.Tag);
            }
            Json.WriteToJsonFile<List<Document>>("../../../Documents.txt", documents);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was made by Panayot Gindev as\na UniBIT VPE (Visual Programming Environments)\nproject. All rights reserved!", "Help -> About");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            SelectedListViewItemCollection list = (sender as ListView).SelectedItems;
            if (list.Count > 0)
            {
                Document item = (Document)list[0].Tag;
                MessageBox.Show(item.Client.Name.ToString()); // TODO: open a new form with selected data
            }
        }
    }
}
