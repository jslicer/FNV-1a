// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set5.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 5 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator
{
    using System.IO;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// Provides an implementation for performing test vector set 5 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set5 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set5"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set5(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 5 generation.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"></see> is closed.</exception>
        public override void Perform()
        {
            this.WriteLine("cu".Test0());
            this.WriteLine("cur".Test0());
            this.WriteLine("curd".Test0());
            this.WriteLine("curds".Test0());
            this.WriteLine("curds ".Test0());
            this.WriteLine("curds a".Test0());
            this.WriteLine("curds an".Test0());
            this.WriteLine("curds and".Test0());
            this.WriteLine("curds and ".Test0());
            this.WriteLine("curds and w".Test0());
            this.WriteLine("curds and wh".Test0());
            this.WriteLine("curds and whe".Test0());
            this.WriteLine("curds and whey".Test0());
            this.WriteLine("curds and whey\n".Test0());
        }

        /// <inheritdoc />
        /// <summary>
        /// Asynchronously performs the test vector set 5 generation.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task"/>.</returns>
        /// <exception cref="System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"></see> is closed.</exception>
        public override async Task PerformAsync()
        {
            await this.WriteLineAsync(await "cu".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "cur".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curd".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds ".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds a".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds an".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and ".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and w".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and wh".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and whe".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and whey".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and whey\n".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
        }
    }
}
