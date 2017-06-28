// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set12.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 12 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <summary>
    /// Provides an implementation for performing test vector set 12 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set12 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set12"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set12(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 12 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("chongo <Landon Curt Noll> /\\../\\".Test());
            this._Writer.WriteLine("chongo <Landon Curt Noll> /\\../\\".Test0());
            this._Writer.WriteLine("chongo (Landon Curt Noll) /\\../\\".Test());
            this._Writer.WriteLine("chongo (Landon Curt Noll) /\\../\\".Test0());
        }
    }
}
