namespace MVP
{
    partial class RemoveStudent
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
            this.button_removeStudent = new System.Windows.Forms.Button();
            this.groupBox_registerstudentInfo = new System.Windows.Forms.GroupBox();
            this.maskedtxt_removestudentID = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_removedept = new System.Windows.Forms.ComboBox();
            this.label_removedept = new System.Windows.Forms.Label();
            this.groupBox_registerTypegroup = new System.Windows.Forms.GroupBox();
            this.rb_removeenrollType2 = new System.Windows.Forms.RadioButton();
            this.rb_removeenrollType1 = new System.Windows.Forms.RadioButton();
            this.txt_removelastName = new System.Windows.Forms.TextBox();
            this.label_removelastName = new System.Windows.Forms.Label();
            this.txt_removefirstName = new System.Windows.Forms.TextBox();
            this.label_removefirstName = new System.Windows.Forms.Label();
            this.label_removestudentID = new System.Windows.Forms.Label();
            this.groupBox_registerstudentInfo.SuspendLayout();
            this.groupBox_registerTypegroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cancelStudent
            // 
            this.button_cancelStudent.Location = new System.Drawing.Point(449, 204);
            this.button_cancelStudent.Name = "button_cancelStudent";
            this.button_cancelStudent.Size = new System.Drawing.Size(99, 46);
            this.button_cancelStudent.TabIndex = 11;
            this.button_cancelStudent.Text = "Cancel Student";
            this.button_cancelStudent.UseVisualStyleBackColor = true;
            this.button_cancelStudent.Click += new System.EventHandler(this.button_resetStudent_Click);
            // 
            // button_removeStudent
            // 
            this.button_removeStudent.Location = new System.Drawing.Point(326, 204);
            this.button_removeStudent.Name = "button_removeStudent";
            this.button_removeStudent.Size = new System.Drawing.Size(99, 46);
            this.button_removeStudent.TabIndex = 10;
            this.button_removeStudent.Text = "Remove Student";
            this.button_removeStudent.UseVisualStyleBackColor = true;
            this.button_removeStudent.Click += new System.EventHandler(this.button_addStudent_Click);
            // 
            // groupBox_registerstudentInfo
            // 
            this.groupBox_registerstudentInfo.Controls.Add(this.maskedtxt_removestudentID);
            this.groupBox_registerstudentInfo.Controls.Add(this.comboBox_removedept);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_removedept);
            this.groupBox_registerstudentInfo.Controls.Add(this.groupBox_registerTypegroup);
            this.groupBox_registerstudentInfo.Controls.Add(this.txt_removelastName);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_removelastName);
            this.groupBox_registerstudentInfo.Controls.Add(this.txt_removefirstName);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_removefirstName);
            this.groupBox_registerstudentInfo.Controls.Add(this.label_removestudentID);
            this.groupBox_registerstudentInfo.Location = new System.Drawing.Point(17, 10);
            this.groupBox_registerstudentInfo.Name = "groupBox_registerstudentInfo";
            this.groupBox_registerstudentInfo.Size = new System.Drawing.Size(531, 177);
            this.groupBox_registerstudentInfo.TabIndex = 9;
            this.groupBox_registerstudentInfo.TabStop = false;
            this.groupBox_registerstudentInfo.Text = "Student Info";
            this.groupBox_registerstudentInfo.Enter += new System.EventHandler(this.groupBox_registerstudentInfo_Enter);
            // 
            // maskedtxt_removestudentID
            // 
            this.maskedtxt_removestudentID.Enabled = false;
            this.maskedtxt_removestudentID.Location = new System.Drawing.Point(123, 28);
            this.maskedtxt_removestudentID.Mask = "000-00-0000";
            this.maskedtxt_removestudentID.Name = "maskedtxt_removestudentID";
            this.maskedtxt_removestudentID.PromptChar = ' ';
            this.maskedtxt_removestudentID.Size = new System.Drawing.Size(140, 20);
            this.maskedtxt_removestudentID.TabIndex = 9;
            // 
            // comboBox_removedept
            // 
            this.comboBox_removedept.Enabled = false;
            this.comboBox_removedept.FormattingEnabled = true;
            this.comboBox_removedept.Location = new System.Drawing.Point(123, 126);
            this.comboBox_removedept.Name = "comboBox_removedept";
            this.comboBox_removedept.Size = new System.Drawing.Size(140, 21);
            this.comboBox_removedept.TabIndex = 8;
            // 
            // label_removedept
            // 
            this.label_removedept.AutoSize = true;
            this.label_removedept.Location = new System.Drawing.Point(26, 126);
            this.label_removedept.Name = "label_removedept";
            this.label_removedept.Size = new System.Drawing.Size(89, 13);
            this.label_removedept.TabIndex = 7;
            this.label_removedept.Text = "Department Type";
            // 
            // groupBox_registerTypegroup
            // 
            this.groupBox_registerTypegroup.Controls.Add(this.rb_removeenrollType2);
            this.groupBox_registerTypegroup.Controls.Add(this.rb_removeenrollType1);
            this.groupBox_registerTypegroup.Location = new System.Drawing.Point(282, 28);
            this.groupBox_registerTypegroup.Name = "groupBox_registerTypegroup";
            this.groupBox_registerTypegroup.Size = new System.Drawing.Size(228, 132);
            this.groupBox_registerTypegroup.TabIndex = 6;
            this.groupBox_registerTypegroup.TabStop = false;
            this.groupBox_registerTypegroup.Text = "Enrollment Type";
            // 
            // rb_removeenrollType2
            // 
            this.rb_removeenrollType2.AutoSize = true;
            this.rb_removeenrollType2.Enabled = false;
            this.rb_removeenrollType2.Location = new System.Drawing.Point(119, 51);
            this.rb_removeenrollType2.Name = "rb_removeenrollType2";
            this.rb_removeenrollType2.Size = new System.Drawing.Size(70, 17);
            this.rb_removeenrollType2.TabIndex = 1;
            this.rb_removeenrollType2.Text = "Part Time";
            this.rb_removeenrollType2.UseVisualStyleBackColor = true;
            // 
            // rb_removeenrollType1
            // 
            this.rb_removeenrollType1.AutoSize = true;
            this.rb_removeenrollType1.Enabled = false;
            this.rb_removeenrollType1.Location = new System.Drawing.Point(16, 51);
            this.rb_removeenrollType1.Name = "rb_removeenrollType1";
            this.rb_removeenrollType1.Size = new System.Drawing.Size(67, 17);
            this.rb_removeenrollType1.TabIndex = 0;
            this.rb_removeenrollType1.Text = "Full Time";
            this.rb_removeenrollType1.UseVisualStyleBackColor = true;
            // 
            // txt_removelastName
            // 
            this.txt_removelastName.Enabled = false;
            this.txt_removelastName.Location = new System.Drawing.Point(123, 96);
            this.txt_removelastName.Name = "txt_removelastName";
            this.txt_removelastName.Size = new System.Drawing.Size(140, 20);
            this.txt_removelastName.TabIndex = 5;
            // 
            // label_removelastName
            // 
            this.label_removelastName.AutoSize = true;
            this.label_removelastName.Location = new System.Drawing.Point(26, 99);
            this.label_removelastName.Name = "label_removelastName";
            this.label_removelastName.Size = new System.Drawing.Size(58, 13);
            this.label_removelastName.TabIndex = 4;
            this.label_removelastName.Text = "Last Name";
            // 
            // txt_removefirstName
            // 
            this.txt_removefirstName.Enabled = false;
            this.txt_removefirstName.Location = new System.Drawing.Point(123, 62);
            this.txt_removefirstName.Name = "txt_removefirstName";
            this.txt_removefirstName.Size = new System.Drawing.Size(140, 20);
            this.txt_removefirstName.TabIndex = 3;
            // 
            // label_removefirstName
            // 
            this.label_removefirstName.AutoSize = true;
            this.label_removefirstName.Location = new System.Drawing.Point(26, 70);
            this.label_removefirstName.Name = "label_removefirstName";
            this.label_removefirstName.Size = new System.Drawing.Size(57, 13);
            this.label_removefirstName.TabIndex = 2;
            this.label_removefirstName.Text = "First Name";
            // 
            // label_removestudentID
            // 
            this.label_removestudentID.AutoSize = true;
            this.label_removestudentID.Location = new System.Drawing.Point(26, 36);
            this.label_removestudentID.Name = "label_removestudentID";
            this.label_removestudentID.Size = new System.Drawing.Size(58, 13);
            this.label_removestudentID.TabIndex = 0;
            this.label_removestudentID.Text = "Student ID";
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 261);
            this.Controls.Add(this.button_cancelStudent);
            this.Controls.Add(this.button_removeStudent);
            this.Controls.Add(this.groupBox_registerstudentInfo);
            this.Name = "RemoveStudent";
            this.Text = "Remove Student";
            this.Load += new System.EventHandler(this.RemoveStudent_Load);
            this.groupBox_registerstudentInfo.ResumeLayout(false);
            this.groupBox_registerstudentInfo.PerformLayout();
            this.groupBox_registerTypegroup.ResumeLayout(false);
            this.groupBox_registerTypegroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cancelStudent;
        private System.Windows.Forms.Button button_removeStudent;
        private System.Windows.Forms.GroupBox groupBox_registerstudentInfo;
        private System.Windows.Forms.MaskedTextBox maskedtxt_removestudentID;
        private System.Windows.Forms.ComboBox comboBox_removedept;
        private System.Windows.Forms.Label label_removedept;
        private System.Windows.Forms.GroupBox groupBox_registerTypegroup;
        private System.Windows.Forms.RadioButton rb_removeenrollType2;
        private System.Windows.Forms.RadioButton rb_removeenrollType1;
        private System.Windows.Forms.TextBox txt_removelastName;
        private System.Windows.Forms.Label label_removelastName;
        private System.Windows.Forms.TextBox txt_removefirstName;
        private System.Windows.Forms.Label label_removefirstName;
        private System.Windows.Forms.Label label_removestudentID;
    }
}