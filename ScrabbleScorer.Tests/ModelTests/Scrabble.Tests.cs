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
  }
}