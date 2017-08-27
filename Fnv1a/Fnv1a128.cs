// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a128.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Implements the FNV-1a 128-bit variant hashing algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1a
{
    using static System.Globalization.CultureInfo;
    using static System.Globalization.NumberStyles;
    using static System.Numerics.BigInteger;

    /// <inheritdoc />
    /// <summary>
    /// Implements the FNV-1a 128-bit variant hashing algorithm.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a128 : Fnv1aBigBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a128"/> class.
        /// </summary>
        public Fnv1a128() : base(
                Parse("100000000000000000000000000000000", AllowHexSpecifier, InvariantCulture),
                Parse("0000000001000000000000000000013B", AllowHexSpecifier, InvariantCulture),
                Parse("6C62272E07BB014262B821756295C58D", AllowHexSpecifier, InvariantCulture)) => this.HashSizeValue = 128;
    }
}
