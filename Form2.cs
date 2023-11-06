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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace db
{
    public partial class Form2 : Form
    {
        private NpgsqlConnection connection;
        private string connectionString;
        public Form2()
        {
            InitializeComponent();
            connectionString = "Host=localhost;Port=7910;Username=postgres;Password='791000';Database=postgres;";
            connection = new NpgsqlConnection(connectionString);
        }
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
                    }
                    else
                    {
                        MessageBox.Show("No users found.");
                    }
                }
            }
            connection.Close();
        }
        private void signup_Click(object sender, EventArgs e)
        {
            // Fetch the username and password from textboxes
            string NewUsername = signupusername.Text;
            string NewPassword = signuppassword.Text;

            string All_users_query = "SELECT username FROM users WHERE username = @NewUsername";

            connection.Open();

            using (NpgsqlCommand cmd = new NpgsqlCommand(All_users_query, connection))
            {
                cmd.Parameters.AddWithValue("NewUsername", NewUsername);
                object existingUsername = cmd.ExecuteScalar(); // Check if the username already exists

                if (existingUsername != null)
                {
                    MessageBox.Show("Username already exists. Please choose a different one.");
                }
                else
                {
                    string sql = "INSERT INTO users (username, password) VALUES (@NewUsername, @NewPassword)";

                    using (NpgsqlCommand insertCmd = new NpgsqlCommand(sql, connection))
                    {
                        insertCmd.Parameters.AddWithValue("NewUsername", NewUsername);
                        insertCmd.Parameters.AddWithValue("NewPassword", NewPassword);

                        int rowsAffected = insertCmd.ExecuteNonQuery(); // Execute the INSERT statement

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account created successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Signup failed. Please check your credentials.");
                        }
                    }
                }
            }

            connection.Close();
            this.Close();
        }

        private void signupusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void signuppassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
