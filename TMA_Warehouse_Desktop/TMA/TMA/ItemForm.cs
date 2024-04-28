using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMA
{
    public partial class ItemForm : Form
    {
        public bool inserting { get; set; }
        private DataManager data { get; set; }
        public string itemId { get; set; }
        public ItemForm(DataManager data)
        {
            InitializeComponent();
            string[] unitsOfMeasurnemt = { "Piece", "CM", "GR", "ML" };
            string[] itemGroups = { "Electronics", "Home Appliances", "Office Supplies", "Building Materials", "Furniture" };
            itemGroupComboBox.Items.AddRange(itemGroups);
            unitOfMeasurementComboBox.Items.AddRange(unitsOfMeasurnemt);
            this.data = data;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( itemNameTextBox.Text == "" || itemGroupComboBox.SelectedItem == null || unitOfMeasurementComboBox.SelectedItem == null ||
                                            quantityTextBox.Text == "" || priceTextBox.Text == "" || statusTextBox.Text == "")
            {
                MessageBox.Show("Please fill all mandatory filds", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            } else {

                if (inserting)
                {

                    _ = data.SendPostItemRequestAsync(itemNameTextBox.Text, itemGroupComboBox.SelectedItem.ToString(), unitOfMeasurementComboBox.SelectedItem.ToString(),
                                           quantityTextBox.Text, priceTextBox.Text, statusTextBox.Text, storageLocationTextBox.Text, contactPersonTextBox.Text);
                }
                else
                {

                    _ = data.SendPutItemRequestAsync(itemId, itemNameTextBox.Text, itemGroupComboBox.SelectedItem.ToString(), unitOfMeasurementComboBox.SelectedItem.ToString(),
                                           quantityTextBox.Text, priceTextBox.Text, statusTextBox.Text, storageLocationTextBox.Text, contactPersonTextBox.Text);
                }
            }

            itemNameTextBox.Clear();
            quantityTextBox.Clear();
            itemGroupComboBox.SelectedIndex = -1;
            unitOfMeasurementComboBox.SelectedIndex = -1;
            priceTextBox.Clear(); 
            statusTextBox.Clear();
            storageLocationTextBox.Clear();
            contactPersonTextBox.Clear();

            inserting = false;
            Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!decimal.TryParse(textBox.Text, out _) && textBox.Text == "")
            {
                MessageBox.Show("Please enter a valid decimal value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                e.Cancel = true; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void fillFormFilds(string name, string itemGroup, string unitOfMesurment, 
                                    string quantity, string price, string status, string storageLocation, string contactPerson)
        {
            itemNameTextBox.Text = name;
            itemGroupComboBox.SelectedItem = itemGroupComboBox.Items[itemGroupComboBox.Items.IndexOf(itemGroup)];
            unitOfMeasurementComboBox.SelectedItem = unitOfMeasurementComboBox.Items[unitOfMeasurementComboBox.Items.IndexOf(unitOfMesurment)];
            quantityTextBox.Text = quantity;
            priceTextBox.Text = price;
            statusTextBox.Text = status;
            storageLocationTextBox.Text = storageLocation;
            contactPersonTextBox.Text = contactPerson;

        }

        private void ItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                this.Hide();
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
