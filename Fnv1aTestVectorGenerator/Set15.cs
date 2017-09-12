// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set15.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 15 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <inheritdoc />
    /// <summary>
    /// Provides an implementation for performing test vector set 15 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set15 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set15"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set15(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 15 generation.
        /// </summary>
        public override void Perform()
        {
            this.WriteLine("\x00".R500());
            this.WriteLine("\x07".R500());
            this.WriteLine("~".R500());
            this.WriteLine("\x7f".R500());
        }
    }
}
