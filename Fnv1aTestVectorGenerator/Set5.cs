// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set5.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 5 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

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
    }
}
