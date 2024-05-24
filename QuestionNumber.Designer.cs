namespace EngProjectNew
{
    partial class QuestionNumber
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
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.icons8_save_48;
            button1.Font = new Font("Segoe UI", 20F);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(83, 124);
            button1.Name = "button1";
            button1.Size = new Size(137, 68);
            button1.TabIndex = 1;
            button1.Text = "SET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // QuestionNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(311, 284);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuestionNumber";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuestionNumber";
            Load += QuestionNumber_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        public TextBox textBox1;
    }
}