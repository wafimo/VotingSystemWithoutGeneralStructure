using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOnVotingSystem.Interfaces;
using ProjectOnVotingSystem.Interfaces.AdminIntefaces;
using ProjectOnVotingSystem.Interfaces.UserInterfaces;

namespace ProjectOnVotingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomepageUI());
            //Application.Run(new LogInUI());
            //Application.Run(new ChooseFormUI());
            //Application.Run(new ManageUserFormUI());
            //Application.Run(new ManageVoteFormUI());
            //Application.Run(new CastVoteFormUI());
        }
    }
}
