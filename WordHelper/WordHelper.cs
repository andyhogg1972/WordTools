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
      var word1Stripped = Regex.Replace(word1.ToLower(), @"[^a-z0-9]", "");
      var word2Stripped = Regex.Replace(word2.ToLower(), @"[^a-z0-9]", "");
      
      //sort strings alphabetically and remove duplicate letters
      var word1sorted = new String(word1Stripped.OrderBy(c => c).Distinct().ToArray());
      var word2sorted = new String(word2Stripped.OrderBy(c => c).Distinct().ToArray());

      //compare strings
      return string.Compare(word1sorted, word2sorted) == 0;
    }

    public bool IsPalindrome(string word)
    {
      //strip punctuation and make lower case
      var wordStripped = Regex.Replace(word.ToLower(), @"[^a-z0-9]", "");

      //reverse string
      var reverse = new String(wordStripped.Reverse().ToArray());

      //compare word with reverse
      return string.Compare(wordStripped, reverse) == 0;
    }
  }
}
