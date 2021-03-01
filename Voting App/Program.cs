using System;
using System.Collections.Generic;

namespace Voting_App
{
    class Program
    {
        static void Main(string[] args)
        {
            mepCanidates BP = new mepCanidates();
            BP.partyname = "Brexit Party";
            BP.voteCount = 452321;
            BP.candidates = new string[5] {"BP1", "BP2", "BP3", "BP4", "BP5"};

            mepCanidates LD = new mepCanidates();
            LD.partyname = "Liberal Democrats";
            LD.voteCount = 203989;
            LD.candidates = new string[5] { "LD1", "LD2", "LD3", "LD4", "LD5" };

            Console.WriteLine("Party: " + LD.partyname + " Vote Count: " + LD.voteCount.ToString());
            for(int x = 0; x >= LD.candidates.Length; x++)
            {
                Console.WriteLine(LD.candidates[x]);
            }


        }
    }
}
