using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMA
{
    public partial class Form1 : Form
    {
       

        private ListViewSorter lvwColumnSorter = new ListViewSorter();
        private DataManager data;
        private RequestForm requestForm;
        private ItemForm itemForm;
        private CreatingRequestForm orderForm;

        public Form1()
        {
            InitializeComponent(); 
            lvwColumnSorter = new ListViewSorter();
            listView1.ListViewItemSorter = lvwColumnSorter;
            listView2.ListViewItemSorter = lvwColumnSorter;
            requestForm = new RequestForm();

            data = new DataManager(listView1, listView2, requestForm.requestRowList);
            orderForm = new CreatingRequestForm(data);
            itemForm = new ItemForm(data);
            requestForm.data = data;
            

            listView1.ColumnClick += new ColumnClickEventHandler(listView1_ColumnClick); 
            listView2.ColumnClick += new ColumnClickEventHandler(listView2_ColumnClick);

            _ = data.GetItemsDataManager();
            _ = data.GetRequestDataManager();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
            listView1.Visible = true;
            _ = data.GetItemsDataManager();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                _ = data.SendDeleteItemRequestAsync(selectedItem.SubItems[0].Text);
            }


        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if the clicked column is already the column that is being sorted.
            

            
            lvwColumnSorter.Order = SortOrder.Ascending;
            
            lvwColumnSorter.SortColumn = e.Column;

            // Perform the sort with these new sort options.
            listView1.Sort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _ = data.GetRequestRow(listView2.SelectedItems[0].Text);
            requestForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            listView2.Visible = true;
            _ = data.GetRequestDataManager();
        }

        

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvwColumnSorter.Order = SortOrder.Ascending;

            lvwColumnSorter.SortColumn = e.Column;

            listView2.Sort();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            itemForm.inserting = true;
            itemForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                
                itemForm.fillFormFilds(selectedItem.SubItems[0].Text, selectedItem.SubItems[1].Text,
                selectedItem.SubItems[2].Text, selectedItem.SubItems[3].Text, selectedItem.SubItems[4].Text, selectedItem.SubItems[5].Text, selectedItem.SubItems[6].Text,
                selectedItem.SubItems[7].Text, selectedItem.SubItems[8].Text);

                itemForm.Show();
            }


            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            data.LoadItemNames();
            orderForm.insertingNewRecord = true;
            orderForm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            data.LoadItemNames();
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];
                orderForm.selectedRequestId = selectedItem.SubItems[0].Text;



                orderForm.Show();
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];

                _ = data.SendDeleteRequestRequestAsync(selectedItem.SubItems[0].Text);
            }
        }
    }
}
