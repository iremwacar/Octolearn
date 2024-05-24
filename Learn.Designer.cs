namespace EngProjectNew
{
    partial class Learn
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
            flashcard = new PictureBox();
            label1 = new Label();
            btnNext = new Button();
            button1 = new Button();
            btnFlip = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)flashcard).BeginInit();
            SuspendLayout();
            // 
            // flashcard
            // 
            flashcard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flashcard.BackColor = Color.FromArgb(8, 41, 90);
            flashcard.Location = new Point(309, 158);
            flashcard.Name = "flashcard";
            flashcard.Size = new Size(209, 242);
            flashcard.TabIndex = 0;
            flashcard.TabStop = false;
            flashcard.Click += flashcard_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(8, 41, 90);
            label1.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(371, 249);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.BackgroundImage = Properties.Resources.icons8_chevron_241;
            btnNext.BackgroundImageLayout = ImageLayout.None;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.ImageAlign = ContentAlignment.MiddleLeft;
            btnNext.Location = new Point(539, 276);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(29, 28);
            btnNext.TabIndex = 2;
            btnNext.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.icons8_chevron_24;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(253, 276);
            button1.Name = "button1";
            button1.Size = new Size(27, 29);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnFlip
            // 
            btnFlip.BackColor = Color.Transparent;
            btnFlip.BackgroundImage = Properties.Resources.icons8_flip_32;
            btnFlip.BackgroundImageLayout = ImageLayout.Center;
            btnFlip.FlatStyle = FlatStyle.Popup;
            btnFlip.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnFlip.Location = new Point(388, 418);
            btnFlip.Name = "btnFlip";
            btnFlip.Size = new Size(40, 36);
            btnFlip.TabIndex = 4;
            btnFlip.UseVisualStyleBackColor = false;
            btnFlip.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.FromArgb(8, 41, 90);
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Trebuchet MS", 12.75F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(326, 280);
            label2.Name = "label2";
            label2.Size = new Size(177, 88);
            label2.TabIndex = 5;
            label2.Click += label2_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Trebuchet MS", 12F, FontStyle.Italic);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(150, 104);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 7;
            textBox1.Text = "word";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Trebuchet MS", 12F, FontStyle.Italic);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(326, 104);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(92, 27);
            textBox2.TabIndex = 8;
            textBox2.Text = "meaning";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Font = new Font("Trebuchet MS", 12F, FontStyle.Italic);
            textBox4.ForeColor = Color.Gray;
            textBox4.Location = new Point(487, 103);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(101, 28);
            textBox4.TabIndex = 10;
            textBox4.Text = "sentence";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Trebuchet MS", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = Properties.Resources.icons8_add_48_2_;
            button2.Location = new Point(655, 92);
            button2.Name = "button2";
            button2.Size = new Size(40, 39);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.icons8_back_64;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(12, 264);
            button3.Name = "button3";
            button3.Size = new Size(38, 40);
            button3.TabIndex = 12;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Learn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.learn;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btnFlip);
            Controls.Add(button1);
            Controls.Add(btnNext);
            Controls.Add(label1);
            Controls.Add(flashcard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Learn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Learn";
            Load += Learn_Load;
            ((System.ComponentModel.ISupportInitialize)flashcard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flashcard;
        private Label label1;
        private Button btnNext;
        private Button button1;
        private Button btnFlip;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Button button3;
    }
}