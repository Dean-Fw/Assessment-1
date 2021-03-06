using System;
using System.Collections.Generic;

namespace Voting_App___Antony_Scott
{
    class DHondtSystem
    {
        static void Main(string[] args)
        {
            MEPCandidates brexit = new MEPCandidates();
            brexit.party_Name = "Brexit Party";
            brexit.vote_Count = 452321;
            brexit.Candidates = new string[5] { "BP1", "BP2", "BP3", "BP4", "BP5" };

            MEPCandidates liberal_democrats = new MEPCandidates();
            liberal_democrats.party_Name = "Liberal Democrats";
            liberal_democrats.vote_Count = 203989;
            liberal_democrats.Candidates = new string[5] { "LD1", "LD2", "LD3", "LD4", "LD5" };

            MEPCandidates labour = new MEPCandidates();
            labour.party_Name = "Labour Party";
            labour.vote_Count = 164682;
            labour.Candidates = new string[5] { "LAB1", "LAB2", "LAB3", "LAB4", "LAB5" };

            MEPCandidates conservatives = new MEPCandidates();
            conservatives.party_Name = "Conservative Party";
            conservatives.vote_Count = 126138;
            conservatives.Candidates = new string[5] { "CON1", "CON2", "CON3", "CON4", "CON5" };

            MEPCandidates green = new MEPCandidates();
            green.party_Name = "Green Party";
            green.vote_Count = 124630;
            green.Candidates = new string[5] { "GR1", "GR2", "GR3", "GR4", "GR5" };

            MEPCandidates ukip = new MEPCandidates();
            ukip.party_Name = "UKIP";
            ukip.vote_Count = 58198;
            ukip.Candidates = new string[5] { "UKP1", "UKP2", "UKP3", "UKP4", "UKP5" };

            MEPCandidates change_uk = new MEPCandidates();
            change_uk.party_Name = "Change UK Party";
            change_uk.vote_Count = 41117;
            change_uk.Candidates = new string[5] { "CUK1", "CUK2", "CUK3", "CUK4", "CUK5" };

            MEPCandidates independent_network = new MEPCandidates();
            independent_network.party_Name = "Independent Network Party";
            independent_network.vote_Count = 7641;
            independent_network.Candidates = new string[5] { "INET1", "INET2", "INET3", "INET4", "INET5" };

            MEPCandidates independent = new MEPCandidates();
            independent.party_Name = "Independent Party";
            independent.vote_Count = 4511;
            independent.Candidates = new string[1] { "IND1" };
        }
    }
}
