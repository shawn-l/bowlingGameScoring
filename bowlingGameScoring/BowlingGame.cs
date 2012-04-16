using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowlingGameScoring
{
    public class BowlingGame
    {
        private int score;
        public int Score {
            get { return score; }
        }
        public void add(int pins)
        {
            score += pins;
        }
    }
}
