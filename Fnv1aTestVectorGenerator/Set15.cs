// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set15.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 15 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// Provides an implementation for performing test vector set 15 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set15 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set15"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set15(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 15 generation.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"></see> is closed.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="System.Text.StringBuilder.MaxCapacity"></see>.</exception>
        public override void Perform()
        {
            this.WriteLine("\x00".R500());
            this.WriteLine("\x07".R500());
            this.WriteLine("~".R500());
            this.WriteLine("\x7f".R500());
        }

        /// <inheritdoc />
        /// <summary>
        /// Asynchronously performs the test vector set 15 generation.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task"/>.</returns>
        /// <exception cref="System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"></see> is closed.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="System.Text.StringBuilder.MaxCapacity"></see>.</exception>
        public override async Task PerformAsync()
        {
            await this.WriteLineAsync(await "\x00".R500Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x07".R500Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "~".R500Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "\x7f".R500Async().ConfigureAwait(false)).ConfigureAwait(false);
        }
    }
}
