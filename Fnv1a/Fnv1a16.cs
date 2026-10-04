// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a16.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Implements the FNV-1a 16-bit variant hashing algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1a;

using System.IO.Hashing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/// <inheritdoc cref="NonCryptographicHashAlgorithm" />
/// <summary>
/// Implements the FNV-1a 32-bit variant hashing algorithm.
/// </summary>
#pragma warning disable SQ0079 // Unused #pragma warning directive
#pragma warning disable S101 // Types should be named in PascalCase
// ReSharper disable once InconsistentNaming
public sealed class Fnv1a16 : NonCryptographicHashAlgorithm
#pragma warning restore S101 // Types should be named in PascalCase
#pragma warning restore SQ0079 // Unused #pragma warning directive
{
    /// <summary>
    /// The hash size in bytes.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    private const int HashSizeInBytes = 2;

    /// <summary>
    /// The default prime.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    private const ushort FnvDefaultPrime = (ushort)0x0101U;

    /// <summary>
    /// The default non-zero offset basis.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    private const ushort FnvDefaultOffsetBasis = (ushort)0x811CU;

    /// <summary>
    /// The hash.
    /// </summary>
    private ushort _hash;

    /// <inheritdoc cref="NonCryptographicHashAlgorithm" />
    /// <summary>
    /// Initializes a new instance of the <see cref="Fnv1a16" /> class.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    public Fnv1a16()
        : this(FnvDefaultPrime, FnvDefaultOffsetBasis)
    {
        // Intentionally empty.
    }

    /// <inheritdoc cref="NonCryptographicHashAlgorithm" />
    /// <summary>
    /// Initializes a new instance of the <see cref="Fnv1a16" /> class.
    /// </summary>
    /// <param name="prime">The prime.</param>
    /// <param name="offsetBasis">The non-zero offset basis.</param>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    public Fnv1a16(ushort prime, ushort offsetBasis)
        : base(HashSizeInBytes)
    {
        if (offsetBasis == (ushort)0U)
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
    public ushort FnvPrime { get; }

    /// <summary>
    /// Gets the non-zero offset basis.
    /// </summary>
    /// <value>
    /// The non-zero offset basis.
    /// </value>
    public ushort FnvOffsetBasis { get; }

    /// <inheritdoc />
    /// <summary>
    /// When overridden in a derived class, appends the contents of <paramref name="source" /> to the data already
    /// processed for the current hash computation.
    /// </summary>
    /// <param name="source">The data to process.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override void Append(ReadOnlySpan<byte> source) => _hash = AppendCore(_hash, source);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    protected override void GetCurrentHashCore(Span<byte> destination)
    {
        if (destination.Length < sizeof(ushort))
        {
            throw new ArgumentException("Destination span is too small.", nameof(destination));
        }

        destination[0] = (byte)_hash;
        destination[1] = (byte)(_hash >> 8);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ushort AppendCore(ushort hash, ReadOnlySpan<byte> source)
    {
        unchecked
        {
            ref byte r0 = ref MemoryMarshal.GetReference(source);

            for (int i = 0; i < source.Length; i++)
            {
                hash ^= Unsafe.Add(ref r0, i);
                hash = (ushort)(hash * FnvDefaultPrime);
            }

            return hash;
        }
    }

    /// <summary>
    /// Initializes the hash for this instance.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Init() => _hash = FnvOffsetBasis;
}