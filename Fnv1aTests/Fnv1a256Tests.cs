// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a256Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Tests the FNV-1a 256-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTests;

using System;
using System.Globalization;
using System.IO;
using System.IO.Hashing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Fnv1a;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using MissingValues;

using static System.Globalization.NumberStyles;
using static System.Text.Encoding;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

/// <summary>
/// Tests the FNV-1a 256-bit algorithm.
/// </summary>
[TestClass]
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
// ReSharper disable once InconsistentNaming
// ReSharper disable once UnusedType.Global
public sealed class Fnv1a256Tests
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
    /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
    /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
    /// value.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by
    /// style.</exception>
    [TestInitialize]
    //// ReSharper disable once UnusedMember.Global
    public void Initialize()
    {
        _alg = new Fnv1a256();
        _alg.Reset();
    }

    /// <summary>
    /// Tests the empty string against the known vector result.
    /// </summary>
    /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
    /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
    /// value.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by
    /// style.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once InconsistentNaming
    public void TestVector1() => AreEqual(
        new(new(0xDD268DBCAAC55036UL, 0x2D98C384C4E576CCUL), new(0xC8B1536847B6BBB3UL, 0x1023B4C8CAEE0535UL)),
        Fnv1a256(string.Empty));

    /// <summary>
    /// Tests the empty string against the known vector result.
    /// </summary>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
    /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
    /// value.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by
    /// style.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public async Task TestVector1Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(
            new(new(0xDD268DBCAAC55036UL, 0x2D98C384C4E576CCUL), new(0xC8B1536847B6BBB3UL, 0x1023B4C8CAEE0535UL)),
            await Fnv1a256Async(string.Empty, cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the empty string against the known vector result.
    /// </summary>
    /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
    /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
    /// value.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by
    /// style.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector1Try() => AreEqual(
        new(new(0xDD268DBCAAC55036UL, 0x2D98C384C4E576CCUL), new(0xC8B1536847B6BBB3UL, 0x1023B4C8CAEE0535UL)),
        Fnv1a256Try(string.Empty));

    /// <summary>
    /// Tests the string "a" against the known vector result.
    /// </summary>
    /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
    /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
    /// value.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by
    /// style.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once InconsistentNaming
    public void TestVector2() => AreEqual(
        new(new(0x63323FB0F35303ECUL, 0x28DC751D0A33BDFAUL), new(0x4DE6A99B7266494FUL, 0x6183B2716811637CUL)),
        Fnv1a256("a"));

    /// <summary>
    /// Tests the string "a" against the known vector result.
    /// </summary>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
    /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
    /// value.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by
    /// style.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public async Task TestVector2Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(
            new(new(0x63323FB0F35303ECUL, 0x28DC751D0A33BDFAUL), new(0x4DE6A99B7266494FUL, 0x6183B2716811637CUL)),
            await Fnv1a256Async("a", cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the string "a" against the known vector result.
    /// </summary>
    /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
    /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
    /// value.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by
    /// style.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector2Try() => AreEqual(
        new(new(0x63323FB0F35303ECUL, 0x28DC751D0A33BDFAUL), new(0x4DE6A99B7266494FUL, 0x6183B2716811637CUL)),
        Fnv1a256Try("a"));

    /// <summary>
    /// Tests the string against the known vector result.
    /// </summary>
    /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
    /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
    /// value.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by
    /// style.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector3() => AreEqual(
        new(new(0xB055EA2F306CADADUL, 0x4F0F81C02D3889DCUL), new(0x32453DAD5AE35B75UL, 0x3BA1A91084AF3428UL)),
        Fnv1a256("foobar"));

    /// <summary>
    /// Tests the string against the known vector result.
    /// </summary>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
    /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
    /// value.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by
    /// style.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public async Task TestVector3Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(
            new(new(0xB055EA2F306CADADUL, 0x4F0F81C02D3889DCUL), new(0x32453DAD5AE35B75UL, 0x3BA1A91084AF3428UL)),
            await Fnv1a256Async("foobar", cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the string against the known vector result.
    /// </summary>
    /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
    /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
    /// value.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by
    /// style.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector3Try() => AreEqual(
        new(new(0xB055EA2F306CADADUL, 0x4F0F81C02D3889DCUL), new(0x32453DAD5AE35B75UL, 0x3BA1A91084AF3428UL)),
        Fnv1a256Try("foobar"));

    /// <summary>
    /// Tests the alternate prime and zero offset.
    /// </summary>
    /// <exception cref="ArgumentException">style is not a
    /// <see cref="NumberStyles" /> value.   -or-  style includes the
    /// <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
    /// value.</exception>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by
    /// style.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestAlternatePrimeAndZeroOffset() =>
        ThrowsExactly<ArgumentOutOfRangeException>(() => _ = new Fnv1a256(
            new(new(0x0000000000000000UL, 0x0000010000000000UL), new(0x0000000000000000UL, 0x0000000000000163UL)),
            UInt256.Zero));

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
        Fnv1a256 alg = new(
            new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFEFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFE9CUL)),
            new(new(0x22D97243553AAFC9UL, 0xD2673C7B3B1A8933UL), new(0x374EAC97B849444CUL, 0xEFDC4B373511FACAUL)));

        AreEqual(32, alg.HashLengthInBytes);
        AreEqual(
            new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFEFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFE9CUL)),
            alg.FnvPrime);
        AreEqual(
            new(new(0x22D97243553AAFC9UL, 0xD2673C7B3B1A8933UL), new(0x374EAC97B849444CUL, 0xEFDC4B373511FACAUL)),
            alg.FnvOffsetBasis);
        alg.Append("foobar"u8.ToArray());

        ReadOnlySpan<byte> currentHash = alg.GetCurrentHash();

        AreEqual(
            new UInt256(new(0x3EA7324391B13110UL, 0xA5EA99E1F1736006UL), new(0x86094AA0B741AE2AUL, 0x343DF42F38836088UL)),
            new(BitConverter.ToUInt128(currentHash[..16]), BitConverter.ToUInt128(currentHash.Slice(16, 16))));
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
        Fnv1a256 alg = new(
            new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFEFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFE9CUL)),
            new(new(0x22D97243553AAFC9UL, 0xD2673C7B3B1A8933UL), new(0x374EAC97B849444CUL, 0xEFDC4B373511FACAUL)));

        AreEqual(32, alg.HashLengthInBytes);
        AreEqual(
            new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFEFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFE9CUL)),
            alg.FnvPrime);
        AreEqual(
            new(new(0x22D97243553AAFC9UL, 0xD2673C7B3B1A8933UL), new(0x374EAC97B849444CUL, 0xEFDC4B373511FACAUL)),
            alg.FnvOffsetBasis);
        using CancellationTokenSource cts = new();
        await using Stream stream = new MemoryStream("foobar"u8.ToArray());
        await alg.AppendAsync(stream, cts.Token).ConfigureAwait(true);

        ReadOnlySpan<byte> currentHash = alg.GetCurrentHash();

        AreEqual(
            new UInt256(new(0x3EA7324391B13110UL, 0xA5EA99E1F1736006UL), new(0x86094AA0B741AE2AUL, 0x343DF42F38836088UL)),
            new(BitConverter.ToUInt128(currentHash[..16]), BitConverter.ToUInt128(currentHash.Slice(16, 16))));
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
        Fnv1a256 alg = new(
            new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFEFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFE9CUL)),
            new(new(0x22D97243553AAFC9UL, 0xD2673C7B3B1A8933UL), new(0x374EAC97B849444CUL, 0xEFDC4B373511FACAUL)));

        AreEqual(32, alg.HashLengthInBytes);
        AreEqual(
            new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFEFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFE9CUL)),
            alg.FnvPrime);
        AreEqual(
            new(new(0x22D97243553AAFC9UL, 0xD2673C7B3B1A8933UL), new(0x374EAC97B849444CUL, 0xEFDC4B373511FACAUL)),
            alg.FnvOffsetBasis);

        const string Data = "foobar";
        int inputByteCount = UTF8.GetByteCount(Data);
        Span<byte> bytes = inputByteCount < 1024
            ? stackalloc byte[inputByteCount]
            : new byte[inputByteCount];

        UTF8.GetBytes(Data, bytes);

        Span<byte> destination = stackalloc byte[alg.HashLengthInBytes];

        alg.Append(bytes);

        bool result = alg.TryGetCurrentHash(destination, out int bytesWritten);

        IsTrue(result);
        AreEqual(bytesWritten, destination.Length);
        AreEqual(
            new UInt256(new(0x3EA7324391B13110UL, 0xA5EA99E1F1736006UL), new(0x86094AA0B741AE2AUL, 0x343DF42F38836088UL)),
            new(BitConverter.ToUInt128(destination[..16]), BitConverter.ToUInt128(destination.Slice(16, 16))));
    }

    /// <summary>
    /// Computes the FNV-1a 256-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.GetCurrentHash()" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private UInt256 Fnv1a256(in string data)
    {
        AreEqual(32, _alg.HashLengthInBytes);
        _alg.Append(UTF8.GetBytes(data));

        ReadOnlySpan<byte> currentHash = _alg.GetCurrentHash();

        return new(BitConverter.ToUInt128(currentHash[..16]), BitConverter.ToUInt128(currentHash.Slice(16, 16)));
    }

    /// <summary>
    /// Asynchronously computes the FNV-1a 256-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.AppendAsync(Stream, CancellationToken)" /> and .
    /// <see cref="NonCryptographicHashAlgorithm.GetCurrentHash()" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    //// ReSharper disable once InconsistentNaming
    private async Task<UInt256> Fnv1a256Async(string data, CancellationToken token = default)
    {
        AreEqual(32, _alg.HashLengthInBytes);
        await using Stream stream = new MemoryStream(UTF8.GetBytes(data));
        await _alg.AppendAsync(stream, token).ConfigureAwait(false);

        ReadOnlySpan<byte> currentHash = _alg.GetCurrentHash();

        return new(BitConverter.ToUInt128(currentHash[..16]), BitConverter.ToUInt128(currentHash.Slice(16, 16)));
    }

    /// <summary>
    /// Computes the FNV-1a 256-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.TryGetCurrentHash" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private UInt256 Fnv1a256Try(in string data)
    {
        AreEqual(32, _alg.HashLengthInBytes);

        int inputByteCount = UTF8.GetByteCount(data);
        Span<byte> bytes = inputByteCount < 1024
            ? stackalloc byte[inputByteCount]
            : new byte[inputByteCount];

        UTF8.GetBytes(data, bytes);
        _alg.Append(bytes);

        Span<byte> destination = stackalloc byte[_alg.HashLengthInBytes];
        bool result = _alg.TryGetCurrentHash(destination, out int bytesWritten);

        IsTrue(result);
        AreEqual(bytesWritten, destination.Length);
        return new(BitConverter.ToUInt128(destination[..16]), BitConverter.ToUInt128(destination.Slice(16, 16)));
    }
}
