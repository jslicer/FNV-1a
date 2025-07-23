// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Benchmark.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Benchmark the X hashing algorithm variants.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv

namespace Fnv1aBenchmarks;

using System.IO.Hashing;

using BenchmarkDotNet.Attributes;

using Fnv1a;

/// <summary>
/// Benchmark the X hashing algorithm variants.
/// </summary>
#pragma warning disable CA1515 // Consider making public types internal
public class Benchmark
#pragma warning restore CA1515 // Consider making public types internal
{
    /// <summary>
    /// The size of the random byte array to hash.
    /// </summary>
    private const int N = 100000;

    /// <summary>
    /// The random byte array to hash.
    /// </summary>
    private readonly byte[] _data;

    /// <summary>
    /// The FNV-1a 32-bit hasher.
    /// </summary>
    private readonly NonCryptographicHashAlgorithm _fnv1A32 = new Fnv1a32();

    /// <summary>
    /// The FNV-1a 64-bit hasher.
    /// </summary>
    private readonly NonCryptographicHashAlgorithm _fnv1A64 = new Fnv1a64();

    /// <summary>
    /// The FNV-1a 128-bit hasher.
    /// </summary>
    private readonly NonCryptographicHashAlgorithm _fnv1A128 = new Fnv1a128();

    /// <summary>
    /// The FNV-1a 256-bit hasher.
    /// </summary>
    private readonly NonCryptographicHashAlgorithm _fnv1A256 = new Fnv1a256();

    /// <summary>
    /// The FNV-1a 512-bit hasher.
    /// </summary>
    private readonly NonCryptographicHashAlgorithm _fnv1A512 = new Fnv1a512();

    /// <summary>
    /// The FNV-1a 1024-bit hasher.
    /// </summary>
    private readonly NonCryptographicHashAlgorithm _fnv1A1024 = new Fnv1a1024();

    /// <summary>
    /// Initializes a new instance of the <see cref="Benchmark" /> class.
    /// </summary>
    public Benchmark()
    {
        _data = new byte[N];
#pragma warning disable CA5394 // Do not use insecure randomness
        Random.Shared.NextBytes(_data);
#pragma warning restore CA5394 // Do not use insecure randomness
    }

    /// <summary>
    /// Benchmark the FNV-1a 32-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A32()
    {
        _fnv1A32.Append(_data);
        return _fnv1A32.GetCurrentHash();
    }

    /// <summary>
    /// Benchmark the FNV-1a 64-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A64()
    {
        _fnv1A64.Append(_data);
        return _fnv1A64.GetCurrentHash();
    }

    /// <summary>
    /// Benchmark the FNV-1a 128-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A128()
    {
        _fnv1A128.Append(_data);
        return _fnv1A128.GetCurrentHash();
    }

    /// <summary>
    /// Benchmark the FNV-1a 1256-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A256()
    {
        _fnv1A256.Append(_data);
        return _fnv1A256.GetCurrentHash();
    }

    /// <summary>
    /// Benchmark the FNV-1a 512-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A512()
    {
        _fnv1A512.Append(_data);
        return _fnv1A512.GetCurrentHash();
    }

    /// <summary>
    /// Benchmark the FNV-1a 1024-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A1024()
    {
        _fnv1A1024.Append(_data);
        return _fnv1A1024.GetCurrentHash();
    }
}