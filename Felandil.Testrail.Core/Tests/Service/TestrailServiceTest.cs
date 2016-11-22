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