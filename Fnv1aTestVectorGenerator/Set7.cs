// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set7.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 7 generation.
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
/// Provides an implementation for performing test vector set 7 generation.
/// </summary>
/// <param name="writer">The writer.</param>
/// <seealso cref="ISet" />
internal sealed class Set7(TextWriter? writer = null) : SetBase(writer)
{
    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Performs the test vector set 7 generation.
    /// </summary>
    /// <exception cref="IOException">An I/O error occurs.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    public override void Perform()
    {
        WriteLine("\xff\x00\x00\x01".Test());
        WriteLine("\x01\x00\x00\xff".Test());
        WriteLine("\xff\x00\x00\x02".Test());
        WriteLine("\x02\x00\x00\xff".Test());
        WriteLine("\xff\x00\x00\x03".Test());
        WriteLine("\x03\x00\x00\xff".Test());
        WriteLine("\xff\x00\x00\x04".Test());
        WriteLine("\x04\x00\x00\xff".Test());
        WriteLine("\x40\x51\x4e\x44".Test());
        WriteLine("\x44\x4e\x51\x40".Test());
        WriteLine("\x40\x51\x4e\x4a".Test());
        WriteLine("\x4a\x4e\x51\x40".Test());
        WriteLine("\x40\x51\x4e\x54".Test());
        WriteLine("\x54\x4e\x51\x40".Test());
    }

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Asynchronously performs the test vector set 7 generation.
    /// </summary>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    // ReSharper disable once MethodTooLong
    public override async Task PerformAsync(CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\xff\x00\x00\x01".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\x01\x00\x00\xff".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\xff\x00\x00\x02".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\x02\x00\x00\xff".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\xff\x00\x00\x03".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\x03\x00\x00\xff".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\xff\x00\x00\x04".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\x04\x00\x00\xff".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\x40\x51\x4e\x44".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\x44\x4e\x51\x40".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\x40\x51\x4e\x4a".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\x4a\x4e\x51\x40".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\x40\x51\x4e\x54".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "\x54\x4e\x51\x40".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
    }
}
