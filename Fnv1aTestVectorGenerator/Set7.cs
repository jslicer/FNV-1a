// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set7.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 7 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <summary>
    /// Provides an implementation for performing test vector set 7 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set7 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set7"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set7(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 7 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("\xff\x00\x00\x01".Test());
            this._Writer.WriteLine("\x01\x00\x00\xff".Test());
            this._Writer.WriteLine("\xff\x00\x00\x02".Test());
            this._Writer.WriteLine("\x02\x00\x00\xff".Test());
            this._Writer.WriteLine("\xff\x00\x00\x03".Test());
            this._Writer.WriteLine("\x03\x00\x00\xff".Test());
            this._Writer.WriteLine("\xff\x00\x00\x04".Test());
            this._Writer.WriteLine("\x04\x00\x00\xff".Test());
            this._Writer.WriteLine("\x40\x51\x4e\x44".Test());
            this._Writer.WriteLine("\x44\x4e\x51\x40".Test());
            this._Writer.WriteLine("\x40\x51\x4e\x4a".Test());
            this._Writer.WriteLine("\x4a\x4e\x51\x40".Test());
            this._Writer.WriteLine("\x40\x51\x4e\x54".Test());
            this._Writer.WriteLine("\x54\x4e\x51\x40".Test());
        }
    }
}
