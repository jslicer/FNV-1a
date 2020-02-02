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
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a512 : Fnv1aBigBase
#pragma warning restore S101 // Types should be named in PascalCase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a512"/> class.
        /// </summary>
        /// <exception cref="System.ArgumentException">style is not a
        /// <see cref="System.Globalization.NumberStyles"></see> value.   -or-  style includes the
        /// <see cref="AllowHexSpecifier"></see> or <see cref="HexNumber"></see> flag along with another
        /// value.</exception>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        public Fnv1a512() : base(
            Parse("100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", AllowHexSpecifier, InvariantCulture),
            Parse("00000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000157", AllowHexSpecifier, InvariantCulture),
            Parse("B86DB0B1171F4416DCA1E50F309990ACAC87D059C90000000000000000000D21E948F68A34C192F62EA79BC942DBE7CE182036415F56E34BAC982AAC4AFE9FD9", AllowHexSpecifier, InvariantCulture),
            512)
        {
        }
    }
}
