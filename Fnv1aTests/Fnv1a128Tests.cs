// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a128Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Tests the FNV-1a 128-bit algorithm.
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
/// Tests the FNV-1a 128-bit algorithm.
/// </summary>
[TestClass]
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
#pragma warning disable CA1515 // Consider making public types internal
// ReSharper disable once InconsistentNaming
// ReSharper disable once UnusedType.Global
public sealed class Fnv1a128Tests
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
    [TestInitialize]
    //// ReSharper disable once UnusedMember.Global
    public void Initialize()
    {
        _alg = new Fnv1a128();
        _alg.Reset();
    }

    /// <summary>
    /// Tests the empty string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once InconsistentNaming
    public void TestVector1() => AreEqual(
        new(0x6C62272E07BB0142UL, 0x62B821756295C58DUL),
        Fnv1a128(string.Empty));

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
        AreEqual(
            new(0x6C62272E07BB0142UL, 0x62B821756295C58DUL),
            await Fnv1a128Async(string.Empty, cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the empty string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector1Try() => AreEqual(
        new(0x6C62272E07BB0142UL, 0x62B821756295C58DUL),
        Fnv1a128Try(string.Empty));

    /// <summary>
    /// Tests the string "a" against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector2() => AreEqual(
        new(0x0D228CB696F1A8CAFUL, 0x78912B704E4A8964UL),
        Fnv1a128("a"));

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
        AreEqual(
            new(0x0D228CB696F1A8CAFUL, 0x78912B704E4A8964UL),
            await Fnv1a128Async("a", cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the string "a" against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector2Try() => AreEqual(
        new(0x0D228CB696F1A8CAFUL, 0x78912B704E4A8964UL),
        Fnv1a128Try("a"));

    /// <summary>
    /// Tests the string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector3() => AreEqual(
        new(0x343E1662793C64BFUL, 0x6F0D3597BA446F18UL),
        Fnv1a128("foobar"));

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
        AreEqual(
            new(0x343E1662793C64BFUL, 0x6F0D3597BA446F18UL),
            await Fnv1a128Async("foobar", cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector3Try() => AreEqual(
        new(0x343E1662793C64BFUL, 0x6F0D3597BA446F18UL),
        Fnv1a128Try("foobar"));

    /// <summary>
    /// Tests the "Hello World" string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestHelloWorld() => AreEqual(
        new(0x0CD7FECF582839515UL, 0xF3E6ECF66B967B77UL),
        Fnv1a128("Hello World"));

    /// <summary>
    /// Tests the "Hello World" string against the known vector result.
    /// </summary>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public async Task TestHelloWorldAsync()
    {
        using CancellationTokenSource cts = new();
        AreEqual(
            new(0x0CD7FECF582839515UL, 0xF3E6ECF66B967B77UL),
            await Fnv1a128Async("Hello World", cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the "Hello World" string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestHelloWorldTry() => AreEqual(
        new(0x0CD7FECF582839515UL, 0xF3E6ECF66B967B77UL),
        Fnv1a128Try("Hello World"));

    /// <summary>
    /// Tests the alternate prime and zero offset.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestAlternatePrimeAndZeroOffset() =>
        ThrowsExactly<ArgumentOutOfRangeException>(() => _ = new Fnv1a128(
            new(0x0000000001000000UL, 0x000000000000013BUL),
            UInt128.Zero));

    /// <summary>
    /// Tests the alternate prime and non-zero offset.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestAlternatePrimeAndOffset()
    {
        Fnv1a128 alg = new(
            new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFEC4UL),
            new(0x939DD8D1F844FEBDUL, 0x9D47DE8A9D6A3A72UL));

        AreEqual(16, alg.HashLengthInBytes);
        AreEqual(new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFEC4UL), alg.FnvPrime);
        AreEqual(new(0x939DD8D1F844FEBDUL, 0x9D47DE8A9D6A3A72UL), alg.FnvOffsetBasis);
        alg.Append("foobar"u8.ToArray());
        AreEqual(
            new(0x0AA2376793386FBA2UL, 0x5B67E764D2093DD8UL),
            BitConverter.ToUInt128(alg.GetCurrentHash()));
    }

    /// <summary>
    /// Tests the alternate prime and non-zero offset.
    /// </summary>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public async Task TestAlternatePrimeAndOffsetAsync()
    {
        Fnv1a128 alg = new(
            new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFEC4UL),
            new(0x939DD8D1F844FEBDUL, 0x9D47DE8A9D6A3A72UL));

        AreEqual(16, alg.HashLengthInBytes);
        AreEqual(new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFEC4UL), alg.FnvPrime);
        AreEqual(new(0x939DD8D1F844FEBDUL, 0x9D47DE8A9D6A3A72UL), alg.FnvOffsetBasis);
        using CancellationTokenSource cts = new();
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
        await using Stream stream = new MemoryStream("foobar"u8.ToArray());
#pragma warning restore CA2007 // Consider calling ConfigureAwait on the awaited task
        await alg.AppendAsync(stream, cts.Token).ConfigureAwait(true);

        UInt128 actual = BitConverter.ToUInt128(alg.GetCurrentHash());

        AreEqual(
            new(0x0AA2376793386FBA2UL, 0x5B67E764D2093DD8UL),
            actual);
    }

    /// <summary>
    /// Tests the alternate prime and non-zero offset.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="EncoderFallbackException">A fallback occurred (for more information, see Character
    /// Encoding in .NET)
    ///  -and-
    ///  <see cref="EncoderFallback" /> is set to <see cref="EncoderExceptionFallback" />.</exception>
    [TestMethod]
    //// ReSharper disable once TooManyDeclarations
    //// ReSharper disable once UnusedMember.Global
    public void TestAlternatePrimeAndOffsetTry()
    {
        Fnv1a128 alg = new(
            new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFEC4UL),
            new(0x939DD8D1F844FEBDUL, 0x9D47DE8A9D6A3A72UL));

        AreEqual(16, alg.HashLengthInBytes);
        AreEqual(new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFEC4UL), alg.FnvPrime);
        AreEqual(new(0x939DD8D1F844FEBDUL, 0x9D47DE8A9D6A3A72UL), alg.FnvOffsetBasis);

        const string Data = "foobar";
        int inputByteCount = UTF8.GetByteCount(Data);
        Span<byte> bytes = inputByteCount < 1024
            ? stackalloc byte[inputByteCount]
            : new byte[inputByteCount];

        AreEqual(inputByteCount, UTF8.GetBytes(Data, bytes));
        alg.Append(bytes);

        Span<byte> destination = stackalloc byte[alg.HashLengthInBytes];
        bool result = alg.TryGetCurrentHash(destination, out int bytesWritten);

        IsTrue(result);
        AreEqual(bytesWritten, destination.Length);
        AreEqual(
            new(0x0AA2376793386FBA2UL, 0x5B67E764D2093DD8UL),
            BitConverter.ToUInt128(destination));
    }

    /// <summary>
    /// Computes the FNV-1a 128-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.GetCurrentHash()" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 128-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private UInt128 Fnv1a128(in string data)
    {
        AreEqual(16, _alg.HashLengthInBytes);
        _alg.Append(UTF8.GetBytes(data));
        return BitConverter.ToUInt128(_alg.GetCurrentHash());
    }

    /// <summary>
    /// Asynchronously computes the FNV-1a 128-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.AppendAsync(Stream, CancellationToken)" /> and .
    /// <see cref="NonCryptographicHashAlgorithm.GetCurrentHash()" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>The FNV-1a 128-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    //// ReSharper disable once InconsistentNaming
    private async Task<UInt128> Fnv1a128Async(string data, CancellationToken token = default)
    {
        AreEqual(16, _alg.HashLengthInBytes);
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
        await using Stream stream = new MemoryStream(UTF8.GetBytes(data));
#pragma warning restore CA2007 // Consider calling ConfigureAwait on the awaited task
        await _alg.AppendAsync(stream, token).ConfigureAwait(false);
        return BitConverter.ToUInt128(_alg.GetCurrentHash());
    }

    /// <summary>
    /// Computes the FNV-1a 128-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.TryGetCurrentHash" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 128-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private UInt128 Fnv1a128Try(in string data)
    {
        AreEqual(16, _alg.HashLengthInBytes);

        int inputByteCount = UTF8.GetByteCount(data);
        Span<byte> bytes = inputByteCount < 1024
            ? stackalloc byte[inputByteCount]
            : new byte[inputByteCount];

        AreEqual(inputByteCount, UTF8.GetBytes(data, bytes));

        Span<byte> destination = stackalloc byte[_alg.HashLengthInBytes];

        _alg.Append(bytes);

        bool result = _alg.TryGetCurrentHash(destination, out int bytesWritten);

        IsTrue(result);
        AreEqual(bytesWritten, destination.Length);
        return BitConverter.ToUInt128(destination);
    }
}
