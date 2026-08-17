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

using System.Text;

/// <inheritdoc cref="SetBase" />
/// <summary>
/// Provides an implementation for performing test vector set 9 generation.
/// </summary>
/// <param name="writer">The writer.</param>
/// <seealso cref="ISet" />
internal sealed class Set9(TextWriter? writer = null) : SetBase(writer)
{
#pragma warning disable S1313 // IP addresses should not be hardcoded
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
#pragma warning restore S1313 // IP addresses should not be hardcoded

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
    /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write
    /// operation.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    /// <exception cref="ArgumentNullException">s is <see langword="null" />.</exception>
    /// <exception cref="EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in
    /// .NET)
    ///  -and-
    ///  <see cref="EncoderFallback" /> is set to <see cref="EncoderExceptionFallback" />.</exception>
    public override async Task PerformAsync(CancellationToken token = default)
    {
        await WriteLineAsync(
            await SixtyFourDotEightyOneDotSeventyEightDotSixtyEight.TestAsync(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await SixtyFourDotEightyOneDotSeventyEightDotSixtyEight.Test0Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await SixtyFourDotEightyOneDotSeventyEightDotSeventyFour.TestAsync(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await SixtyFourDotEightyOneDotSeventyEightDotSeventyFour.Test0Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await SixtyFourDotEightyOneDotSeventyEightDotEightyFour.TestAsync(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await SixtyFourDotEightyOneDotSeventyEightDotEightyFour.Test0Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
    }
}