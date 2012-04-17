using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowlingGameScoring
{
    public class BowlingGame
    {
        private int[] score;
        private int[] allroundpins;
        private int currentroll;
        private Scoring scoring;

        public BowlingGame() {
            currentroll = 0;
            score = new int[11];
            allroundpins = new int[22];
            scoring = new Scoring();
        }

        public int CurrentRound
        {
            get { return currentroll / 2; }
        }

        public void AddDownPins(int pins)
        {
            allroundpins[currentroll++] = pins;
            if (pins == 10 && currentroll % 2 != 0)
                allroundpins[currentroll++] = 0;
        }

        public void CalculateScoring()
        {
            scoring.AddRoundData(allroundpins);
            for(int round=1;round<=10;round++)
                 score[round] = scoring.GetScoringInRound(round);
        }
        public int GetScoringInRound(int round)
        {
            return score[round];
        }
    }
}
