// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set0.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 0 generation.
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
    /// Provides an implementation for performing test vector set 0 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set0 : SetBase
    {
        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set0" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set0(TextWriter writer = null)
            : base(writer)
        {
            // Intentionally empty.
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Performs the test vector set 0 generation.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        public override void Perform()
        {
            //// ReSharper disable StringLiteralTypo
            this.WriteLine(string.Empty.Test());
            this.WriteLine("a".Test());
            this.WriteLine("b".Test());
            this.WriteLine("c".Test());
            this.WriteLine("d".Test());
            this.WriteLine("e".Test());
            this.WriteLine("f".Test());
            this.WriteLine("fo".Test());
            this.WriteLine("foo".Test());
            this.WriteLine("foob".Test());
            this.WriteLine("fooba".Test());
            this.WriteLine("foobar".Test());
            //// ReSharper enable StringLiteralTypo
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Asynchronously performs the test vector set 0 generation.
        /// </summary>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        public override async Task PerformAsync(CancellationToken token = default)
        {
            //// ReSharper disable StringLiteralTypo
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await string.Empty.TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "a".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "b".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "c".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "d".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "e".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "f".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "fo".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "foo".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "foob".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "fooba".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "foobar".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            token.ThrowIfCancellationRequested();
            await this.WriteLineAsync(await "foobarfoobar".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(false);
            //// ReSharper enable StringLiteralTypo
        }
    }
}
