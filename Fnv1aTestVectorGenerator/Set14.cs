// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set14.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 14 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator;

using System.Text;

/// <inheritdoc cref="SetBase" />
/// <summary>
/// Provides an implementation for performing test vector set 14 generation.
/// </summary>
/// <param name="writer">The writer.</param>
/// <seealso cref="ISet" />
internal sealed class Set14(TextWriter? writer = null) : SetBase(writer)
{
    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Performs the test vector set 14 generation.
    /// </summary>
    /// <exception cref="IOException">An I/O error occurs.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
    /// <see cref="StringBuilder.MaxCapacity" />.</exception>
    // ReSharper disable once MethodTooLong
    public override void Perform()
    {
        WriteLine("21701".R10());
        WriteLine("M21701".R10());
        WriteLine("2^21701-1".R10());
        WriteLine("\x54\xc5".R10());
        WriteLine("\xc5\x54".R10());
        WriteLine("23209".R10());
        WriteLine("M23209".R10());
        WriteLine("2^23209-1".R10());
        WriteLine("\x5a\xa9".R10());
        WriteLine("\xa9\x5a".R10());
        WriteLine("391581216093".R10());
        WriteLine("391581*2^216093-1".R10());
        WriteLine("\x05\xf9\x9d\x03\x4c\x81".R10());
        WriteLine("FEDCBA9876543210".R10());
        WriteLine("\xfe\xdc\xba\x98\x76\x54\x32\x10".R10());
        WriteLine("EFCDAB8967452301".R10());
        WriteLine("\xef\xcd\xab\x89\x67\x45\x23\x01".R10());
        WriteLine("0123456789ABCDEF".R10());
        WriteLine("\x01\x23\x45\x67\x89\xab\xcd\xef".R10());
        WriteLine("1032547698BADCFE".R10());
        WriteLine("\x10\x32\x54\x76\x98\xba\xdc\xfe".R10());
    }

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Asynchronously performs the test vector set 14 generation.
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
    // ReSharper disable once MethodTooLong
    public override async Task PerformAsync(CancellationToken token = default)
    {
        await WriteLineAsync(await "21701".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "M21701".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "2^21701-1".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "\x54\xc5".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "\xc5\x54".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "23209".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "M23209".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "2^23209-1".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "\x5a\xa9".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "\xa9\x5a".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(await "391581216093".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        await WriteLineAsync(
            await "391581*2^216093-1".R10Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await "\x05\xf9\x9d\x03\x4c\x81".R10Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await "FEDCBA9876543210".R10Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await "\xfe\xdc\xba\x98\x76\x54\x32\x10".R10Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await "EFCDAB8967452301".R10Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await "\xef\xcd\xab\x89\x67\x45\x23\x01".R10Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await "0123456789ABCDEF".R10Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await "\x01\x23\x45\x67\x89\xab\xcd\xef".R10Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await "1032547698BADCFE".R10Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
        await WriteLineAsync(
            await "\x10\x32\x54\x76\x98\xba\xdc\xfe".R10Async(token).ConfigureAwait(false),
            token).ConfigureAwait(true);
    }
}