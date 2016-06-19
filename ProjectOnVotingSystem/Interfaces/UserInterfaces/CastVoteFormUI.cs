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
    public partial class CastVoteFormUI : MetroForm
    {

        public CastVoteFormUI(string userEmail)
        {
            InitializeComponent();
            voterEmailLabel.Text = userEmail;
            CheckVotingOnStatus();
            candidateGridView.Enabled = false;
        }

        //extra contructor
        public CastVoteFormUI()
        {
            InitializeComponent();
            FillCombo();
        }
        //end

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
                CheckUser();
                FillCombo();
                LoadGridView();
            }
            else if (systemOn == "Off")
            {
                castButton.Text = "Voting System is Off Now";
                castButton.Enabled = false;
                symbolComboBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Erorr");
            }
        }



        private User aUser = new User();

        //user check
        public void CheckUser()
        {
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = ("SELECT * FROM t_login");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader;
            aReader = command.ExecuteReader();

            while (aReader.Read())
            {
                if ((string)aReader["username"] == voterEmailLabel.Text)
                {
                    if ((string)aReader["status"] == "Voted")
                    {
                        symbolComboBox.Enabled = false;
                        castButton.Enabled = false;
                        castButton.Text = "Your vote is already given";
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            connection.Close();
        }
        //end check
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


        private List<Candidate> candidateList = new List<Candidate>();

        private void FillCombo()
        {
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection(conn);
            string query = "SELECT * FROM t_candidate";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader;
            connection.Open();
            aReader = command.ExecuteReader();

            try
            {
                while (aReader.Read())
                {
                    Candidate aCandidate = new Candidate();
                    aCandidate.Id = Convert.ToInt32(aReader["id"]);
                    aCandidate.CandidateName = aReader["candidateName"].ToString();
                    aCandidate.Symbol = aReader["symbol"].ToString();
                    candidateList.Add(aCandidate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
            symbolComboBox.DisplayMember = "Symbol";
            symbolComboBox.DataSource = candidateList;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            LogInUI aLogInUi = new LogInUI();
            aLogInUi.ShowDialog();
        }

        private void CastVoteFormUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        private void castButton_Click(object sender, EventArgs e)
        {
            Candidate candidate = (Candidate)symbolComboBox.SelectedItem;

            //---------------------------------
            string conn = @"server=WAFI-PC\SQLEXPRESS; database=Voting_System;integrated security=true";
            SqlConnection connection = new SqlConnection(conn);
            string query = "SELECT * FROM t_candidate";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader;
            connection.Open();
            aReader = command.ExecuteReader();
            int affectedRow = 0;
            string symbol = "";
            while (aReader.Read())
            {
                symbol = (string)aReader["symbol"];

                if (symbol == candidate.Symbol)
                {
                    aReader.Close();
                    string query1 = "UPDATE t_vote SET numberOfVote+='1' WHERE candidateID = '" + candidate.Id + "' ";
                    SqlCommand command1 = new SqlCommand(query1, connection);
                    affectedRow = command1.ExecuteNonQuery();
                    break;
                }

            }
            connection.Close();
            if (affectedRow > 0)
            {
                symbolComboBox.Enabled = false;
                castButton.Enabled = false;
                connection.Open();
                string query3 = "SELECT * FROM t_login";
                SqlCommand command3 = new SqlCommand(query3, connection);
                aReader = command3.ExecuteReader();
                while (aReader.Read())
                {
                    if ((string)aReader["username"] == voterEmailLabel.Text)
                    {
                        connection.Close();
                        connection.Open();
                        string query4 = "UPDATE t_login SET status = 'Voted' WHERE username= '" + voterEmailLabel.Text +
                                        "'";
                        SqlCommand command1 = new SqlCommand(query4, connection);
                        affectedRow = command1.ExecuteNonQuery();
                        if (affectedRow > 0)
                        {
                            MessageBox.Show("You have voted for " + candidate.CandidateName);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Error occured");
                            break;
                        }
                    }
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Error Occured");
            }

            connection.Close();
        }
    }
}
