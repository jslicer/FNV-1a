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

    /// <summary>
    /// Provides an implementation for performing test vector set 15 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set15 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set15"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set15(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 15 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("\x00".R500());
            this._Writer.WriteLine("\x07".R500());
            this._Writer.WriteLine("~".R500());
            this._Writer.WriteLine("\x7f".R500());
        }
    }
}
