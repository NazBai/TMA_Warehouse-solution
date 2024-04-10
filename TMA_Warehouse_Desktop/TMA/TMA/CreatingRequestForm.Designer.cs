namespace TMA
{
    partial class CreatingRequestForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextFild = new System.Windows.Forms.TextBox();
            this.itemNameListBox = new System.Windows.Forms.ListBox();
            this.unitOfMeasurementListBox = new System.Windows.Forms.ListBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.quantityTexBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 848);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 712);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 77);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 58);
            this.label6.TabIndex = 6;
            this.label6.Text = "Comment\r\n(Optional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price Vithout VAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Uniy Of Measurement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee name";
            // 
            // nameTextFild
            // 
            this.nameTextFild.Location = new System.Drawing.Point(274, 46);
            this.nameTextFild.Name = "nameTextFild";
            this.nameTextFild.Size = new System.Drawing.Size(295, 35);
            this.nameTextFild.TabIndex = 1;
            // 
            // itemNameListBox
            // 
            this.itemNameListBox.FormattingEnabled = true;
            this.itemNameListBox.ItemHeight = 29;
            this.itemNameListBox.Location = new System.Drawing.Point(276, 140);
            this.itemNameListBox.Name = "itemNameListBox";
            this.itemNameListBox.Size = new System.Drawing.Size(293, 91);
            this.itemNameListBox.TabIndex = 2;
            this.itemNameListBox.SelectedIndexChanged += new System.EventHandler(this.itemNameListBox_SelectedIndexChanged);
            // 
            // unitOfMeasurementListBox
            // 
            this.unitOfMeasurementListBox.FormattingEnabled = true;
            this.unitOfMeasurementListBox.ItemHeight = 29;
            this.unitOfMeasurementListBox.Location = new System.Drawing.Point(277, 260);
            this.unitOfMeasurementListBox.Name = "unitOfMeasurementListBox";
            this.unitOfMeasurementListBox.Size = new System.Drawing.Size(292, 91);
            this.unitOfMeasurementListBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(277, 459);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(292, 35);
            this.priceTextBox.TabIndex = 4;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.priceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(274, 556);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(295, 111);
            this.commentTextBox.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 715);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 75);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // quantityTexBox
            // 
            this.quantityTexBox.Location = new System.Drawing.Point(277, 390);
            this.quantityTexBox.Name = "quantityTexBox";
            this.quantityTexBox.Size = new System.Drawing.Size(292, 35);
            this.quantityTexBox.TabIndex = 7;
            this.quantityTexBox.TextChanged += new System.EventHandler(this.quantityTexBox_TextChanged);
            this.quantityTexBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // CreatingRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 848);
            this.Controls.Add(this.quantityTexBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.unitOfMeasurementListBox);
            this.Controls.Add(this.itemNameListBox);
            this.Controls.Add(this.nameTextFild);
            this.Controls.Add(this.panel1);
            this.Name = "CreatingRequestForm";
            this.Text = "CreatingRequestForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreatingRequestForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextFild;
        private System.Windows.Forms.ListBox itemNameListBox;
        private System.Windows.Forms.ListBox unitOfMeasurementListBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTexBox;
    }
}