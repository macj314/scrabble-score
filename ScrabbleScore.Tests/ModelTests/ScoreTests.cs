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
    public void GetScore_Returns0_Int()
    {
      int result = Score.GetScore();
      Assert.AreEqual(0, result);
    }
  }
}
