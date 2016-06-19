using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOnVotingSystem
{
    class Candidate
    {
        public int Id { get; set; }
        public string CandidateName { get; set; }
        public int NumberOfVote { get; set; }
        public string Symbol { get; set; }
        public string Password { get; set; }
    }
}
