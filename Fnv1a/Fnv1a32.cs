// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a32.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Implements the FNV-1a 32-bit variant hashing algorithm.
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
/// Implements the FNV-1a 32-bit variant hashing algorithm.
/// </summary>
// ReSharper disable once InconsistentNaming
#pragma warning disable S101 // Types should be named in PascalCase
public sealed class Fnv1a32 : NonCryptographicHashAlgorithm
#pragma warning restore S101 // Types should be named in PascalCase
{
    /// <summary>
    /// The hash size in bytes.
    /// </summary>
    private const int HashSizeInBytes = 4;

    /// <summary>
    /// The default prime.
    /// </summary>
    private const uint FnvDefaultPrime = 0x01000193U;

    /// <summary>
    /// The default non-zero offset basis.
    /// </summary>
    private const uint FnvDefaultOffsetBasis = 0x811C9DC5U;

    /// <summary>
    /// The hash.
    /// </summary>
    private uint _hash;

    /// <inheritdoc cref="NonCryptographicHashAlgorithm" />
    /// <summary>
    /// Initializes a new instance of the <see cref="Fnv1a32" /> class.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    public Fnv1a32()
        : this(FnvDefaultPrime, FnvDefaultOffsetBasis)
    {
        // Intentionally empty.
    }

    /// <inheritdoc cref="NonCryptographicHashAlgorithm" />
    /// <summary>
    /// Initializes a new instance of the <see cref="Fnv1a32" /> class.
    /// </summary>
    /// <param name="prime">The prime.</param>
    /// <param name="offsetBasis">The non-zero offset basis.</param>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    public Fnv1a32(uint prime, uint offsetBasis)
        : base(HashSizeInBytes)
    {
        if (offsetBasis == 0U)
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
    public uint FnvPrime { get; }

    /// <summary>
    /// Gets the non-zero offset basis.
    /// </summary>
    /// <value>
    /// The non-zero offset basis.
    /// </value>
    public uint FnvOffsetBasis { get; }

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

        // Process 4 bytes at a time if possible
        while (i + 4 <= len)
        {
            // ReSharper disable once ComplexConditionExpression
            uint chunk = MemoryMarshal.Read<uint>(source[i..]);

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
            }

            i += 4;
        }

        // Process remaining bytes
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
