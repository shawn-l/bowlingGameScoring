using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowlingGameScoring
{
    public class BowlingGame
    {
        private int[] score;
        private int[] allRollsData;
        private int currentRoll;
        private Scoring scoring;

        public BowlingGame() {
            currentRoll = 0;
            score = new int[11];
            allRollsData = new int[22];
            scoring = new Scoring();
        }

        public int CurrentRound
        {
            get { return currentRoll / 2; }
        }

        public void AddOneRollData(int pins)
        {
            allRollsData[currentRoll++] = pins;
            if (pins == 10 && currentRoll % 2 != 0)
                allRollsData[currentRoll++] = 0;
        }

        public void CalculateScoring()
        {
            scoring.AddRoundData(allRollsData);
            for(int round=1;round<=10;round++)
                 score[round] = scoring.GetScoringInRound(round);
        }
        public int GetScoringInRound(int round)
        {
            return score[round];
        }

        public void PrintAllScore()
        {
            for (int round = 1; round <= 10; round++)
            {
                Console.WriteLine("round {0:D} is {1:D}.", round,GetScoringInRound(round));
            }
        }
    }
}
