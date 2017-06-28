// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set3.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 3 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <summary>
    /// Provides an implementation for performing test vector set 3 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set3 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set3"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set3(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 3 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("ch".Test0());
            this._Writer.WriteLine("cho".Test0());
            this._Writer.WriteLine("chon".Test0());
            this._Writer.WriteLine("chong".Test0());
            this._Writer.WriteLine("chongo".Test0());
            this._Writer.WriteLine("chongo ".Test0());
            this._Writer.WriteLine("chongo w".Test0());
            this._Writer.WriteLine("chongo wa".Test0());
            this._Writer.WriteLine("chongo was".Test0());
            this._Writer.WriteLine("chongo was ".Test0());
            this._Writer.WriteLine("chongo was h".Test0());
            this._Writer.WriteLine("chongo was he".Test0());
            this._Writer.WriteLine("chongo was her".Test0());
            this._Writer.WriteLine("chongo was here".Test0());
            this._Writer.WriteLine("chongo was here!".Test0());
            this._Writer.WriteLine("chongo was here!\n".Test0());
        }
    }
}
