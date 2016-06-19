using System.Data.SqlClient;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOnVotingSystem.Interfaces;
using ProjectOnVotingSystem.Interfaces.AdminIntefaces;
using ProjectOnVotingSystem.Interfaces.CandidateInterface;
using ProjectOnVotingSystem.Interfaces.UserInterfaces;
using System.Collections;

namespace ProjectOnVotingSystem
{
    public partial class LogInUI : MetroForm
    {
        public LogInUI()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 8;
            candidatePasswordTextBox.PasswordChar = '*';
            candidatePasswordTextBox.MaxLength = 8;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {

            if (userNameTextBox.Text == "" && passwordTextBox.Text == "" && selectComboBox.Text != "Admin" &&
                selectComboBox.Text != "User")
            {
                blankError.SetError(userNameTextBox, "Invalid user name");
                blankError.SetError(passwordTextBox, "Invalid password");
                blankError.SetError(selectComboBox, "Invalid selection");
            }
            else
            {
                string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = conn;
                connection.Open();
                string query = "SELECT * FROM t_login where username = '" + userNameTextBox.Text + "' AND password = '" +
                               passwordTextBox.Text + "' AND type ='" + selectComboBox.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader arReader = command.ExecuteReader();

                string type = "";
                while (arReader.Read())
                {
                    type = arReader["type"].ToString();
                    connection.Close();
                    break;
                }

                if (type == "Admin")
                {
                    Hide();
                    ChooseFormUI aChooseFormUi = new ChooseFormUI();
                    aChooseFormUi.ShowDialog();
                }

                else if (type == "Voter")
                {
                    Hide();
                    CastVoteFormUI aCastVoteFormUi = new CastVoteFormUI(userNameTextBox.Text);
                    aCastVoteFormUi.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void LogInUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        private void checkResultInterfaceButton_Click(object sender, EventArgs e)
        {
            ResultUi aUi = new ResultUi();
            Hide();
            aUi.ShowDialog();
        }

        private void candidateLogInButton_Click(object sender, EventArgs e)
        {
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            string query = "SELECT * FROM t_candidate WHERE candidateName = '" + candidateNameTextBox.Text +
                           "' AND password = '" + candidatePasswordTextBox.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader arReader = command.ExecuteReader();

            bool msg = arReader.HasRows;
            arReader.Close();
            connection.Close();
            if (msg)
            {
                Hide();
                CandidateUI aUi = new CandidateUI(candidateNameTextBox.Text);
                aUi.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}







