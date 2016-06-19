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
using MetroFramework.Forms;

namespace ProjectOnVotingSystem.Interfaces.AdminIntefaces
{
    public partial class ManageUserFormUI : MetroForm
    {
        public ManageUserFormUI()
        {
            InitializeComponent();
            passwordTextBox.MaxLength = 8;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            ChooseFormUI aChooseFormUi = new ChooseFormUI();
            aChooseFormUi.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            LogInUI aLogInUi = new LogInUI();
            aLogInUi.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            User aUser = new User();
            aUser.Username = userNameTextBox.Text;
            aUser.Password = passwordTextBox.Text;

            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            if (userNameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                connection.Open();
                string query = string.Format("INSERT INTO t_login VALUES ('{0}','{1}','{2}','{3}')", aUser.Username,
                    aUser.Password, "Voter","Not Voted");
                SqlCommand command = new SqlCommand(query, connection);
                int affectedRow = command.ExecuteNonQuery();
                if (affectedRow > 0)
                {
                    MessageBox.Show("Successfully Saved");
                    userNameTextBox.Clear();
                    passwordTextBox.Clear();
                    connection.Close();
                    LoadGridView();
                }
                else
                {
                    MessageBox.Show("Invalid input");
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill up all the field");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            if (deleteUserTextBox.Text != "")
            {
                if (deleteUserTextBox.Text != "admin@iubat.edu")
                {
                    string query = string.Format("DELETE FROM t_login WHERE username ='" + deleteUserTextBox.Text + "'");
                    SqlCommand command = new SqlCommand(query, connection);
                    int affectedRow = command.ExecuteNonQuery();
                    if (affectedRow > 0)
                    {
                        MessageBox.Show("deleted");
                        LoadGridView();
                    }
                    deleteUserTextBox.Clear();
                    connection.Close();

                }
                else
                {
                    MessageBox.Show("ADMIN CANNOT BE DELETED");
                }
            }
            else
            {
                MessageBox.Show("Empty field");
            }
        }

        private void showUserGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = showUserGridView.Rows[e.RowIndex];
                deleteUserTextBox.Text = row.Cells[1].Value.ToString();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void LoadGridView()
        {
            string conn = @"server= WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = "SELECT * FROM t_login";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            showUserGridView.Rows.Clear();
            List<User> userList = new List<User>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    User aUser = new User();
                    aUser.Id = (int) aReader[0];
                    aUser.Username = (string) aReader[1];
                    aUser.Password = (string) aReader[2];
                    aUser.Type = (string) aReader[3];
                    aUser.Status = aReader[4].ToString();

                    userList.Add(aUser);
                }
            }
            connection.Close();

            int SlNo = 1;
            foreach (var user in userList)
            {
                showUserGridView.Rows.Add(SlNo, user.Username, user.Password, user.Status);
                SlNo++;
            }
        }

        private void ManageUserFormUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }
    }
}
