// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bitmasks.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2020
// </copyright>
// <summary>
//   Byte bitmasks used for the larger bit-sized test vectors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator
{
    using System.Numerics;

    using static System.Globalization.CultureInfo;
    using static System.Globalization.NumberStyles;
    using static System.Numerics.BigInteger;

    /// <summary>
    /// Byte bitmasks used for the larger bit-sized test vectors.
    /// </summary>
    internal static class Bitmasks
    {
        /// <summary>
        /// Gets the bottom 64 bytes.
        /// </summary>
        // ReSharper disable once ExceptionNotDocumentedOptional
        internal static BigInteger Bottom64Bytes { get; } = Parse(
            // ReSharper disable once StringLiteralTypo
            "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
            AllowHexSpecifier,
            InvariantCulture);

        /// <summary>
        /// Gets the third 64 bytes.
        /// </summary>
        // ReSharper disable once ExceptionNotDocumentedOptional
        internal static BigInteger Third64Bytes { get; } = Parse(
            "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF0000000000000000000000000000000000000000000000000000000000000000",
            AllowHexSpecifier,
            InvariantCulture);

        /// <summary>
        /// Gets the second 64 bytes.
        /// </summary>
        // ReSharper disable once ExceptionNotDocumentedOptional
        internal static BigInteger Second64Bytes { get; } = Parse(
            "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000",
            AllowHexSpecifier,
            InvariantCulture);
    }
}
