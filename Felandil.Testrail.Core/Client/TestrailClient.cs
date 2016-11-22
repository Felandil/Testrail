// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestrailClient.cs" company="Felandil IT">
//    Copyright (c) 2008 -2016 Felandil IT. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.Testrail.Core.Client
{
  using System.Collections.Generic;
  using System.Diagnostics.CodeAnalysis;

  using Felandil.Testrail.Core.Entity;

  using Gurock.TestRail;

  using Newtonsoft.Json.Linq;

  /// <summary>
  /// The testrail client.
  /// </summary>
  [ExcludeFromCodeCoverage]
  public class TestrailClient : ITestrailClient
  {
    #region Constructors and Destructors

    /// <summary>
    /// Initializes a new instance of the <see cref="TestrailClient"/> class.
    /// </summary>
    /// <param name="baseUrl">
    /// The base Url.
    /// </param>
    /// <param name="user">
    /// The user.
    /// </param>
    /// <param name="password">
    /// The password.
    /// </param>
    public TestrailClient(string baseUrl, string user, string password)
    {
      this.InternalClient = new APIClient(baseUrl) { User = user, Password = password };
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the internal client.
    /// </summary>
    private APIClient InternalClient { get; set; }

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
      var result = (JObject)this.InternalClient.SendGet(string.Format("get_case/{0}", id));
      return new Testcase { Id = result.Value<int>("id") };
    }

    /// <summary>
    /// The post testcase result.
    /// </summary>
    /// <param name="testcase">
    /// The testcase.
    /// </param>
    public void PostTestcaseResult(Testcase testcase)
    {
      var data = new Dictionary<string, object> { { "status_id", 1 }, { "comment", testcase.Summary } };
      this.InternalClient.SendPost(string.Format("add_result_for_case/1/{0}", testcase.Id), data);
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
      var data = new Dictionary<string, object> { { "suite_id", suiteId } };
      var result = (JObject)this.InternalClient.SendPost(string.Format("add_run/{0}", projectId), data);

      return result.Value<int>("id");
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
      var suiteData = (JArray)this.InternalClient.SendGet(string.Format("get_suites/{0}", projectId));
      var suiteId = -1;

      foreach (var token in suiteData)
      {
        var suite = (JObject)token;

        if (suite == null)
        {
          continue;
        }

        if (suite.Value<string>("name") != suiteName)
        {
          continue;
        }

        suiteId = suite.Value<int>("id");
        break;
      }

      if (suiteId == -1)
      {
        return -1;
      }

      return this.StartSuiteRun(projectId, suiteId);
    }

    #endregion
  }
}