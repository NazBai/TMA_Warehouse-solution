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
       

        private ListViewSorter lvwColumnSorter;
        private DataManager data;
        private RequestForm requestForm;
        private ItemForm itemForm;
        private CreatingRequestForm orderForm;

        public Form1()
        {
            InitializeComponent(); 
            lvwColumnSorter = new ListViewSorter();
            itemListView.ListViewItemSorter = lvwColumnSorter;
            requestListView.ListViewItemSorter = lvwColumnSorter;
            requestListView.Visible = false;
            itemListView.Visible = true;

            requestForm = new RequestForm();

            data = new DataManager(itemListView, requestListView, requestForm.requestRowList);
            orderForm = new CreatingRequestForm(data);
            itemForm = new ItemForm(data);
            requestForm.data = data;
            

            itemListView.ColumnClick += new ColumnClickEventHandler(itemListView_ColumnClick); 
            requestListView.ColumnClick += new ColumnClickEventHandler(requestListView_ColumnClick);

            _ = data.GetItemsDataAsync();
            _ = data.GetRequestDataManagerAsync();
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

        private void itemListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            requestListView.Visible = false;
            itemListView.Visible = true;
            _ = data.GetItemsDataAsync();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (itemListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = itemListView.SelectedItems[0];

                _ = data.SendDeleteItemRequestAsync(selectedItem.SubItems[0].Text);
            }


        }

        private void itemListView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void itemListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            
            
            lvwColumnSorter.SortColumn = e.Column;

            itemListView.Sort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (requestListView.SelectedItems.Count > 0)
            {
                _ = data.GetRequestRowAsync(requestListView.SelectedItems[0].Text);
                requestForm.Show();
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemListView.Visible = false;
            requestListView.Visible = true;
            _ = data.GetRequestDataManagerAsync();
        }

        

        private void requestListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void requestListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            

            lvwColumnSorter.SortColumn = e.Column;

            requestListView.Sort();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            itemForm.inserting = true;
            itemForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (itemListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = itemListView.SelectedItems[0];
                
                itemForm.fillFormFilds(selectedItem.SubItems[1].Text,
                selectedItem.SubItems[2].Text, selectedItem.SubItems[3].Text, selectedItem.SubItems[4].Text, selectedItem.SubItems[5].Text, selectedItem.SubItems[6].Text,
                selectedItem.SubItems[7].Text, selectedItem.SubItems[8].Text);
                itemForm.itemId = selectedItem.SubItems[0].Text;

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
            if (requestListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = requestListView.SelectedItems[0];
                orderForm.selectedRequestId = selectedItem.SubItems[0].Text;



                orderForm.Show();
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            if (requestListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = requestListView.SelectedItems[0];

                _ = data.SendDeleteRequestRequestAsync(selectedItem.SubItems[0].Text);
            }
        }
    }
}
