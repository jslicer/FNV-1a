// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a512Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Tests the FNV-1a 512-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTests;

using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Fnv1a;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using static System.Globalization.CultureInfo;
using static System.Globalization.NumberStyles;
using static System.Numerics.BigInteger;
using static System.Text.Encoding;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

/// <inheritdoc />
/// <summary>
/// Tests the FNV-1a 512-bit algorithm.
/// </summary>
[TestClass]
//// ReSharper disable once InconsistentNaming
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
public sealed class Fnv1a512Tests : IDisposable
#pragma warning restore S101 // Types should be named in PascalCase
#pragma warning restore IDE0079 // Remove unnecessary suppression
{
    /// <summary>
    /// The hash algorithm being tested.
    /// </summary>
    private HashAlgorithm _alg = null!;

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
    public void Initialize() => _alg = new Fnv1a512();

    /// <summary>
    /// The method to run after each test.
    /// </summary>
    [TestCleanup]
    public void Cleanup() => Dispose();

    /// <inheritdoc />
    /// <summary>
    /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    /// </summary>
    public void Dispose() => _alg.Dispose();

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
        Parse("0B86DB0B1171F4416DCA1E50F309990ACAC87D059C90000000000000000000D21E948F68A34C192F62EA79BC942DBE7CE182036415F56E34BAC982AAC4AFE9FD9", AllowHexSpecifier, InvariantCulture),
        Fnv1a512(string.Empty));

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
    //// ReSharper disable once InconsistentNaming
    public async Task TestVector1Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(
            Parse("0B86DB0B1171F4416DCA1E50F309990ACAC87D059C90000000000000000000D21E948F68A34C192F62EA79BC942DBE7CE182036415F56E34BAC982AAC4AFE9FD9", AllowHexSpecifier, InvariantCulture),
            await Fnv1a512Async(string.Empty, cts.Token).ConfigureAwait(true));
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
    public void TestVector1Try() => AreEqual(
        Parse("0B86DB0B1171F4416DCA1E50F309990ACAC87D059C90000000000000000000D21E948F68A34C192F62EA79BC942DBE7CE182036415F56E34BAC982AAC4AFE9FD9", AllowHexSpecifier, InvariantCulture),
        Fnv1a512Try(string.Empty));

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
        Parse("0E43A992DC8FC5AD7DE493E3D696D6F85D64326EC07000000000000000011986F90C2532CAF5BE7D88291BAA894A395225328B196BD6A8A643FE12CD87B27FF88", AllowHexSpecifier, InvariantCulture),
        Fnv1a512("a"));

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
    //// ReSharper disable once InconsistentNaming
    public async Task TestVector2Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(
            Parse("0E43A992DC8FC5AD7DE493E3D696D6F85D64326EC07000000000000000011986F90C2532CAF5BE7D88291BAA894A395225328B196BD6A8A643FE12CD87B27FF88", AllowHexSpecifier, InvariantCulture),
            await Fnv1a512Async("a", cts.Token).ConfigureAwait(true));
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
    //// ReSharper disable once InconsistentNaming
    public void TestVector2Try() => AreEqual(
        Parse("0E43A992DC8FC5AD7DE493E3D696D6F85D64326EC07000000000000000011986F90C2532CAF5BE7D88291BAA894A395225328B196BD6A8A643FE12CD87B27FF88", AllowHexSpecifier, InvariantCulture),
        Fnv1a512Try("a"));

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
    //// ReSharper disable once InconsistentNaming
    public void TestVector3() => AreEqual(
        Parse("0B0EC738D9C6FD969D05F0B35F6C0ED53ADCACCCD8E0000004BF99F58EE4196AFB9700E20110830FEA5396B76280E47FD022B6E81331CA1A9CED729C364BE7788", AllowHexSpecifier, InvariantCulture),
        Fnv1a512("foobar"));

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
    //// ReSharper disable once InconsistentNaming
    public async Task TestVector3Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(
            Parse("0B0EC738D9C6FD969D05F0B35F6C0ED53ADCACCCD8E0000004BF99F58EE4196AFB9700E20110830FEA5396B76280E47FD022B6E81331CA1A9CED729C364BE7788", AllowHexSpecifier, InvariantCulture),
            await Fnv1a512Async("foobar", cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the string against the known vector result using
    /// <see cref="HashAlgorithm.ComputeHash(byte[])" />.
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
    public void TestVector3Try() => AreEqual(
        Parse("0B0EC738D9C6FD969D05F0B35F6C0ED53ADCACCCD8E0000004BF99F58EE4196AFB9700E20110830FEA5396B76280E47FD022B6E81331CA1A9CED729C364BE7788", AllowHexSpecifier, InvariantCulture),
        Fnv1a512Try("foobar"));

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
    public void TestAlternatePrimeAndZeroOffset() =>
        ThrowsExactly<ArgumentOutOfRangeException>(() => _ = new Fnv1a512(
            Parse("00000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000157", AllowHexSpecifier, InvariantCulture),
            Zero));

    /// <summary>
    /// Tests the alternate prime and non-zero offset.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="ArgumentException">startIndex is greater than or equal to the length of value minus 3, and
    /// is less than or equal to the length of value minus 1.</exception>
    /// <exception cref="ArgumentNullException">buffer is <see langword="null" />.</exception>
    [TestMethod]
    public void TestAlternatePrimeAndOffset()
    {
        using Fnv1a512 alg = new(
            Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEA8", AllowHexSpecifier, InvariantCulture),
            Parse("47924F4EE8E0BBE9235E1AF0CF666F5353782FA636FFFFFFFFFFFFFFFFFFF2DE16B70975CB3E6D09D1586436BD241831E7DFC9BEA0A91CB45367D553B5016026", AllowHexSpecifier, InvariantCulture));
        AreEqual(512, alg.HashSize);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEA8", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
        AreEqual(Parse("47924F4EE8E0BBE9235E1AF0CF666F5353782FA636FFFFFFFFFFFFFFFFFFF2DE16B70975CB3E6D09D1586436BD241831E7DFC9BEA0A91CB45367D553B5016026", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);
        AreEqual(
            Parse("0BDF47E35FEA1353B31800456716B6D8349B346DEFDFFFFFFB2AFA956272A8B776065B4EDE4EFC112CCD0BEB3AD4A8424B2C53A71B44E08AACFF9BBDD68CEC710", AllowHexSpecifier, InvariantCulture),
            new(alg.ComputeHash("foobar"u8.ToArray()).AddZero()));
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
    public async Task TestAlternatePrimeAndOffsetAsync()
    {
        using Fnv1a512 alg = new(
            Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEA8", AllowHexSpecifier, InvariantCulture),
            Parse("47924F4EE8E0BBE9235E1AF0CF666F5353782FA636FFFFFFFFFFFFFFFFFFF2DE16B70975CB3E6D09D1586436BD241831E7DFC9BEA0A91CB45367D553B5016026", AllowHexSpecifier, InvariantCulture));
        AreEqual(512, alg.HashSize);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEA8", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
        AreEqual(Parse("47924F4EE8E0BBE9235E1AF0CF666F5353782FA636FFFFFFFFFFFFFFFFFFF2DE16B70975CB3E6D09D1586436BD241831E7DFC9BEA0A91CB45367D553B5016026", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);
        using CancellationTokenSource cts = new();
        await using Stream stream = new MemoryStream("foobar"u8.ToArray());

        BigInteger actual = new((await alg.ComputeHashAsync(stream, cts.Token).ConfigureAwait(false)).AddZero());

        AreEqual(
            Parse("0BDF47E35FEA1353B31800456716B6D8349B346DEFDFFFFFFB2AFA956272A8B776065B4EDE4EFC112CCD0BEB3AD4A8424B2C53A71B44E08AACFF9BBDD68CEC710", AllowHexSpecifier, InvariantCulture),
            actual);
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
    public void TestAlternatePrimeAndOffsetTry()
    {
        using Fnv1a512 alg = new(
            Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEA8", AllowHexSpecifier, InvariantCulture),
            Parse("47924F4EE8E0BBE9235E1AF0CF666F5353782FA636FFFFFFFFFFFFFFFFFFF2DE16B70975CB3E6D09D1586436BD241831E7DFC9BEA0A91CB45367D553B5016026", AllowHexSpecifier, InvariantCulture));
        AreEqual(512, alg.HashSize);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEA8", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
        AreEqual(Parse("47924F4EE8E0BBE9235E1AF0CF666F5353782FA636FFFFFFFFFFFFFFFFFFF2DE16B70975CB3E6D09D1586436BD241831E7DFC9BEA0A91CB45367D553B5016026", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);

        const string Data = "foobar";
        int inputByteCount = UTF8.GetByteCount(Data);
        Span<byte> bytes = inputByteCount < 1024
            ? stackalloc byte[inputByteCount]
            : new byte[inputByteCount];

        UTF8.GetBytes(Data, bytes);

        // ReSharper disable once ComplexConditionExpression
        Span<byte> destination = stackalloc byte[1 + (alg.HashSize / 8)];
        bool result = alg.TryComputeHash(bytes, destination, out int bytesWritten);

        IsTrue(result);
        IsTrue(destination.Length >= bytesWritten);
        AreEqual(
            Parse("0BDF47E35FEA1353B31800456716B6D8349B346DEFDFFFFFFB2AFA956272A8B776065B4EDE4EFC112CCD0BEB3AD4A8424B2C53A71B44E08AACFF9BBDD68CEC710", AllowHexSpecifier, InvariantCulture),
            new(destination));
    }

    /// <summary>
    /// Computes the FNV-1a 512-bit hash for the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 512-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private BigInteger Fnv1a512(in string data)
    {
        AreEqual(512, _alg.HashSize);
        return new(_alg.ComputeHash(UTF8.GetBytes(data)).AddZero());
    }

    /// <summary>
    /// Asynchronously computes the FNV-1a 512-bit hash for the specified data using
    /// <see cref="HashAlgorithm.ComputeHashAsync(Stream, CancellationToken)" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>The FNV-1a 512-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    //// ReSharper disable once InconsistentNaming
    private async Task<BigInteger> Fnv1a512Async(string data, CancellationToken token = default)
    {
        AreEqual(512, _alg.HashSize);
        await using Stream stream = new MemoryStream(UTF8.GetBytes(data));
        return new((await _alg.ComputeHashAsync(stream, token).ConfigureAwait(false)).AddZero());
    }

    /// <summary>
    /// Computes the FNV-1a 512-bit hash for the specified data using <see cref="HashAlgorithm.TryComputeHash" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 512-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private BigInteger Fnv1a512Try(in string data)
    {
        AreEqual(512, _alg.HashSize);

        int inputByteCount = UTF8.GetByteCount(data);
        Span<byte> bytes = inputByteCount < 1024
            ? stackalloc byte[inputByteCount]
            : new byte[inputByteCount];

        UTF8.GetBytes(data, bytes);

        // ReSharper disable once ComplexConditionExpression
        Span<byte> destination = stackalloc byte[1 + (_alg.HashSize / 8)];
        bool result = _alg.TryComputeHash(bytes, destination, out int bytesWritten);

        IsTrue(result);
        IsTrue(destination.Length >= bytesWritten);
        return new(destination);
    }
}
