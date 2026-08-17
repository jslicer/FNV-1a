// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set15.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 15 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator;

using System.Text;

/// <inheritdoc cref="SetBase" />
/// <summary>
/// Provides an implementation for performing test vector set 15 generation.
/// </summary>
/// <param name="writer">The writer.</param>
/// <seealso cref="ISet" />
internal sealed class Set15(TextWriter? writer = null) : SetBase(writer)
{
    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Performs the test vector set 15 generation.
    /// </summary>
    /// <exception cref="IOException">An I/O error occurs.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
    /// <see cref="StringBuilder.MaxCapacity" />.</exception>
    public override void Perform()
    {
        WriteLine("\0".R500());
        WriteLine("\a".R500());
        WriteLine("~".R500());
        WriteLine("\x7f".R500());
    }

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Asynchronously performs the test vector set 15 generation.
    /// </summary>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write
    /// operation.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
    /// <see cref="StringBuilder.MaxCapacity" />.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    /// <exception cref="ArgumentNullException">s is <see langword="null" />.</exception>
    /// <exception cref="EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in
    /// .NET)
    ///  -and-
    ///  <see cref="EncoderFallback" /> is set to <see cref="EncoderExceptionFallback" />.</exception>
    public override async Task PerformAsync(CancellationToken token = default)
    {
        await WriteLineAsync(await "\0".R500Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "\a".R500Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "~".R500Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "\x7f".R500Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
    }
}