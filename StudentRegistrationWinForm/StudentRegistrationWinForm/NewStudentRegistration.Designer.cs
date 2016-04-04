namespace StudentRegistrationWinForm
{
    partial class NewStudentRegistration
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
            this.groupBox_registerstudentInfo = new System.Windows.Forms.GroupBox();
            this.groupBox_registerTypegroup = new System.Windows.Forms.GroupBox();
            this.rb_registerenrollType2 = new System.Windows.Forms.RadioButton();
            this.rb_registerenrollType1 = new System.Windows.Forms.RadioButton();
            this.txt_registerlastName = new System.Windows.Forms.TextBox();
            this.label_registerlastName = new System.Windows.Forms.Label();
            this.txt_registerfirstName = new System.Windows.Forms.TextBox();
            this.label_registerfirstName = new System.Windows.Forms.Label();
            this.txt_registerstudentID = new System.Windows.Forms.TextBox();
            this.label_registerstudentID = new System.Windows.Forms.Label();
            this.button_resetStudent = new System.Windows.Forms.Button();
            this.button_addStudent = new System.Windows.Forms.Button();
            this.groupBox_registerstudentInfo.SuspendLayout();
            this.groupBox_registerTypegroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_registerstudentInfo
            // 
            this.groupBox_registerstudentInfo.Controls.Add(this.groupBox_registerTypegroup);
            this.groupBox_registerstudentInfo.Controls.Add(this.txt_registerlastName);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_registerlastName);
            this.groupBox_registerstudentInfo.Controls.Add(this.txt_registerfirstName);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_registerfirstName);
            this.groupBox_registerstudentInfo.Controls.Add(this.txt_registerstudentID);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_registerstudentID);
            this.groupBox_registerstudentInfo.Location = new System.Drawing.Point(21, 30);
            this.groupBox_registerstudentInfo.Name = "groupBox_registerstudentInfo";
            this.groupBox_registerstudentInfo.Size = new System.Drawing.Size(531, 188);
            this.groupBox_registerstudentInfo.TabIndex = 1;
            this.groupBox_registerstudentInfo.TabStop = false;
            this.groupBox_registerstudentInfo.Text = "Student Info";
            // 
            // groupBox_registerTypegroup
            // 
            this.groupBox_registerTypegroup.Controls.Add(this.rb_registerenrollType2);
            this.groupBox_registerTypegroup.Controls.Add(this.rb_registerenrollType1);
            this.groupBox_registerTypegroup.Location = new System.Drawing.Point(282, 28);
            this.groupBox_registerTypegroup.Name = "groupBox_registerTypegroup";
            this.groupBox_registerTypegroup.Size = new System.Drawing.Size(228, 132);
            this.groupBox_registerTypegroup.TabIndex = 6;
            this.groupBox_registerTypegroup.TabStop = false;
            this.groupBox_registerTypegroup.Text = "Enrollment Type";
            // 
            // rb_registerenrollType2
            // 
            this.rb_registerenrollType2.AutoSize = true;
            this.rb_registerenrollType2.Location = new System.Drawing.Point(119, 51);
            this.rb_registerenrollType2.Name = "rb_registerenrollType2";
            this.rb_registerenrollType2.Size = new System.Drawing.Size(70, 17);
            this.rb_registerenrollType2.TabIndex = 1;
            this.rb_registerenrollType2.TabStop = true;
            this.rb_registerenrollType2.Text = "Part Time";
            this.rb_registerenrollType2.UseVisualStyleBackColor = true;
            // 
            // rb_registerenrollType1
            // 
            this.rb_registerenrollType1.AutoSize = true;
            this.rb_registerenrollType1.Location = new System.Drawing.Point(16, 51);
            this.rb_registerenrollType1.Name = "rb_registerenrollType1";
            this.rb_registerenrollType1.Size = new System.Drawing.Size(67, 17);
            this.rb_registerenrollType1.TabIndex = 0;
            this.rb_registerenrollType1.TabStop = true;
            this.rb_registerenrollType1.Text = "Full Time";
            this.rb_registerenrollType1.UseVisualStyleBackColor = true;
            // 
            // txt_registerlastName
            // 
            this.txt_registerlastName.Location = new System.Drawing.Point(123, 96);
            this.txt_registerlastName.Name = "txt_registerlastName";
            this.txt_registerlastName.Size = new System.Drawing.Size(140, 20);
            this.txt_registerlastName.TabIndex = 5;
            // 
            // label_registerlastName
            // 
            this.label_registerlastName.AutoSize = true;
            this.label_registerlastName.Location = new System.Drawing.Point(26, 99);
            this.label_registerlastName.Name = "label_registerlastName";
            this.label_registerlastName.Size = new System.Drawing.Size(53, 13);
            this.label_registerlastName.TabIndex = 4;
            this.label_registerlastName.Text = "Last Time";
            // 
            // txt_registerfirstName
            // 
            this.txt_registerfirstName.Location = new System.Drawing.Point(123, 62);
            this.txt_registerfirstName.Name = "txt_registerfirstName";
            this.txt_registerfirstName.Size = new System.Drawing.Size(140, 20);
            this.txt_registerfirstName.TabIndex = 3;
            // 
            // label_registerfirstName
            // 
            this.label_registerfirstName.AutoSize = true;
            this.label_registerfirstName.Location = new System.Drawing.Point(26, 70);
            this.label_registerfirstName.Name = "label_registerfirstName";
            this.label_registerfirstName.Size = new System.Drawing.Size(57, 13);
            this.label_registerfirstName.TabIndex = 2;
            this.label_registerfirstName.Text = "First Name";
            // 
            // txt_registerstudentID
            // 
            this.txt_registerstudentID.Location = new System.Drawing.Point(123, 28);
            this.txt_registerstudentID.Name = "txt_registerstudentID";
            this.txt_registerstudentID.Size = new System.Drawing.Size(140, 20);
            this.txt_registerstudentID.TabIndex = 1;
            this.txt_registerstudentID.TextChanged += new System.EventHandler(this.txt_registerstudentID_TextChanged);
            // 
            // label_registerstudentID
            // 
            this.label_registerstudentID.AutoSize = true;
            this.label_registerstudentID.Location = new System.Drawing.Point(26, 36);
            this.label_registerstudentID.Name = "label_registerstudentID";
            this.label_registerstudentID.Size = new System.Drawing.Size(58, 13);
            this.label_registerstudentID.TabIndex = 0;
            this.label_registerstudentID.Text = "Student ID";
            // 
            // button_resetStudent
            // 
            this.button_resetStudent.Location = new System.Drawing.Point(453, 224);
            this.button_resetStudent.Name = "button_resetStudent";
            this.button_resetStudent.Size = new System.Drawing.Size(99, 46);
            this.button_resetStudent.TabIndex = 5;
            this.button_resetStudent.Text = "Reset Student";
            this.button_resetStudent.UseVisualStyleBackColor = true;
            // 
            // button_addStudent
            // 
            this.button_addStudent.Location = new System.Drawing.Point(330, 224);
            this.button_addStudent.Name = "button_addStudent";
            this.button_addStudent.Size = new System.Drawing.Size(99, 46);
            this.button_addStudent.TabIndex = 4;
            this.button_addStudent.Text = "Add Student";
            this.button_addStudent.UseVisualStyleBackColor = true;
            // 
            // NewStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 321);
            this.Controls.Add(this.button_resetStudent);
            this.Controls.Add(this.button_addStudent);
            this.Controls.Add(this.groupBox_registerstudentInfo);
            this.Name = "NewStudentRegistration";
            this.Text = "New Student Registration";
            this.groupBox_registerstudentInfo.ResumeLayout(false);
            this.groupBox_registerstudentInfo.PerformLayout();
            this.groupBox_registerTypegroup.ResumeLayout(false);
            this.groupBox_registerTypegroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_registerstudentInfo;
        private System.Windows.Forms.GroupBox groupBox_registerTypegroup;
        private System.Windows.Forms.RadioButton rb_registerenrollType2;
        private System.Windows.Forms.RadioButton rb_registerenrollType1;
        private System.Windows.Forms.TextBox txt_registerlastName;
        private System.Windows.Forms.Label label_registerlastName;
        private System.Windows.Forms.TextBox txt_registerfirstName;
        private System.Windows.Forms.Label label_registerfirstName;
        private System.Windows.Forms.TextBox txt_registerstudentID;
        private System.Windows.Forms.Label label_registerstudentID;
        private System.Windows.Forms.Button button_resetStudent;
        private System.Windows.Forms.Button button_addStudent;
    }
}