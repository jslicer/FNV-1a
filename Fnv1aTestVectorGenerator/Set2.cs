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
            WriteLine("ch".Test());
            WriteLine("cho".Test());
            WriteLine("chon".Test());
            WriteLine("chong".Test());
            WriteLine("chongo".Test());
            WriteLine("chongo ".Test());
            WriteLine("chongo w".Test());
            WriteLine("chongo wa".Test());
            WriteLine("chongo was".Test());
            WriteLine("chongo was ".Test());
            WriteLine("chongo was h".Test());
            WriteLine("chongo was he".Test());
            WriteLine("chongo was her".Test());
            WriteLine("chongo was here".Test());
            WriteLine("chongo was here!".Test());
            WriteLine("chongo was here!\n".Test());
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
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        // ReSharper disable once MethodTooLong
        public override async Task PerformAsync(CancellationToken token = default)
        {
            //// ReSharper disable StringLiteralTypo
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "ch".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "cho".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chon".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chong".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo ".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo w".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo wa".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo was".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo was ".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo was h".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo was he".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo was her".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo was here".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo was here!".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "chongo was here!\n".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            //// ReSharper enable StringLiteralTypo
        }
    }
}
