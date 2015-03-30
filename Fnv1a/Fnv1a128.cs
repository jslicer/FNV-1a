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
    using System.Globalization;
    using System.Numerics;

    /// <summary>
    /// Implements the FNV-1a 128-bit variant hashing algorithm.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a128 : Fnv1aBigBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a128"/> class.
        /// </summary>
        public Fnv1a128() : base(
                BigInteger.Parse("100000000000000000000000000000000", NumberStyles.AllowHexSpecifier),
                BigInteger.Parse("0000000001000000000000000000013B", NumberStyles.AllowHexSpecifier),
                BigInteger.Parse("6C62272E07BB014262B821756295C58D", NumberStyles.AllowHexSpecifier))
        {
        }
    }
}
