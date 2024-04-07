// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set15.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 15 generation.
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
    /// Provides an implementation for performing test vector set 15 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set15 : SetBase
    {
        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set15" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set15(TextWriter writer = null)
            : base(writer)
        {
            // Intentionally empty.
        }

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
            this.WriteLine("\x00".R500());
            this.WriteLine("\x07".R500());
            this.WriteLine("~".R500());
            this.WriteLine("\x7f".R500());
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Asynchronously performs the test vector set 15 generation.
        /// </summary>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="StringBuilder.MaxCapacity" />.</exception>
        public override async Task PerformAsync(CancellationToken token = default)
        {
            await this.WriteLineAsync(await "\x00".R500Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x07".R500Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "~".R500Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x7f".R500Async().ConfigureAwait(false)).ConfigureAwait(false);
        }
    }
}
