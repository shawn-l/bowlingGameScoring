using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowlingGameScoring
{
    public class BowlingGameRound
    {
        private int score;
        public int  Score      
        {
            get { return score;  }
        }
        public void AddDownPins(int pins)
        {
            score += pins;
        }

       
    }
}
