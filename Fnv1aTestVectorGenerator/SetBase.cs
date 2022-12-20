// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SetBase.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an base class for performing test vector generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// Provides an base class for performing test vector generation.
    /// </summary>
    /// <seealso cref="T:Fnv1aTestVectorGenerator.ISet" />
    internal abstract class SetBase : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="SetBase"/> class.
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
        /// <returns>An asynchronous <see cref="Task"/>.</returns>
        public abstract Task PerformAsync();

        /// <summary>
        /// Writes the line to the <see cref="TextWriter"/>.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"></see> is
        /// closed.</exception>
        protected void WriteLine(in string value) => this._writer.WriteLine(value);

        /// <summary>
        /// Asynchronously writes the line to the <see cref="TextWriter"/>.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <returns>An asynchronous <see cref="Task"/></returns>
        /// <exception cref="System.InvalidOperationException">The text writer is currently in use by a previous write
        /// operation.</exception>
        /// <exception cref="System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"></see> is
        /// closed.</exception>
        // ReSharper disable once RedundantAwait
        protected async Task WriteLineAsync(string value) =>
            // ReSharper disable once AsyncConverter.AsyncAwaitMayBeElidedHighlighting
            //// ReSharper disable RedundantAwait
            await this._writer.WriteLineAsync(value).ConfigureAwait(false);
            //// ReSharper enable RedundantAwait
    }
}
