using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowlingGameScoring
{
    public class Scoring
    {
        private int[] roundData;
        private int[] roundScore; 

        public Scoring() {
            roundScore = new int[11]; 
            roundScore[0] = 0;
        }

        public void AddRoundData(int[] allRoundData)
        {
            roundData = allRoundData;
        }

        public int GetScoringInRound(int round)
        {
            int firstRoll = round * 2 - 2;
            int secondRoll = round * 2 - 1;

            if ( isStrike(firstRoll) )
                GetStrikeScore(round, firstRoll, secondRoll);
            else if ( isSpare(firstRoll, secondRoll) )
                GetSpareScore(round, firstRoll, secondRoll);
            else
                GetScore(round, firstRoll, secondRoll);
            return roundScore[round];
        }

        private bool isSpare(int firstRoll, int secondRoll)
        {
            return roundData[firstRoll] + roundData[secondRoll] == 10;
        }

        private bool isStrike(int firstRoll)
        {
            return roundData[firstRoll] == 10;
        }


        private void GetScore(int round, int firstRoll, int secondRoll)
        {
            roundScore[round] = roundScore[round - 1] + roundData[firstRoll] + roundData[secondRoll];
        }

        private void GetStrikeScore(int round, int firstRoll, int secondRoll)
        {
            roundScore[round] = roundScore[round - 1] + roundData[firstRoll] + roundData[secondRoll] + roundData[secondRoll + 1] + roundData[secondRoll + 2];
        }

        private void GetSpareScore(int round, int firstRoll, int secondRoll)
        {
            roundScore[round] = roundScore[round - 1] + roundData[firstRoll] + roundData[secondRoll] + roundData[secondRoll + 1] ;
        }
    }
}
