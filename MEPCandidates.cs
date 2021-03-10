using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App___Antony_Scott
{
    class MEPCandidates
    {
        private string partyName;
        private int voteCount;
        private string[] candidates;
        private int divideCount;

        public string party_Name
        {
            get { return party_Name; }
            set { party_Name = value; }
        }

        public int vote_Count
        {
            get { return vote_Count; }
            set { vote_Count = value; }
        }

        public string[] Candidates
        {
            get { return Candidates; }
            set { Candidates = value; }
        }
        public int divide_Count
        {
            get { return divide_Count; }
            set { divide_Count = value; }
        }
    }
}
