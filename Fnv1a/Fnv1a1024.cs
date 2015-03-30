// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a1024.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Implements the FNV-1a 1024-bit variant hashing algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1a
{
    using System.Globalization;
    using System.Numerics;

    /// <summary>
    /// Implements the FNV-1a 1024-bit variant hashing algorithm.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a1024 : Fnv1aBigBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a1024"/> class.
        /// </summary>
        public Fnv1a1024() : base(
                BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", NumberStyles.AllowHexSpecifier),
                BigInteger.Parse("000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000018D", NumberStyles.AllowHexSpecifier),
                BigInteger.Parse("0000000000000000005F7A76758ECC4D32E56D5A591028B74B29FC4223FDADA16C3BF34EDA3674DA9A21D9000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004C6D7EB6E73802734510A555F256CC005AE556BDE8CC9C6A93B21AFF4B16C71EE90B3", NumberStyles.AllowHexSpecifier))
        {
            this.HashSizeValue = 1024;
        }
    }
}
