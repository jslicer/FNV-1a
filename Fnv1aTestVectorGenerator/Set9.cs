// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set9.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 9 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <inheritdoc />
    /// <summary>
    /// Provides an implementation for performing test vector set 9 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set9 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set9"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set9(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 9 generation.
        /// </summary>
        public override void Perform()
        {
            this.WriteLine("64.81.78.68".Test());
            this.WriteLine("64.81.78.68".Test0());
            this.WriteLine("64.81.78.74".Test());
            this.WriteLine("64.81.78.74".Test0());
            this.WriteLine("64.81.78.84".Test());
            this.WriteLine("64.81.78.84".Test0());
        }
    }
}
