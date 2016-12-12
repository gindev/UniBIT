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
        public readonly List<Document> foundDocuments;

        public Form1()
        {
            InitializeComponent();
            foundDocuments = Json.ReadFromJsonFile<List<Document>>("../../../Documents.txt");
            // Get a list of documents to show

            foreach (var foundDocument in foundDocuments)
            {
                ListViewItem item = new ListViewItem()
                {
                    Text = foundDocument.Type,
                    Tag = foundDocument
                };
                item.SubItems.Add(foundDocument.Number);
                item.SubItems.Add(foundDocument.IssueDate.ToShortDateString());
                decimal itemTotalSum = 0m;
                foreach (var itemInInvoice in foundDocument.ProductsList)
                {
                    itemTotalSum += itemInInvoice.ProductSinglePrice * itemInInvoice.ProductQuantity;
                }
                item.SubItems.Add(itemTotalSum.ToString());
                item.SubItems.Add(foundDocument.Client.Name);
                listView1.Items.Add(item);
            }

            SaveDocuments(listView1);
        }


        /// <summary>
        /// Saves all documents from a ListView item to the database used.
        /// </summary>
        private void SaveDocuments(ListView listview)
        {
            List<Document> documents = new List<Document>();
            foreach (ListViewItem convertedItem in listview.Items)
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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            SelectedListViewItemCollection list = (sender as ListView).SelectedItems;
            if (list.Count > 0)
            {
                Document item = (Document)list[0].Tag;
                Form2EditDocument editForm = new Form2EditDocument(item);
                editForm.Show();
            }
        }
    }
}
