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

    internal abstract class SetBase : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <inheritdoc />
        /// <summary>
        /// Defines the test vector set generation.
        /// </summary>
        public abstract void Perform();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetBase"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        protected SetBase(TextWriter writer = null) => this._Writer = writer ?? TextWriter.Null;

        /// <summary>
        /// Writes the line to the <see cref="TextWriter"/>.
        /// </summary>
        /// <param name="value">The value to write.</param>
        protected void WriteLine(string value) => this._Writer.WriteLine(value);
    }
}
