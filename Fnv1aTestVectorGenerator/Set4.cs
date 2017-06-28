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

    /// <summary>
    /// Provides an implementation for performing test vector set 4 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set4 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set4"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set4(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 4 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("cu".Test());
            this._Writer.WriteLine("cur".Test());
            this._Writer.WriteLine("curd".Test());
            this._Writer.WriteLine("curds".Test());
            this._Writer.WriteLine("curds ".Test());
            this._Writer.WriteLine("curds a".Test());
            this._Writer.WriteLine("curds an".Test());
            this._Writer.WriteLine("curds and".Test());
            this._Writer.WriteLine("curds and ".Test());
            this._Writer.WriteLine("curds and w".Test());
            this._Writer.WriteLine("curds and wh".Test());
            this._Writer.WriteLine("curds and whe".Test());
            this._Writer.WriteLine("curds and whey".Test());
            this._Writer.WriteLine("curds and whey\n".Test());
        }
    }
}
