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

namespace ProjectOnVotingSystem.Interfaces.CandidateInterface
{
    public partial class CandidateUI : MetroForm
    {
        public CandidateUI(string nameofCandidate)
        {
            InitializeComponent();
            LoadGridView();
            candidateNameTextBox.Text = nameofCandidate;
            candidateNameTextBox.Enabled = false;
            symbolTextBox.Enabled = false;
            CheckSymbol();
        }

        private void CheckSymbol()
        {
            string conn = @"server= WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = "SELECT symbol FROM t_candidate WHERE candidateName = '"+ candidateNameTextBox.Text+"'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            while (aReader.Read())
            {
                symbolTextBox.Text = aReader["symbol"].ToString();
            }
        }
        private void LoadGridView()
        {
            string conn = @"server= WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = "SELECT candidateName,symbol FROM t_candidate";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            candidateGridView.Rows.Clear();
            List<Candidate> candidateList = new List<Candidate>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Candidate aCandidate = new Candidate();
                    //aCandidate.id = (int)aReader[0];
                    aCandidate.CandidateName = (string)aReader[0];
                    aCandidate.Symbol = (string)aReader[1];
                    candidateList.Add(aCandidate);
                }
            }
            connection.Close();

            int SlNo = 1;
            foreach (var candidate in candidateList)
            {
                candidateGridView.Rows.Add(SlNo, candidate.CandidateName, candidate.Symbol);
                SlNo++;
            }
        }

        private void CandidateUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            HomepageUI aUi = new HomepageUI();
            aUi.Show();
        }

    }
}
