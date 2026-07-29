namespace Assignment_4_2.Views
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
            btnLogon = new Button();
            btnExit = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogon
            // 
            btnLogon.Location = new Point(34, 93);
            btnLogon.Name = "btnLogon";
            btnLogon.Size = new Size(75, 23);
            btnLogon.TabIndex = 3;
            btnLogon.Text = "Logon";
            btnLogon.UseVisualStyleBackColor = true;
            btnLogon.Click += btnLogon_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(130, 93);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(99, 21);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(99, 50);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 4;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 58);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogon;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(228, 128);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnExit);
            Controls.Add(btnLogon);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logon To LMS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogon;
        private Button btnExit;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
    }
}