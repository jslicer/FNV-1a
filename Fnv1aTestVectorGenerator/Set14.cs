// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set14.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 14 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <summary>
    /// Provides an implementation for performing test vector set 14 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set14 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set14"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set14(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 14 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("21701".R10());
            this._Writer.WriteLine("M21701".R10());
            this._Writer.WriteLine("2^21701-1".R10());
            this._Writer.WriteLine("\x54\xc5".R10());
            this._Writer.WriteLine("\xc5\x54".R10());
            this._Writer.WriteLine("23209".R10());
            this._Writer.WriteLine("M23209".R10());
            this._Writer.WriteLine("2^23209-1".R10());
            this._Writer.WriteLine("\x5a\xa9".R10());
            this._Writer.WriteLine("\xa9\x5a".R10());
            this._Writer.WriteLine("391581216093".R10());
            this._Writer.WriteLine("391581*2^216093-1".R10());
            this._Writer.WriteLine("\x05\xf9\x9d\x03\x4c\x81".R10());
            this._Writer.WriteLine("FEDCBA9876543210".R10());
            this._Writer.WriteLine("\xfe\xdc\xba\x98\x76\x54\x32\x10".R10());
            this._Writer.WriteLine("EFCDAB8967452301".R10());
            this._Writer.WriteLine("\xef\xcd\xab\x89\x67\x45\x23\x01".R10());
            this._Writer.WriteLine("0123456789ABCDEF".R10());
            this._Writer.WriteLine("\x01\x23\x45\x67\x89\xab\xcd\xef".R10());
            this._Writer.WriteLine("1032547698BADCFE".R10());
            this._Writer.WriteLine("\x10\x32\x54\x76\x98\xba\xdc\xfe".R10());
        }
    }
}
