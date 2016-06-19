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
    public partial class ManageVoteFormUI : MetroForm
    {
        public ManageVoteFormUI()
        {
            InitializeComponent();
            CheckPublishStatus();
            CheckVotingOnStatus();
        }

        private void CheckPublishStatus()
        {
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = ("SELECT publishingStatus FROM t_status");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader;
            aReader = command.ExecuteReader();
            string publishStastus = "";
            while (aReader.Read())
            {
                publishStastus = aReader["publishingStatus"].ToString();
            }
            connection.Close();
            if (publishStastus == "Published")
            {
                publishButton.Enabled = false;
                withholdResultButton.Enabled = true;
            }
            else if (publishStastus == "Not Published")
            {
                withholdResultButton.Enabled = false;
                publishButton.Enabled = true;
            }
        }

        private void CheckVotingOnStatus()
        {
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = ("SELECT systemOnStatus FROM t_status");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader;
            aReader = command.ExecuteReader();
            string systemOn = "";
            while (aReader.Read())
            {
                systemOn = aReader["systemOnStatus"].ToString();
            }
            connection.Close();
            if (systemOn == "On")
            {
                voteOnButton.Enabled = false;
                voteOffButton.Enabled = true;
            }
            else if (systemOn == "Off")
            {
                voteOffButton.Enabled = false;
                voteOnButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Erorr");
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            ChooseFormUI aChooseFormUi = new ChooseFormUI();
            aChooseFormUi.ShowDialog();
        }

        private void candidateEntrySaveButton_Click(object sender, EventArgs e)
        {
            Candidate aCandidate = new Candidate();
            aCandidate.CandidateName = candidateNameTextBox.Text;
            aCandidate.Symbol = symbolTextBox.Text;
            aCandidate.Password = passwordTextBox.Text;


            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            if (candidateNameTextBox.Text != "" && symbolTextBox.Text != "" && passwordTextBox.Text != "")
            {
                connection.Open();
                string query = string.Format("INSERT INTO t_candidate VALUES ('{0}','{1}','{2}')", aCandidate.CandidateName, aCandidate.Symbol ,aCandidate.Password );
                SqlCommand command = new SqlCommand(query, connection);
                int affectedRow = command.ExecuteNonQuery();
                if (affectedRow > 0)
                {
                    candidateNameTextBox.Clear();
                    symbolTextBox.Clear();
                    passwordTextBox.Clear();
                    string query2 = "SELECT id FROM t_candidate WHERE Symbol = '" + aCandidate.Symbol + "'";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    SqlDataReader aReader = command2.ExecuteReader();
                    int idHolder = 0;
                    while (aReader.Read())
                    {
                        idHolder = (int)aReader["id"];
                    }
                    connection.Close();
                    connection.Open();
                    string query3 = string.Format("INSERT INTO t_vote values ('{0}','{1}')", idHolder, "0");
                    SqlCommand command3 = new SqlCommand(query3, connection);
                    command3.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                    connection.Close();
                    LoadGridView();

                }
                else
                {
                    MessageBox.Show("Invalid input");
                    connection.Close();
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please fill up all the field");
            }
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
            string query = "SELECT candidateName,symbol,password FROM t_candidate";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            candidateDataGridView.Rows.Clear();
            List<Candidate> candidateList = new List<Candidate>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Candidate aCandidate = new Candidate();
                    //aCandidate.id = (int)aReader[0];
                    aCandidate.CandidateName = (string)aReader[0];
                    aCandidate.Symbol = (string)aReader[1];
                    aCandidate.Password = aReader[2].ToString();
                    candidateList.Add(aCandidate);
                }
            }
            connection.Close();

            int SlNo = 1;
            foreach (var candidate in candidateList)
            {
                candidateDataGridView.Rows.Add(SlNo, candidate.CandidateName, candidate.Symbol,candidate.Password);
                SlNo++;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            if (deleteTextBox.Text != "")
            {
                string query1 = "SELECT id FROM t_candidate WHERE candidateName ='" + deleteTextBox.Text + "'";
                SqlCommand command1 = new SqlCommand(query1, connection);
                SqlDataReader aReader = command1.ExecuteReader();
                int idHolder = 0;
                while (aReader.Read())
                {
                    idHolder = (int)aReader["id"];
                }
                connection.Close();
                connection.Open();
                string query3 = "DELETE FROM t_vote where candidateID='" + idHolder + "'";
                SqlCommand command3 = new SqlCommand(query3, connection);
                command3.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                string query = string.Format("DELETE FROM t_candidate WHERE candidateName ='" + deleteTextBox.Text + "'");
                SqlCommand command = new SqlCommand(query, connection);
                int affectedRow = command.ExecuteNonQuery();
                if (affectedRow > 0)
                {
                    MessageBox.Show("Successfully deleted ");
                    LoadGridView();

                }
                deleteTextBox.Clear();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Empty field");
            }
        }

        private void candidateDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = candidateDataGridView.Rows[e.RowIndex];
            deleteTextBox.Text = row.Cells[1].Value.ToString();
            
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            LogInUI aLogInUi = new LogInUI();
            aLogInUi.ShowDialog();
        }

        private void ManageVoteFormUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }
        //----------------------------------------------------------------//
        private void resultButton_Click(object sender, EventArgs e)
        {
            LoadResultGridView();
            //---------------------------------------------------------------//
        }

        private void LoadResultGridView()
        {
            string conn = @"server= WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query =
                "SELECT t_candidate.candidateName,t_vote.numberOfVote From t_candidate INNER JOIN t_vote ON t_candidate.id=t_vote.candidateID";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            resultDataGridView.Rows.Clear();
            List<Candidate> resultList = new List<Candidate>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Candidate aCandidate = new Candidate();

                    aCandidate.CandidateName = aReader["candidateName"].ToString();
                    aCandidate.NumberOfVote = Convert.ToInt32(aReader["numberOfVote"]);
                    resultList.Add(aCandidate);
                }
            }
            connection.Close();

            int SlNo = 1;
            foreach (var result in resultList)
            {
                resultDataGridView.Rows.Add(SlNo, result.CandidateName, result.NumberOfVote);
                SlNo++;
            }
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query ="UPDATE t_status SET publishingStatus = 'Published' where id = '1'" ;
            SqlCommand command = new SqlCommand(query, connection);
            int affectedRow = command.ExecuteNonQuery();
            if (affectedRow > 0)
            {
                MessageBox.Show("Result has been published");
                publishButton.Enabled = false;
                withholdResultButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("error");
            }

        }

        private void voteOnButton_Click(object sender, EventArgs e)
        {
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = "UPDATE t_status SET systemOnStatus = 'On' where id = '1'";
            SqlCommand command = new SqlCommand(query, connection);
            int affectedRow = command.ExecuteNonQuery();
            if (affectedRow > 0)
            {
                MessageBox.Show("Voting is on");
                voteOffButton.Enabled = true;
                voteOnButton.Enabled = false;

            }
            else
            {
                MessageBox.Show("error");
            }
            
        }

        private void voteOffButton_Click(object sender, EventArgs e)
        {
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = "UPDATE t_status SET systemOnStatus = 'Off' where id = '1'";
            SqlCommand command = new SqlCommand(query, connection);
            int affectedRow = command.ExecuteNonQuery();
            if (affectedRow > 0)
            {
                MessageBox.Show("Voting is off");
                voteOffButton.Enabled = false;
                voteOnButton.Enabled = true;

            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void withholdResultButton_Click(object sender, EventArgs e)
        {
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = "UPDATE t_status SET publishingStatus = 'Not Published' where id = '1'";
            SqlCommand command = new SqlCommand(query, connection);
            int affectedRow = command.ExecuteNonQuery();
            if (affectedRow > 0)
            {
                MessageBox.Show("Result has been WithHold");
                publishButton.Enabled = true;
                withholdResultButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
