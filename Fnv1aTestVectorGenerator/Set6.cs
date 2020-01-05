// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set6.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 6 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// Provides an implementation for performing test vector set 6 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set6 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set6"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set6(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 6 generation.
        /// </summary>
        public override void Perform()
        {
            this.WriteLine("hi".Test());
            this.WriteLine("hi".Test0());
            this.WriteLine("hello".Test());
            this.WriteLine("hello".Test0());
        }

        /// <inheritdoc />
        /// <summary>
        /// Asynchronously performs the test vector set 6 generation.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task"/>.</returns>
        public override async Task PerformAsync()
        {
            await this.WriteLineAsync(await "hi".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "hi".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "hello".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "hello".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
        }
    }
}
