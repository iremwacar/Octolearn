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
    public partial class ResetPasswordcs : Form
    {
        public ResetPasswordcs()
        {
            InitializeComponent();
        }

        private void ResetPasswordcs_Load(object sender, EventArgs e)
        {

        }

        SqlConnection connection = new SqlConnection("Data Source=IREM\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True");
        string userName;
        string currentPassword;



        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private bool CheckUser(string userName, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.AddWithValue("@password", password);
            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();
            return count > 0;
        }

        private bool UpdatePassword(string userName, string newPassword)
        {
            string query = "UPDATE Users SET Password = @password WHERE Username = @username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.AddWithValue("@password", newPassword);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected > 0;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            userName = txtUsername.Text;
            currentPassword = txtPassword.Text;
            string newPassword = this.txtNewPassword.Text;
            string reEnteredPassword = txtReEnteredPassword.Text;

            // Veritabanından kullanıcı adı ve şifreyi kontrol et
            if (CheckUser(userName, currentPassword))
            {
                // Yeni şifre ile tekrar girilen şifrenin aynı olup olmadığını kontrol et
                if (newPassword == reEnteredPassword)
                {
                    // Veritabanında şifreyi güncelle
                    if (UpdatePassword(userName, newPassword))
                    {
                        MessageBox.Show("Password updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password.");
                    }
                }
                else
                {
                    MessageBox.Show("New password and re-entered password do not match!");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "userName")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "userName";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "newPassword")
            {
                txtNewPassword.Text = "";
                txtNewPassword.ForeColor = Color.Black;
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                txtNewPassword.Text = "newPassword";
                txtNewPassword.ForeColor = Color.Gray;
            }
        }

        private void txtReEnteredPassword_Enter(object sender, EventArgs e)
        {
            if (txtReEnteredPassword.Text == "ReNewPassword")
            {
                txtNewPassword.Text = "";
                txtNewPassword.ForeColor = Color.Black;
            }
        }

        private void txtReEnteredPassword_Leave(object sender, EventArgs e)
        {
            if (txtReEnteredPassword.Text == "")
            {
                txtReEnteredPassword.Text = "ReNewPassword";
                txtReEnteredPassword.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

