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
    public void GetScoreLinq_Returns10WhenSentAStringWithOneq_Int()
    {
      int result = Score.GetScoreLinq("Q");
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void GetScoreLinq_ReturnsIntThatGoesThroughEachPossibleStringCase_Int()
    {
      int result = Score.GetScoreLinq("qJKFBDA");
      Assert.AreEqual(33, result);
    }

    [TestMethod]
    public void GetScoreIf_ReturnsIntThatGoesThroughEachPossibleStringCase_Int()
    {
      int result = Score.GetScoreIf("qJKFBDA");
      Assert.AreEqual(33, result);
    }
  }
}
