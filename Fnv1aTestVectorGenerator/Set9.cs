// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set9.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 9 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

/// <inheritdoc cref="SetBase" />
/// <summary>
/// Provides an implementation for performing test vector set 9 generation.
/// </summary>
/// <param name="writer">The writer.</param>
/// <seealso cref="ISet" />
internal sealed class Set9(TextWriter? writer = null) : SetBase(writer)
{
    /// <summary>
    /// The 64.81.78.68 string.
    /// </summary>
    private const string SixtyFourDotEightyOneDotSeventyEightDotSixtyEight = "64.81.78.68";

    /// <summary>
    /// The 64.81.78.74 string.
    /// </summary>
    private const string SixtyFourDotEightyOneDotSeventyEightDotSeventyFour = "64.81.78.74";

    /// <summary>
    /// 64.81.78.84 string.
    /// </summary>
    private const string SixtyFourDotEightyOneDotSeventyEightDotEightyFour = "64.81.78.84";

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Performs the test vector set 9 generation.
    /// </summary>
    /// <exception cref="IOException">An I/O error occurs.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    public override void Perform()
    {
        WriteLine(SixtyFourDotEightyOneDotSeventyEightDotSixtyEight.Test());
        WriteLine(SixtyFourDotEightyOneDotSeventyEightDotSixtyEight.Test0());
        WriteLine(SixtyFourDotEightyOneDotSeventyEightDotSeventyFour.Test());
        WriteLine(SixtyFourDotEightyOneDotSeventyEightDotSeventyFour.Test0());
        WriteLine(SixtyFourDotEightyOneDotSeventyEightDotEightyFour.Test());
        WriteLine(SixtyFourDotEightyOneDotSeventyEightDotEightyFour.Test0());
    }

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Asynchronously performs the test vector set 9 generation.
    /// </summary>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    public override async Task PerformAsync(CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await SixtyFourDotEightyOneDotSeventyEightDotSixtyEight.TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await SixtyFourDotEightyOneDotSeventyEightDotSixtyEight.Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await SixtyFourDotEightyOneDotSeventyEightDotSeventyFour.TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await SixtyFourDotEightyOneDotSeventyEightDotSeventyFour.Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await SixtyFourDotEightyOneDotSeventyEightDotEightyFour.TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await SixtyFourDotEightyOneDotSeventyEightDotEightyFour.Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
    }
}
