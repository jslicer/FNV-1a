// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a128.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Implements the FNV-1a 128-bit variant hashing algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1a;

using System;
using System.IO.Hashing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/// <inheritdoc cref="NonCryptographicHashAlgorithm" />
/// <summary>
/// Implements the FNV-1a 128-bit variant hashing algorithm.
/// </summary>
// ReSharper disable once InconsistentNaming
#pragma warning disable S101 // Types should be named in PascalCase
public sealed class Fnv1a128 : NonCryptographicHashAlgorithm
#pragma warning restore S101 // Types should be named in PascalCase
{
    /// <summary>
    /// The hash size in bytes.
    /// </summary>
    private const int HashSizeInBytes = 16;

    /// <summary>
    /// The default prime.
    /// </summary>
    private static readonly UInt128 FnvDefaultPrime = new(0x0000000001000000UL, 0x000000000000013BUL);

    /// <summary>
    /// The default non-zero offset basis.
    /// </summary>
    private static readonly UInt128 FnvDefaultOffsetBasis = new(0x6C62272E07BB0142UL, 0x62B821756295C58DUL);

    /// <summary>
    /// The hash.
    /// </summary>
    private UInt128 _hash;

    /// <inheritdoc cref="NonCryptographicHashAlgorithm" />
    /// <summary>
    /// Initializes a new instance of the <see cref="Fnv1a128" /> class.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    public Fnv1a128()
        : this(FnvDefaultPrime, FnvDefaultOffsetBasis)
    {
        // Intentionally empty.
    }

    /// <inheritdoc cref="NonCryptographicHashAlgorithm" />
    /// <summary>
    /// Initializes a new instance of the <see cref="Fnv1a128" /> class.
    /// </summary>
    /// <param name="prime">The prime.</param>
    /// <param name="offsetBasis">The non-zero offset basis.</param>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    public Fnv1a128(UInt128 prime, UInt128 offsetBasis)
        : base(HashSizeInBytes)
    {
        if (offsetBasis == UInt128.Zero)
        {
            throw new ArgumentOutOfRangeException(
                nameof(offsetBasis),
                offsetBasis,
                "The offset basis must be non-zero.");
        }

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
    public UInt128 FnvPrime { get; }

    /// <summary>
    /// Gets the non-zero offset basis.
    /// </summary>
    /// <value>
    /// The non-zero offset basis.
    /// </value>
    public UInt128 FnvOffsetBasis { get; }

    /// <inheritdoc />
    /// <summary>
    /// When overridden in a derived class, appends the contents of <paramref name="source" /> to the data already
    /// processed for the current hash computation.
    /// </summary>
    /// <param name="source">The data to process.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //// ReSharper disable once MethodTooLong
    public override void Append(ReadOnlySpan<byte> source)
    {
        int i = 0;
        int len = source.Length;

        while (i + 16 <= len)
        {
            // ReSharper disable once ComplexConditionExpression
            UInt128 chunk = BitConverter.ToUInt128(source[i..(i + 16)]);

            unchecked
            {
                _hash ^= (byte)chunk;
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 8);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 16);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 24);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 32);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 40);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 48);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 56);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 64);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 72);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 80);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 88);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 96);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 104);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 112);
                _hash *= FnvPrime;
                _hash ^= (byte)(chunk >> 120);
                _hash *= FnvPrime;
            }

            i += 16;
        }

        for (; i < len; i++)
        {
            unchecked
            {
                _hash ^= source[i];
                _hash *= FnvPrime;
            }
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// When overridden in a derived class, resets the hash computation to the initial state.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override void Reset() => _hash = FnvOffsetBasis;

    /// <inheritdoc />
    /// <summary>
    /// When overridden in a derived class, writes the computed hash value to <paramref name="destination" /> without
    /// modifying accumulated state.
    /// </summary>
    /// <param name="destination">The buffer that receives the computed hash value.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override void GetCurrentHashCore(Span<byte> destination) => MemoryMarshal.Write(destination, in _hash);

    /// <summary>
    /// Initializes the hash for this instance.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Init() => _hash = FnvOffsetBasis;
}
