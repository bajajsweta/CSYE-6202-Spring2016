namespace Final_Project
{
    partial class CreateFlightSchedule
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flightname_Combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flightFrom_comboBox = new System.Windows.Forms.ComboBox();
            this.flightTo_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BusinessType_SeatCount = new System.Windows.Forms.TextBox();
            this.crewNumber_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_CrewMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CrewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(21, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(586, 44);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Create Flight Schedule";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Flight Name";
            // 
            // flightname_Combobox
            // 
            this.flightname_Combobox.FormattingEnabled = true;
            this.flightname_Combobox.Location = new System.Drawing.Point(133, 105);
            this.flightname_Combobox.Name = "flightname_Combobox";
            this.flightname_Combobox.Size = new System.Drawing.Size(170, 21);
            this.flightname_Combobox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Flight From";
            // 
            // flightFrom_comboBox
            // 
            this.flightFrom_comboBox.FormattingEnabled = true;
            this.flightFrom_comboBox.Location = new System.Drawing.Point(133, 141);
            this.flightFrom_comboBox.Name = "flightFrom_comboBox";
            this.flightFrom_comboBox.Size = new System.Drawing.Size(170, 21);
            this.flightFrom_comboBox.TabIndex = 22;
            // 
            // flightTo_comboBox
            // 
            this.flightTo_comboBox.FormattingEnabled = true;
            this.flightTo_comboBox.Location = new System.Drawing.Point(133, 179);
            this.flightTo_comboBox.Name = "flightTo_comboBox";
            this.flightTo_comboBox.Size = new System.Drawing.Size(170, 21);
            this.flightTo_comboBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Flight To";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd, MM, yyyy hh:mm:ss tt ";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(133, 217);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerFrom.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Departure Time";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Arrival Time";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd, MM, yyyy hh:mm:ss tt ";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(133, 256);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerTo.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Select Flight Crew";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Business Seats";
            // 
            // BusinessType_SeatCount
            // 
            this.BusinessType_SeatCount.Location = new System.Drawing.Point(133, 296);
            this.BusinessType_SeatCount.Name = "BusinessType_SeatCount";
            this.BusinessType_SeatCount.Size = new System.Drawing.Size(170, 20);
            this.BusinessType_SeatCount.TabIndex = 35;
            // 
            // crewNumber_comboBox
            // 
            this.crewNumber_comboBox.FormattingEnabled = true;
            this.crewNumber_comboBox.Location = new System.Drawing.Point(357, 141);
            this.crewNumber_comboBox.Name = "crewNumber_comboBox";
            this.crewNumber_comboBox.Size = new System.Drawing.Size(168, 21);
            this.crewNumber_comboBox.TabIndex = 36;
            this.crewNumber_comboBox.SelectedIndexChanged += new System.EventHandler(this.crewNumber_comboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Crew Members";
            // 
            // dgv_CrewMembers
            // 
            this.dgv_CrewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CrewMembers.Location = new System.Drawing.Point(357, 217);
            this.dgv_CrewMembers.Name = "dgv_CrewMembers";
            this.dgv_CrewMembers.Size = new System.Drawing.Size(240, 150);
            this.dgv_CrewMembers.TabIndex = 38;
            // 
            // CreateFlightSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(635, 478);
            this.Controls.Add(this.dgv_CrewMembers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.crewNumber_comboBox);
            this.Controls.Add(this.BusinessType_SeatCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.flightTo_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flightFrom_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flightname_Combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "CreateFlightSchedule";
            this.Text = "CreateFlightSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CrewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox flightname_Combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox flightFrom_comboBox;
        private System.Windows.Forms.ComboBox flightTo_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BusinessType_SeatCount;
        private System.Windows.Forms.ComboBox crewNumber_comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_CrewMembers;
    }
}