﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set8.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 8 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Provides an implementation for performing test vector set 8 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set8 : SetBase
    {
        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set8" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set8(TextWriter writer = null)
            : base(writer)
        {
            // Intentionally empty.
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Performs the test vector set 8 generation.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        public override void Perform()
        {
            this.WriteLine("127.0.0.1".Test());
            this.WriteLine("127.0.0.1".Test0());
            this.WriteLine("127.0.0.2".Test());
            this.WriteLine("127.0.0.2".Test0());
            this.WriteLine("127.0.0.3".Test());
            this.WriteLine("127.0.0.3".Test0());
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Asynchronously performs the test vector set 8 generation.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        public override async Task PerformAsync()
        {
            await this.WriteLineAsync(await "127.0.0.1".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "127.0.0.1".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "127.0.0.2".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "127.0.0.2".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "127.0.0.3".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "127.0.0.3".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
        }
    }
}
