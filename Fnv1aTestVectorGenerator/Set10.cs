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
        public override void Perform()
        {
            this.WriteLine("feedface".Test());
            this.WriteLine("feedface".Test0());
            this.WriteLine("feedfacedaffdeed".Test());
            this.WriteLine("feedfacedaffdeed".Test0());
            this.WriteLine("feedfacedeadbeef".Test());
            this.WriteLine("feedfacedeadbeef".Test0());
        }
    }
}
