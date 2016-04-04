namespace StudentRegistrationWinForm
{
    partial class StudentRegistrationLogin
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
            this.label_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.button_signin = new System.Windows.Forms.Button();
            this.masked_txt_password = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(51, 66);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(55, 13);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(153, 63);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(129, 20);
            this.txt_username.TabIndex = 1;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(51, 99);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password";
            // 
            // button_signin
            // 
            this.button_signin.Location = new System.Drawing.Point(189, 139);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(93, 30);
            this.button_signin.TabIndex = 4;
            this.button_signin.Text = "Sign In";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // masked_txt_password
            // 
            this.masked_txt_password.Location = new System.Drawing.Point(153, 96);
            this.masked_txt_password.Name = "masked_txt_password";
            this.masked_txt_password.PasswordChar = '*';
            this.masked_txt_password.PromptChar = ' ';
            this.masked_txt_password.Size = new System.Drawing.Size(129, 20);
            this.masked_txt_password.TabIndex = 5;
            // 
            // StudentRegistrationLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 291);
            this.Controls.Add(this.masked_txt_password);
            this.Controls.Add(this.button_signin);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label_username);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentRegistrationLogin";
            this.Text = "Student Registration Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.MaskedTextBox masked_txt_password;
    }
}

