namespace MVP
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
            this.button_resetStudent = new System.Windows.Forms.Button();
            this.button_addStudent = new System.Windows.Forms.Button();
            this.groupBox_registerstudentInfo = new System.Windows.Forms.GroupBox();
            this.maskedtxt_registerstudentID = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_dept = new System.Windows.Forms.ComboBox();
            this.label_dept = new System.Windows.Forms.Label();
            this.groupBox_registerTypegroup = new System.Windows.Forms.GroupBox();
            this.rb_registerenrollType2 = new System.Windows.Forms.RadioButton();
            this.rb_registerenrollType1 = new System.Windows.Forms.RadioButton();
            this.txt_registerlastName = new System.Windows.Forms.TextBox();
            this.label_registerlastName = new System.Windows.Forms.Label();
            this.txt_registerfirstName = new System.Windows.Forms.TextBox();
            this.label_registerfirstName = new System.Windows.Forms.Label();
            this.label_registerstudentID = new System.Windows.Forms.Label();
            this.groupBox_registerstudentInfo.SuspendLayout();
            this.groupBox_registerTypegroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_resetStudent
            // 
            this.button_resetStudent.Location = new System.Drawing.Point(460, 221);
            this.button_resetStudent.Name = "button_resetStudent";
            this.button_resetStudent.Size = new System.Drawing.Size(99, 46);
            this.button_resetStudent.TabIndex = 8;
            this.button_resetStudent.Text = "Reset Student";
            this.button_resetStudent.UseVisualStyleBackColor = true;
            this.button_resetStudent.CursorChanged += new System.EventHandler(this.button_resetStudent_CursorChanged);
            this.button_resetStudent.Click += new System.EventHandler(this.button_resetStudent_Click);
            // 
            // button_addStudent
            // 
            this.button_addStudent.Location = new System.Drawing.Point(337, 221);
            this.button_addStudent.Name = "button_addStudent";
            this.button_addStudent.Size = new System.Drawing.Size(99, 46);
            this.button_addStudent.TabIndex = 7;
            this.button_addStudent.Text = "Add Student";
            this.button_addStudent.UseVisualStyleBackColor = true;
            this.button_addStudent.Click += new System.EventHandler(this.button_addStudent_Click);
            // 
            // groupBox_registerstudentInfo
            // 
            this.groupBox_registerstudentInfo.Controls.Add(this.maskedtxt_registerstudentID);
            this.groupBox_registerstudentInfo.Controls.Add(this.comboBox_dept);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_dept);
            this.groupBox_registerstudentInfo.Controls.Add(this.groupBox_registerTypegroup);
            this.groupBox_registerstudentInfo.Controls.Add(this.txt_registerlastName);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_registerlastName);
            this.groupBox_registerstudentInfo.Controls.Add(this.txt_registerfirstName);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_registerfirstName);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_registerstudentID);
            this.groupBox_registerstudentInfo.Location = new System.Drawing.Point(28, 27);
            this.groupBox_registerstudentInfo.Name = "groupBox_registerstudentInfo";
            this.groupBox_registerstudentInfo.Size = new System.Drawing.Size(531, 188);
            this.groupBox_registerstudentInfo.TabIndex = 6;
            this.groupBox_registerstudentInfo.TabStop = false;
            this.groupBox_registerstudentInfo.Text = "Student Info";
            this.groupBox_registerstudentInfo.Enter += new System.EventHandler(this.groupBox_registerstudentInfo_Enter);
            // 
            // maskedtxt_registerstudentID
            // 
            this.maskedtxt_registerstudentID.Location = new System.Drawing.Point(123, 28);
            this.maskedtxt_registerstudentID.Mask = "000-00-0000";
            this.maskedtxt_registerstudentID.Name = "maskedtxt_registerstudentID";
            this.maskedtxt_registerstudentID.PromptChar = ' ';
            this.maskedtxt_registerstudentID.Size = new System.Drawing.Size(140, 20);
            this.maskedtxt_registerstudentID.TabIndex = 9;
            this.maskedtxt_registerstudentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedtxt_registerstudentID_KeyDown);
            // 
            // comboBox_dept
            // 
            this.comboBox_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dept.FormattingEnabled = true;
            this.comboBox_dept.Location = new System.Drawing.Point(123, 126);
            this.comboBox_dept.Name = "comboBox_dept";
            this.comboBox_dept.Size = new System.Drawing.Size(140, 21);
            this.comboBox_dept.TabIndex = 8;
            // 
            // label_dept
            // 
            this.label_dept.AutoSize = true;
            this.label_dept.Location = new System.Drawing.Point(26, 126);
            this.label_dept.Name = "label_dept";
            this.label_dept.Size = new System.Drawing.Size(89, 13);
            this.label_dept.TabIndex = 7;
            this.label_dept.Text = "Department Type";
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
            this.rb_registerenrollType2.Text = "Part Time";
            this.rb_registerenrollType2.UseVisualStyleBackColor = true;
            // 
            // rb_registerenrollType1
            // 
            this.rb_registerenrollType1.AutoSize = true;
            this.rb_registerenrollType1.Checked = true;
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
            this.txt_registerlastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_registerlastName_KeyDown);
            this.txt_registerlastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_registerlastName_KeyPress);
            // 
            // label_registerlastName
            // 
            this.label_registerlastName.AutoSize = true;
            this.label_registerlastName.Location = new System.Drawing.Point(26, 99);
            this.label_registerlastName.Name = "label_registerlastName";
            this.label_registerlastName.Size = new System.Drawing.Size(58, 13);
            this.label_registerlastName.TabIndex = 4;
            this.label_registerlastName.Text = "Last Name";
            // 
            // txt_registerfirstName
            // 
            this.txt_registerfirstName.Location = new System.Drawing.Point(123, 62);
            this.txt_registerfirstName.Name = "txt_registerfirstName";
            this.txt_registerfirstName.Size = new System.Drawing.Size(140, 20);
            this.txt_registerfirstName.TabIndex = 3;
            this.txt_registerfirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_registerfirstName_KeyDown);
            this.txt_registerfirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_registerfirstName_KeyPress);
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
            // label_registerstudentID
            // 
            this.label_registerstudentID.AutoSize = true;
            this.label_registerstudentID.Location = new System.Drawing.Point(26, 36);
            this.label_registerstudentID.Name = "label_registerstudentID";
            this.label_registerstudentID.Size = new System.Drawing.Size(58, 13);
            this.label_registerstudentID.TabIndex = 0;
            this.label_registerstudentID.Text = "Student ID";
            // 
            // NewStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 331);
            this.Controls.Add(this.button_resetStudent);
            this.Controls.Add(this.button_addStudent);
            this.Controls.Add(this.groupBox_registerstudentInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewStudentRegistration";
            this.Text = "New Student Registration";
            this.Load += new System.EventHandler(this.NewStudentRegistration_Load);
            this.groupBox_registerstudentInfo.ResumeLayout(false);
            this.groupBox_registerstudentInfo.PerformLayout();
            this.groupBox_registerTypegroup.ResumeLayout(false);
            this.groupBox_registerTypegroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_resetStudent;
        private System.Windows.Forms.Button button_addStudent;
        private System.Windows.Forms.GroupBox groupBox_registerstudentInfo;
        private System.Windows.Forms.GroupBox groupBox_registerTypegroup;
        private System.Windows.Forms.RadioButton rb_registerenrollType2;
        private System.Windows.Forms.RadioButton rb_registerenrollType1;
        private System.Windows.Forms.TextBox txt_registerlastName;
        private System.Windows.Forms.Label label_registerlastName;
        private System.Windows.Forms.TextBox txt_registerfirstName;
        private System.Windows.Forms.Label label_registerfirstName;
        private System.Windows.Forms.Label label_registerstudentID;
        private System.Windows.Forms.ComboBox comboBox_dept;
        private System.Windows.Forms.Label label_dept;
        private System.Windows.Forms.MaskedTextBox maskedtxt_registerstudentID;
    }
}