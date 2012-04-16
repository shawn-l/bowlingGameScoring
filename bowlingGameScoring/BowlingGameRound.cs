using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowlingGameScoring
{
    public class Scoring
    {
        private int score;
        private int[] roll = new int[21];
        private int[] roundScoring = new int[11]; 
        private int currentroll;

        public Scoring() {
            currentroll = 0;
            score = 0;
            roundScoring[0] = 0;
        }

        public int  Score      
        {
            get { return score;  }
        }

        public int CurrentRound
        {
            get { return currentroll / 2;  }
        }

        public void AddDownPins(int pins)
        {
            roll[currentroll++] = pins;
            if (pins == 10 && currentroll % 2 != 0)
                roll[currentroll++] = 0;
        }

        public int getScoringInRound(int round)
        {
            int roundfirst = round * 2 -  2;
            int roundsecond = round * 2 - 1;
            if (roll[roundfirst] + roll[roundsecond] == 10)
            {
                if (roll[roundfirst] != 10 && roll[roundsecond] != 10)
                    roundScoring[round] = roundScoring[round - 1] + roll[roundfirst] + roll[roundsecond] + roll[roundsecond + 1];
                else
                    roundScoring[round] = roundScoring[round - 1] +roll[roundfirst] + roll[roundsecond] + roll[roundsecond + 1] + roll[roundsecond + 2];
            }
            else
                roundScoring[round] =  roundScoring[round - 1] + roll[roundfirst] + roll[roundsecond];
            return roundScoring[round];
        }
    }
}
