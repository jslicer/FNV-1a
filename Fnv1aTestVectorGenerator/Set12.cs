// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set12.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 12 generation.
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
/// Provides an implementation for performing test vector set 12 generation.
/// </summary>
/// <param name="writer">The writer.</param>
/// <seealso cref="ISet" />
internal sealed class Set12(TextWriter? writer = null) : SetBase(writer)
{
    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Performs the test vector set 12 generation.
    /// </summary>
    /// <exception cref="IOException">An I/O error occurs.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    public override void Perform()
    {
        //// ReSharper disable StringLiteralTypo
        WriteLine("chongo <Landon Curt Noll> /\\../\\".Test());
        WriteLine("chongo <Landon Curt Noll> /\\../\\".Test0());
        WriteLine("chongo (Landon Curt Noll) /\\../\\".Test());
        WriteLine("chongo (Landon Curt Noll) /\\../\\".Test0());
        //// ReSharper enable StringLiteralTypo
    }

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Asynchronously performs the test vector set 12 generation.
    /// </summary>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    public override async Task PerformAsync(CancellationToken token = default)
    {
        //// ReSharper disable StringLiteralTypo
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo <Landon Curt Noll> /\\../\\".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo <Landon Curt Noll> /\\../\\".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo (Landon Curt Noll) /\\../\\".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo (Landon Curt Noll) /\\../\\".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        //// ReSharper enable StringLiteralTypo
    }
}
