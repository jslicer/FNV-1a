// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set3.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 3 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// Provides an implementation for performing test vector set 3 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set3 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set3"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set3(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 3 generation.
        /// </summary>
        public override void Perform()
        {
            this.WriteLine("ch".Test0());
            this.WriteLine("cho".Test0());
            this.WriteLine("chon".Test0());
            this.WriteLine("chong".Test0());
            this.WriteLine("chongo".Test0());
            this.WriteLine("chongo ".Test0());
            this.WriteLine("chongo w".Test0());
            this.WriteLine("chongo wa".Test0());
            this.WriteLine("chongo was".Test0());
            this.WriteLine("chongo was ".Test0());
            this.WriteLine("chongo was h".Test0());
            this.WriteLine("chongo was he".Test0());
            this.WriteLine("chongo was her".Test0());
            this.WriteLine("chongo was here".Test0());
            this.WriteLine("chongo was here!".Test0());
            this.WriteLine("chongo was here!\n".Test0());
        }

        /// <inheritdoc />
        /// <summary>
        /// Asynchronously performs the test vector set 3 generation.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task"/>.</returns>
        public override async Task PerformAsync()
        {
            await this.WriteLineAsync(await "ch".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "cho".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chon".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chong".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo ".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo w".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo wa".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was ".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was h".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was he".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was her".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was here".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was here!".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "chongo was here!\n".Test0Async().ConfigureAwait(false)).ConfigureAwait(false);
        }
    }
}
