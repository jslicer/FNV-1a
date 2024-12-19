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
            WriteLine(string.Empty.Test());
            WriteLine("a".Test());
            WriteLine("b".Test());
            WriteLine("c".Test());
            WriteLine("d".Test());
            WriteLine("e".Test());
            WriteLine("f".Test());
            WriteLine("fo".Test());
            WriteLine("foo".Test());
            WriteLine("foob".Test());
            WriteLine("fooba".Test());
            WriteLine("foobar".Test());
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
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        // ReSharper disable once MethodTooLong
        public override async Task PerformAsync(CancellationToken token = default)
        {
            //// ReSharper disable StringLiteralTypo
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await string.Empty.TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "a".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "b".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "c".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "d".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "e".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "f".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "fo".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "foo".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "foob".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "fooba".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "foobar".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            token.ThrowIfCancellationRequested();
            await WriteLineAsync(await "foobarfoobar".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
            //// ReSharper enable StringLiteralTypo
        }
    }
}
