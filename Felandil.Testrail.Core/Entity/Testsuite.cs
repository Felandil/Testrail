// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Testsuite.cs" company="Felandil IT">
//    Copyright (c) 2008 -2016 Felandil IT. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.Testrail.Core.Entity
{
  using System.Collections.Generic;

  /// <summary>
  /// The testsuite.
  /// </summary>
  public class Testsuite
  {
    #region Constants

    /// <summary>
    /// The default run id.
    /// </summary>
    public const int DefaultRunId = -1;

    #endregion

    #region Constructors and Destructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Testsuite"/> class.
    /// </summary>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="projectId">
    /// The project Id.
    /// </param>
    public Testsuite(string name, int projectId)
    {
      this.Name = name;
      this.ProjectId = projectId;
      this.CurrentRunId = DefaultRunId;
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets the current run id.
    /// </summary>
    public int CurrentRunId { get; internal set; }

    /// <summary>
    /// Gets the name.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the project id.
    /// </summary>
    public int ProjectId { get; private set; }

    /// <summary>
    /// Gets the testcases.
    /// </summary>
    public List<Testcase> Testcases { get; private set; }

    #endregion
  }
}