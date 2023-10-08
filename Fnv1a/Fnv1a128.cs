﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a128.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Implements the FNV-1a 128-bit variant hashing algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1a
{
    using System;

    using static System.Globalization.CultureInfo;
    using static System.Globalization.NumberStyles;
    using static System.Numerics.BigInteger;

    /// <inheritdoc />
    /// <summary>
    /// Implements the FNV-1a 128-bit variant hashing algorithm.
    /// </summary>
    // ReSharper disable once InconsistentNaming
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a128 : Fnv1aBigBase
#pragma warning restore S101 // Types should be named in PascalCase
    {
        /// <inheritdoc cref="Fnv1aBigBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a128" /> class.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a
        /// <see cref="System.Globalization.NumberStyles" /> value.   -or-  style includes the
        /// <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        public Fnv1a128()
            : base(
                Parse("0FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", AllowHexSpecifier, InvariantCulture),
                Parse("0000000001000000000000000000013B", AllowHexSpecifier, InvariantCulture),
                Parse("6C62272E07BB014262B821756295C58D", AllowHexSpecifier, InvariantCulture),
                128)
        {
            // Intentionally empty.
        }
    }
}
