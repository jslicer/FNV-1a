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
    internal sealed class Set0 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Fnv1aTestVectorGenerator.Set0" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set0(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 0 generation.
        /// </summary>
        public override void Perform()
        {
            this.WriteLine(string.Empty.Test());
            this.WriteLine("a".Test());
            this.WriteLine("b".Test());
            this.WriteLine("c".Test());
            this.WriteLine("d".Test());
            this.WriteLine("e".Test());
            this.WriteLine("f".Test());
            this.WriteLine("fo".Test());
            this.WriteLine("foo".Test());
            this.WriteLine("foob".Test());
            this.WriteLine("fooba".Test());
            this.WriteLine("foobar".Test());
        }
    }
}
