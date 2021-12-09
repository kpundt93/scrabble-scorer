using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void Score_CreatesInstanceOfScore_WordScore()
    {
      Score wordScore = new Score();
      Assert.AreEqual(typeof(Score), wordScore.GetType());
    }

    [TestMethod]
    public void GetScore_ReturnsCorrectScore_Int()
    { //Arrange
      Score wordScore = new Score();
      string test = "scrabble";
      //Act
      int score = wordScore.getScore(test);
      //Assert
      Assert.AreEqual(score, 14);
    }
  }
}