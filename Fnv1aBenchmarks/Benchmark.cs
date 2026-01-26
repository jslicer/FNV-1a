// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Benchmark.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Benchmark the FNV-1A hashing algorithm variants.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aBenchmarks;

using System;
using System.IO.Hashing;

using BenchmarkDotNet.Attributes;

using Fnv1a;

/// <summary>
/// Benchmark the FNV-1A hashing algorithm variants.
/// </summary>
#pragma warning disable CA1515 // Consider making public types internal
[Config(typeof(BenchmarkConfig))]
public class Benchmark
#pragma warning restore CA1515 // Consider making public types internal
{
    /// <summary>
    /// Shared single-byte buffer for streaming benchmarks.
    /// </summary>
    private readonly byte[] _singleByte = new byte[1];

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
    /// The random byte array to hash.
    /// </summary>
    private byte[] _data = [];

    /// <summary>
    /// Gets or sets the payload length for the benchmarks.
    /// </summary>
    [Params(32, 1024, 65536)]
    //// ReSharper disable once UnusedAutoPropertyAccessor.Global
    public int PayloadLength { get; set; }

    /// <summary>
    /// Initializes the data buffer for each benchmark run.
    /// </summary>
    [GlobalSetup]
    public void Setup()
    {
        _data = new byte[PayloadLength];
#pragma warning disable CA5394 // Do not use insecure randomness
#pragma warning disable SCS0005 // Weak random number generator.
        Random.Shared.NextBytes(_data);
#pragma warning restore SCS0005 // Weak random number generator.
#pragma warning restore CA5394 // Do not use insecure randomness
    }

    /// <summary>
    /// Benchmark the FNV-1a 32-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark(Baseline = true)]
    public byte[] Fnv1A32Block() => ComputeBlock(_fnv1A32);

    /// <summary>
    /// Benchmark the FNV-1a 32-bit hashing algorithm variant processing one byte at a time.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A32SingleByte() => ComputeSingleByte(_fnv1A32);

    /// <summary>
    /// Benchmark the FNV-1a 64-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A64Block() => ComputeBlock(_fnv1A64);

    /// <summary>
    /// Benchmark the FNV-1a 64-bit hashing algorithm variant processing one byte at a time.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A64SingleByte() => ComputeSingleByte(_fnv1A64);

    /// <summary>
    /// Benchmark the FNV-1a 128-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A128Block() => ComputeBlock(_fnv1A128);

    /// <summary>
    /// Benchmark the FNV-1a 128-bit hashing algorithm variant one byte at a time.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A128SingleByte() => ComputeSingleByte(_fnv1A128);

    /// <summary>
    /// Benchmark the FNV-1a 1256-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A256Block() => ComputeBlock(_fnv1A256);

    /// <summary>
    /// Benchmark the FNV-1a 256-bit hashing algorithm variant one byte at a time.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A256SingleByte() => ComputeSingleByte(_fnv1A256);

    /// <summary>
    /// Benchmark the FNV-1a 512-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A512Block() => ComputeBlock(_fnv1A512);

    /// <summary>
    /// Benchmark the FNV-1a 512-bit hashing algorithm variant one byte at a time.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A512SingleByte() => ComputeSingleByte(_fnv1A512);

    /// <summary>
    /// Benchmark the FNV-1a 1024-bit hashing algorithm variant.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A1024Block() => ComputeBlock(_fnv1A1024);

    /// <summary>
    /// Benchmark the FNV-1a 1024-bit hashing algorithm variant one byte at a time.
    /// </summary>
    /// <returns>The resulting hash value of the random byte array.</returns>
    [Benchmark]
    public byte[] Fnv1A1024SingleByte() => ComputeSingleByte(_fnv1A1024);

    /// <summary>
    /// Computes the block.
    /// </summary>
    /// <param name="algorithm">The algorithm.</param>
    /// <returns>The computed block.</returns>
    private byte[] ComputeBlock(NonCryptographicHashAlgorithm algorithm)
    {
        algorithm.Reset();
        algorithm.Append(_data);
        return algorithm.GetCurrentHash();
    }

    /// <summary>
    /// Computes the single byte.
    /// </summary>
    /// <param name="algorithm">The algorithm.</param>
    /// <returns>The computed byte.</returns>
    private byte[] ComputeSingleByte(NonCryptographicHashAlgorithm algorithm)
    {
        algorithm.Reset();
        foreach (byte b in _data)
        {
            _singleByte[0] = b;
            algorithm.Append(_singleByte);
        }

        return algorithm.GetCurrentHash();
    }
}