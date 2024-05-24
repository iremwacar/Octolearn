namespace EngProjectNew
{
    partial class AboutUs
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
            button4 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.icons8_back_64;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(23, 231);
            button4.Name = "button4";
            button4.Size = new Size(38, 40);
            button4.TabIndex = 14;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._42dbbeb8_a640_4e15_af2b_3bacea8eb318;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AboutUs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AboutUs";
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
    }
}