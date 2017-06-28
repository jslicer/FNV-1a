// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set11.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 11 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <summary>
    /// Provides an implementation for performing test vector set 11 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set11 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set11"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set11(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 11 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("line 1\nline 2\nline 3".Test());
        }
    }
}
