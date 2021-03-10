using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
    class mepCandidates
    {
        private string _partyName;
        private int _voteCount;
        private string[] _Candidates;
        public int dividecount;
        public int MEPCOUNT;
        public string partyname;
        public string candidatesGiven
        {
            get { return _partyName; }
            set { _partyName = value; }
        }

        public int voteCount
        {
            get { return _voteCount; }
            set { _voteCount = value; }
        }
        public string[] candidates
        {
            get { return _Candidates; }
            set { _Candidates = value; }
        }
    }
}
