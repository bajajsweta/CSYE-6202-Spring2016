namespace MVP
{
    partial class EditStudent
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
            this.button_cancelStudent = new System.Windows.Forms.Button();
            this.button_editStudent = new System.Windows.Forms.Button();
            this.groupBox_registerstudentInfo = new System.Windows.Forms.GroupBox();
            this.maskedtxt_editstudentID = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_deptedit = new System.Windows.Forms.ComboBox();
            this.label_editdept = new System.Windows.Forms.Label();
            this.groupBox_registerTypegroup = new System.Windows.Forms.GroupBox();
            this.rb_editenrollType2 = new System.Windows.Forms.RadioButton();
            this.rb_editenrollType1 = new System.Windows.Forms.RadioButton();
            this.txt_editlastName = new System.Windows.Forms.TextBox();
            this.label_editastName = new System.Windows.Forms.Label();
            this.txt_editfirstName = new System.Windows.Forms.TextBox();
            this.label_editfirstName = new System.Windows.Forms.Label();
            this.label_editstudentID = new System.Windows.Forms.Label();
            this.groupBox_registerstudentInfo.SuspendLayout();
            this.groupBox_registerTypegroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cancelStudent
            // 
            this.button_cancelStudent.Location = new System.Drawing.Point(467, 204);
            this.button_cancelStudent.Name = "button_cancelStudent";
            this.button_cancelStudent.Size = new System.Drawing.Size(99, 46);
            this.button_cancelStudent.TabIndex = 11;
            this.button_cancelStudent.Text = "Cancel";
            this.button_cancelStudent.UseVisualStyleBackColor = true;
            this.button_cancelStudent.Click += new System.EventHandler(this.button_cancelStudent_Click);
            // 
            // button_editStudent
            // 
            this.button_editStudent.Location = new System.Drawing.Point(344, 204);
            this.button_editStudent.Name = "button_editStudent";
            this.button_editStudent.Size = new System.Drawing.Size(99, 46);
            this.button_editStudent.TabIndex = 10;
            this.button_editStudent.Text = "Update";
            this.button_editStudent.UseVisualStyleBackColor = true;
            this.button_editStudent.Click += new System.EventHandler(this.button_editStudent_Click);
            // 
            // groupBox_registerstudentInfo
            // 
            this.groupBox_registerstudentInfo.Controls.Add(this.maskedtxt_editstudentID);
            this.groupBox_registerstudentInfo.Controls.Add(this.comboBox_deptedit);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_editdept);
            this.groupBox_registerstudentInfo.Controls.Add(this.groupBox_registerTypegroup);
            this.groupBox_registerstudentInfo.Controls.Add(this.txt_editlastName);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_editastName);
            this.groupBox_registerstudentInfo.Controls.Add(this.txt_editfirstName);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_editfirstName);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_editstudentID);
            this.groupBox_registerstudentInfo.Location = new System.Drawing.Point(35, 10);
            this.groupBox_registerstudentInfo.Name = "groupBox_registerstudentInfo";
            this.groupBox_registerstudentInfo.Size = new System.Drawing.Size(531, 188);
            this.groupBox_registerstudentInfo.TabIndex = 9;
            this.groupBox_registerstudentInfo.TabStop = false;
            this.groupBox_registerstudentInfo.Text = "Student Info";
            // 
            // maskedtxt_editstudentID
            // 
            this.maskedtxt_editstudentID.Location = new System.Drawing.Point(123, 28);
            this.maskedtxt_editstudentID.Mask = "000-00-0000";
            this.maskedtxt_editstudentID.Name = "maskedtxt_editstudentID";
            this.maskedtxt_editstudentID.PromptChar = ' ';
            this.maskedtxt_editstudentID.Size = new System.Drawing.Size(140, 20);
            this.maskedtxt_editstudentID.TabIndex = 9;
            // 
            // comboBox_deptedit
            // 
            this.comboBox_deptedit.FormattingEnabled = true;
            this.comboBox_deptedit.Location = new System.Drawing.Point(123, 126);
            this.comboBox_deptedit.Name = "comboBox_deptedit";
            this.comboBox_deptedit.Size = new System.Drawing.Size(140, 21);
            this.comboBox_deptedit.TabIndex = 8;
            // 
            // label_editdept
            // 
            this.label_editdept.AutoSize = true;
            this.label_editdept.Location = new System.Drawing.Point(26, 126);
            this.label_editdept.Name = "label_editdept";
            this.label_editdept.Size = new System.Drawing.Size(89, 13);
            this.label_editdept.TabIndex = 7;
            this.label_editdept.Text = "Department Type";
            // 
            // groupBox_registerTypegroup
            // 
            this.groupBox_registerTypegroup.Controls.Add(this.rb_editenrollType2);
            this.groupBox_registerTypegroup.Controls.Add(this.rb_editenrollType1);
            this.groupBox_registerTypegroup.Location = new System.Drawing.Point(282, 28);
            this.groupBox_registerTypegroup.Name = "groupBox_registerTypegroup";
            this.groupBox_registerTypegroup.Size = new System.Drawing.Size(228, 132);
            this.groupBox_registerTypegroup.TabIndex = 6;
            this.groupBox_registerTypegroup.TabStop = false;
            this.groupBox_registerTypegroup.Text = "Enrollment Type";
            // 
            // rb_editenrollType2
            // 
            this.rb_editenrollType2.AutoSize = true;
            this.rb_editenrollType2.Location = new System.Drawing.Point(119, 51);
            this.rb_editenrollType2.Name = "rb_editenrollType2";
            this.rb_editenrollType2.Size = new System.Drawing.Size(70, 17);
            this.rb_editenrollType2.TabIndex = 1;
            this.rb_editenrollType2.Text = "Part Time";
            this.rb_editenrollType2.UseVisualStyleBackColor = true;
            // 
            // rb_editenrollType1
            // 
            this.rb_editenrollType1.AutoSize = true;
            this.rb_editenrollType1.Checked = true;
            this.rb_editenrollType1.Location = new System.Drawing.Point(16, 51);
            this.rb_editenrollType1.Name = "rb_editenrollType1";
            this.rb_editenrollType1.Size = new System.Drawing.Size(67, 17);
            this.rb_editenrollType1.TabIndex = 0;
            this.rb_editenrollType1.TabStop = true;
            this.rb_editenrollType1.Text = "Full Time";
            this.rb_editenrollType1.UseVisualStyleBackColor = true;
            // 
            // txt_editlastName
            // 
            this.txt_editlastName.Location = new System.Drawing.Point(123, 96);
            this.txt_editlastName.Name = "txt_editlastName";
            this.txt_editlastName.Size = new System.Drawing.Size(140, 20);
            this.txt_editlastName.TabIndex = 5;
            // 
            // label_editastName
            // 
            this.label_editastName.AutoSize = true;
            this.label_editastName.Location = new System.Drawing.Point(26, 99);
            this.label_editastName.Name = "label_editastName";
            this.label_editastName.Size = new System.Drawing.Size(58, 13);
            this.label_editastName.TabIndex = 4;
            this.label_editastName.Text = "Last Name";
            // 
            // txt_editfirstName
            // 
            this.txt_editfirstName.Location = new System.Drawing.Point(123, 62);
            this.txt_editfirstName.Name = "txt_editfirstName";
            this.txt_editfirstName.Size = new System.Drawing.Size(140, 20);
            this.txt_editfirstName.TabIndex = 3;
            // 
            // label_editfirstName
            // 
            this.label_editfirstName.AutoSize = true;
            this.label_editfirstName.Location = new System.Drawing.Point(26, 70);
            this.label_editfirstName.Name = "label_editfirstName";
            this.label_editfirstName.Size = new System.Drawing.Size(57, 13);
            this.label_editfirstName.TabIndex = 2;
            this.label_editfirstName.Text = "First Name";
            // 
            // label_editstudentID
            // 
            this.label_editstudentID.AutoSize = true;
            this.label_editstudentID.Location = new System.Drawing.Point(26, 36);
            this.label_editstudentID.Name = "label_editstudentID";
            this.label_editstudentID.Size = new System.Drawing.Size(58, 13);
            this.label_editstudentID.TabIndex = 0;
            this.label_editstudentID.Text = "Student ID";
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 261);
            this.Controls.Add(this.button_cancelStudent);
            this.Controls.Add(this.button_editStudent);
            this.Controls.Add(this.groupBox_registerstudentInfo);
            this.Name = "EditStudent";
            this.Text = "Edit Student Registration";
            this.groupBox_registerstudentInfo.ResumeLayout(false);
            this.groupBox_registerstudentInfo.PerformLayout();
            this.groupBox_registerTypegroup.ResumeLayout(false);
            this.groupBox_registerTypegroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cancelStudent;
        private System.Windows.Forms.Button button_editStudent;
        private System.Windows.Forms.GroupBox groupBox_registerstudentInfo;
        private System.Windows.Forms.MaskedTextBox maskedtxt_editstudentID;
        private System.Windows.Forms.ComboBox comboBox_deptedit;
        private System.Windows.Forms.Label label_editdept;
        private System.Windows.Forms.GroupBox groupBox_registerTypegroup;
        private System.Windows.Forms.RadioButton rb_editenrollType2;
        private System.Windows.Forms.RadioButton rb_editenrollType1;
        private System.Windows.Forms.TextBox txt_editlastName;
        private System.Windows.Forms.Label label_editastName;
        private System.Windows.Forms.TextBox txt_editfirstName;
        private System.Windows.Forms.Label label_editfirstName;
        private System.Windows.Forms.Label label_editstudentID;
    }
}