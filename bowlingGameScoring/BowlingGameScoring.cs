using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowlingGameScoring
{
    public class Scoring
    {
        private int[] rounddata;
        private int[] roundScoring; 

        public Scoring() {
            roundScoring = new int[11]; 
            roundScoring[0] = 0;
        }

        public void AddRoundData(int[] allrounddata)
        {
            rounddata = allrounddata;
        }

        public int GetScoringInRound(int round)
        {
            int roundfirst = round * 2 -  2;
            int roundsecond = round * 2 - 1;
            if (rounddata[roundfirst] + rounddata[roundsecond] == 10)
            {
                if (rounddata[roundfirst] != 10)
                    roundScoring[round] = roundScoring[round - 1] + rounddata[roundfirst] + rounddata[roundsecond] + rounddata[roundsecond + 1];
                else
                    roundScoring[round] = roundScoring[round - 1] +rounddata[roundfirst] + rounddata[roundsecond] + rounddata[roundsecond + 1] + rounddata[roundsecond + 2];
            }
            else
                roundScoring[round] =  roundScoring[round - 1] + rounddata[roundfirst] + rounddata[roundsecond];
            return roundScoring[round];
        }
    }
}
