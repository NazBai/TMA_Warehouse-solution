using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TMA
{
    public partial class CreatingRequestForm : Form
    {
        public string selectedRequestId { get; set; }
        public bool insertingNewRecord = false;
        private DataManager data;
        private string selectedItemQuantity;
        public CreatingRequestForm(DataManager data)
        {
            InitializeComponent();
            this.data = data;
            string[] unitsOfMeasurnemt = { "Piece", "CM", "GR", "ML" };
            data.itemNames = itemNameListBox;
            unitOfMeasurementListBox.Items.AddRange(unitsOfMeasurnemt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextFild.Text == "" || itemNameListBox.SelectedItem == null || unitOfMeasurementListBox.SelectedItem == null ||
                                            quantityTexBox.Text == "" || priceTextBox.Text == "")
            {
                MessageBox.Show("Please fill all mandatory filds", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            } else
            {
                if (insertingNewRecord)
                {
                    _ = data.SendPostRequestRequestAsync(nameTextFild.Text, commentTextBox.Text,
                        "New", itemNameListBox.SelectedItem.ToString(), unitOfMeasurementListBox.SelectedItem.ToString(), quantityTexBox.Text, priceTextBox.Text);
                } else
                {
                    _ = data.SendPostRequestRowRequestAsync(selectedRequestId, commentTextBox.Text,
                                                         itemNameListBox.SelectedItem.ToString(), unitOfMeasurementListBox.SelectedItem.ToString(), quantityTexBox.Text, priceTextBox.Text);
                    MessageBox.Show("Request updated");
                }

                Hide();

            }

            itemNameListBox.SelectedIndex = -1;
            commentTextBox.Clear();
            quantityTexBox.Clear();
            priceTextBox.Clear();
            unitOfMeasurementListBox.SelectedIndex = -1;
            insertingNewRecord = false;


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!decimal.TryParse(textBox.Text, out _) && textBox.Text != "")
            {
                MessageBox.Show("Please enter a valid decimal value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                e.Cancel = true; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CreatingRequestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                this.Hide();
            }
        }

        private void itemNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemNameListBox.SelectedIndex != -1)
            {
                selectedItemQuantity = data.GetQuantityByName(itemNameListBox.SelectedItem.ToString());
                quantityTexBox.Text = selectedItemQuantity;
            }
            
        }

        private void quantityTexBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(quantityTexBox.Text, out int enteredValue) && int.TryParse(selectedItemQuantity, out int maxValue))
            {
                if (enteredValue > maxValue)
                {
                    quantityTexBox.Text = selectedItemQuantity;
                }
            }
            else
            {
                
                quantityTexBox.Text = "";
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
