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

    public partial class Analysis : Form
    {

        string connectionString = "Data Source=IREM\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public Analysis()
        {
            InitializeComponent();
        }

        private void LoadKnownWords()
        {
            using (connection = new SqlConnection(connectionString))
            {
                // Veritabanından verileri çek ve DataGridView'e yükle
                adapter = new SqlDataAdapter("SELECT word FROM Words WHERE correctAnswer=6", connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void LoadUnknownWords()
        {
            using (connection = new SqlConnection(connectionString))
            {
                // Veritabanından verileri çek ve DataGridView'e yükle
                adapter = new SqlDataAdapter("SELECT word FROM Words WHERE correctAnswer!=6", connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;
            }
        }


        private void Analysis_Load(object sender, EventArgs e)
        {
            LoadKnownWords();
            LoadUnknownWords();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Formun boyutlarıyla aynı boyutta bir bitmap oluşturun
            Bitmap bitmap = new Bitmap(this.Width, this.Height);

            // Bitmap üzerine çizim yapmak için bir Graphics nesnesi oluşturun
            Graphics graphics = Graphics.FromImage(bitmap);

            // Formun içeriğini bitmap'e çizin
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            string directoryPath = @"C:\path\to\save";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }


            // Kullanıcıya bir mesaj gösterin
            MessageBox.Show("Ekran görüntüsü kaydedildi: " + directoryPath);

        }
    }
}
