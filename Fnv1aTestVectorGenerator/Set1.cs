// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set1.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 1 generation.
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
    /// Provides an implementation for performing test vector set 1 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set1 : SetBase
    {
        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set1" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set1(TextWriter writer = null)
            : base(writer)
        {
            // Intentionally empty.
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Performs the test vector set 1 generation.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        public override void Perform()
        {
            //// ReSharper disable StringLiteralTypo
            this.WriteLine(string.Empty.Test0());
            this.WriteLine("a".Test0());
            this.WriteLine("b".Test0());
            this.WriteLine("c".Test0());
            this.WriteLine("d".Test0());
            this.WriteLine("e".Test0());
            this.WriteLine("f".Test0());
            this.WriteLine("fo".Test0());
            this.WriteLine("foo".Test0());
            this.WriteLine("foob".Test0());
            this.WriteLine("fooba".Test0());
            this.WriteLine("foobar".Test0());
            //// ReSharper enable StringLiteralTypo
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Asynchronously performs the test vector set 1 generation.
        /// </summary>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        public override async Task PerformAsync(CancellationToken token = default)
        {
            //// ReSharper disable StringLiteralTypo
            await this.WriteLineAsync(await string.Empty.Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "a".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "b".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "c".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "d".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "e".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "f".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "fo".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "foo".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "foob".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "fooba".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "foobar".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            //// ReSharper enable StringLiteralTypo
        }
    }
}
