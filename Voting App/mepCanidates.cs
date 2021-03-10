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
        private string _outputText;
        private int _numCandidates;

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
        public string outputText
        {
            get { return _outputText; }
            set { _outputText = value; }
        }
        public int numCandidates
        {
            get { return _numCandidates; }
            set { _numCandidates = value; }
        }
    }
}
