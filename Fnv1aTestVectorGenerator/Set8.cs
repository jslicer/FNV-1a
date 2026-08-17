// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set8.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 8 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator;

using System.Text;

/// <inheritdoc cref="SetBase" />
/// <summary>
/// Provides an implementation for performing test vector set 8 generation.
/// </summary>
/// <param name="writer">The writer.</param>
/// <seealso cref="ISet" />
internal sealed class Set8(TextWriter? writer = null) : SetBase(writer)
{
    /// <summary>
    /// The 127.0.0.1 string.
    /// </summary>
    private const string OneTwentySevenDotZeroDotZeroDotOne = "127.0.0.1";

    /// <summary>
    /// The 127.0.0.2 string.
    /// </summary>
    private const string OneTwentySevenDotZeroDotZeroDotTwo = "127.0.0.2";

    /// <summary>
    /// The 127.0.0.3 string.
    /// </summary>
    private const string OneTwentySevenDotZeroDotZeroDotThree = "127.0.0.3";

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Performs the test vector set 8 generation.
    /// </summary>
    /// <exception cref="IOException">An I/O error occurs.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    public override void Perform()
    {
        WriteLine(OneTwentySevenDotZeroDotZeroDotOne.Test());
        WriteLine(OneTwentySevenDotZeroDotZeroDotOne.Test0());
        WriteLine(OneTwentySevenDotZeroDotZeroDotTwo.Test());
        WriteLine(OneTwentySevenDotZeroDotZeroDotTwo.Test0());
        WriteLine(OneTwentySevenDotZeroDotZeroDotThree.Test());
        WriteLine(OneTwentySevenDotZeroDotZeroDotThree.Test0());
    }

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Asynchronously performs the test vector set 8 generation.
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
            await OneTwentySevenDotZeroDotZeroDotOne.TestAsync(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await OneTwentySevenDotZeroDotZeroDotOne.Test0Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await OneTwentySevenDotZeroDotZeroDotTwo.TestAsync(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await OneTwentySevenDotZeroDotZeroDotTwo.Test0Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await OneTwentySevenDotZeroDotZeroDotThree.TestAsync(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await OneTwentySevenDotZeroDotZeroDotThree.Test0Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
    }
}