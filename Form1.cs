using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace db
{
    public partial class Form1 : Form
    {
        private void ShowUsers()
        {
            string sql = "SELECT username FROM users";
            connection.Open();

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Binding the retrieved data to the DataGridView control
                        Users.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No users found.");
                    }
                }
            }
            connection.Close();
        }


        private NpgsqlConnection connection;
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = "Host=localhost;Port=7910;Username=postgres;Password='791000';Database=postgres;";
            connection = new NpgsqlConnection(connectionString);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            // Fetch the username and password from textboxes
            string Username = username.Text;
            string Password = password.Text;

            // Create a query to check the credentials
            string sql = "SELECT * FROM users WHERE username = @Username AND password = @Password";

            // Open the database connection
            connection.Open();

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("username", Username);
                cmd.Parameters.AddWithValue("password", Password);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Login successful; user exists in the database
                        // You can add code to navigate to another tab or perform further actions.
                        Form3 secondForm = new Form3();
                        this.Close();
                        // Show the dashboard form
                        secondForm.ShowDialog();
                        
                    }
                    else
                    {
                        // Login failed; user not found or incorrect password
                        MessageBox.Show("Login failed. Please check your credentials.");
                    }
                }
            }
            connection.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();

            // Show the second form
            secondForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showUsers_Click(object sender, EventArgs e)
        {
            ShowUsers();
        }
    }
}
