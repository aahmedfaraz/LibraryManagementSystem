
namespace Library_Management_System
{
    partial class Login
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.adminRadio = new System.Windows.Forms.RadioButton();
            this.studentRadio = new System.Windows.Forms.RadioButton();
            this.facultyRadio = new System.Windows.Forms.RadioButton();
            this.librarianRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(242, 126);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 25);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(242, 154);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.PlaceholderText = "Enter Username";
            this.usernameInput.Size = new System.Drawing.Size(309, 31);
            this.usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(242, 216);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PlaceholderText = "Enter Password";
            this.passwordInput.Size = new System.Drawing.Size(309, 31);
            this.passwordInput.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(242, 188);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 25);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(303, 52);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(180, 74);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.ForeColor = System.Drawing.SystemColors.Window;
            this.loginButton.Location = new System.Drawing.Point(242, 329);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(309, 54);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.Location = new System.Drawing.Point(304, 253);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(90, 29);
            this.adminRadio.TabIndex = 10;
            this.adminRadio.Text = "Admin";
            this.adminRadio.UseVisualStyleBackColor = true;
            // 
            // studentRadio
            // 
            this.studentRadio.AutoSize = true;
            this.studentRadio.Checked = true;
            this.studentRadio.Location = new System.Drawing.Point(400, 253);
            this.studentRadio.Name = "studentRadio";
            this.studentRadio.Size = new System.Drawing.Size(98, 29);
            this.studentRadio.TabIndex = 11;
            this.studentRadio.TabStop = true;
            this.studentRadio.Text = "Student";
            this.studentRadio.UseVisualStyleBackColor = true;
            // 
            // facultyRadio
            // 
            this.facultyRadio.AutoSize = true;
            this.facultyRadio.Location = new System.Drawing.Point(400, 288);
            this.facultyRadio.Name = "facultyRadio";
            this.facultyRadio.Size = new System.Drawing.Size(91, 29);
            this.facultyRadio.TabIndex = 13;
            this.facultyRadio.Text = "Faculty";
            this.facultyRadio.UseVisualStyleBackColor = true;
            // 
            // librarianRadio
            // 
            this.librarianRadio.AutoSize = true;
            this.librarianRadio.Location = new System.Drawing.Point(304, 288);
            this.librarianRadio.Name = "librarianRadio";
            this.librarianRadio.Size = new System.Drawing.Size(104, 29);
            this.librarianRadio.TabIndex = 12;
            this.librarianRadio.Text = "Librarian";
            this.librarianRadio.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.facultyRadio);
            this.Controls.Add(this.librarianRadio);
            this.Controls.Add(this.studentRadio);
            this.Controls.Add(this.adminRadio);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.usernameLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RadioButton adminRadio;
        private System.Windows.Forms.RadioButton studentRadio;
        private System.Windows.Forms.RadioButton facultyRadio;
        private System.Windows.Forms.RadioButton librarianRadio;
    }
}