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

    /// <inheritdoc />
    /// <summary>
    /// Provides an implementation for performing test vector set 7 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set7 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set7"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set7(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 7 generation.
        /// </summary>
        public override void Perform()
        {
            this.WriteLine("\xff\x00\x00\x01".Test());
            this.WriteLine("\x01\x00\x00\xff".Test());
            this.WriteLine("\xff\x00\x00\x02".Test());
            this.WriteLine("\x02\x00\x00\xff".Test());
            this.WriteLine("\xff\x00\x00\x03".Test());
            this.WriteLine("\x03\x00\x00\xff".Test());
            this.WriteLine("\xff\x00\x00\x04".Test());
            this.WriteLine("\x04\x00\x00\xff".Test());
            this.WriteLine("\x40\x51\x4e\x44".Test());
            this.WriteLine("\x44\x4e\x51\x40".Test());
            this.WriteLine("\x40\x51\x4e\x4a".Test());
            this.WriteLine("\x4a\x4e\x51\x40".Test());
            this.WriteLine("\x40\x51\x4e\x54".Test());
            this.WriteLine("\x54\x4e\x51\x40".Test());
        }
    }
}
