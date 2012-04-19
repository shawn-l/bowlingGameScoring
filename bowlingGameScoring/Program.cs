using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowlingGameScoring
{
    class Program
    {
        static void Main(string[] args)
        {
            BowlingGame game = new BowlingGame();
            string pin;

            Console.WriteLine("Enter the data of each roll,end with -1!");
            
            while ((pin = Console.ReadLine() )!= "-1")
                game.AddOneRollData(int.Parse(pin));
            
            game.CalculateScoring();

            Console.WriteLine("Each round of the game is :");
            game.PrintAllScore();
        }
    }
}
