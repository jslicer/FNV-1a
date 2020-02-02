// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set4.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 4 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// Provides an implementation for performing test vector set 4 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set4 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set4"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set4(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 4 generation.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"></see> is closed.</exception>
        public override void Perform()
        {
            this.WriteLine("cu".Test());
            this.WriteLine("cur".Test());
            this.WriteLine("curd".Test());
            this.WriteLine("curds".Test());
            this.WriteLine("curds ".Test());
            this.WriteLine("curds a".Test());
            this.WriteLine("curds an".Test());
            this.WriteLine("curds and".Test());
            this.WriteLine("curds and ".Test());
            this.WriteLine("curds and w".Test());
            this.WriteLine("curds and wh".Test());
            this.WriteLine("curds and whe".Test());
            this.WriteLine("curds and whey".Test());
            this.WriteLine("curds and whey\n".Test());
        }

        /// <inheritdoc />
        /// <summary>
        /// Asynchronously performs the test vector set 4 generation.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task"/>.</returns>
        /// <exception cref="System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"></see> is closed.</exception>
        public override async Task PerformAsync()
        {
            await this.WriteLineAsync(await "cu".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "cur".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curd".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds ".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds a".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds an".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and ".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and w".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and wh".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and whe".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and whey".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "curds and whey\n".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
        }
    }
}
