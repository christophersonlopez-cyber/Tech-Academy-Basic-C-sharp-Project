using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;  // Para ma-access ang App.config
using System.Data.SqlClient;

namespace GoldenLechonSystem
{
    public partial class Form1 : Form
    {

        private string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["GoldenLechonDB"].ConnectionString;

        }


        private void button1_Click(object sender, EventArgs e)
        {
      
            string username = textBox1.Text;
            string password = textBox2.Text;

            string query = "SELECT COUNT(*) FROM tbl_user WHERE username=@username AND password=@password";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Parameterized query para safe sa SQL injection
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");
                            // Open main form dito
                            // MainForm mainForm = new MainForm();
                            // mainForm.Show();
                            // this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();  // Subukang buksan ang connection
                    MessageBox.Show("Connection successful! ✅");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message + " ❌");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM tbl_user"; // Palitan ng table mo
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt); // Fill ang DataTable

                    dataGridView1.DataSource = dt; // I-bind sa DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
