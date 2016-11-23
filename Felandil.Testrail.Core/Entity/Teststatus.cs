// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Teststatus.cs" company="Felandil IT">
//    Copyright (c) 2008 -2016 Felandil IT. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.Testrail.Core.Entity
{
  /// <summary>
  /// The teststatus.
  /// </summary>
  public enum Teststatus
  {
    /// <summary>
    /// The passed.
    /// </summary>
    Passed = 1, 

    /// <summary>
    /// The blocked.
    /// </summary>
    Blocked = 2, 

    /// <summary>
    /// The untested.
    /// </summary>
    Untested = 3, 

    /// <summary>
    /// The retest.
    /// </summary>
    Retest = 4, 

    /// <summary>
    /// The failed.
    /// </summary>
    Failed = 5
  }
}