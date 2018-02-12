// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SetBase.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an base class for performing test vector generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <inheritdoc />
    /// <summary>
    /// Provides an base class for performing test vector generation.
    /// </summary>
    /// <seealso cref="T:Fnv1aTestVectorGenerator.ISet" />
    internal abstract class SetBase : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="SetBase"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        protected SetBase(TextWriter writer = null) => this._writer = writer ?? TextWriter.Null;

        /// <inheritdoc />
        /// <summary>
        /// Defines the test vector set generation.
        /// </summary>
        public abstract void Perform();

        /// <summary>
        /// Writes the line to the <see cref="TextWriter"/>.
        /// </summary>
        /// <param name="value">The value to write.</param>
        protected void WriteLine(string value) => this._writer.WriteLine(value);
    }
}
