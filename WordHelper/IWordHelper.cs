namespace Helpers
{
  public interface IWordHelper
  {
    /// <summary>
    /// Returns true if word1 is an anagram of word2 (contain the same letters)
    /// Case insensitive and ignores punctuation and spaces.  Does not check for valid English
    /// </summary>
    /// <param name="word1"></param>
    /// <param name="word2"></param>
    /// <returns></returns>
    bool IsAnagram(string word1, string word2);

    /// <summary>
    /// Returns true if word is a palindrome (same read backwards as forwards)
    /// Case insensitive and ignores punctuation and spaces.  Does not check for valid English
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    bool IsPalindrome(string word);
  }

}
