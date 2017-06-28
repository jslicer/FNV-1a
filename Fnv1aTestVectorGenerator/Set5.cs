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

    /// <summary>
    /// Provides an implementation for performing test vector set 5 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set5 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set5"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set5(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 5 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("cu".Test0());
            this._Writer.WriteLine("cur".Test0());
            this._Writer.WriteLine("curd".Test0());
            this._Writer.WriteLine("curds".Test0());
            this._Writer.WriteLine("curds ".Test0());
            this._Writer.WriteLine("curds a".Test0());
            this._Writer.WriteLine("curds an".Test0());
            this._Writer.WriteLine("curds and".Test0());
            this._Writer.WriteLine("curds and ".Test0());
            this._Writer.WriteLine("curds and w".Test0());
            this._Writer.WriteLine("curds and wh".Test0());
            this._Writer.WriteLine("curds and whe".Test0());
            this._Writer.WriteLine("curds and whey".Test0());
            this._Writer.WriteLine("curds and whey\n".Test0());
        }
    }
}
