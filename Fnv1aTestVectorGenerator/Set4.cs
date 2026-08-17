// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set4.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 4 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator;

using System.Text;

/// <inheritdoc cref="SetBase" />
/// <summary>
/// Provides an implementation for performing test vector set 4 generation.
/// </summary>
/// <param name="writer">The writer.</param>
/// <seealso cref="ISet" />
internal sealed class Set4(TextWriter? writer = null) : SetBase(writer)
{
    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Performs the test vector set 4 generation.
    /// </summary>
    /// <exception cref="IOException">An I/O error occurs.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    public override void Perform()
    {
        WriteLine("cu".Test());
        WriteLine("cur".Test());
        WriteLine("curd".Test());
        WriteLine("curds".Test());
        WriteLine("curds ".Test());
        WriteLine("curds a".Test());
        WriteLine("curds an".Test());
        WriteLine("curds and".Test());
        WriteLine("curds and ".Test());
        WriteLine("curds and w".Test());
        WriteLine("curds and wh".Test());
        WriteLine("curds and whe".Test());
        WriteLine("curds and whey".Test());
        WriteLine("curds and whey\n".Test());
    }

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Asynchronously performs the test vector set 4 generation.
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
    // ReSharper disable once MethodTooLong
    public override async Task PerformAsync(CancellationToken token = default)
    {
        await WriteLineAsync(await "cu".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "cur".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "curd".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "curds".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "curds ".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "curds a".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "curds an".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "curds and".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "curds and ".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "curds and w".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "curds and wh".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "curds and whe".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(
            await "curds and whey".TestAsync(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await "curds and whey\n".TestAsync(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
    }
}