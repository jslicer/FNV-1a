// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISet.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an definition for performing test vector set generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator;

using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Provides an definition for performing test vector set generation.
/// </summary>
internal interface ISet
{
    /// <summary>
    /// Performs the test vector set generation.
    /// </summary>
    void Perform();

    /// <summary>
    /// Asynchronously performs the test vector set generation.
    /// </summary>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    Task PerformAsync(CancellationToken token = default);
}
