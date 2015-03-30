// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a64.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Implements the FNV-1a 64-bit variant hashing algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1a
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Security.Cryptography;

    /// <summary>
    /// Implements the FNV-1a 64-bit variant hashing algorithm.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a64 : HashAlgorithm
    {
        /// <summary>
        /// The prime.
        /// </summary>
        private const ulong FnvPrime = unchecked(0x00000100000001B3);

        /// <summary>
        /// The non-zero offset basis.
        /// </summary>
        private const ulong FnvOffsetBasis = unchecked(0xCBF29CE484222325);

        /// <summary>
        /// The hash.
        /// </summary>
        private ulong _Hash;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a64"/> class.
        /// </summary>
        public Fnv1a64()
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes an implementation of the <see cref="T:System.Security.Cryptography.HashAlgorithm"/> class.
        /// </summary>
        public override void Initialize()
        {
            this._Hash = FnvOffsetBasis;
        }

        /// <summary>
        /// When overridden in a derived class, routes data written to the object into the hash algorithm for computing
        /// the hash.
        /// </summary>
        /// <param name="array">The input to compute the hash code for.</param>
        /// <param name="ibStart">The offset into the byte array from which to begin using data.</param>
        /// <param name="cbSize">The number of bytes in the byte array to use as data.</param>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "Reviewed. Suppression is OK here.")]
        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            for (var i = ibStart; i < cbSize; i++)
            {
                unchecked
                {
                    this._Hash ^= array[i];
                    this._Hash *= FnvPrime;
                }
            }
        }

        /// <summary>
        /// When overridden in a derived class, finalizes the hash computation after the last data is processed by the
        /// cryptographic stream object.
        /// </summary>
        /// <returns>
        /// The computed hash code.
        /// </returns>
        protected override byte[] HashFinal()
        {
            return BitConverter.GetBytes(this._Hash);
        }
    }
}
