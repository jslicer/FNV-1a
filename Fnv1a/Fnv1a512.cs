// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a512.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Implements the FNV-1a 512-bit variant hashing algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1a;

using System;
using System.IO.Hashing;
using System.Runtime.CompilerServices;

using MissingValues;

/// <inheritdoc cref="NonCryptographicHashAlgorithm" />
/// <summary>
/// Implements the FNV-1a 512-bit variant hashing algorithm.
/// </summary>
// ReSharper disable once InconsistentNaming
#pragma warning disable S101 // Types should be named in PascalCase
public sealed class Fnv1a512 : NonCryptographicHashAlgorithm
#pragma warning restore S101 // Types should be named in PascalCase
{
    /// <summary>
    /// The hash size in bytes.
    /// </summary>
    private const int HashSizeInBytes = 64;

    /// <summary>
    /// The default prime.
    /// </summary>
    private static readonly UInt512 FnvDefaultPrime = new(
        new(new(0x0000000000000000UL, 0x0000000000000000UL), new(0x0000000001000000UL, 0x0000000000000000UL)),
        new(new(0x0000000000000000UL, 0x0000000000000000UL), new(0x0000000000000000UL, 0x0000000000000157UL)));

    /// <summary>
    /// The default non-zero offset basis.
    /// </summary>
    private static readonly UInt512 FnvDefaultOffsetBasis = new(
        new(new(0xB86DB0B1171F4416UL, 0xDCA1E50F309990ACUL), new(0xAC87D059C9000000UL, 0x0000000000000D21UL)),
        new(new(0xE948F68A34C192F6UL, 0x2EA79BC942DBE7CEUL), new(0x182036415F56E34BUL, 0xAC982AAC4AFE9FD9UL)));

    /// <summary>
    /// The hash.
    /// </summary>
    private UInt512 _hash;

    /// <inheritdoc cref="NonCryptographicHashAlgorithm" />
    /// <summary>
    /// Initializes a new instance of the <see cref="Fnv1a512" /> class.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    public Fnv1a512()
        : this(FnvDefaultPrime, FnvDefaultOffsetBasis)
    {
        // Intentionally empty.
    }

    /// <inheritdoc cref="NonCryptographicHashAlgorithm" />
    /// <summary>
    /// Initializes a new instance of the <see cref="Fnv1a512" /> class.
    /// </summary>
    /// <param name="prime">The prime.</param>
    /// <param name="offsetBasis">The non-zero offset basis.</param>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    public Fnv1a512(UInt512 prime, UInt512 offsetBasis)
        : base(HashSizeInBytes)
    {
        if (offsetBasis == UInt512.Zero)
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
    public UInt512 FnvPrime { get; }

    /// <summary>
    /// Gets the non-zero offset basis.
    /// </summary>
    /// <value>
    /// The non-zero offset basis.
    /// </value>
    public UInt512 FnvOffsetBasis { get; }

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
            unchecked
            {
                _hash ^= b;
                _hash *= FnvPrime;
            }
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// When overridden in a derived class, resets the hash computation to the initial state.
    /// </summary>
    public override void Reset() => _hash = FnvOffsetBasis;

    /// <inheritdoc />
    /// <summary>
    /// When overridden in a derived class, writes the computed hash value to <paramref name="destination" /> without
    /// modifying accumulated state.
    /// </summary>
    /// <param name="destination">The buffer that receives the computed hash value.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override void GetCurrentHashCore(Span<byte> destination)
    {
        BitConverter.GetBytes((UInt128)(_hash >> 384)).CopyTo(destination);
        BitConverter.GetBytes((UInt128)(_hash >> 256)).CopyTo(destination[16..]);
        BitConverter.GetBytes((UInt128)(_hash >> 128)).CopyTo(destination[32..]);
        BitConverter.GetBytes((UInt128)_hash).CopyTo(destination[48..]);
    }

    /// <summary>
    /// Initializes the hash for this instance.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Init() => _hash = FnvOffsetBasis;
}
