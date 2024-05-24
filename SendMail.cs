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
    public partial class SendMail : Form
    {
        SqlConnection connection = Form1.connection;
        public SendMail()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Gray;
            }
        }


        bool isThere;
        private void button6_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string email = textBox2.Text;


            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Users ", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (username == reader["userName"].ToString().TrimEnd() && email == reader["email"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }

            }
            connection.Close();
            if (isThere)
            {
                MessageBox.Show("A link has been sent to your e-mail account. Check your e-mail account.");
            }
            else
            {
                MessageBox.Show("Your username and e-mail address do not match.");
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "E-mail")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "E-mail";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
