using Helpers;
using Xunit;

namespace UnitTests
{
  public class HelperTests
  {
    [Fact]
    public void IsPalindrome_True()
    {
      //Arrange
      var helper = new WordHelper();
      var word = "Race car!";

      //Act
      var result = helper.IsPalindrome(word);

      //Assert
      Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_False()
    {
      //Arrange
      var helper = new WordHelper();
      var word = "Mud!?";

      //Act
      var result = helper.IsPalindrome(word);

      //Assert
      Assert.False(result);
    }

    [Fact]
    public void IsAnagram_True()
    {
      //Arrange
      var helper = new WordHelper();
      var word1 = "Old West Action??$";
      var word2 = "Clint EastWood";

      //Act
      var result = helper.IsAnagram(word1, word2);

      //Assert
      Assert.True(result);
    }

    [Fact]
    public void IsAnagram_False()
    {
      //Arrange
      var helper = new WordHelper();
      var word1 = "Old East Action££";
      var word2 = "Clint EastWood";

      //Act
      var result = helper.IsAnagram(word1, word2);

      //Assert
      Assert.False(result);
    }

  }
}
