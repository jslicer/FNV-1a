// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set2.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 2 generation.
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
    /// Provides an implementation for performing test vector set 2 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set2 : SetBase
    {
        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set2" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set2(TextWriter writer = null)
            : base(writer)
        {
            // Intentionally empty.
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Performs the test vector set 2 generation.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        // ReSharper disable once MethodTooLong
        public override void Perform()
        {
            //// ReSharper disable StringLiteralTypo
            this.WriteLine("ch".Test());
            this.WriteLine("cho".Test());
            this.WriteLine("chon".Test());
            this.WriteLine("chong".Test());
            this.WriteLine("chongo".Test());
            this.WriteLine("chongo ".Test());
            this.WriteLine("chongo w".Test());
            this.WriteLine("chongo wa".Test());
            this.WriteLine("chongo was".Test());
            this.WriteLine("chongo was ".Test());
            this.WriteLine("chongo was h".Test());
            this.WriteLine("chongo was he".Test());
            this.WriteLine("chongo was her".Test());
            this.WriteLine("chongo was here".Test());
            this.WriteLine("chongo was here!".Test());
            this.WriteLine("chongo was here!\n".Test());
            //// ReSharper enable StringLiteralTypo
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Asynchronously performs the test vector set 2 generation.
        /// </summary>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        // ReSharper disable once MethodTooLong
        public override async Task PerformAsync(CancellationToken token = default)
        {
            //// ReSharper disable StringLiteralTypo
            await this.WriteLineAsync(await "ch".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "cho".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chon".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chong".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo ".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo w".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo wa".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was ".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was h".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was he".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was her".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was here".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was here!".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was here!\n".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            //// ReSharper enable StringLiteralTypo
        }
    }
}
