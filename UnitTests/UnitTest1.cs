using Xunit;
using UnitTesting;

namespace UnitTests
{
    public class RockPaperScissorsTest
    {
        [Fact]
        public void TestTie()
        {
            //Arrange
            string player1 = "rock";
            string player2 = "rock";

            // Actual
            string actual = Methods.RockPaperScissors(player1, player2);

            // Assert
            Assert.Equal("It's a tie!", actual);
        }

        [Fact]
        public void TestRockWinsP1()
        {
            //Arrange
            string player1 = "rock";
            string player2 = "scissors";

            // Actual
            string actual = Methods.RockPaperScissors(player1, player2);

            // Assert
            Assert.Equal("Player 1 wins!", actual);
        }

        [Fact]
        public void TestRockWinsP2()
        {
            //Arrange
            string player1 = "scissors";
            string player2 = "rock";

            // Actual
            string actual = Methods.RockPaperScissors(player1, player2);

            // Assert
            Assert.Equal("Player 2 wins!", actual);
        }

        [Fact]
        public void TestPaperWinsP1()
        {
            //Arrange
            string player1 = "paper";
            string player2 = "rock";

            // Actual
            string actual = Methods.RockPaperScissors(player1, player2);

            // Assert
            Assert.Equal("Player 1 wins!", actual);
        }

        [Fact]
        public void TestPaperWinsP2()
        {
            //Arrange
            string player1 = "rock";
            string player2 = "paper";

            // Actual
            string actual = Methods.RockPaperScissors(player1, player2);

            // Assert
            Assert.Equal("Player 2 wins!", actual);
        }

        [Fact]
        public void TestScissorsWinsP1()
        {
            //Arrange
            string player1 = "scissors";
            string player2 = "paper";

            // Actual
            string actual = Methods.RockPaperScissors(player1, player2);

            // Assert
            Assert.Equal("Player 1 wins!", actual);
        }

        [Fact]
        public void TestScissorsWinsP2()
        {
            //Arrange
            string player1 = "paper";
            string player2 = "scissors";

            // Actual
            string actual = Methods.RockPaperScissors(player1, player2);

            // Assert
            Assert.Equal("Player 2 wins!", actual);
        }
    }

    public class SortNumsTest
    {
        [Theory]
        [InlineData(new int[] {1, 6, 3, 4, 5}, new int[] {1, 3, 4, 5, 6})]
        [InlineData(new int[] {}, new int[] {})]
        [InlineData(new int[] { 5, 5, 5, 5, 5 }, new int[] { 5, 5, 5, 5, 5 })]
        [InlineData(new int[] { 0, 800, 5, -3, 17 }, new int[] { -3, 0, 5, 17, 800 })]
        [InlineData(new int[] { -25, 2, -45, -3, 17 }, new int[] { -45, -25, -3, 2, 17 })]

        public void TestSort(int[] valuesarray, int[] expectedarray)
        {
            List<int> values = new List<int>(valuesarray);
            List<int> expected = new List<int>(expectedarray);

            List<int> actual = Methods.SortNums(values);
            Assert.Equal(expected, actual);
        }
    }

    public class IsSunUpTest
    {
        [Theory]
        [InlineData(3, 0, false)]
        [InlineData(6, 0, false)]
        [InlineData(7, 0, false)]
        [InlineData(7, 3, false)]
        [InlineData(8, 0, true)]
        [InlineData(12, 0, true)]
        [InlineData(17, 15, true)]
        [InlineData(20, 0, false)]
        [InlineData(20, 30, false)]
        [InlineData(21, 0, true)]
        [InlineData(23, 59, false)]

        public void TestSunIsUp(int hour, int min, bool expected)
        {
            // Arrange
            TimeSpan daylight = new TimeSpan(hour,min,0);

            // Actual
            bool actual = Methods.IsTheSunUp(daylight);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}