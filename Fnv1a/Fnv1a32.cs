// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a32.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Implements the FNV-1a 32-bit variant hashing algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1a
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// Implements the FNV-1a 32-bit variant hashing algorithm.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a32 : System.Security.Cryptography.HashAlgorithm
    {
        /// <summary>
        /// The prime.
        /// </summary>
        private const uint FnvPrime = 0x01000193;

        /// <summary>
        /// The non-zero offset basis.
        /// </summary>
        private const uint FnvOffsetBasis = 0x811C9DC5;

        /// <summary>
        /// The hash.
        /// </summary>
        private uint _hash;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1a32"/> class.
        /// </summary>
        public Fnv1a32()
        {
            this.Initialize();
            this.HashSizeValue = 32;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes an implementation of the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> class.
        /// </summary>
        public override void Initialize() => this._hash = FnvOffsetBasis;

        /// <inheritdoc />
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
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = ibStart; i < cbSize; i++)
            {
                unchecked
                {
                    this._hash ^= array[i];
                    this._hash *= FnvPrime;
                }
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// When overridden in a derived class, finalizes the hash computation after the last data is processed by the
        /// cryptographic stream object.
        /// </summary>
        /// <returns>
        /// The computed hash code.
        /// </returns>
        protected override byte[] HashFinal() => BitConverter.GetBytes(this._hash);
    }
}
