using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
    class mepCanidates
    {
        private string _partyName;
        private int _voteCount;
        private string[] _canidates;

        public string partyname
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
            get { return _canidates; }
            set { _canidates = value; }
        }
    }
}
