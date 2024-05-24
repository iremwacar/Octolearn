using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static EngProjectNew.QuestionNumber;

namespace EngProjectNew
{
    public partial class Quiz : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=IREM\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True");
        private List<Word> words;
        private List<string> options;
        private int currentQuestionIndex;
        private int correctAnswers;
        private int totalQuestions;
        private int correctOptionIndex;
        int number;

        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            btnOption1.Click += new EventHandler(btnOption_Click);
            btnOption2.Click += new EventHandler(btnOption_Click);
            btnOption3.Click += new EventHandler(btnOption_Click);
            btnOption4.Click += new EventHandler(btnOption_Click);
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as System.Windows.Forms.Button;
            int selectedOptionIndex = int.Parse(clickedButton.Tag.ToString());

            CheckAnswer(selectedOptionIndex);
            currentQuestionIndex++;

            if (currentQuestionIndex < totalQuestions)
            {
                DisplayNextWord();
            }
            else
            {
                MessageBox.Show($"The End! Score : {correctAnswers}/{totalQuestions}");
            }
        }

        private void LoadRandomWords(int count)
        {
            string sql = "SELECT TOP (@count) * FROM Words WHERE correctAnswer <= 6 ORDER BY NEWID()";
            words = new List<Word>();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@count", count);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        words.Add(new Word
                        {
                            ID = (int)reader["wordID"],
                            EnglishWord = reader["word"].ToString(),
                            TurkishMeaning = reader["meaning"].ToString(),
                            CorrectAnswer = (int)reader["correctAnswer"],
                            Sentence = reader["sentence"].ToString()
                        });
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }

        private void DisplayNextWord()
        {
            if (currentQuestionIndex >= totalQuestions)
            {
                MessageBox.Show("Quiz has ended!");
                return;
            }

            if (words.Count == 0)
            {
                MessageBox.Show("There are no words to display!");
                return;
            }

            if (currentQuestionIndex >= words.Count)
            {
                MessageBox.Show("There are not enough words to display!");
                return;
            }

            lblEnglishWord.Text = words[currentQuestionIndex].EnglishWord;
            options = new List<string> { words[currentQuestionIndex].TurkishMeaning };

            var random = new Random();
            while (options.Count < 4)
            {
                int index = random.Next(words.Count);

                // Doğru anlamı içeren seçeneği ekleme
                if (!options.Contains(words[index].TurkishMeaning))
                {
                    options.Add(words[index].TurkishMeaning);
                }
            }

            options = options.OrderBy(x => random.Next()).ToList();
            correctOptionIndex = options.IndexOf(words[currentQuestionIndex].TurkishMeaning);

            btnOption1.Text = options[0];
            btnOption1.Tag = 0;
            btnOption2.Text = options[1];
            btnOption2.Tag = 1;
            btnOption3.Text = options[2];
            btnOption3.Tag = 2;
            btnOption4.Text = options[3];
            btnOption4.Tag = 3;
        }

        private void CheckAnswer(int selectedOptionIndex)
        {
            if (selectedOptionIndex == correctOptionIndex)
            {
                correctAnswers++;
                lblResult.Text = "Correct!";
                UpdateWordCounter(words[currentQuestionIndex].ID, true);
            }
            else
            {
                lblResult.Text = $"Wrong! \nCorrect answer: {words[currentQuestionIndex].TurkishMeaning}";
                UpdateWordCounter(words[currentQuestionIndex].ID, false);
            }
        }

        private void UpdateWordCounter(int wordId, bool isCorrect)
        {
            string sql = isCorrect ? "UPDATE Words SET correctAnswer = correctAnswer + 1 WHERE wordID = @wordID"
                                   : "UPDATE Words SET correctAnswer = 0 WHERE wordID = @wordID";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@wordID", wordId);
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnStartQuiz_Click_1(object sender, EventArgs e)
        {
            int number = SharedData.QuestionNumber;
            totalQuestions = number;
            LoadRandomWords(totalQuestions);
            currentQuestionIndex = 0;
            correctAnswers = 0;
            DisplayNextWord();
        }

        private void lblEnglishWord_Click(object sender, EventArgs e)
        {

        }

        private void btnOption1_Click(object sender, EventArgs e)
        {

        }

        private void btnOption2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }

    public class Word
    {
        public int ID { get; set; }
        public string EnglishWord { get; set; }
        public string TurkishMeaning { get; set; }
        public int CorrectAnswer { get; set; }
        public string Sentence { get; set; }
    }
}
