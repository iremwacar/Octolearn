namespace EngProjectNew
{
    partial class Quiz
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
            btnStartQuiz = new Button();
            lblEnglishWord = new Label();
            btnOption1 = new Button();
            btnOption2 = new Button();
            btnOption3 = new Button();
            btnOption4 = new Button();
            lblResult = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(353, 91);
            btnStartQuiz.Margin = new Padding(4);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(86, 27);
            btnStartQuiz.TabIndex = 1;
            btnStartQuiz.Text = "Let's Go!";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click_1;
            // 
            // lblEnglishWord
            // 
            lblEnglishWord.AutoSize = true;
            lblEnglishWord.BackColor = Color.Transparent;
            lblEnglishWord.FlatStyle = FlatStyle.Popup;
            lblEnglishWord.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEnglishWord.Location = new Point(256, 155);
            lblEnglishWord.Margin = new Padding(4, 0, 4, 0);
            lblEnglishWord.Name = "lblEnglishWord";
            lblEnglishWord.Size = new Size(0, 50);
            lblEnglishWord.TabIndex = 2;
            lblEnglishWord.Click += lblEnglishWord_Click;
            // 
            // btnOption1
            // 
            btnOption1.BackColor = Color.FromArgb(251, 46, 237);
            btnOption1.BackgroundImageLayout = ImageLayout.Center;
            btnOption1.FlatStyle = FlatStyle.Popup;
            btnOption1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOption1.Location = new Point(176, 266);
            btnOption1.Margin = new Padding(4);
            btnOption1.Name = "btnOption1";
            btnOption1.Size = new Size(153, 61);
            btnOption1.TabIndex = 3;
            btnOption1.UseVisualStyleBackColor = false;
            btnOption1.Click += btnOption1_Click;
            // 
            // btnOption2
            // 
            btnOption2.BackColor = Color.Transparent;
            btnOption2.BackgroundImageLayout = ImageLayout.Center;
            btnOption2.FlatStyle = FlatStyle.Popup;
            btnOption2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOption2.Location = new Point(477, 266);
            btnOption2.Margin = new Padding(4);
            btnOption2.Name = "btnOption2";
            btnOption2.Size = new Size(166, 61);
            btnOption2.TabIndex = 4;
            btnOption2.UseVisualStyleBackColor = false;
            btnOption2.Click += btnOption2_Click;
            // 
            // btnOption3
            // 
            btnOption3.BackColor = Color.Transparent;
            btnOption3.BackgroundImageLayout = ImageLayout.Center;
            btnOption3.FlatStyle = FlatStyle.Popup;
            btnOption3.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOption3.Location = new Point(172, 356);
            btnOption3.Margin = new Padding(4);
            btnOption3.Name = "btnOption3";
            btnOption3.Size = new Size(157, 52);
            btnOption3.TabIndex = 5;
            btnOption3.UseVisualStyleBackColor = false;
            // 
            // btnOption4
            // 
            btnOption4.BackColor = Color.Transparent;
            btnOption4.BackgroundImageLayout = ImageLayout.Center;
            btnOption4.FlatStyle = FlatStyle.Popup;
            btnOption4.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOption4.Location = new Point(477, 356);
            btnOption4.Margin = new Padding(4);
            btnOption4.Name = "btnOption4";
            btnOption4.Size = new Size(166, 52);
            btnOption4.TabIndex = 6;
            btnOption4.UseVisualStyleBackColor = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(435, 634);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.icons8_back_64;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(12, 253);
            button3.Name = "button3";
            button3.Size = new Size(38, 40);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Quiz;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(button3);
            Controls.Add(lblResult);
            Controls.Add(btnOption4);
            Controls.Add(btnOption3);
            Controls.Add(btnOption2);
            Controls.Add(btnOption1);
            Controls.Add(lblEnglishWord);
            Controls.Add(btnStartQuiz);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Quiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            Load += Quiz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStartQuiz;
        private Label lblEnglishWord;
        private Button btnOption1;
        private Button btnOption2;
        private Button btnOption3;
        private Button btnOption4;
        private Label lblResult;
        private Button button3;
    }
}