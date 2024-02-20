// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a256.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Implements the FNV-1a 256-bit variant hashing algorithm.
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
    /// Implements the FNV-1a 256-bit variant hashing algorithm.
    /// </summary>
    // ReSharper disable once InconsistentNaming
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a256 : Fnv1aBigBase
#pragma warning restore S101 // Types should be named in PascalCase
    {
        /// <inheritdoc cref="Fnv1aBigBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a256" /> class.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a
        /// <see cref="System.Globalization.NumberStyles" /> value.   -or-  style includes the
        /// <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        public Fnv1a256()
            : this(
                Parse("0000000000000000000001000000000000000000000000000000000000000163", AllowHexSpecifier, InvariantCulture),
                Parse("DD268DBCAAC550362D98C384C4E576CCC8B1536847B6BBB31023B4C8CAEE0535", AllowHexSpecifier, InvariantCulture))
        {
            // Intentionally empty.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a256" /> class.
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
        /// <inheritdoc cref="Fnv1aBigBase" />
        public Fnv1a256(BigInteger prime, BigInteger offsetBasis)
            : base(
                Parse("0FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", AllowHexSpecifier, InvariantCulture),
                prime,
                offsetBasis,
                256)
        {
            // Intentionally empty.
        }
    }
}
