namespace TMA
{
    partial class ItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.itemGroupComboBox = new System.Windows.Forms.ComboBox();
            this.unitOfMeasurementComboBox = new System.Windows.Forms.ComboBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.storageLocationTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price without VAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unit of measurement";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Item Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 58);
            this.label7.TabIndex = 6;
            this.label7.Text = "Storage location\r\n(Optional)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 629);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 58);
            this.label8.TabIndex = 7;
            this.label8.Text = "Contact Person\r\n(Optional)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 796);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 74);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 796);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 74);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(348, 379);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(234, 35);
            this.priceTextBox.TabIndex = 14;
            this.priceTextBox.Text = " ";
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            this.priceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.Location = new System.Drawing.Point(348, 638);
            this.contactPersonTextBox.MaximumSize = new System.Drawing.Size(200, 200);
            this.contactPersonTextBox.Multiline = true;
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(200, 65);
            this.contactPersonTextBox.TabIndex = 17;
            // 
            // itemGroupComboBox
            // 
            this.itemGroupComboBox.FormattingEnabled = true;
            this.itemGroupComboBox.Location = new System.Drawing.Point(348, 119);
            this.itemGroupComboBox.Name = "itemGroupComboBox";
            this.itemGroupComboBox.Size = new System.Drawing.Size(234, 37);
            this.itemGroupComboBox.TabIndex = 19;
            this.itemGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // unitOfMeasurementComboBox
            // 
            this.unitOfMeasurementComboBox.FormattingEnabled = true;
            this.unitOfMeasurementComboBox.Location = new System.Drawing.Point(348, 206);
            this.unitOfMeasurementComboBox.Name = "unitOfMeasurementComboBox";
            this.unitOfMeasurementComboBox.Size = new System.Drawing.Size(234, 37);
            this.unitOfMeasurementComboBox.TabIndex = 20;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(348, 466);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(234, 35);
            this.statusTextBox.TabIndex = 21;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(348, 292);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(234, 35);
            this.quantityTextBox.TabIndex = 22;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 903);
            this.panel1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "Name";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(348, 36);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(234, 35);
            this.itemNameTextBox.TabIndex = 24;
            // 
            // storageLocationTextBox
            // 
            this.storageLocationTextBox.Location = new System.Drawing.Point(348, 546);
            this.storageLocationTextBox.Name = "storageLocationTextBox";
            this.storageLocationTextBox.Size = new System.Drawing.Size(234, 35);
            this.storageLocationTextBox.TabIndex = 25;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 906);
            this.Controls.Add(this.storageLocationTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.unitOfMeasurementComboBox);
            this.Controls.Add(this.itemGroupComboBox);
            this.Controls.Add(this.contactPersonTextBox);
            this.Controls.Add(this.priceTextBox);
            this.MaximumSize = new System.Drawing.Size(646, 985);
            this.MinimumSize = new System.Drawing.Size(646, 985);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemForm_FormClosing);
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.ComboBox itemGroupComboBox;
        private System.Windows.Forms.ComboBox unitOfMeasurementComboBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox storageLocationTextBox;
    }
}