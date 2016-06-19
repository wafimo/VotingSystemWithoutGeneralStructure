using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ProjectOnVotingSystem.Interfaces.AdminIntefaces
{
    public partial class ChooseFormUI : MetroForm
    {
        public ChooseFormUI()
        {
            InitializeComponent();
        }

        private void manageVoterButton_Click(object sender, EventArgs e)
        {
            Hide();
            ManageUserFormUI aManageUserFormUi = new ManageUserFormUI();
            aManageUserFormUi.ShowDialog();
        }

        private void manageVoteButton_Click(object sender, EventArgs e)
        {
            Hide();
            ManageVoteFormUI aManageVoteFormUi = new ManageVoteFormUI();
            aManageVoteFormUi.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
            LogInUI alLogInUi = new LogInUI();
            alLogInUi.ShowDialog();
        }

        private void ChooseFormUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }
    }
}
