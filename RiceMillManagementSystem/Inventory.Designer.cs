namespace RiceMillManagementSystem
{
    partial class Inventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxItemName = new System.Windows.Forms.ComboBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxMinQuantity = new System.Windows.Forms.TextBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 77);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(492, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(610, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Minimum Quantity:";
            // 
            // comboBoxItemName
            // 
            this.comboBoxItemName.FormattingEnabled = true;
            this.comboBoxItemName.Items.AddRange(new object[] {
            "Paddy",
            "Rice",
            "Bran",
            "Husk"});
            this.comboBoxItemName.Location = new System.Drawing.Point(352, 106);
            this.comboBoxItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxItemName.Name = "comboBoxItemName";
            this.comboBoxItemName.Size = new System.Drawing.Size(234, 28);
            this.comboBoxItemName.TabIndex = 5;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "kg",
            "ton",
            "metric ton"});
            this.comboBoxUnit.Location = new System.Drawing.Point(798, 106);
            this.comboBoxUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(234, 28);
            this.comboBoxUnit.TabIndex = 6;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(334, 160);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(234, 26);
            this.textBoxQuantity.TabIndex = 7;
            // 
            // textBoxMinQuantity
            // 
            this.textBoxMinQuantity.Location = new System.Drawing.Point(805, 160);
            this.textBoxMinQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMinQuantity.Name = "textBoxMinQuantity";
            this.textBoxMinQuantity.Size = new System.Drawing.Size(234, 26);
            this.textBoxMinQuantity.TabIndex = 8;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.ForeColor = System.Drawing.Color.White;
            this.buttonAddItem.Location = new System.Drawing.Point(1065, 100);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(180, 46);
            this.buttonAddItem.TabIndex = 9;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateItem.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateItem.Location = new System.Drawing.Point(1065, 154);
            this.buttonUpdateItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(180, 46);
            this.buttonUpdateItem.TabIndex = 10;
            this.buttonUpdateItem.Text = "Update Item";
            this.buttonUpdateItem.UseVisualStyleBackColor = false;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(1065, 625);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(180, 46);
            this.buttonPrint.TabIndex = 12;
            this.buttonPrint.Text = "Print Inventory";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(246, 215);
            this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 62;
            this.dataGridViewInventory.Size = new System.Drawing.Size(999, 385);
            this.dataGridViewInventory.TabIndex = 11;
            this.dataGridViewInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventory_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(-2, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 736);
            this.panel2.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(5, 636);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 52);
            this.button5.TabIndex = 9;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(5, 576);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(220, 52);
            this.button6.TabIndex = 8;
            this.button6.Text = "Reports";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(5, 517);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(220, 52);
            this.button7.TabIndex = 7;
            this.button7.Text = "Payments";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(5, 457);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(220, 52);
            this.button8.TabIndex = 6;
            this.button8.Text = "Sales";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(6, 396);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "Purchases";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(6, 336);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "Suppliers";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 277);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Customers";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(35, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Welcome";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1382, 820);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.buttonUpdateItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.textBoxMinQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.comboBoxItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inventory";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxItemName;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxMinQuantity;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}