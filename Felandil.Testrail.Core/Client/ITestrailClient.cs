// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITestrailClient.cs" company="Felandil IT">
//    Copyright (c) 2008 -2016 Felandil IT. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.Testrail.Core.Client
{
  using Felandil.Testrail.Core.Entity;

  /// <summary>
  /// The TestrailClient interface.
  /// </summary>
  public interface ITestrailClient
  {
    #region Public Methods and Operators

    /// <summary>
    /// The end suite run.
    /// </summary>
    /// <param name="runid">
    /// The runid.
    /// </param>
    void EndSuiteRun(int runid);

    /// <summary>
    /// The get testcase.
    /// </summary>
    /// <param name="id">
    /// The id.
    /// </param>
    /// <returns>
    /// The <see cref="Testcase"/>.
    /// </returns>
    Testcase GetTestcase(int id);

    /// <summary>
    /// The post testcase result.
    /// </summary>
    /// <param name="runId">
    /// The run Id.
    /// </param>
    /// <param name="testcaseId">
    /// The testcase Id.
    /// </param>
    /// <param name="status">
    /// The status.
    /// </param>
    /// <param name="summary">
    /// The summary.
    /// </param>
    void PostTestcaseResult(int runId, int testcaseId, int status, string summary);

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
    /// The run Id<see cref="int"/>.
    /// </returns>
    int StartSuiteRun(int projectId, int suiteId);

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
    int StartSuiteRun(int projectId, string suiteName);

    #endregion
  }
}