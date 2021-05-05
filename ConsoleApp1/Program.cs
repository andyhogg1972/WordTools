using Helpers;
using System.Collections.Generic;
using Tools;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      var words = new List<string> { "Tar",
        "Elbow", "Anna", "Rat", "Dormitory",
        "Racecar", "Silent", "Silence", "Listen",
        "The Eyes", "God", "Nana", "They See!", "Coffee Hit?",
        "Old West Action", "The Office", "Clint Eastwood", "Dog" };

      var helper = new WordHelper();

      WordChecker.CheckWords(helper, words);

    }


  }
}
