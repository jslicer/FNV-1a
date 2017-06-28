// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set2.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 2 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <summary>
    /// Provides an implementation for performing test vector set 2 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set2 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set2"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set2(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 2 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("ch".Test());
            this._Writer.WriteLine("cho".Test());
            this._Writer.WriteLine("chon".Test());
            this._Writer.WriteLine("chong".Test());
            this._Writer.WriteLine("chongo".Test());
            this._Writer.WriteLine("chongo ".Test());
            this._Writer.WriteLine("chongo w".Test());
            this._Writer.WriteLine("chongo wa".Test());
            this._Writer.WriteLine("chongo was".Test());
            this._Writer.WriteLine("chongo was ".Test());
            this._Writer.WriteLine("chongo was h".Test());
            this._Writer.WriteLine("chongo was he".Test());
            this._Writer.WriteLine("chongo was her".Test());
            this._Writer.WriteLine("chongo was here".Test());
            this._Writer.WriteLine("chongo was here!".Test());
            this._Writer.WriteLine("chongo was here!\n".Test());
        }
    }
}
