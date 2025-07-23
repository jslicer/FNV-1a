// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1aBigBase.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Implements the FNV-1a variant hashing algorithm for subtypes using the BigInteger class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1a;

using System;
using System.IO.Hashing;
using System.Numerics;
using System.Runtime.CompilerServices;

/// <inheritdoc cref="NonCryptographicHashAlgorithm" />
/// <summary>
/// Implements the FNV-1a variant hashing algorithm for subtypes using the BigInteger class.
/// </summary>
// ReSharper disable once InconsistentNaming
#pragma warning disable S101 // Types should be named in PascalCase
public abstract class Fnv1aBigBase : NonCryptographicHashAlgorithm
#pragma warning restore S101 // Types should be named in PascalCase
{
    /// <summary>
    /// The bit mask value for keeping multiplication within the number of bits.
    /// </summary>
    private readonly BigInteger _bitMask;

    /// <summary>
    /// The hash.
    /// </summary>
    private BigInteger _hash;

    /// <inheritdoc cref="NonCryptographicHashAlgorithm" />
    /// <summary>
    /// Initializes a new instance of the <see cref="Fnv1aBigBase" /> class.
    /// </summary>
    /// <param name="bitMask">The bit mask value for keeping multiplication within the number of bits.</param>
    /// <param name="prime">The FNV-1a prime.</param>
    /// <param name="offsetBasis">The FNV-1a offset basis.</param>
    /// <param name="hashSizeValue">The size, in bits, of the computed hash code.</param>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    // ReSharper disable once TooManyDependencies
    protected Fnv1aBigBase(
        in BigInteger bitMask,
        in BigInteger prime,
        in BigInteger offsetBasis,
        in int hashSizeValue)
        : base(1 + (hashSizeValue >> 3))
    {
        if (offsetBasis.IsZero)
        {
            throw new ArgumentOutOfRangeException(
                nameof(offsetBasis),
                offsetBasis,
                "The offset basis must be non-zero.");
        }

        _bitMask = bitMask;
        FnvPrime = prime;
        FnvOffsetBasis = offsetBasis;
        Init();
    }

    /// <summary>
    /// Gets the prime.
    /// </summary>
    /// <value>
    /// The prime.
    /// </value>
    public BigInteger FnvPrime { get; }

    /// <summary>
    /// Gets the non-zero offset basis.
    /// </summary>
    /// <value>
    /// The non-zero offset basis.
    /// </value>
    public BigInteger FnvOffsetBasis { get; }

    /// <inheritdoc />
    /// <summary>
    /// When overridden in a derived class, appends the contents of <paramref name="source" /> to the data already
    /// processed for the current hash computation.
    /// </summary>
    /// <param name="source">The data to process.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override void Append(ReadOnlySpan<byte> source)
    {
        foreach (byte b in source)
        {
            _hash ^= b;
            _hash = (_hash * FnvPrime) & _bitMask;
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// When overridden in a derived class, resets the hash computation to the initial state.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override void Reset() => Init();

    /// <inheritdoc />
    /// <summary>
    /// When overridden in a derived class, writes the computed hash value to <paramref name="destination" /> without
    /// modifying accumulated state.
    /// </summary>
    /// <param name="destination">The buffer that receives the computed hash value.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override void GetCurrentHashCore(Span<byte> destination) => _hash.TryWriteBytes(destination, out _);

    /// <summary>
    /// Initializes the hash for this instance.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Init() => _hash = FnvOffsetBasis;
}
