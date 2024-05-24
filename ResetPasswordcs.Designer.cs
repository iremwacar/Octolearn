namespace EngProjectNew
{
    partial class ResetPasswordcs
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtReEnteredPassword = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(194, 184, 226);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new Point(300, 136);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(213, 18);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "userName";
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(194, 184, 226);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(300, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(213, 18);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "password";
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(194, 184, 226);
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Font = new Font("Segoe UI", 10F);
            txtNewPassword.ForeColor = Color.Gray;
            txtNewPassword.Location = new Point(300, 252);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(213, 18);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.Text = "newPassword";
            txtNewPassword.Enter += txtNewPassword_Enter;
            txtNewPassword.Leave += txtNewPassword_Leave;
            // 
            // txtReEnteredPassword
            // 
            txtReEnteredPassword.BackColor = Color.FromArgb(194, 184, 226);
            txtReEnteredPassword.BorderStyle = BorderStyle.None;
            txtReEnteredPassword.Font = new Font("Segoe UI", 10F);
            txtReEnteredPassword.ForeColor = Color.Gray;
            txtReEnteredPassword.Location = new Point(300, 320);
            txtReEnteredPassword.Name = "txtReEnteredPassword";
            txtReEnteredPassword.Size = new Size(213, 18);
            txtReEnteredPassword.TabIndex = 3;
            txtReEnteredPassword.Text = "ReNewPassword";
            txtReEnteredPassword.Enter += txtReEnteredPassword_Enter;
            txtReEnteredPassword.Leave += txtReEnteredPassword_Leave;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnUpdate.ForeColor = Color.HotPink;
            btnUpdate.Location = new Point(326, 367);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(165, 31);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "RESET";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // ResetPasswordcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_05_24_at_21_53_38;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txtReEnteredPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPasswordcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPasswordcs";
            Load += ResetPasswordcs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtNewPassword;
        private TextBox txtReEnteredPassword;
        private Button btnUpdate;
    }
}