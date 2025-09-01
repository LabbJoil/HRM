namespace TestTask.WindowsFormsApp
{
    partial class LoginForm
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
            this.serverLabel = new System.Windows.Forms.Label();
            this.dataBaseLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.dataBaseTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverLabel.Location = new System.Drawing.Point(127, 29);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(84, 24);
            this.serverLabel.TabIndex = 0;
            this.serverLabel.Text = "Сервер";
            // 
            // dataBaseLabel
            // 
            this.dataBaseLabel.AutoSize = true;
            this.dataBaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.dataBaseLabel.Location = new System.Drawing.Point(137, 100);
            this.dataBaseLabel.Name = "dataBaseLabel";
            this.dataBaseLabel.Size = new System.Drawing.Size(57, 24);
            this.dataBaseLabel.TabIndex = 1;
            this.dataBaseLabel.Text = "База";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.loginLabel.Location = new System.Drawing.Point(428, 29);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(69, 24);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(415, 100);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 24);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль";
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.SignInButton.Location = new System.Drawing.Point(257, 208);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(108, 38);
            this.SignInButton.TabIndex = 4;
            this.SignInButton.Text = "Вход";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // serverTextBox
            // 
            this.serverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverTextBox.Location = new System.Drawing.Point(70, 56);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(206, 26);
            this.serverTextBox.TabIndex = 5;
            // 
            // dataBaseTextBox
            // 
            this.dataBaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBaseTextBox.Location = new System.Drawing.Point(70, 127);
            this.dataBaseTextBox.Name = "dataBaseTextBox";
            this.dataBaseTextBox.Size = new System.Drawing.Size(206, 26);
            this.dataBaseTextBox.TabIndex = 6;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(358, 56);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(206, 26);
            this.loginTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(358, 127);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(206, 26);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 296);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.dataBaseTextBox);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.dataBaseLabel);
            this.Controls.Add(this.serverLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label dataBaseLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.TextBox dataBaseTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}