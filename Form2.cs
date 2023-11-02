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

        private void signup_Click(object sender, EventArgs e)
        {
            // Fetch the username and password from textboxes
            string NewUsername = signupusername.Text;
            string NewPassword = signuppassword.Text;

            // Create a query to insert the new user
            string sql = "INSERT INTO users (username, password) VALUES (@NewUsername, @NewPassword)";

            // Open the database connection
            connection.Open();

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("NewUsername", NewUsername);  // Use the parameter names here
                cmd.Parameters.AddWithValue("NewPassword", NewPassword);  // Use the parameter names here

                int rowsAffected = cmd.ExecuteNonQuery();  // Execute the INSERT statement

                if (rowsAffected > 0)
                {
                    // Rows were affected, indicating a successful insertion
                    MessageBox.Show("Account created successfully!");
                }
                else
                {
                    // No rows were affected, indicating a failed insertion
                    MessageBox.Show("Signup failed. Please check your credentials.");
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
