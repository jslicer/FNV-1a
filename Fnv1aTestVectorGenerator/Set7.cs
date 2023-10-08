﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set7.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 7 generation.
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
    /// Provides an implementation for performing test vector set 7 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set7 : SetBase
    {
        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set7" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set7(TextWriter writer = null)
            : base(writer)
        {
            // Intentionally empty.
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Performs the test vector set 7 generation.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        public override void Perform()
        {
            this.WriteLine("\xff\x00\x00\x01".Test());
            this.WriteLine("\x01\x00\x00\xff".Test());
            this.WriteLine("\xff\x00\x00\x02".Test());
            this.WriteLine("\x02\x00\x00\xff".Test());
            this.WriteLine("\xff\x00\x00\x03".Test());
            this.WriteLine("\x03\x00\x00\xff".Test());
            this.WriteLine("\xff\x00\x00\x04".Test());
            this.WriteLine("\x04\x00\x00\xff".Test());
            this.WriteLine("\x40\x51\x4e\x44".Test());
            this.WriteLine("\x44\x4e\x51\x40".Test());
            this.WriteLine("\x40\x51\x4e\x4a".Test());
            this.WriteLine("\x4a\x4e\x51\x40".Test());
            this.WriteLine("\x40\x51\x4e\x54".Test());
            this.WriteLine("\x54\x4e\x51\x40".Test());
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Asynchronously performs the test vector set 7 generation.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        public override async Task PerformAsync()
        {
            await this.WriteLineAsync(await "\xff\x00\x00\x01".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x01\x00\x00\xff".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\xff\x00\x00\x02".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x02\x00\x00\xff".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\xff\x00\x00\x03".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x03\x00\x00\xff".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\xff\x00\x00\x04".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x04\x00\x00\xff".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x40\x51\x4e\x44".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x44\x4e\x51\x40".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x40\x51\x4e\x4a".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x4a\x4e\x51\x40".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x40\x51\x4e\x54".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x54\x4e\x51\x40".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
        }
    }
}
