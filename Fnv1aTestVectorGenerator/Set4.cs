// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set4.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 4 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Provides an implementation for performing test vector set 4 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set4 : SetBase
    {
        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set4" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set4(TextWriter writer = null)
            : base(writer)
        {
            // Intentionally empty.
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Performs the test vector set 4 generation.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        public override void Perform()
        {
            this.WriteLine("cu".Test());
            this.WriteLine("cur".Test());
            this.WriteLine("curd".Test());
            this.WriteLine("curds".Test());
            this.WriteLine("curds ".Test());
            this.WriteLine("curds a".Test());
            this.WriteLine("curds an".Test());
            this.WriteLine("curds and".Test());
            this.WriteLine("curds and ".Test());
            this.WriteLine("curds and w".Test());
            this.WriteLine("curds and wh".Test());
            this.WriteLine("curds and whe".Test());
            this.WriteLine("curds and whey".Test());
            this.WriteLine("curds and whey\n".Test());
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Asynchronously performs the test vector set 4 generation.
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
            await this.WriteLineAsync(await "cu".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "cur".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curd".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curds".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curds ".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curds a".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curds an".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curds and".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curds and ".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curds and w".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curds and wh".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curds and whe".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curds and whey".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "curds and whey\n".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        }
    }
}
