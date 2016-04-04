namespace StudentRegistrationWinForm
{
    partial class StudentRegistrationMainWindow
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
            this.groupBox_studentInfo = new System.Windows.Forms.GroupBox();
            this.comboBox_deptread = new System.Windows.Forms.ComboBox();
            this.label_dept = new System.Windows.Forms.Label();
            this.maskedTextBox_studentid = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_Typegroup = new System.Windows.Forms.GroupBox();
            this.rb_enrollType2 = new System.Windows.Forms.RadioButton();
            this.rb_enrollType1 = new System.Windows.Forms.RadioButton();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.label_studentID = new System.Windows.Forms.Label();
            this.button_newStudent = new System.Windows.Forms.Button();
            this.button_removeStudent = new System.Windows.Forms.Button();
            this.button_editStudent = new System.Windows.Forms.Button();
            this.dgv_studentInfo = new System.Windows.Forms.DataGridView();
            this.groupBox_studentInfo.SuspendLayout();
            this.groupBox_Typegroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_studentInfo
            // 
            this.groupBox_studentInfo.Controls.Add(this.comboBox_deptread);
            this.groupBox_studentInfo.Controls.Add(this.label_dept);
            this.groupBox_studentInfo.Controls.Add(this.maskedTextBox_studentid);
            this.groupBox_studentInfo.Controls.Add(this.groupBox_Typegroup);
            this.groupBox_studentInfo.Controls.Add(this.txt_lastName);
            this.groupBox_studentInfo.Controls.Add(this.label_lastName);
            this.groupBox_studentInfo.Controls.Add(this.txt_firstName);
            this.groupBox_studentInfo.Controls.Add(this.label_firstName);
            this.groupBox_studentInfo.Controls.Add(this.label_studentID);
            this.groupBox_studentInfo.Location = new System.Drawing.Point(13, 13);
            this.groupBox_studentInfo.Name = "groupBox_studentInfo";
            this.groupBox_studentInfo.Size = new System.Drawing.Size(531, 188);
            this.groupBox_studentInfo.TabIndex = 0;
            this.groupBox_studentInfo.TabStop = false;
            this.groupBox_studentInfo.Text = "Student Info";
            // 
            // comboBox_deptread
            // 
            this.comboBox_deptread.Enabled = false;
            this.comboBox_deptread.FormattingEnabled = true;
            this.comboBox_deptread.Location = new System.Drawing.Point(123, 123);
            this.comboBox_deptread.Name = "comboBox_deptread";
            this.comboBox_deptread.Size = new System.Drawing.Size(140, 21);
            this.comboBox_deptread.TabIndex = 10;
            // 
            // label_dept
            // 
            this.label_dept.AutoSize = true;
            this.label_dept.Location = new System.Drawing.Point(26, 126);
            this.label_dept.Name = "label_dept";
            this.label_dept.Size = new System.Drawing.Size(89, 13);
            this.label_dept.TabIndex = 9;
            this.label_dept.Text = "Department Type";
            // 
            // maskedTextBox_studentid
            // 
            this.maskedTextBox_studentid.Enabled = false;
            this.maskedTextBox_studentid.Location = new System.Drawing.Point(123, 36);
            this.maskedTextBox_studentid.Mask = "000-00-0000";
            this.maskedTextBox_studentid.Name = "maskedTextBox_studentid";
            this.maskedTextBox_studentid.PromptChar = ' ';
            this.maskedTextBox_studentid.Size = new System.Drawing.Size(140, 20);
            this.maskedTextBox_studentid.TabIndex = 7;
            // 
            // groupBox_Typegroup
            // 
            this.groupBox_Typegroup.Controls.Add(this.rb_enrollType2);
            this.groupBox_Typegroup.Controls.Add(this.rb_enrollType1);
            this.groupBox_Typegroup.Location = new System.Drawing.Point(282, 28);
            this.groupBox_Typegroup.Name = "groupBox_Typegroup";
            this.groupBox_Typegroup.Size = new System.Drawing.Size(228, 132);
            this.groupBox_Typegroup.TabIndex = 6;
            this.groupBox_Typegroup.TabStop = false;
            this.groupBox_Typegroup.Text = "Enrollment Type";
            // 
            // rb_enrollType2
            // 
            this.rb_enrollType2.AutoSize = true;
            this.rb_enrollType2.Enabled = false;
            this.rb_enrollType2.Location = new System.Drawing.Point(119, 51);
            this.rb_enrollType2.Name = "rb_enrollType2";
            this.rb_enrollType2.Size = new System.Drawing.Size(70, 17);
            this.rb_enrollType2.TabIndex = 1;
            this.rb_enrollType2.TabStop = true;
            this.rb_enrollType2.Text = "Part Time";
            this.rb_enrollType2.UseVisualStyleBackColor = true;
            // 
            // rb_enrollType1
            // 
            this.rb_enrollType1.AutoSize = true;
            this.rb_enrollType1.Enabled = false;
            this.rb_enrollType1.Location = new System.Drawing.Point(16, 51);
            this.rb_enrollType1.Name = "rb_enrollType1";
            this.rb_enrollType1.Size = new System.Drawing.Size(67, 17);
            this.rb_enrollType1.TabIndex = 0;
            this.rb_enrollType1.TabStop = true;
            this.rb_enrollType1.Text = "Full Time";
            this.rb_enrollType1.UseVisualStyleBackColor = true;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Enabled = false;
            this.txt_lastName.Location = new System.Drawing.Point(123, 96);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(140, 20);
            this.txt_lastName.TabIndex = 5;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(26, 99);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(58, 13);
            this.label_lastName.TabIndex = 4;
            this.label_lastName.Text = "Last Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Enabled = false;
            this.txt_firstName.Location = new System.Drawing.Point(123, 67);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(140, 20);
            this.txt_firstName.TabIndex = 3;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(26, 70);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(57, 13);
            this.label_firstName.TabIndex = 2;
            this.label_firstName.Text = "First Name";
            // 
            // label_studentID
            // 
            this.label_studentID.AutoSize = true;
            this.label_studentID.Location = new System.Drawing.Point(26, 36);
            this.label_studentID.Name = "label_studentID";
            this.label_studentID.Size = new System.Drawing.Size(58, 13);
            this.label_studentID.TabIndex = 0;
            this.label_studentID.Text = "Student ID";
            // 
            // button_newStudent
            // 
            this.button_newStudent.Location = new System.Drawing.Point(560, 32);
            this.button_newStudent.Name = "button_newStudent";
            this.button_newStudent.Size = new System.Drawing.Size(99, 46);
            this.button_newStudent.TabIndex = 1;
            this.button_newStudent.Text = "New Student";
            this.button_newStudent.UseVisualStyleBackColor = true;
            this.button_newStudent.Click += new System.EventHandler(this.button_newStudent_Click);
            // 
            // button_removeStudent
            // 
            this.button_removeStudent.Location = new System.Drawing.Point(560, 84);
            this.button_removeStudent.Name = "button_removeStudent";
            this.button_removeStudent.Size = new System.Drawing.Size(99, 46);
            this.button_removeStudent.TabIndex = 2;
            this.button_removeStudent.Text = "Remove Student";
            this.button_removeStudent.UseVisualStyleBackColor = true;
            this.button_removeStudent.Click += new System.EventHandler(this.button_removeStudent_Click);
            // 
            // button_editStudent
            // 
            this.button_editStudent.Location = new System.Drawing.Point(560, 136);
            this.button_editStudent.Name = "button_editStudent";
            this.button_editStudent.Size = new System.Drawing.Size(99, 46);
            this.button_editStudent.TabIndex = 3;
            this.button_editStudent.Text = "Edit Student";
            this.button_editStudent.UseVisualStyleBackColor = true;
            this.button_editStudent.Click += new System.EventHandler(this.button_editStudent_Click);
            // 
            // dgv_studentInfo
            // 
            this.dgv_studentInfo.AllowUserToAddRows = false;
            this.dgv_studentInfo.AllowUserToDeleteRows = false;
            this.dgv_studentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentInfo.Location = new System.Drawing.Point(13, 221);
            this.dgv_studentInfo.Name = "dgv_studentInfo";
            this.dgv_studentInfo.ReadOnly = true;
            this.dgv_studentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_studentInfo.Size = new System.Drawing.Size(531, 232);
            this.dgv_studentInfo.TabIndex = 4;
       //     this.dgv_studentInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_studentInfo_KeyDown);
            this.dgv_studentInfo.MouseEnter += new System.EventHandler(this.dgv_studentInfo_MouseEnter);
            // 
            // StudentRegistrationMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 488);
            this.Controls.Add(this.dgv_studentInfo);
            this.Controls.Add(this.button_editStudent);
            this.Controls.Add(this.button_removeStudent);
            this.Controls.Add(this.button_newStudent);
            this.Controls.Add(this.groupBox_studentInfo);
            this.MaximizeBox = false;
            this.Name = "StudentRegistrationMainWindow";
            this.Text = "Student Registration Main Window";
            this.Load += new System.EventHandler(this.StudentRegistrationMainWindow_Load);
            this.groupBox_studentInfo.ResumeLayout(false);
            this.groupBox_studentInfo.PerformLayout();
            this.groupBox_Typegroup.ResumeLayout(false);
            this.groupBox_Typegroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_studentInfo;
        private System.Windows.Forms.GroupBox groupBox_Typegroup;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Label label_studentID;
        private System.Windows.Forms.RadioButton rb_enrollType2;
        private System.Windows.Forms.RadioButton rb_enrollType1;
        private System.Windows.Forms.Button button_newStudent;
        private System.Windows.Forms.Button button_removeStudent;
        private System.Windows.Forms.Button button_editStudent;
        private System.Windows.Forms.DataGridView dgv_studentInfo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_studentid;
        private System.Windows.Forms.ComboBox comboBox_deptread;
        private System.Windows.Forms.Label label_dept;
    }
}