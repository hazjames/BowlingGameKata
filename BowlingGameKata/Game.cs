using System;
using System.Collections.Generic;

namespace BowlingGameKata
{
    public class Game
    {
        private List<int> rolls = new List<int>(21);

        public void Roll(int numOfPins)
        {
            rolls.Add(numOfPins);
        }

        public int Score
        {
            get
            {
                int score = 0;
                int rollIndex = 0;
                for (int frame = 0; frame < 10; frame++)
                {
                    score += rolls[rollIndex];
                    score += rolls[rollIndex + 1];
                }

                return score;
            }
        }
    }
}
