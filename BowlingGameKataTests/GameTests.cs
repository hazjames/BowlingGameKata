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

        [Fact]
        public void GetScore_ReturnsZero_WhenBowlingAGutterGame()
        {

        }

        [Fact]
        public void GetScore_ReturnsTen_WhenBowlingOnlyOnePinEachFrame()
        {

        }

        [Fact]
        public void GetScore_ReturnsNinety_WhenBowlingNineAndAMissEachFrame()
        {

        }

        [Fact]
        public void GetScore_ReturnsCorrectScore_WhenBowlingSpareGame()
        {

        }

        [Fact]
        public void GetScore_ReturnsThreeHundred_WhenBowlingAllStrikeGame()
        {

        }
    }
}
