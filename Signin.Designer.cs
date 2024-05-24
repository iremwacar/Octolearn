namespace EngProjectNew
{
    partial class Signin
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button6 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(195, 184, 227);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(282, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 22);
            textBox1.TabIndex = 6;
            textBox1.Text = "Repeat Password";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(195, 184, 227);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(282, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 22);
            textBox2.TabIndex = 7;
            textBox2.Text = "Password";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(195, 184, 227);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.ForeColor = Color.Gray;
            textBox3.Location = new Point(282, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 22);
            textBox3.TabIndex = 8;
            textBox3.Text = "Username";
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(195, 184, 227);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.ForeColor = Color.Gray;
            textBox4.Location = new Point(282, 305);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 22);
            textBox4.TabIndex = 9;
            textBox4.Text = "E-mail";
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(43, 171, 242);
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Forte", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Navy;
            button6.Location = new Point(320, 367);
            button6.Name = "button6";
            button6.Size = new Size(158, 34);
            button6.TabIndex = 10;
            button6.Text = "Sign up!";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.icons8_back_64;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(12, 239);
            button1.Name = "button1";
            button1.Size = new Size(38, 40);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.signuppng;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signin";
            Load += Signin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button6;
        private Button button1;
    }
}