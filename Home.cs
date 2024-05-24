using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngProjectNew
{
    public partial class Home : Form
    {
        string connectionString = "Data Source=IREM\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True";
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Learn learn = new Learn();
            learn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Quiz quiz = new Quiz();
            quiz.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Analysis analysis = new Analysis();
            analysis.Show();
            int knownWordsCount = GetWordCount("SELECT COUNT(*) FROM Words WHERE correctAnswer=6");
            int totalWordsCount = GetWordCount("SELECT COUNT(*) FROM Words");

            double knownWordsPercentage = (double)knownWordsCount / totalWordsCount * 100;

            analysis.textBox1.Text = ($"{knownWordsPercentage:F2}%");
        }






        private int GetWordCount(string query)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();  
            about.Show();
            this.Hide();
        }
    }
}
