using System;
using System.Collections.Generic;

namespace BowlingGameKata
{
    public class Game
    {
        private List<int> rolls = new List<int>();

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


                    if (isStrike(rollIndex))
                    {
                        score += CalculateStrikeFrame(rollIndex);

                        rollIndex++;
                    }
                    else if (isSpare(rollIndex))
                    {
                        score += CalculateSpareFrame(rollIndex);

                        rollIndex += 2;
                    }
                    else
                    {
                        score += CalculateNormalFrame(rollIndex);

                        rollIndex += 2;
                    }
                }

                return score;
            }
        }

        private int CalculateNormalFrame(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1];
        }

        private int CalculateStrikeFrame(int rollIndex)
        {
            return 10 + rolls[rollIndex + 1] + rolls[rollIndex + 2];
        }

        private int CalculateSpareFrame(int rollIndex)
        {
            return 10 + rolls[rollIndex + 2];
        }

        private bool isSpare(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
        }

        private bool isStrike(int rollIndex)
        {
            return rolls[rollIndex] == 10;
        }
    }
}
