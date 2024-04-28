using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TMA
{
    public partial class RequestForm : Form
    {
        public DataManager data { set; get; }
        public RequestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem selectedRequest = data.requestData.SelectedItems[0];
            _ = data.SendPutRequestRequestAsync(selectedRequest.SubItems[0].Text, selectedRequest.SubItems[1].Text, commentTextBox.Text, "Confirmd");
            data.ReduseItemsQuantiry();
            Hide();

            
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem selectedRequest = data.requestData.SelectedItems[0];
            _ = data.SendPutRequestRequestAsync(selectedRequest.SubItems[0].Text, selectedRequest.SubItems[1].Text, commentTextBox.Text, "Rejected");
            Hide();

        }

        private void RequestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                this.Hide();
            }
        }

        private void requestRowList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
