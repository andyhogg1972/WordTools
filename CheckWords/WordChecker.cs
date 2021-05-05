using Helpers;
using System;
using System.Collections.Generic;

namespace Tools
{
  public static class WordChecker
  {
    /// <summary>
    /// Checks a list of works to determine which ones are palindromes and which anagrams of each other.
    /// Writes the results to the console.
    /// </summary>
    /// <param name="helper"></param>
    /// <param name="words"></param>
    public static void CheckWords(IWordHelper helper, List<string> words)
    {
      var resultsAnagrams = String.Empty;
      var resultsPalindromes = String.Empty;

      for (int i = 0; i <= words.Count-1; i++)
      {
        resultsPalindromes += helper.IsPalindrome(words[i]) ? "\n" + $"Word{i + 1} is a palindrome." : "";

        for (int j = i+1; j <= words.Count-1; j++)
        {
          resultsAnagrams += helper.IsAnagram(words[i], words[j]) ? "\n" + $"Word{i + 1} is an anagram of word{j + 1}." : "";
        }
      }

      Console.WriteLine(resultsAnagrams);
      Console.WriteLine(resultsPalindromes);

    }

  }
}
