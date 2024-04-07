// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set14.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 14 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator
{
    using System;
    using System.IO;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Provides an implementation for performing test vector set 14 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set14 : SetBase
    {
        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set14" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set14(TextWriter writer = null)
            : base(writer)
        {
            // Intentionally empty.
        }

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
            this.WriteLine("21701".R10());
            this.WriteLine("M21701".R10());
            this.WriteLine("2^21701-1".R10());
            this.WriteLine("\x54\xc5".R10());
            this.WriteLine("\xc5\x54".R10());
            this.WriteLine("23209".R10());
            this.WriteLine("M23209".R10());
            this.WriteLine("2^23209-1".R10());
            this.WriteLine("\x5a\xa9".R10());
            this.WriteLine("\xa9\x5a".R10());
            this.WriteLine("391581216093".R10());
            this.WriteLine("391581*2^216093-1".R10());
            this.WriteLine("\x05\xf9\x9d\x03\x4c\x81".R10());
            this.WriteLine("FEDCBA9876543210".R10());
            this.WriteLine("\xfe\xdc\xba\x98\x76\x54\x32\x10".R10());
            this.WriteLine("EFCDAB8967452301".R10());
            this.WriteLine("\xef\xcd\xab\x89\x67\x45\x23\x01".R10());
            this.WriteLine("0123456789ABCDEF".R10());
            this.WriteLine("\x01\x23\x45\x67\x89\xab\xcd\xef".R10());
            this.WriteLine("1032547698BADCFE".R10());
            this.WriteLine("\x10\x32\x54\x76\x98\xba\xdc\xfe".R10());
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Asynchronously performs the test vector set 14 generation.
        /// </summary>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="StringBuilder.MaxCapacity" />.</exception>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        // ReSharper disable once MethodTooLong
        public override async Task PerformAsync(CancellationToken token = default)
        {
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "21701".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "M21701".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "2^21701-1".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "\x54\xc5".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "\xc5\x54".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "23209".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "M23209".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "2^23209-1".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "\x5a\xa9".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "\xa9\x5a".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "391581216093".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "391581*2^216093-1".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "\x05\xf9\x9d\x03\x4c\x81".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "FEDCBA9876543210".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "\xfe\xdc\xba\x98\x76\x54\x32\x10".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "EFCDAB8967452301".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "\xef\xcd\xab\x89\x67\x45\x23\x01".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "0123456789ABCDEF".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "\x01\x23\x45\x67\x89\xab\xcd\xef".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "1032547698BADCFE".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "\x10\x32\x54\x76\x98\xba\xdc\xfe".R10Async(token).ConfigureAwait(false), token).ConfigureAwait(true);
        }
    }
}
