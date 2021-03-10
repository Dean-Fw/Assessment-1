using System;
using System.Collections.Generic;

namespace Voting_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //canidate calsses filled
            
            mepCanidates BP = new mepCanidates();
            BP.partyname = "Brexit Party";
            BP.voteCount = 452321;
            BP.candidates = new string[5] {"BP1", "BP2", "BP3", "BP4", "BP5"};

            mepCanidates LD = new mepCanidates();
            LD.partyname = "Liberal Democrats";
            LD.voteCount = 203989;
            LD.candidates = new string[5] { "LD1", "LD2", "LD3", "LD4", "LD5" };

            mepCanidates LB = new mepCanidates();
            LB.partyname = "Labour Party";
            LB.voteCount = 164682;
            LB.candidates = new string[5] { "LAB1", "LAB2", "LAB3", "LAB4", "LAB5" };

            mepCanidates CON = new mepCanidates();
            CON.partyname = "Conservatives";
            CON.voteCount = 126138;
            CON.candidates = new string[5] { "CON1", "CON2", "CON3", "CON4", "CON5" };

            mepCanidates GR = new mepCanidates();
            GR.partyname = "Green Party";
            GR.voteCount = 124630;
            GR.candidates = new string[5] { "GR1", "GR2", "GR3", "GR4", "GR5" };

            mepCanidates UP = new mepCanidates();
            UP.partyname = "UKIP";
            UP.voteCount = 58198;
            UP.candidates = new string[5] { "UKP1", "UKP2", "UKP3", "UKP4", "UKP5" };

            mepCanidates CU = new mepCanidates();
            CU.partyname = "Change UK";
            CU.voteCount = 41117;
            CU.candidates = new string[5] { "CUK1", "CUK2", "CUK3", "CUK4", "CUK5" };

            mepCanidates IN = new mepCanidates();
            IN.partyname = "Independant Network";
            IN.voteCount = 7641;
            IN.candidates = new string[5] { "INET1", "INET2", "INET3", "INET4", "INET5" };

            mepCanidates ID = new mepCanidates();
            ID.partyname = "Independant";
            ID.voteCount = 4511;
            ID.candidates = new string[1] { "IND1" };

            Console.WriteLine("Wooooo!");
        }
    }
}
