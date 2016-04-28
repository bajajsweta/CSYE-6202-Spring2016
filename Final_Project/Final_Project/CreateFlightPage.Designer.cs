namespace Final_Project
{
    partial class CreateFlightPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.noOfSeats_txt = new System.Windows.Forms.TextBox();
            this.flightcarrier_txt = new System.Windows.Forms.TextBox();
            this.flightname_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noOfSeats_txt
            // 
            this.noOfSeats_txt.Location = new System.Drawing.Point(199, 159);
            this.noOfSeats_txt.Name = "noOfSeats_txt";
            this.noOfSeats_txt.Size = new System.Drawing.Size(163, 20);
            this.noOfSeats_txt.TabIndex = 27;
            this.noOfSeats_txt.TextChanged += new System.EventHandler(this.noOfSeats_txt_TextChanged);
            // 
            // flightcarrier_txt
            // 
            this.flightcarrier_txt.Location = new System.Drawing.Point(199, 123);
            this.flightcarrier_txt.Name = "flightcarrier_txt";
            this.flightcarrier_txt.Size = new System.Drawing.Size(163, 20);
            this.flightcarrier_txt.TabIndex = 26;
            this.flightcarrier_txt.TextChanged += new System.EventHandler(this.flightcarrier_txt_TextChanged);
            // 
            // flightname_txt
            // 
            this.flightname_txt.Location = new System.Drawing.Point(199, 91);
            this.flightname_txt.Name = "flightname_txt";
            this.flightname_txt.Size = new System.Drawing.Size(163, 20);
            this.flightname_txt.TabIndex = 25;
            this.flightname_txt.TextChanged += new System.EventHandler(this.flightname_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "No. of Seats";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Flight Carrier";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Flight Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(22, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 40);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Create Flight ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CreateFlightPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(418, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.noOfSeats_txt);
            this.Controls.Add(this.flightcarrier_txt);
            this.Controls.Add(this.flightname_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "CreateFlightPage";
            this.Text = "CreateFlightPage";
            this.Load += new System.EventHandler(this.CreateFlightPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox noOfSeats_txt;
        private System.Windows.Forms.TextBox flightcarrier_txt;
        private System.Windows.Forms.TextBox flightname_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}