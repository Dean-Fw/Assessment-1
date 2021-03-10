using System;
using System.Collections.Generic;

namespace Voting_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //canidate calsses filled

            mepCandidates BP = new mepCandidates();
            BP.partyname = "Brexit Party";
            BP.voteCount = 452321;
            BP.candidates = new string[5] { "BP1", "BP2", "BP3", "BP4", "BP5" };
            BP.dividecount = 2;
            BP.candidatesGiven = " ";

            mepCandidates LD = new mepCandidates();
            LD.partyname = "Liberal Democrats";
            LD.voteCount = 203989;
            LD.candidates = new string[5] { "LD1", "LD2", "LD3", "LD4", "LD5" };
            LD.dividecount = 2;
            LD.candidatesGiven = " ";

            mepCandidates LB = new mepCandidates();
            LB.partyname = "Labour Party";
            LB.voteCount = 164682;
            LB.candidates = new string[5] { "LAB1", "LAB2", "LAB3", "LAB4", "LAB5" };
            LB.dividecount = 2;
            LB.candidatesGiven = " ";

            mepCandidates CON = new mepCandidates();
            CON.partyname = "Conservatives";
            CON.voteCount = 126138;
            CON.candidates = new string[5] { "CON1", "CON2", "CON3", "CON4", "CON5" };
            CON.dividecount = 2;
            CON.candidatesGiven = " ";

            mepCandidates GR = new mepCandidates();
            GR.partyname = "Green Party";
            GR.voteCount = 124630;
            GR.candidates = new string[5] { "GR1", "GR2", "GR3", "GR4", "GR5" };
            GR.dividecount = 2;
            GR.candidatesGiven = " ";

            mepCandidates UP = new mepCandidates();
            UP.partyname = "UKIP";
            UP.voteCount = 58198;
            UP.candidates = new string[5] { "UKP1", "UKP2", "UKP3", "UKP4", "UKP5" };
            UP.dividecount = 2;
            UP.candidatesGiven = " ";

            mepCandidates CU = new mepCandidates();
            CU.partyname = "Change UK";
            CU.voteCount = 41117;
            CU.candidates = new string[5] { "CUK1", "CUK2", "CUK3", "CUK4", "CUK5" };
            CU.dividecount = 2;
            CU.candidatesGiven = " ";

            mepCandidates IN = new mepCandidates();
            IN.partyname = "Independant Network";
            IN.voteCount = 7641;
            IN.candidates = new string[5] { "INET1", "INET2", "INET3", "INET4", "INET5" };
            IN.dividecount = 2;
            IN.candidatesGiven = " ";

            mepCandidates ID = new mepCandidates();
            ID.partyname = "Independant";
            ID.voteCount = 4511;
            ID.candidates = new string[1] { "IND1" };
            ID.dividecount = 2;
            ID.candidatesGiven = " ";

            // Places all votes into a list next each other so the data can be compared 
            List<int> Partys = new List<int>();
            Partys.Add(BP.voteCount);
            Partys.Add(LD.voteCount);
            Partys.Add(LB.voteCount);
            Partys.Add(CON.voteCount);
            Partys.Add(GR.voteCount);
            Partys.Add(UP.voteCount);
            Partys.Add(CU.voteCount);
            Partys.Add(IN.voteCount);
            Partys.Add(ID.voteCount);

            // Creates an loop that runs 5 times 
            for (int y = 0; y < 5; y++)
            {

                int highest = 0;
                int highestx = 0;
                for (int x = 0; x < 8; x++)
                { // Grabs highes number form the list and saves it for use later
                    if (highest < Partys[x])
                    {
                        highest = Partys[x];
                        highestx = x;
                    }
                }
                // highest means the highest number
                // highestx means the position in list of the highest number
                // These if statements allow the votecount data to be accessed and changed
                if (highestx == 0)
                {
                    Partys[highestx] = BP.voteCount / (BP.dividecount);
                    BP.dividecount += 1;
                    BP.MEPCOUNT += 1;
                }
                if (highestx == 1)
                {
                    Partys[highestx] = LD.voteCount / (LD.dividecount);
                    LD.dividecount += 1;
                    LD.MEPCOUNT += 1;
                }
                if (highestx == 2)
                {
                    Partys[highestx] = LB.voteCount / (LB.dividecount);
                    LB.dividecount += 1;
                    LB.MEPCOUNT += 1;
                }
                if (highestx == 3)
                {
                    Partys[highestx] = CON.voteCount / (CON.dividecount);
                    CON.dividecount += 1;
                    CON.MEPCOUNT += 1;
                }

                if (highestx == 4)
                {
                    Partys[highestx] = GR.voteCount / (GR.dividecount);
                    GR.dividecount += 1;
                    GR.MEPCOUNT += 1;
                }
                if (highestx == 5)
                {
                    Partys[highestx] = UP.voteCount / (UP.dividecount);
                    UP.dividecount += 1;
                    UP.MEPCOUNT += 1;
                }
                if (highestx == 6)
                {
                    Partys[highestx] = CU.voteCount / (CU.dividecount);
                    CU.dividecount += 1;
                    CU.MEPCOUNT += 1;
                }
                if (highestx == 7)
                {
                    Partys[highestx] = IN.voteCount / (IN.dividecount);
                    IN.dividecount += 1;
                    IN.MEPCOUNT += 1;
                }
                if (highestx == 8)
                {
                    Partys[highestx] = ID.voteCount / (ID.dividecount);
                    ID.dividecount += 1;
                    ID.MEPCOUNT += 1;
                }
            } // Counts the MEPs aswell well as moves cross the candidates list 
            for (int i = 0; i < BP.MEPCOUNT; i++)
            {
                BP.candidatesGiven = BP.candidatesGiven +","+ BP.candidates[i];
            }
            for (int i = 0; i < LD.MEPCOUNT; i++)
            {
                LD.candidatesGiven = LD.candidatesGiven +","+ LD.candidates[i];
            }
            for (int i = 0; i < LB.MEPCOUNT; i++)
            {
                LB.candidatesGiven = LB.candidatesGiven +","+ LB.candidates[i];
            }
            for (int i = 0; i < CON.MEPCOUNT; i++)
            {
                CON.candidatesGiven = CON.candidatesGiven +","+ CON.candidates[i];
            }
            for (int i = 0; i < GR.MEPCOUNT; i++)
            {
                GR.candidatesGiven = GR.candidatesGiven +","+ GR.candidates[i];
            }
            for (int i = 0; i < UP.MEPCOUNT; i++)
            {
                UP.candidatesGiven = UP.candidatesGiven +","+ UP.candidates[i];
            }
            for (int i = 0; i < CU.MEPCOUNT; i++)
            {
                CU.candidatesGiven =CU.candidatesGiven +","+ CU.candidates[i];
            }
            for (int i = 0; i < IN.MEPCOUNT; i++)
            {
                IN.candidatesGiven = IN.candidatesGiven +","+ IN.candidates[i];
            }
            for (int i = 0; i < ID.MEPCOUNT; i++)
            {
                ID.candidatesGiven = ID.candidatesGiven +","+ ID.candidates[i];
            }
            // Takes the output of the program so i be reworded and organised 
            string BPWordPlacing = BP.candidatesGiven.Trim();
         string LDWordPlacing = LD.candidatesGiven.Trim();
         string LBWordPlacing = LB.candidatesGiven.Trim();
            // Places output in correct order
            Console.WriteLine("#East Midlands (European Parliament Constituency)");
            Console.WriteLine("Brexit Party"+BPWordPlacing+";");
            Console.WriteLine("Liberal Democrats"+LDWordPlacing+";");
            Console.WriteLine("Labour"+LBWordPlacing+";");
        }
    }
}
