// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set1.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 1 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <summary>
    /// Provides an implementation for performing test vector set 1 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set1 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set1"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set1(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 1 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine(string.Empty.Test0());
            this._Writer.WriteLine("a".Test0());
            this._Writer.WriteLine("b".Test0());
            this._Writer.WriteLine("c".Test0());
            this._Writer.WriteLine("d".Test0());
            this._Writer.WriteLine("e".Test0());
            this._Writer.WriteLine("f".Test0());
            this._Writer.WriteLine("fo".Test0());
            this._Writer.WriteLine("foo".Test0());
            this._Writer.WriteLine("foob".Test0());
            this._Writer.WriteLine("fooba".Test0());
            this._Writer.WriteLine("foobar".Test0());
        }
    }
}
