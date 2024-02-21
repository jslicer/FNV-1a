// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a512.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Implements the FNV-1a 512-bit variant hashing algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1a
{
    using System;
    using System.Numerics;

    using static System.Globalization.CultureInfo;
    using static System.Globalization.NumberStyles;
    using static System.Numerics.BigInteger;

    /// <inheritdoc />
    /// <summary>
    /// Implements the FNV-1a 512-bit variant hashing algorithm.
    /// </summary>
    // ReSharper disable once InconsistentNaming
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a512 : Fnv1aBigBase
#pragma warning restore S101 // Types should be named in PascalCase
    {
        /// <inheritdoc cref="Fnv1aBigBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a512" /> class.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a
        /// <see cref="System.Globalization.NumberStyles" /> value.   -or-  style includes the
        /// <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
        public Fnv1a512()
            : this(
                Parse("00000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000157", AllowHexSpecifier, InvariantCulture),
                Parse("B86DB0B1171F4416DCA1E50F309990ACAC87D059C90000000000000000000D21E948F68A34C192F62EA79BC942DBE7CE182036415F56E34BAC982AAC4AFE9FD9", AllowHexSpecifier, InvariantCulture))
        {
            // Intentionally empty.
        }

        /// <inheritdoc cref="Fnv1aBigBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a512" /> class.
        /// </summary>
        /// <param name="prime">The prime.</param>
        /// <param name="offsetBasis">The non-zero offset basis.</param>
        /// <exception cref="ArgumentException">style is not a
        /// <see cref="System.Globalization.NumberStyles" /> value.   -or-  style includes the
        /// <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
        public Fnv1a512(BigInteger prime, BigInteger offsetBasis)
            : base(
                Parse("0FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", AllowHexSpecifier, InvariantCulture),
                prime,
                offsetBasis,
                512)
        {
            // Intentionally empty.
        }
    }
}
