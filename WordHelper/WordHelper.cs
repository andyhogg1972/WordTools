using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Helpers

{
  public class WordHelper : IWordHelper
  {
    public bool IsAnagram(string word1, string word2)
    {
      //strip punctuation and make lower case
      var word1Stripped = StripPunctuationMakeLowercase(word1);
      var word2Stripped = StripPunctuationMakeLowercase(word2);
      
      //sort strings alphabetically and remove duplicate letters
      var word1sorted = OrderString(word1Stripped);
      var word2sorted = OrderString(word2Stripped);

      //compare strings
      return string.Compare(word1sorted, word2sorted) == 0;
    }

    public bool IsPalindrome(string word)
    {
      //strip punctuation and make lower case
      var wordStripped = StripPunctuationMakeLowercase(word);

      //reverse string
      var reverse = new String(wordStripped.Reverse().ToArray());

      //compare word with reverse
      return string.Compare(wordStripped, reverse) == 0;
    }

    private string StripPunctuationMakeLowercase(string word)
    {
      return Regex.Replace(word.ToLower(), @"[^a-z0-9]", "");
    }

    private string OrderString(string word)
    {
      return new String(word.OrderBy(c => c).ToArray());
    }
  }
}
