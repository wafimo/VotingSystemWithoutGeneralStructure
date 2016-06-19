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
using ProjectOnVotingSystem.Interfaces.UserInterfaces;

namespace ProjectOnVotingSystem.Interfaces
{
    public partial class HomepageUI : MetroForm
    {
        public HomepageUI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInUI aUi = new LogInUI();
            aUi.ShowDialog();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultUi aUi = new ResultUi();
            aUi.ShowDialog();
        }

        private void fileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Gold;

        }

        private void fileToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            menuStrip1.BackColor = DefaultBackColor;
        }   
    }
}
