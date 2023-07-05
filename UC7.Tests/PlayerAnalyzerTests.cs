using Xunit;

namespace UC7.Tests;

public class PlayerAnalyzerTests
{
    private readonly PlayerAnalyzer _playerAnalyzer = new PlayerAnalyzer();

    [Theory]
    [InlineData(25, 5, new int[] { 2, 2, 2 }, 250)]
    [InlineData(15, 3, new int[] { 3, 3, 3 }, 67.5)]
    [InlineData(35, 15, new int[] { 4, 4, 4 }, 2520)]

    public void CalculateScore_SinglePlayerPassed_ScoreOfPlayerIsReturned(int age, int experience, int[] skills, double expectedScore)
    {
        //Arrange
        var player = new Player
        {
            Age = age,
            Experience = experience,
            Skills = skills.ToList()
        };

        var playerList = new List<Player> { player };

        //Act
        var actualScore = _playerAnalyzer.CalculateScore(playerList);

        //Assert
        Assert.Equal(expectedScore, actualScore);
    }

    [Fact]
    public void CalculateScore_MultiplePlayersPassed_SumOfPassedPlayersIsReturned()
    {
        //Arrange
        var playerList = new List<Player>
        {
            new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } },
            new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
        };

        //Act
        var actualScore = _playerAnalyzer.CalculateScore(playerList);

        //Assert
        Assert.Equal(2770, actualScore);
    }
    
    [Fact]
    public void CalculateScore_SkillEqualsNull_ThrowsException()
    {
        //Arrange
        var player = new Player
        {
            Age = 25,
            Experience = 5,
            Skills = null!
        };

        var playerList = new List<Player> { player };

        //Act & Assert
        Assert.ThrowsAny<Exception>(() => _playerAnalyzer.CalculateScore(playerList));
    }

    [Fact]
    public void CalculateScore_EmptyArrayPassed_ThrowsException()
    {
        //Arrange
        var playerList = new List<Player>();

        //Act
        var actualScore = _playerAnalyzer.CalculateScore(playerList);

        //Assert
        Assert.Equal(0, actualScore);
    }
}
