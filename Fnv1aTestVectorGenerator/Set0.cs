// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set0.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 0 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <summary>
    /// Provides an implementation for performing test vector set 0 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set0 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set0"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set0(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 0 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine(string.Empty.Test());
            this._Writer.WriteLine("a".Test());
            this._Writer.WriteLine("b".Test());
            this._Writer.WriteLine("c".Test());
            this._Writer.WriteLine("d".Test());
            this._Writer.WriteLine("e".Test());
            this._Writer.WriteLine("f".Test());
            this._Writer.WriteLine("fo".Test());
            this._Writer.WriteLine("foo".Test());
            this._Writer.WriteLine("foob".Test());
            this._Writer.WriteLine("fooba".Test());
            this._Writer.WriteLine("foobar".Test());
        }
    }
}
