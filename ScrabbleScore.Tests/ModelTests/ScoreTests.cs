using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void GetScore_Returns10WhenSentAStringWithOneq_Int()
    {
      int result = Score.GetScore("Q");
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void GetScore_ReturnsIntThatGoesThroughEachPossibleStringCase_Int()
    {
      int result = Score.GetScore("qJKFBDA");
      Assert.AreEqual(27, result);
    }
  }
}
