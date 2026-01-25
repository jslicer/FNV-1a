// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set6.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 6 generation.
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
/// Provides an implementation for performing test vector set 6 generation.
/// </summary>
/// <param name="writer">The writer.</param>
/// <seealso cref="ISet" />
internal sealed class Set6(TextWriter? writer = null) : SetBase(writer)
{
    /// <summary>
    /// The hi string.
    /// </summary>
    private const string Hi = "hi";

    /// <summary>
    /// The hello string.
    /// </summary>
    private const string Hello = "hello";

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Performs the test vector set 6 generation.
    /// </summary>
    /// <exception cref="IOException">An I/O error occurs.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    public override void Perform()
    {
        WriteLine(Hi.Test());
        WriteLine(Hi.Test0());
        WriteLine(Hello.Test());
        WriteLine(Hello.Test0());
    }

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Asynchronously performs the test vector set 6 generation.
    /// </summary>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    public override async Task PerformAsync(CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await Hi.TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await Hi.Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await Hello.TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await Hello.Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
    }
}
