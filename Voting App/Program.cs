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
            BP.outputText = "";
            BP.numCandidates = 0;

            mepCanidates LD = new mepCanidates();
            LD.partyname = "Liberal Democrats";
            LD.voteCount = 203989;
            LD.candidates = new string[5] { "LD1", "LD2", "LD3", "LD4", "LD5" };
            LD.outputText = "";
            LD.numCandidates = 0;

            mepCanidates LB = new mepCanidates();
            LB.partyname = "Labour Party";
            LB.voteCount = 164682;
            LB.candidates = new string[5] { "LAB1", "LAB2", "LAB3", "LAB4", "LAB5" };
            LB.outputText = "";
            LB.numCandidates = 0;

            mepCanidates CON = new mepCanidates();
            CON.partyname = "Conservatives";
            CON.voteCount = 126138;
            CON.candidates = new string[5] { "CON1", "CON2", "CON3", "CON4", "CON5" };
            CON.outputText = "";
            CON.numCandidates = 0;

            mepCanidates GR = new mepCanidates();
            GR.partyname = "Green Party";
            GR.voteCount = 124630;
            GR.candidates = new string[5] { "GR1", "GR2", "GR3", "GR4", "GR5" };
            GR.outputText = "";
            GR.numCandidates = 0;

            mepCanidates UP = new mepCanidates();
            UP.partyname = "UKIP";
            UP.voteCount = 58198;
            UP.candidates = new string[5] { "UKP1", "UKP2", "UKP3", "UKP4", "UKP5" };
            UP.outputText = "";
            UP.numCandidates = 0;

            mepCanidates CU = new mepCanidates();
            CU.partyname = "Change UK";
            CU.voteCount = 41117;
            CU.candidates = new string[5] { "CUK1", "CUK2", "CUK3", "CUK4", "CUK5" };
            CU.outputText = "";
            CU.numCandidates = 0;

            mepCanidates IN = new mepCanidates();
            IN.partyname = "Independent Network";
            IN.voteCount = 7641;
            IN.candidates = new string[5] { "INET1", "INET2", "INET3", "INET4", "INET5" };
            IN.outputText = "";
            IN.numCandidates = 0;


            mepCanidates ID = new mepCanidates();
            ID.partyname = "Independent";
            ID.voteCount = 4511;
            ID.candidates = new string[1] { "IND1" };
            ID.outputText = "";
            ID.numCandidates = 0;


            for (int x = 0; x < 5; x++)
            {
                int highest = BP.voteCount;
                string highestParty = "Brexit Party";
                if (LD.voteCount > highest)
                {
                    highest = LD.voteCount;
                    highestParty = LD.partyname;
                }
                if (LB.voteCount > highest)
                {
                    highest = LB.voteCount;
                    highestParty = LB.partyname;
                }
                if (CON.voteCount > highest)
                {
                    highest = CON.voteCount;
                    highestParty = CON.partyname;
                }
                if (GR.voteCount > highest)
                {
                    highest = GR.voteCount;
                    highestParty = GR.partyname;
                }
                if (UP.voteCount > highest)
                {
                    highest = UP.voteCount;
                    highestParty = UP.partyname;
                }
                if (CU.voteCount > highest)
                {
                    highest = CU.voteCount;
                    highestParty = CU.partyname;
                }
                if (IN.voteCount > highest)
                {
                    highest = IN.voteCount;
                    highestParty = IN.partyname;
                }
                if (ID.voteCount > highest)
                {
                    highest = ID.voteCount;
                    highestParty = ID.partyname;
                }
                if (highestParty == BP.partyname)
                {
                    if (BP.outputText == "")
                    {
                        BP.outputText = BP.outputText + BP.partyname + "," + BP.candidates[0];
                        BP.voteCount = BP.voteCount / 2;
                        BP.numCandidates += 1;
                    }
                    else
                    {
                        BP.outputText = BP.outputText + "," + BP.candidates[BP.numCandidates];
                        BP.voteCount = BP.voteCount / 2;
                        BP.numCandidates += 1;
                    }
                }
                if (highestParty == LD.partyname)
                {
                    if (LD.outputText == "")
                    {
                        LD.outputText = LD.outputText + LD.partyname + "," + LD.candidates[0];
                        LD.voteCount = LD.voteCount / 2;
                        LD.numCandidates += 1;
                    }
                    else
                    {
                        LD.outputText = LD.outputText + "," + LD.candidates[LD.numCandidates];
                        LD.voteCount = LD.voteCount / 2;
                        LD.numCandidates += 1;
                    }
                }
                if (highestParty == LB.partyname)
                {
                    if (LB.outputText == "")
                    {
                        LB.outputText = LB.outputText + LB.partyname + "," + LB.candidates[0];
                        LB.voteCount = LB.voteCount / 2;
                        LB.numCandidates += 1;
                    }
                    else
                    {
                        LB.outputText = LB.outputText + "," + LB.candidates[LB.numCandidates];
                        LB.voteCount = LB.voteCount / 2;
                        LB.numCandidates += 1;
                    }
                }
                if (highestParty == CON.partyname)
                {
                    if (CON.outputText == "")
                    {
                        CON.outputText = CON.outputText + CON.partyname + "," + CON.candidates[0];
                        CON.voteCount = CON.voteCount / 2;
                        CON.numCandidates += 1;
                    }
                    else
                    {
                        CON.outputText = CON.outputText + "," + CON.candidates[CON.numCandidates];
                        CON.voteCount = CON.voteCount / 2;
                        CON.numCandidates += 1;
                    }
                }
                if (highestParty == GR.partyname)
                {
                    if (GR.outputText == "")
                    {
                        GR.outputText = GR.outputText + GR.partyname + "," + GR.candidates[0];
                        GR.voteCount = GR.voteCount / 2;
                        GR.numCandidates += 1;
                    }
                    else
                    {
                        GR.outputText = GR.outputText + "," + GR.candidates[GR.numCandidates];
                        GR.voteCount = GR.voteCount / 2;
                        GR.numCandidates += 1;
                    }
                }
                if (highestParty == UP.partyname)
                {
                    if (UP.outputText == "")
                    {
                        UP.outputText = UP.outputText + UP.partyname + "," + UP.candidates[0];
                        UP.voteCount = UP.voteCount / 2;
                        UP.numCandidates += 1;
                    }
                    else
                    {
                        UP.outputText = UP.outputText + "," + UP.candidates[UP.numCandidates];
                        UP.voteCount = UP.voteCount / 2;
                        UP.numCandidates += 1;
                    }
                }
                if (highestParty == CU.partyname)
                {
                    if (CU.outputText == "")
                    {
                        CU.outputText = CU.outputText + CU.partyname + "," + CU.candidates[0];
                        CU.voteCount = CU.voteCount / 2;
                        CU.numCandidates += 1;
                    }
                    else
                    {
                        CU.outputText = CU.outputText + "," + CU.candidates[CU.numCandidates];
                        CU.voteCount = CU.voteCount / 2;
                        CU.numCandidates += 1;
                    }
                }
                if (highestParty == IN.partyname)
                {
                    if (IN.outputText == "")
                    {
                        IN.outputText = IN.outputText +  IN.partyname + "," + IN.candidates[0];
                        IN.voteCount = IN.voteCount / 2;
                        IN.numCandidates += 1;
                    }
                    else
                    {
                        IN.outputText = IN.outputText + "," + IN.candidates[IN.numCandidates];
                        IN.voteCount = IN.voteCount / 2;
                        IN.numCandidates += 1;
                    }
                }
                if (highestParty == ID.partyname)
                {
                    if (ID.outputText == "")
                    {
                        ID.outputText = ID.outputText + ID.partyname + "," + ID.candidates[0];
                        ID.voteCount = ID.voteCount / 2;
                        ID.numCandidates += 1;
                    }
                    else
                    {
                        ID.outputText = ID.outputText + "," + ID.candidates[ID.numCandidates];
                        ID.voteCount = ID.voteCount / 2;
                        ID.numCandidates += 1;
                    }
                }
            }
            Console.WriteLine("East Middlands (European Parliment Constituency)");
            Console.WriteLine(BP.outputText);
            Console.WriteLine(LD.outputText);
            Console.WriteLine(LB.outputText);
            Console.WriteLine(CON.outputText);
            Console.WriteLine(GR.outputText);
            Console.WriteLine(UP.outputText);
            Console.WriteLine(CU.outputText);
            Console.WriteLine(IN.outputText);
            Console.WriteLine(ID.outputText);
        }
    }
}
