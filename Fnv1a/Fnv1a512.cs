// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a512.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Implements the FNV-1a 512-bit variant hashing algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1a
{
    using static System.Globalization.CultureInfo;
    using static System.Globalization.NumberStyles;
    using static System.Numerics.BigInteger;

    /// <inheritdoc />
    /// <summary>
    /// Implements the FNV-1a 512-bit variant hashing algorithm.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a512 : Fnv1aBigBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a512"/> class.
        /// </summary>
        public Fnv1a512() : base(
                Parse("10000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", AllowHexSpecifier, InvariantCulture),
                Parse("00000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000157", AllowHexSpecifier, InvariantCulture),
                Parse("0B86DB0B1171F4416DCA1E50F309990ACAC87D059C90000000000000000000D21E948F68A34C192F62EA79BC942DBE7CE182036415F56E34BAC982AAC4AFE9FD9", AllowHexSpecifier, InvariantCulture))
        {
            this.HashSizeValue = 512;
        }
    }
}
