// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestrailServiceTest.cs" company="Felandil IT">
//    Copyright (c) 2008 -2016 Felandil IT. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.Testrail.Core.Tests.Service
{
  using Felandil.Testrail.Core.Entity;
  using Felandil.Testrail.Core.Service;
  using Felandil.Testrail.Core.Tests.Client;

  using Microsoft.VisualStudio.TestTools.UnitTesting;

  /// <summary>
  /// The testrail service test.
  /// </summary>
  [TestClass]
  public class TestrailServiceTest
  {
    #region Public Methods and Operators

    /// <summary>
    /// The test end run call client and resets run id to default.
    /// </summary>
    [TestMethod]
    public void TestEndRunCallClientAndResetsRunIdToDefault()
    {
      var inMemoryTestrailClient = new InMemoryTestrailClient();

      var service = new TestrailService(inMemoryTestrailClient);
      var suite = new Testsuite("SomeSuite", 1);
      service.StartSuite(suite);
      service.EndSuite(suite);

      Assert.AreEqual(-1, suite.CurrentRunId);
      Assert.IsTrue(inMemoryTestrailClient.EndSuiteCalled);
    }

    /// <summary>
    /// The test post test result sends test status as integer.
    /// </summary>
    [TestMethod]
    public void TestPostTestResultSendsTestStatusAsInteger()
    {
      var inMemoryTestrailClient = new InMemoryTestrailClient();

      var service = new TestrailService(inMemoryTestrailClient);
      var testcase = new Testcase { Status = Teststatus.Passed };

      service.PostTestResult(testcase, 10);

      Assert.AreEqual(inMemoryTestrailClient.LastTestStatus, (int)Teststatus.Passed);
    }

    /// <summary>
    /// The test start test run calls client and sets run id on suite.
    /// </summary>
    [TestMethod]
    public void TestStartTestRunCallsClientAndSetsRunIdOnSuite()
    {
      var inMemoryTestrailClient = new InMemoryTestrailClient();

      var service = new TestrailService(inMemoryTestrailClient);
      var suite = new Testsuite("SomeSuite", 1);
      service.StartSuite(suite);

      Assert.AreEqual(InMemoryTestrailClient.RunId, suite.CurrentRunId);
    }

    #endregion
  }
}