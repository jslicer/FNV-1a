// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set1.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 1 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// Provides an implementation for performing test vector set 1 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set1 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Fnv1aTestVectorGenerator.Set1" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set1(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 1 generation.
        /// </summary>
        public override void Perform()
        {
            this.WriteLine(string.Empty.Test0());
            this.WriteLine("a".Test0());
            this.WriteLine("b".Test0());
            this.WriteLine("c".Test0());
            this.WriteLine("d".Test0());
            this.WriteLine("e".Test0());
            this.WriteLine("f".Test0());
            this.WriteLine("fo".Test0());
            this.WriteLine("foo".Test0());
            this.WriteLine("foob".Test0());
            this.WriteLine("fooba".Test0());
            this.WriteLine("foobar".Test0());
        }

        /// <inheritdoc />
        /// <summary>
        /// Asynchronously performs the test vector set 1 generation.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task"/>.</returns>
        public override async Task PerformAsync()
        {
            await this.WriteLineAsync(await string.Empty.Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "a".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "b".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "c".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "d".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "e".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "f".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "fo".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "foo".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "foob".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "fooba".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "foobar".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
        }
    }
}
