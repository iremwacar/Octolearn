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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EngProjectNew
{
    public partial class Learn : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source=IREM\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True");
        int currentWordId = 0;
        public Learn()
        {
            InitializeComponent();
            nextWord();

        }

        public class ImageDisplayHelper
        {
            /*p/*ublic static void DisplayImageFromURL(PictureBox pictureBox1, int currentWordId, string Words, string imageURL)
            {

                // Connect to the database
                using (SqlConnection connection = new SqlConnection("Data Source=IREM\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True"))
                {
                    connection.Open();

                    // Retrieve the imageURL from the database
                    string sqlQuery = "SELECT imageURL FROM Words WHERE wordID = @currentWordId";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@currentWordId", currentWordId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string imageurl = reader["imageURL"].ToString();

                                // Load the image into the PictureBox
                                if (!string.IsNullOrEmpty(imageurl))
                                {
                                    pictureBox1.LoadAsync(imageurl);
                                }
                            }
                        }
                    }
                }
            }*/


        }


        private void showWord()
        {
            label1.Text = "";
            label2.Text = "";
            using (SqlConnection connection = new SqlConnection("Data Source=IREM\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT word FROM Words WHERE wordID=@currentWordID", connection))
                    {
                        command.Parameters.AddWithValue("@currentWordID", currentWordId);
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            label1.Text = result.ToString();
                        }

                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("General Error: " + ex.Message);
                }
            }

        }

        private void nextWord()
        {
            currentWordId++;
            showWord();
            //ImageDisplayHelper.DisplayImageFromURL(pictureBox1, 1, "Words", "imageURL");
        }


        private void previousWord()
        {
            if (currentWordId > 1)
            {
                currentWordId--;
                showWord();
                //ImageDisplayHelper.DisplayImageFromURL(pictureBox1, 1, "Words", "imageURL");
            }
        }

        private void flipIt()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=IREM\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True"))
            {
                label1.Text = "";
                label2.Text = "";
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT meaning, sentence FROM Words WHERE wordID=@currentWordID", connection))
                    {
                        command.Parameters.AddWithValue("@currentWordID", currentWordId);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string meaning = reader["meaning"].ToString();
                            string sentence = reader["sentence"].ToString();
                            // Display the meaning and sentence
                            label1.Text = meaning;
                            label2.Text = sentence;
                        }
                        else
                        {
                            label1.Text = "Word not found.";
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("General Error: " + ex.Message);
                }
            }
        }
        private void addWord()
        {
            connection.Open();
            string query = "INSERT INTO Words (word, meaning, sentence) VALUES (@word, @meaning,@sentence)";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@word", textBox1.Text);
            command.Parameters.AddWithValue("@meaning", textBox2.Text);
            command.Parameters.AddWithValue("@sentence", textBox4.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Word added successfully!");
            textBox1.Text = "word";
            textBox2.Text = "meaning";
            textBox4.Text = "sentence";
        }
        private void Learn_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nextWord();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            previousWord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flipIt();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addWord();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void flashcard_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "word")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "word";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "meaning")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "meaning";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "sentence")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "sentence";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
