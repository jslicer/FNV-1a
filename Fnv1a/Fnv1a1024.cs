// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a1024.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Implements the FNV-1a 1024-bit variant hashing algorithm.
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
    /// Implements the FNV-1a 1024-bit variant hashing algorithm.
    /// </summary>
    // ReSharper disable once InconsistentNaming
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a1024 : Fnv1aBigBase
#pragma warning restore S101 // Types should be named in PascalCase
    {
        /// <inheritdoc cref="Fnv1aBigBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a1024" /> class.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a
        /// <see cref="System.Globalization.NumberStyles" /> value.   -or-  style includes the
        /// <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
        public Fnv1a1024()
            : this(
                Parse("000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000018D", AllowHexSpecifier, InvariantCulture),
                Parse("0000000000000000005F7A76758ECC4D32E56D5A591028B74B29FC4223FDADA16C3BF34EDA3674DA9A21D9000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004C6D7EB6E73802734510A555F256CC005AE556BDE8CC9C6A93B21AFF4B16C71EE90B3", AllowHexSpecifier, InvariantCulture))
        {
            // Intentionally empty.
        }

        /// <inheritdoc cref="Fnv1aBigBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a1024" /> class.
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
        public Fnv1a1024(BigInteger prime, BigInteger offsetBasis)
            : base(
                Parse("0FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", AllowHexSpecifier, InvariantCulture),
                prime,
                offsetBasis,
                1024)
        {
            // Intentionally empty.
        }
    }
}
