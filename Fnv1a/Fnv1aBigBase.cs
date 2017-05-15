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
        private readonly BigInteger _FnvPrime;

        /// <summary>
        /// The non-zero offset basis.
        /// </summary>
        private readonly BigInteger _FnvOffsetBasis;

        /// <summary>
        /// The hash.
        /// </summary>
        private BigInteger _Hash;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fnv1aBigBase"/> class.
        /// </summary>
        /// <param name="modValue">The "wrap-around" modulo value for keeping multiplication within the number of
        /// bits.</param>
        /// <param name="fnvPrime">The FNV-1a prime.</param>
        /// <param name="fnvOffsetBasis">The FNV-1a offset basis.</param>
        protected Fnv1aBigBase(BigInteger modValue, BigInteger fnvPrime, BigInteger fnvOffsetBasis)
        {
            this._ModValue = modValue;
            this._FnvPrime = fnvPrime;
            this._FnvOffsetBasis = fnvOffsetBasis;
            this.Initialize();
        }

        /// <summary>
        /// Initializes an implementation of the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> class.
        /// </summary>
        public override sealed void Initialize()
        {
            this._Hash = this._FnvOffsetBasis;
        }

        /// <summary>
        /// When overridden in a derived class, routes data written to the object into the hash algorithm for computing
        /// the hash.
        /// </summary>
        /// <param name="array">The input to compute the hash code for.</param>
        /// <param name="ibStart">The offset into the byte array from which to begin using data.</param>
        /// <param name="cbSize">The number of bytes in the byte array to use as data.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "Reviewed. Suppression is OK here.")]
        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            for (var i = ibStart; i < cbSize; i++)
            {
                unchecked
                {
                    this._Hash ^= array[i];
                    this._Hash = (this._Hash * this._FnvPrime) % this._ModValue;
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
            return this._Hash.ToByteArray();
        }
    }
}
