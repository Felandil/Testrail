// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Testcase.cs" company="Felandil IT">
//    Copyright (c) 2008 -2016 Felandil IT. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.Testrail.Core.Entity
{
  using System.Collections.Generic;

  /// <summary>
  /// The testcase.
  /// </summary>
  public class Testcase
  {
    #region Constructors and Destructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Testcase"/> class.
    /// </summary>
    public Testcase()
    {
      this.SummarySteps = new List<string>();
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets the summary.
    /// </summary>
    public string Summary
    {
      get
      {
        var i = 1;
        var result = string.Empty;
        foreach (var summaryStep in this.SummarySteps)
        {
          result += string.Format("{0}. {1} \r", i, summaryStep);
          i++;
        }

        return result;
      }
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the summary steps.
    /// </summary>
    private List<string> SummarySteps { get; set; }

    #endregion

    #region Public Methods and Operators

    /// <summary>
    /// The add summary step.
    /// </summary>
    /// <param name="summaryStep">
    /// The summary step.
    /// </param>
    public void AddSummaryStep(string summaryStep)
    {
      this.SummarySteps.Add(summaryStep);
    }

    #endregion
  }
}