﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set6.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 6 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <summary>
    /// Provides an implementation for performing test vector set 6 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set6 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set6"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set6(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 6 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("hi".Test());
            this._Writer.WriteLine("hi".Test0());
            this._Writer.WriteLine("hello".Test());
            this._Writer.WriteLine("hello".Test0());
        }
    }
}
