// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1aBigBase.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Implements the FNV-1a variant hashing algorithm for subtypes using the BigInteger class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1a
{
    using System.Numerics;

    /// <inheritdoc />
    /// <summary>
    /// Implements the FNV-1a variant hashing algorithm for subtypes using the BigInteger class.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public abstract class Fnv1aBigBase : System.Security.Cryptography.HashAlgorithm
    {
        /// <summary>
        /// The "wrap-around" modulo value for keeping multiplication within the number of bits.
        /// </summary>
        private readonly BigInteger _ModValue;

        /// <summary>
        /// The prime.
        /// </summary>
        private readonly BigInteger _Prime;

        /// <summary>
        /// The non-zero offset basis.
        /// </summary>
        private readonly BigInteger _OffsetBasis;

        /// <summary>
        /// The hash.
        /// </summary>
        private BigInteger _Hash;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1aBigBase"/> class.
        /// </summary>
        /// <param name="modValue">The "wrap-around" modulo value for keeping multiplication within the number of
        /// bits.</param>
        /// <param name="prime">The FNV-1a prime.</param>
        /// <param name="offsetBasis">The FNV-1a offset basis.</param>
        protected Fnv1aBigBase(BigInteger modValue, BigInteger prime, BigInteger offsetBasis)
        {
            this._ModValue = modValue;
            this._Prime = prime;
            this._OffsetBasis = offsetBasis;
            this.Init();
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes an implementation of the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> class.
        /// </summary>
        public sealed override void Initialize() => this.Init();

        /// <inheritdoc />
        /// <summary>
        /// When overridden in a derived class, routes data written to the object into the hash algorithm for computing
        /// the hash.
        /// </summary>
        /// <param name="array">The input to compute the hash code for.</param>
        /// <param name="ibStart">The offset into the byte array from which to begin using data.</param>
        /// <param name="cbSize">The number of bytes in the byte array to use as data.</param>
        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            if (array == null)
            {
                throw new System.ArgumentNullException(nameof(array));
            }

            for (var i = ibStart; i < cbSize; i++)
            {
                unchecked
                {
                    this._Hash ^= array[i];
                    this._Hash = (this._Hash * this._Prime) % this._ModValue;
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
        protected override byte[] HashFinal() => this._Hash.ToByteArray();

        /// <summary>
        /// Initializes the hash for this instance.
        /// </summary>
        private void Init() => this._Hash = this._OffsetBasis;
    }
}
