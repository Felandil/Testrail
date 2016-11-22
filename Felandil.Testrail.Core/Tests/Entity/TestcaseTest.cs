// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestcaseTest.cs" company="Felandil IT">
//    Copyright (c) 2008 -2016 Felandil IT. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.Testrail.Core.Tests.Entity
{
  using Felandil.Testrail.Core.Entity;

  using Microsoft.VisualStudio.TestTools.UnitTesting;

  /// <summary>
  /// The testcase test.
  /// </summary>
  [TestClass]
  public class TestcaseTest
  {
    #region Public Methods and Operators

    /// <summary>
    /// The test adding two steps returns summary with numerated steps.
    /// </summary>
    [TestMethod]
    public void TestAddingTwoStepsReturnsSummaryWithNumeratedSteps()
    {
      var testcase = new Testcase();
      testcase.AddSummaryStep("One step");
      testcase.AddSummaryStep("Another step");

      Assert.AreEqual("1. One step \r2. Another step \r", testcase.Summary);
    }

    #endregion
  }
}