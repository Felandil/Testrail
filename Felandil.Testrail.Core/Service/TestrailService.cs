﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestrailService.cs" company="Felandil IT">
//    Copyright (c) 2008 -2016 Felandil IT. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.Testrail.Core.Service
{
  using Felandil.Testrail.Core.Client;
  using Felandil.Testrail.Core.Entity;

  /// <summary>
  /// The testrail service.
  /// </summary>
  public class TestrailService
  {
    #region Constructors and Destructors

    /// <summary>
    /// Initializes a new instance of the <see cref="TestrailService"/> class.
    /// </summary>
    /// <param name="client">
    /// The client.
    /// </param>
    public TestrailService(ITestrailClient client)
    {
      this.TestrailClient = client;
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the testrail client.
    /// </summary>
    private ITestrailClient TestrailClient { get; set; }

    #endregion

    #region Public Methods and Operators

    /// <summary>
    /// The start suite.
    /// </summary>
    /// <param name="suite">
    /// The suite.
    /// </param>
    public void StartSuite(Testsuite suite)
    {
      suite.CurrentRunId = this.TestrailClient.StartSuiteRun(suite.ProjectId, suite.Name);
    }

    #endregion
  }
}