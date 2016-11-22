// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InMemoryTestrailClient.cs" company="Felandil IT">
//    Copyright (c) 2008 -2016 Felandil IT. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.Testrail.Core.Tests.Client
{
  using Felandil.Testrail.Core.Client;
  using Felandil.Testrail.Core.Entity;

  /// <summary>
  /// The in memory testrail client.
  /// </summary>
  internal class InMemoryTestrailClient : ITestrailClient
  {
    #region Constants

    /// <summary>
    /// The run id.
    /// </summary>
    public const int RunId = 10;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets the current testcase summary.
    /// </summary>
    public string CurrentTestcaseSummary { get; private set; }

    #endregion

    #region Public Methods and Operators

    /// <summary>
    /// The get testcase.
    /// </summary>
    /// <param name="id">
    /// The id.
    /// </param>
    /// <returns>
    /// The <see cref="Testcase"/>.
    /// </returns>
    public Testcase GetTestcase(int id)
    {
      return new Testcase();
    }

    /// <summary>
    /// The post testcase result.
    /// </summary>
    /// <param name="testcase">
    /// The testcase.
    /// </param>
    public void PostTestcaseResult(Testcase testcase)
    {
      this.CurrentTestcaseSummary = testcase.Summary;
    }

    /// <summary>
    /// The start suite run.
    /// </summary>
    /// <param name="projectId">
    /// The project id.
    /// </param>
    /// <param name="suiteId">
    /// The suite id.
    /// </param>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    public int StartSuiteRun(int projectId, int suiteId)
    {
      return RunId;
    }

    /// <summary>
    /// The start suite run.
    /// </summary>
    /// <param name="projectId">
    /// The project id.
    /// </param>
    /// <param name="suiteName">
    /// The suite name.
    /// </param>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    public int StartSuiteRun(int projectId, string suiteName)
    {
      return RunId;
    }

    #endregion
  }
}