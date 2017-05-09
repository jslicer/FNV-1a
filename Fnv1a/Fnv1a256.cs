// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a256.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Implements the FNV-1a 256-bit variant hashing algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1a
{
    using static System.Globalization.CultureInfo;
    using static System.Globalization.NumberStyles;
    using static System.Numerics.BigInteger;

    /// <summary>
    /// Implements the FNV-1a 256-bit variant hashing algorithm.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a256 : Fnv1aBigBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a256"/> class.
        /// </summary>
        public Fnv1a256() : base(
                Parse("1000000000000000000000000000000000000000000000000000000000000000", AllowHexSpecifier, InvariantCulture),
                Parse("0000000000000000000001000000000000000000000000000000000000000163", AllowHexSpecifier, InvariantCulture),
                Parse("0DD268DBCAAC550362D98C384C4E576CCC8B1536847B6BBB31023B4C8CAEE0535", AllowHexSpecifier, InvariantCulture))
        {
            this.HashSizeValue = 256;
        }
    }
}
