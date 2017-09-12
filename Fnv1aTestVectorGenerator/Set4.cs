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
    }
}
