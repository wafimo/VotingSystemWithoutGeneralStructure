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

namespace ProjectOnVotingSystem.Interfaces.UserInterfaces
{
    public partial class ResultUi : MetroForm
    {
        public ResultUi()
        {
            InitializeComponent();
            resultStatusButton.Enabled = false;
            CheckPublishStatus();
        }

        private void CheckWinner()
        {
            winnerNameTextBox.Enabled = false;
            achievedVoteTextBox.Enabled = false;

            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = ("select t_candidate.candidateName, t_vote.numberOfVote from t_candidate inner join t_vote on t_candidate.id=t_vote.candidateID where t_vote.numberOfVote=(select max(t_vote.numberOfVote) from t_vote)");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader;
            aReader = command.ExecuteReader();
            while (aReader.Read())
            {

                winnerNameTextBox.Text = aReader["candidateName"].ToString();
                achievedVoteTextBox.Text = aReader["NumberOfVote"].ToString();
            }
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
                resultGroupBox.Text = "Result of Candidates";
                Publish();
                resultGridView.Enabled = false;
                resultStatusButton.Text = "Result Has Been Published";
                resultStatusButton.BackColor = Color.DarkGreen;
                CheckWinner();
            }
            else
            {
                resultGridView.Hide();
                resultGroupBox.Text = "Result is not published yet";
                resultStatusButton.Text = "Result Has Not Published Yet";
                resultStatusButton.BackColor = Color.Red;
                winnerPanel.Hide();
            }
        }
        private void Publish()
        {
            string conn = @"server= WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = "SELECT t_candidate.candidateName,t_vote.numberOfVote From t_candidate INNER JOIN t_vote ON t_candidate.id=t_vote.candidateID";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            resultGridView.Rows.Clear();
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
                resultGridView.Rows.Add(SlNo, result.CandidateName, result.NumberOfVote);
                SlNo++;
            }
        }

        private void ResultUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            HomepageUI aUi = new HomepageUI();
            aUi.Show();
        }
    }
}
