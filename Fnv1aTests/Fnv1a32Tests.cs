// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a32Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Tests the FNV-1a 32-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTests;

using System;
using System.IO;
using System.IO.Hashing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Fnv1a;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using static System.Text.Encoding;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

/// <summary>
/// Tests the FNV-1a 32-bit algorithm.
/// </summary>
[TestClass]
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
#pragma warning disable CA1515 // Consider making public types internal
// ReSharper disable once InconsistentNaming
// ReSharper disable once UnusedType.Global
public sealed class Fnv1a32Tests
#pragma warning restore CA1515 // Consider making public types internal
#pragma warning restore S101 // Types should be named in PascalCase
#pragma warning restore IDE0079 // Remove unnecessary suppression
{
    /// <summary>
    /// The hash algorithm being tested.
    /// </summary>
    private NonCryptographicHashAlgorithm _alg = null!;

    /// <summary>
    /// The method to run before each test.
    /// </summary>
    //// ReSharper disable once UnusedMember.Global
    [TestInitialize]
    //// ReSharper disable once UnusedMember.Global
    public void Initialize()
    {
        _alg = new Fnv1a32();
        _alg.Reset();
    }

    /// <summary>
    /// Tests the empty string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector1() => AreEqual(0x811C9DC5U, Fnv1a32(string.Empty));

    /// <summary>
    /// Tests the empty string against the known vector result.
    /// </summary>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public async Task TestVector1Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(0x811C9DC5U, await Fnv1a32Async(string.Empty, cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the empty string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector1Try() => AreEqual(0x811C9DC5U, Fnv1a32Try(string.Empty));

    /// <summary>
    /// Tests the string "a" against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector2() => AreEqual(0xE40C292CU, Fnv1a32("a"));

    /// <summary>
    /// Tests the string "a" against the known vector result.
    /// </summary>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public async Task TestVector2Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(0xE40C292CU, await Fnv1a32Async("a", cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the string "a" against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector2Try() => AreEqual(0xE40C292CU, Fnv1a32Try("a"));

    /// <summary>
    /// Tests the string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector3() => AreEqual(0xBF9CF968U, Fnv1a32("foobar"));

    /// <summary>
    /// Tests the string against the known vector result.
    /// </summary>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public async Task TestVector3Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(0xBF9CF968U, await Fnv1a32Async("foobar", cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector3Try() => AreEqual(0xBF9CF968U, Fnv1a32Try("foobar"));

    /// <summary>
    /// Tests the alternate prime and zero offset.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestAlternatePrimeAndZeroOffset() => ThrowsExactly<ArgumentOutOfRangeException>(() => _ = new Fnv1a32(0xB3CB2E29U, 0x0U));

    /// <summary>
    /// Tests the alternate prime and non-zero offset.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="ArgumentException">startIndex is greater than or equal to the length of value minus 3, and
    /// is less than or equal to the length of value minus 1.</exception>
    /// <exception cref="ArgumentNullException">buffer is <see langword="null" />.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestAlternatePrimeAndOffset()
    {
        Fnv1a32 alg = new(0xB3CB2E29U, 0x319712C3U);

        AreEqual(4, alg.HashLengthInBytes);
        AreEqual(0xB3CB2E29U, alg.FnvPrime);
        AreEqual(0x319712C3U, alg.FnvOffsetBasis);
        _alg.Append("foobar"u8.ToArray());
        AreEqual(0xBF9CF968U, (uint)BitConverter.ToInt32(_alg.GetCurrentHash(), 0));
    }

    /// <summary>
    /// Tests the alternate prime and non-zero offset.
    /// </summary>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="ArgumentException">startIndex is greater than or equal to the length of value minus 3, and
    /// is less than or equal to the length of value minus 1.</exception>
    /// <exception cref="ArgumentNullException">buffer is <see langword="null" />.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public async Task TestAlternatePrimeAndOffsetAsync()
    {
        Fnv1a32 alg = new(0xB3CB2E29U, 0x319712C3U);

        AreEqual(4, alg.HashLengthInBytes);
        AreEqual(0xB3CB2E29U, alg.FnvPrime);
        AreEqual(0x319712C3U, alg.FnvOffsetBasis);
        using CancellationTokenSource cts = new();
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
        await using Stream stream = new MemoryStream("foobar"u8.ToArray());
#pragma warning restore CA2007 // Consider calling ConfigureAwait on the awaited task
        await _alg.AppendAsync(stream, cts.Token).ConfigureAwait(true);

        uint actual = (uint)BitConverter.ToInt32(_alg.GetCurrentHash(), 0);

        AreEqual(0xBF9CF968U, actual);
    }

    /// <summary>
    /// Tests the alternate prime and non-zero offset.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="ArgumentNullException">s is <see langword="null" />.</exception>
    /// <exception cref="EncoderFallbackException">A fallback occurred (for more information, see Character
    /// Encoding in .NET)
    ///  -and-
    ///  <see cref="EncoderFallback" /> is set to <see cref="EncoderExceptionFallback" />.</exception>
    [TestMethod]
    //// ReSharper disable once TooManyDeclarations
    //// ReSharper disable once UnusedMember.Global
    public void TestAlternatePrimeAndOffsetTry()
    {
        Fnv1a32 alg = new(0xB3CB2E29U, 0x319712C3U);

        AreEqual(4, alg.HashLengthInBytes);
        AreEqual(0xB3CB2E29U, alg.FnvPrime);
        AreEqual(0x319712C3U, alg.FnvOffsetBasis);

        const string Data = "foobar";
        int inputByteCount = UTF8.GetByteCount(Data);
        Span<byte> bytes = inputByteCount < 1024
            ? stackalloc byte[inputByteCount]
            : new byte[inputByteCount];

        AreEqual(inputByteCount, UTF8.GetBytes(Data, bytes));

        Span<byte> destination = stackalloc byte[_alg.HashLengthInBytes];

        _alg.Append(bytes);

        bool result = _alg.TryGetCurrentHash(destination, out int bytesWritten);

        IsTrue(result);
        IsGreaterThanOrEqualTo(bytesWritten, destination.Length);
        AreEqual(0xBF9CF968U, (uint)BitConverter.ToInt32(destination));
    }

    /// <summary>
    /// Computes the FNV-1a 32-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.Append(byte[])" /> and
    /// <see cref="NonCryptographicHashAlgorithm.GetCurrentHash()" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 32-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private uint Fnv1a32(in string data)
    {
        AreEqual(4, _alg.HashLengthInBytes);
        _alg.Append(UTF8.GetBytes(data));
        return (uint)BitConverter.ToInt32(_alg.GetCurrentHash(), 0);
    }

    /// <summary>
    /// Asynchronously computes the FNV-1a 32-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.AppendAsync(Stream, CancellationToken)" /> and
    /// <see cref="NonCryptographicHashAlgorithm.GetCurrentHash()" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>The FNV-1a 32-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    //// ReSharper disable once InconsistentNaming
    private async Task<uint> Fnv1a32Async(string data, CancellationToken token = default)
    {
        AreEqual(4, _alg.HashLengthInBytes);
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
        await using Stream stream = new MemoryStream(UTF8.GetBytes(data));
#pragma warning restore CA2007 // Consider calling ConfigureAwait on the awaited task
        await _alg.AppendAsync(stream, token).ConfigureAwait(true);
        return (uint)BitConverter.ToInt32(_alg.GetCurrentHash(), 0);
    }

    /// <summary>
    /// Computes the FNV-1a 32-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.Append(byte[])" /> and
    /// <see cref="NonCryptographicHashAlgorithm.TryGetCurrentHash" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 32-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private uint Fnv1a32Try(in string data)
    {
        AreEqual(4, _alg.HashLengthInBytes);

        int inputByteCount = UTF8.GetByteCount(data);
        Span<byte> bytes = inputByteCount < 1024
            ? stackalloc byte[inputByteCount]
            : new byte[inputByteCount];

        AreEqual(inputByteCount, UTF8.GetBytes(data, bytes));

        Span<byte> destination = stackalloc byte[_alg.HashLengthInBytes];

        _alg.Append(bytes);

        bool result = _alg.TryGetCurrentHash(destination, out int bytesWritten);

        IsTrue(result);
        IsGreaterThanOrEqualTo(bytesWritten, destination.Length);
        return (uint)BitConverter.ToInt32(destination);
    }
}
