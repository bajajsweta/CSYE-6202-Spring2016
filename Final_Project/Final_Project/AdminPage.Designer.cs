namespace Final_Project
{
    partial class AdminPage
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_flightdetails = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_flightScheduleDetails = new System.Windows.Forms.DataGridView();
            this.delete_Button = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.update_Button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_CrewDetails = new System.Windows.Forms.DataGridView();
            this.crewDelete_Button = new System.Windows.Forms.Button();
            this.crewAdd_Button = new System.Windows.Forms.Button();
            this.crewUpdate_Button = new System.Windows.Forms.Button();
            this.view_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flightdetails)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flightScheduleDetails)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CrewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv_flightdetails
            // 
            this.dgv_flightdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_flightdetails.Location = new System.Drawing.Point(26, 23);
            this.dgv_flightdetails.Name = "dgv_flightdetails";
            this.dgv_flightdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_flightdetails.Size = new System.Drawing.Size(480, 150);
            this.dgv_flightdetails.TabIndex = 4;
            this.dgv_flightdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_details_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 418);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_flightdetails);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Flight Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.view_Button);
            this.tabPage2.Controls.Add(this.dgv_flightScheduleDetails);
            this.tabPage2.Controls.Add(this.delete_Button);
            this.tabPage2.Controls.Add(this.add_Button);
            this.tabPage2.Controls.Add(this.update_Button);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flight Schedule Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_flightScheduleDetails
            // 
            this.dgv_flightScheduleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_flightScheduleDetails.Location = new System.Drawing.Point(35, 200);
            this.dgv_flightScheduleDetails.Name = "dgv_flightScheduleDetails";
            this.dgv_flightScheduleDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_flightScheduleDetails.Size = new System.Drawing.Size(605, 150);
            this.dgv_flightScheduleDetails.TabIndex = 8;
            // 
            // delete_Button
            // 
            this.delete_Button.Location = new System.Drawing.Point(530, 103);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(110, 41);
            this.delete_Button.TabIndex = 7;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            // 
            // add_Button
            // 
            this.add_Button.Location = new System.Drawing.Point(530, 6);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(110, 46);
            this.add_Button.TabIndex = 5;
            this.add_Button.Text = "Add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.button5_Click);
            // 
            // update_Button
            // 
            this.update_Button.Location = new System.Drawing.Point(530, 58);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(110, 39);
            this.update_Button.TabIndex = 6;
            this.update_Button.Text = "Update";
            this.update_Button.UseVisualStyleBackColor = true;
            this.update_Button.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_CrewDetails);
            this.tabPage3.Controls.Add(this.crewDelete_Button);
            this.tabPage3.Controls.Add(this.crewAdd_Button);
            this.tabPage3.Controls.Add(this.crewUpdate_Button);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(675, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Flight Crew Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_CrewDetails
            // 
            this.dgv_CrewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CrewDetails.Location = new System.Drawing.Point(35, 200);
            this.dgv_CrewDetails.Name = "dgv_CrewDetails";
            this.dgv_CrewDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CrewDetails.Size = new System.Drawing.Size(605, 150);
            this.dgv_CrewDetails.TabIndex = 8;
            // 
            // crewDelete_Button
            // 
            this.crewDelete_Button.Location = new System.Drawing.Point(530, 139);
            this.crewDelete_Button.Name = "crewDelete_Button";
            this.crewDelete_Button.Size = new System.Drawing.Size(110, 41);
            this.crewDelete_Button.TabIndex = 7;
            this.crewDelete_Button.Text = "Delete";
            this.crewDelete_Button.UseVisualStyleBackColor = true;
            this.crewDelete_Button.Click += new System.EventHandler(this.button7_Click);
            // 
            // crewAdd_Button
            // 
            this.crewAdd_Button.Location = new System.Drawing.Point(530, 42);
            this.crewAdd_Button.Name = "crewAdd_Button";
            this.crewAdd_Button.Size = new System.Drawing.Size(110, 46);
            this.crewAdd_Button.TabIndex = 5;
            this.crewAdd_Button.Text = "Add";
            this.crewAdd_Button.UseVisualStyleBackColor = true;
            this.crewAdd_Button.Click += new System.EventHandler(this.button8_Click);
            // 
            // crewUpdate_Button
            // 
            this.crewUpdate_Button.Location = new System.Drawing.Point(530, 94);
            this.crewUpdate_Button.Name = "crewUpdate_Button";
            this.crewUpdate_Button.Size = new System.Drawing.Size(110, 39);
            this.crewUpdate_Button.TabIndex = 6;
            this.crewUpdate_Button.Text = "Update";
            this.crewUpdate_Button.UseVisualStyleBackColor = true;
            this.crewUpdate_Button.Click += new System.EventHandler(this.button9_Click);
            // 
            // view_Button
            // 
            this.view_Button.Location = new System.Drawing.Point(530, 150);
            this.view_Button.Name = "view_Button";
            this.view_Button.Size = new System.Drawing.Size(110, 41);
            this.view_Button.TabIndex = 9;
            this.view_Button.Text = "View Details";
            this.view_Button.UseVisualStyleBackColor = true;
            this.view_Button.Click += new System.EventHandler(this.view_Button_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPage";
            this.Text = "Administrator Page";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flightdetails)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flightScheduleDetails)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CrewDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv_flightdetails;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_flightScheduleDetails;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Button update_Button;
        private System.Windows.Forms.DataGridView dgv_CrewDetails;
        private System.Windows.Forms.Button crewDelete_Button;
        private System.Windows.Forms.Button crewAdd_Button;
        private System.Windows.Forms.Button crewUpdate_Button;
        private System.Windows.Forms.Button view_Button;
    }
}