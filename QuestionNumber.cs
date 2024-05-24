using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EngProjectNew
{
    public partial class QuestionNumber : Form
    {
        public int qNumber;


        public QuestionNumber()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int result))
            {
                SharedData.QuestionNumber = result; // Set the value in the shared class
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        

        private void QuestionNumber_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static class SharedData
        {
            public static int QuestionNumber { get; set; } = 10; // Default value set to 10
        }
    }
}
