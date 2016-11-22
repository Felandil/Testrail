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
    /// <param name="testcase">
    /// The testcase.
    /// </param>
    void PostTestcaseResult(Testcase testcase);

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