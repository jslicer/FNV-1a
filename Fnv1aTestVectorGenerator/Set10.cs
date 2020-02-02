// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set10.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 10 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// Provides an implementation for performing test vector set 10 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set10 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set10"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set10(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 10 generation.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"></see> is closed.</exception>
        public override void Perform()
        {
            //// ReSharper disable StringLiteralTypo
            this.WriteLine("feedface".Test());
            this.WriteLine("feedface".Test0());
            this.WriteLine("feedfacedaffdeed".Test());
            this.WriteLine("feedfacedaffdeed".Test0());
            this.WriteLine("feedfacedeadbeef".Test());
            this.WriteLine("feedfacedeadbeef".Test0());
            //// ReSharper enable StringLiteralTypo
        }

        /// <inheritdoc />
        /// <summary>
        /// Asynchronously performs the test vector set 10 generation.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task"/>.</returns>
        /// <exception cref="System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter"></see> is closed.</exception>
        public override async Task PerformAsync()
        {
            //// ReSharper disable StringLiteralTypo
            await this.WriteLineAsync(await "feedface".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "feedface".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "feedfacedaffdeed".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "feedfacedaffdeed".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "feedfacedeadbeef".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "feedfacedeadbeef".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            //// ReSharper enable StringLiteralTypo
        }
    }
}
