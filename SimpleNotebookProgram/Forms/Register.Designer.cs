namespace SimpleNotebookProgram
{
    partial class registerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginRegisterButton = new System.Windows.Forms.Button();
            this.clearRegisterButton = new System.Windows.Forms.Button();
            this.backToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(166, 76);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(97, 25);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameTextBox.Location = new System.Drawing.Point(85, 105);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(238, 43);
            this.userNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(85, 191);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(238, 43);
            this.passwordTextBox.TabIndex = 4;
            // 
            // loginRegisterButton
            // 
            this.loginRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginRegisterButton.ForeColor = System.Drawing.Color.White;
            this.loginRegisterButton.Location = new System.Drawing.Point(223, 503);
            this.loginRegisterButton.Name = "loginRegisterButton";
            this.loginRegisterButton.Size = new System.Drawing.Size(100, 43);
            this.loginRegisterButton.TabIndex = 15;
            this.loginRegisterButton.Text = "Register";
            this.loginRegisterButton.UseVisualStyleBackColor = true;
            this.loginRegisterButton.Click += new System.EventHandler(this.loginRegisterButton_Click);
            // 
            // clearRegisterButton
            // 
            this.clearRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearRegisterButton.ForeColor = System.Drawing.Color.White;
            this.clearRegisterButton.Location = new System.Drawing.Point(85, 503);
            this.clearRegisterButton.Name = "clearRegisterButton";
            this.clearRegisterButton.Size = new System.Drawing.Size(102, 43);
            this.clearRegisterButton.TabIndex = 14;
            this.clearRegisterButton.Text = "Clear";
            this.clearRegisterButton.UseVisualStyleBackColor = true;
            this.clearRegisterButton.Click += new System.EventHandler(this.clearRegisterButton_Click);
            // 
            // backToLogin
            // 
            this.backToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLogin.ForeColor = System.Drawing.Color.White;
            this.backToLogin.Location = new System.Drawing.Point(138, 570);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(129, 43);
            this.backToLogin.TabIndex = 16;
            this.backToLogin.Text = "Back To Login";
            this.backToLogin.UseVisualStyleBackColor = true;
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 879);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.loginRegisterButton);
            this.Controls.Add(this.clearRegisterButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "registerForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginRegisterButton;
        private System.Windows.Forms.Button clearRegisterButton;
        private System.Windows.Forms.Button backToLogin;
    }
}
