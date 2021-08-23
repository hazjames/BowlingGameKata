using BowlingGameKata;
using Xunit;

namespace BowlingGameKataTests
{
    public class GameTests
    {
        private readonly Game _sut;

        public GameTests()
        {
            _sut = new Game();
        }

        [Theory]
        [InlineData(20, 0, 0)]
        [InlineData(20, 1, 20)]
        [InlineData(21, 5, 150)]
        public void Score_ReturnsCorrectScore_WhenBowlingSameNumberOfPinsOnEachRoll(int numOfRolls, int numOfPins, int expectedScore)
        {
            RollPins(numOfRolls, numOfPins);

            Assert.Equal(expectedScore, _sut.Score);
        }

        [Fact]
        public void Score_ReturnsNinety_WhenBowlingNineAndAMissEachFrame()
        {
            RollPins(10, new int[] { 9, 0 });

            Assert.Equal(90, _sut.Score);
        }

        [Fact]
        public void Score_DoublesTheNextRoll_WhenBowlingASpare()
        {
            RollSpare();
            _sut.Roll(3);
            RollPins(17, 0);

            Assert.Equal(16, _sut.Score);
        }

        [Fact]
        public void Score_DoublesTheNextFrame_WhenBowlingAStrike()
        {
            RollStrike();
            _sut.Roll(3);
            _sut.Roll(4);
            RollPins(16, 0);

            Assert.Equal(24, _sut.Score);
        }

        [Fact]
        public void Score_ReturnsThreeHundred_WhenBowlingAllStrikeGame()
        {
            RollPins(12, 10);

            Assert.Equal(300, _sut.Score);
        }


        // ------ Helper functions ------

        private void RollPins(int numOfRolls, int numOfPins)
        {
            for (int rollNum = 0; rollNum < numOfRolls; rollNum++)
            {
                _sut.Roll(numOfPins);
            }
        }

        private void RollPins(int numOfFrames, int[] pinsHitPerFrame)
        {
            for (int frameNum = 0; frameNum < numOfFrames; frameNum++)
            {
                _sut.Roll(pinsHitPerFrame[0]);
                _sut.Roll(pinsHitPerFrame[1]);
            }
        }

        private void RollSpare()
        {
            _sut.Roll(5);
            _sut.Roll(5);
        }

        private void RollStrike()
        {
            _sut.Roll(10);
        }
    }
}
