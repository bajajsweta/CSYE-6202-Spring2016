namespace Final_Project
{
    partial class CommonPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Depart_comboBox = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.No_of_seats_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.seatType_CombBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FlightTo_comboBox = new System.Windows.Forms.ComboBox();
            this.FlightFrom_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_CommonTable = new System.Windows.Forms.DataGridView();
            this.login_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CommonTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Depart_comboBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FlightTo_comboBox);
            this.groupBox1.Controls.Add(this.FlightFrom_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Flights";
            // 
            // Depart_comboBox
            // 
            this.Depart_comboBox.Location = new System.Drawing.Point(19, 118);
            this.Depart_comboBox.Name = "Depart_comboBox";
            this.Depart_comboBox.Size = new System.Drawing.Size(134, 20);
            this.Depart_comboBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.No_of_seats_textbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.seatType_CombBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(376, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 103);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // No_of_seats_textbox
            // 
            this.No_of_seats_textbox.Location = new System.Drawing.Point(104, 72);
            this.No_of_seats_textbox.Name = "No_of_seats_textbox";
            this.No_of_seats_textbox.Size = new System.Drawing.Size(134, 20);
            this.No_of_seats_textbox.TabIndex = 11;
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
            // seatType_CombBox
            // 
            this.seatType_CombBox.FormattingEnabled = true;
            this.seatType_CombBox.Items.AddRange(new object[] {
            "Business",
            "Economy"});
            this.seatType_CombBox.Location = new System.Drawing.Point(104, 28);
            this.seatType_CombBox.Name = "seatType_CombBox";
            this.seatType_CombBox.Size = new System.Drawing.Size(134, 21);
            this.seatType_CombBox.TabIndex = 9;
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
            // FlightTo_comboBox
            // 
            this.FlightTo_comboBox.FormattingEnabled = true;
            this.FlightTo_comboBox.Location = new System.Drawing.Point(190, 50);
            this.FlightTo_comboBox.Name = "FlightTo_comboBox";
            this.FlightTo_comboBox.Size = new System.Drawing.Size(134, 21);
            this.FlightTo_comboBox.TabIndex = 2;
            // 
            // FlightFrom_comboBox
            // 
            this.FlightFrom_comboBox.FormattingEnabled = true;
            this.FlightFrom_comboBox.Location = new System.Drawing.Point(19, 50);
            this.FlightFrom_comboBox.Name = "FlightFrom_comboBox";
            this.FlightFrom_comboBox.Size = new System.Drawing.Size(134, 21);
            this.FlightFrom_comboBox.TabIndex = 1;
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
            // dgv_CommonTable
            // 
            this.dgv_CommonTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CommonTable.Location = new System.Drawing.Point(24, 286);
            this.dgv_CommonTable.Name = "dgv_CommonTable";
            this.dgv_CommonTable.Size = new System.Drawing.Size(640, 185);
            this.dgv_CommonTable.TabIndex = 1;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_button.Location = new System.Drawing.Point(545, 11);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(119, 43);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "LogIn";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBox2.Location = new System.Drawing.Point(24, 13);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(515, 41);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "WELCOME";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CommonPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(716, 497);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.dgv_CommonTable);
            this.Controls.Add(this.groupBox1);
            this.Name = "CommonPage";
            this.Text = "Common Page";
            this.Load += new System.EventHandler(this.button2_Click);
            this.Click += new System.EventHandler(this.button2_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CommonTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_CommonTable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox No_of_seats_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox seatType_CombBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FlightTo_comboBox;
        private System.Windows.Forms.ComboBox FlightFrom_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker Depart_comboBox;
    }
}