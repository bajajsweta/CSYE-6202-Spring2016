namespace Final_Project
{
    partial class EmployeeCustomerPage
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
            this.dgv_CommonTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmpDepart_comboBox = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmpNo_of_seats_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpSeatType_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpFlightTo_comboBox = new System.Windows.Forms.ComboBox();
            this.EmpFlightFrom_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgv_bookedTickets = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CommonTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookedTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CommonTable
            // 
            this.dgv_CommonTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CommonTable.Location = new System.Drawing.Point(18, 224);
            this.dgv_CommonTable.Name = "dgv_CommonTable";
            this.dgv_CommonTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CommonTable.Size = new System.Drawing.Size(640, 145);
            this.dgv_CommonTable.TabIndex = 2;
            this.dgv_CommonTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_CommonTable_MouseClick);
            this.dgv_CommonTable.MouseEnter += new System.EventHandler(this.dgv_CommonTable_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmpDepart_comboBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EmpFlightTo_comboBox);
            this.groupBox1.Controls.Add(this.EmpFlightFrom_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flights";
            // 
            // EmpDepart_comboBox
            // 
            this.EmpDepart_comboBox.Location = new System.Drawing.Point(19, 118);
            this.EmpDepart_comboBox.Name = "EmpDepart_comboBox";
            this.EmpDepart_comboBox.Size = new System.Drawing.Size(134, 20);
            this.EmpDepart_comboBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmpNo_of_seats_textbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.EmpSeatType_comboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(376, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 103);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // EmpNo_of_seats_textbox
            // 
            this.EmpNo_of_seats_textbox.Location = new System.Drawing.Point(103, 72);
            this.EmpNo_of_seats_textbox.Name = "EmpNo_of_seats_textbox";
            this.EmpNo_of_seats_textbox.Size = new System.Drawing.Size(134, 20);
            this.EmpNo_of_seats_textbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "No. of Seats";
            // 
            // EmpSeatType_comboBox
            // 
            this.EmpSeatType_comboBox.FormattingEnabled = true;
            this.EmpSeatType_comboBox.Location = new System.Drawing.Point(104, 28);
            this.EmpSeatType_comboBox.Name = "EmpSeatType_comboBox";
            this.EmpSeatType_comboBox.Size = new System.Drawing.Size(134, 21);
            this.EmpSeatType_comboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Travel Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Departing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Flying To";
            // 
            // EmpFlightTo_comboBox
            // 
            this.EmpFlightTo_comboBox.FormattingEnabled = true;
            this.EmpFlightTo_comboBox.Location = new System.Drawing.Point(190, 50);
            this.EmpFlightTo_comboBox.Name = "EmpFlightTo_comboBox";
            this.EmpFlightTo_comboBox.Size = new System.Drawing.Size(134, 21);
            this.EmpFlightTo_comboBox.TabIndex = 2;
            // 
            // EmpFlightFrom_comboBox
            // 
            this.EmpFlightFrom_comboBox.FormattingEnabled = true;
            this.EmpFlightFrom_comboBox.Location = new System.Drawing.Point(19, 50);
            this.EmpFlightFrom_comboBox.Name = "EmpFlightFrom_comboBox";
            this.EmpFlightFrom_comboBox.Size = new System.Drawing.Size(134, 21);
            this.EmpFlightFrom_comboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flying From";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 461);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgv_CommonTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book Tickets";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.dgv_bookedTickets);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Booked Tickets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Booked Flights";
            // 
            // dgv_bookedTickets
            // 
            this.dgv_bookedTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bookedTickets.Location = new System.Drawing.Point(15, 78);
            this.dgv_bookedTickets.Name = "dgv_bookedTickets";
            this.dgv_bookedTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bookedTickets.Size = new System.Drawing.Size(542, 302);
            this.dgv_bookedTickets.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(582, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 48);
            this.button3.TabIndex = 9;
            this.button3.Text = "UnBook Ticket";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EmployeeCustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 533);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "EmployeeCustomerPage";
            this.Text = "EmployeePage";
            this.Load += new System.EventHandler(this.button2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CommonTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookedTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_CommonTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker EmpDepart_comboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox EmpNo_of_seats_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EmpSeatType_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EmpFlightTo_comboBox;
        private System.Windows.Forms.ComboBox EmpFlightFrom_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgv_bookedTickets;
        private System.Windows.Forms.Button button3;
    }
}