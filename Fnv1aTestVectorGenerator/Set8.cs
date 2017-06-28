// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set8.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 8 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <summary>
    /// Provides an implementation for performing test vector set 8 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set8 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set8"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set8(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 8 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("127.0.0.1".Test());
            this._Writer.WriteLine("127.0.0.1".Test0());
            this._Writer.WriteLine("127.0.0.2".Test());
            this._Writer.WriteLine("127.0.0.2".Test0());
            this._Writer.WriteLine("127.0.0.3".Test());
            this._Writer.WriteLine("127.0.0.3".Test0());
        }
    }
}
