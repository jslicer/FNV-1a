// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SetBase.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides a base class for performing test vector generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <inheritdoc cref="ISet" />
    /// <summary>
    /// Provides a base class for performing test vector generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal abstract class SetBase : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="SetBase" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        protected SetBase(TextWriter writer = null) => this._writer = writer ?? TextWriter.Null;

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set generation.
        /// </summary>
        public abstract void Perform();

        /// <inheritdoc />
        /// <summary>
        /// Asynchronously performs the test vector set generation.
        /// </summary>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        public abstract Task PerformAsync(CancellationToken token = default);

        /// <summary>
        /// Writes the line to the <see cref="TextWriter" />.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        protected void WriteLine(in string value) => this._writer.WriteLine(value);

        /// <summary>
        /// Asynchronously writes the line to the <see cref="TextWriter" />.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write
        /// operation.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        // ReSharper disable once RedundantAwait
        protected async Task WriteLineAsync(string value, CancellationToken token = default)
        {
            token.ThrowIfCancellationRequested();
            //// ReSharper disable once AsyncConverter.AsyncAwaitMayBeElidedHighlighting
            //// ReSharper disable once AsyncApostle.AsyncAwaitMayBeElidedHighlighting
            //// ReSharper disable RedundantAwait
            await this._writer.WriteLineAsync(value).ConfigureAwait(false);
            //// ReSharper enable RedundantAwait
        }
    }
}
