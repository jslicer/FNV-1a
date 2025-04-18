﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set3.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 3 generation.
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
/// Provides an implementation for performing test vector set 3 generation.
/// </summary>
/// <param name="writer">The writer.</param>
/// <seealso cref="ISet" />
internal sealed class Set3(TextWriter? writer = null) : SetBase(writer)
{
    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Performs the test vector set 3 generation.
    /// </summary>
    /// <exception cref="IOException">An I/O error occurs.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    // ReSharper disable once MethodTooLong
    public override void Perform()
    {
        //// ReSharper disable StringLiteralTypo
        WriteLine("ch".Test0());
        WriteLine("cho".Test0());
        WriteLine("chon".Test0());
        WriteLine("chong".Test0());
        WriteLine("chongo".Test0());
        WriteLine("chongo ".Test0());
        WriteLine("chongo w".Test0());
        WriteLine("chongo wa".Test0());
        WriteLine("chongo was".Test0());
        WriteLine("chongo was ".Test0());
        WriteLine("chongo was h".Test0());
        WriteLine("chongo was he".Test0());
        WriteLine("chongo was her".Test0());
        WriteLine("chongo was here".Test0());
        WriteLine("chongo was here!".Test0());
        WriteLine("chongo was here!\n".Test0());
        //// ReSharper enable StringLiteralTypo
    }

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Asynchronously performs the test vector set 3 generation.
    /// </summary>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    // ReSharper disable once MethodTooLong
    public override async Task PerformAsync(CancellationToken token = default)
    {
        //// ReSharper disable StringLiteralTypo
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "ch".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "cho".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chon".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chong".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo ".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo w".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo wa".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo was".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo was ".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo was h".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo was he".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo was her".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo was here".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo was here!".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "chongo was here!\n".Test0Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        //// ReSharper enable StringLiteralTypo
    }
}
