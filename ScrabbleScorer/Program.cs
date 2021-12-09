using Scrabble.Models;
using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to get your Scrabble score.");
      Console.WriteLine("===================");
      string inputWord = Console.ReadLine();
      Score userScore = new Score();
      Console.WriteLine("Your score is: " + userScore.getScore(inputWord));
    }
  }
}