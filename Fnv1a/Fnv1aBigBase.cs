﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1aBigBase.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Implements the FNV-1a variant hashing algorithm for subtypes using the BigInteger class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv ib
namespace Fnv1a
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Numerics;
    using System.Security.Cryptography;

    /// <inheritdoc cref="HashAlgorithm" />
    /// <summary>
    /// Implements the FNV-1a variant hashing algorithm for subtypes using the BigInteger class.
    /// </summary>
    // ReSharper disable once InconsistentNaming
#pragma warning disable S101 // Types should be named in PascalCase
    public abstract class Fnv1aBigBase : HashAlgorithm
#pragma warning restore S101 // Types should be named in PascalCase
    {
        /// <summary>
        /// The bit mask value for keeping multiplication within the number of bits.
        /// </summary>
        private readonly BigInteger _bitMask;

        /// <summary>
        /// The prime.
        /// </summary>
        private readonly BigInteger _prime;

        /// <summary>
        /// The non-zero offset basis.
        /// </summary>
        private readonly BigInteger _offsetBasis;

        /// <summary>
        /// The hash.
        /// </summary>
        private BigInteger _hash;

        /// <inheritdoc cref="HashAlgorithm" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1aBigBase" /> class.
        /// </summary>
        /// <param name="bitMask">The bit mask value for keeping multiplication within the number of bits.</param>
        /// <param name="prime">The FNV-1a prime.</param>
        /// <param name="offsetBasis">The FNV-1a offset basis.</param>
        /// <param name="hashSizeValue">The size, in bits, of the computed hash code.</param>
        // ReSharper disable once TooManyDependencies
        protected Fnv1aBigBase(
            in BigInteger bitMask,
            in BigInteger prime,
            in BigInteger offsetBasis,
            in int hashSizeValue)
        {
            this._bitMask = bitMask;
            this._prime = prime;
            this._offsetBasis = offsetBasis;
            this.Init();
            this.HashSizeValue = hashSizeValue;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes an implementation of the <see cref="HashAlgorithm" /> class.
        /// </summary>
        public override sealed void Initialize() => this.Init();

        /// <inheritdoc />
        /// <summary>
        /// When overridden in a derived class, routes data written to the object into the hash algorithm for computing
        /// the hash.
        /// </summary>
        /// <param name="array">The input to compute the hash code for.</param>
        /// <param name="ibStart">The offset into the byte array from which to begin using data.</param>
        /// <param name="cbSize">The number of bytes in the byte array to use as data.</param>
#pragma warning disable IDE0079 // Remove unnecessary suppression
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "Reviewed. Suppression is OK here.")]
#pragma warning restore IDE0079 // Remove unnecessary suppression
        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            for (int i = ibStart; i < cbSize; i++)
            {
                unchecked
                {
                    this._hash ^= array[i];
                    this._hash = (this._hash * this._prime) & this._bitMask;
                }
            }
        }

        /// <summary>
        /// Routes data written to the object into the hash algorithm for computing the hash.
        /// </summary>
        /// <param name="source">The input to compute the hash code for.</param>
        protected override void HashCore(ReadOnlySpan<byte> source)
        {
            foreach (byte b in source)
            {
                unchecked
                {
                    this._hash ^= b;
                    this._hash = (this._hash * this._prime) & this._bitMask;
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
        protected override byte[] HashFinal() => this.GetHashByteArray();

        /// <summary>
        /// Attempts to finalize the hash computation after the last data is processed by the hash algorithm.
        /// </summary>
        /// <param name="destination">The buffer to receive the hash value.</param>
        /// <param name="bytesWritten">When this method returns, the total number of bytes written into
        /// <paramref name="destination" />. This parameter is treated as uninitialized.</param>
        /// <returns><see langword="true" /> if <paramref name="destination" /> is long enough to receive the hash
        /// value; otherwise, <see langword="false" />.</returns>
        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            byte[] bytes = this.GetHashByteArray();

            bytes.CopyTo(destination);
            bytesWritten = bytes.Length;
            return true;
        }

        /// <summary>
        /// Initializes the hash for this instance.
        /// </summary>
        private void Init() => this._hash = this._offsetBasis;

        private byte[] GetHashByteArray() => this._hash.ToByteArray().Take(this.HashSize / 8).ToArray();
    }
}
