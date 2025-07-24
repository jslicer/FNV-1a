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
/// Tests the FNV-1a 512-bit algorithm.
/// </summary>
[TestClass]
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
#pragma warning disable CA1515 // Consider making public types internal
// ReSharper disable once InconsistentNaming
// ReSharper disable once UnusedType.Global
public sealed class Fnv1a512Tests
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
        _alg = new Fnv1a512();
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
    //// ReSharper disable once UnusedMember.Global
    public void TestVector1() => AreEqual(
        new(
            new(new(0xB86DB0B1171F4416UL, 0xDCA1E50F309990ACUL), new(0xAC87D059C9000000UL, 0x0000000000000D21UL)),
            new(new(0xE948F68A34C192F6UL, 0x2EA79BC942DBE7CEUL), new(0x182036415F56E34BUL, 0xAC982AAC4AFE9FD9UL))),
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
    //// ReSharper disable once UnusedMember.Global
    public async Task TestVector1Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(
            new(
                new(new(0xB86DB0B1171F4416UL, 0xDCA1E50F309990ACUL), new(0xAC87D059C9000000UL, 0x0000000000000D21UL)),
                new(new(0xE948F68A34C192F6UL, 0x2EA79BC942DBE7CEUL), new(0x182036415F56E34BUL, 0xAC982AAC4AFE9FD9UL))),
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
    //// ReSharper disable once UnusedMember.Global
    public void TestVector1Try() => AreEqual(
        new(
            new(new(0xB86DB0B1171F4416UL, 0xDCA1E50F309990ACUL), new(0xAC87D059C9000000UL, 0x0000000000000D21UL)),
            new(new(0xE948F68A34C192F6UL, 0x2EA79BC942DBE7CEUL), new(0x182036415F56E34BUL, 0xAC982AAC4AFE9FD9UL))),
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
    //// ReSharper disable once UnusedMember.Global
    public void TestVector2() => AreEqual(
        new(
            new(new(0xE43A992DC8FC5AD7UL, 0xDE493E3D696D6F85UL), new(0xD64326EC07000000UL, 0x000000000011986FUL)),
            new(new(0x90C2532CAF5BE7D8UL, 0x8291BAA894A39522UL), new(0x5328B196BD6A8A64UL, 0x3FE12CD87B27FF88UL))),
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
    //// ReSharper disable once UnusedMember.Global
    public async Task TestVector2Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(
            new(
                new(new(0xE43A992DC8FC5AD7UL, 0xDE493E3D696D6F85UL), new(0xD64326EC07000000UL, 0x000000000011986FUL)),
                new(new(0x90C2532CAF5BE7D8UL, 0x8291BAA894A39522UL), new(0x5328B196BD6A8A64UL, 0x3FE12CD87B27FF88UL))),
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
    //// ReSharper disable once UnusedMember.Global
    public void TestVector2Try() => AreEqual(
        new(
            new(new(0xE43A992DC8FC5AD7UL, 0xDE493E3D696D6F85UL), new(0xD64326EC07000000UL, 0x000000000011986FUL)),
            new(new(0x90C2532CAF5BE7D8UL, 0x8291BAA894A39522UL), new(0x5328B196BD6A8A64UL, 0x3FE12CD87B27FF88UL))),
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
    //// ReSharper disable once UnusedMember.Global
    public void TestVector3() => AreEqual(
        new(
            new(new(0xB0EC738D9C6FD969UL, 0xD05F0B35F6C0ED53UL), new(0xADCACCCD8E000000UL, 0x4BF99F58EE4196AFUL)),
            new(new(0xB9700E20110830FEUL, 0xA5396B76280E47FDUL), new(0x022B6E81331CA1A9UL, 0xCED729C364BE7788UL))),
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
    //// ReSharper disable once UnusedMember.Global
    public async Task TestVector3Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(
            new(
                new(new(0xB0EC738D9C6FD969UL, 0xD05F0B35F6C0ED53UL), new(0xADCACCCD8E000000UL, 0x4BF99F58EE4196AFUL)),
                new(new(0xB9700E20110830FEUL, 0xA5396B76280E47FDUL), new(0x022B6E81331CA1A9UL, 0xCED729C364BE7788UL))),
            await Fnv1a512Async("foobar", cts.Token).ConfigureAwait(true));
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
        new(
            new(new(0xB0EC738D9C6FD969UL, 0xD05F0B35F6C0ED53UL), new(0xADCACCCD8E000000UL, 0x4BF99F58EE4196AFUL)),
            new(new(0xB9700E20110830FEUL, 0xA5396B76280E47FDUL), new(0x022B6E81331CA1A9UL, 0xCED729C364BE7788UL))),
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
    //// ReSharper disable once UnusedMember.Global
    public void TestAlternatePrimeAndZeroOffset() =>
        ThrowsExactly<ArgumentOutOfRangeException>(() => _ = new Fnv1a512(
            new(
                new(new(0x0000000000000000UL, 0x0000000000000000UL), new(0x0000000001000000UL, 0x0000000000000000UL)),
                new(new(0x0000000000000000UL, 0x0000000000000000UL), new(0x0000000000000000UL, 0x0000000000000157UL))),
            UInt512.Zero));

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
        Fnv1a512 alg = new(
            new(
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL)),
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFEA8UL))),
            new(
                new(new(0x47924F4EE8E0BBE9UL, 0x235E1AF0CF666F53UL), new(0x53782FA636FFFFFFUL, 0xFFFFFFFFFFFFF2DEUL)),
                new(new(0x16B70975CB3E6D09UL, 0xD1586436BD241831UL), new(0xE7DFC9BEA0A91CB4UL, 0x5367D553B5016026UL))));

        AreEqual(64, alg.HashLengthInBytes);
        AreEqual(
            new(
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL)),
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFEA8UL))),
            alg.FnvPrime);
        AreEqual(
            new(
                new(new(0x47924F4EE8E0BBE9UL, 0x235E1AF0CF666F53UL), new(0x53782FA636FFFFFFUL, 0xFFFFFFFFFFFFF2DEUL)),
                new(new(0x16B70975CB3E6D09UL, 0xD1586436BD241831UL), new(0xE7DFC9BEA0A91CB4UL, 0x5367D553B5016026UL))),
            alg.FnvOffsetBasis);
        alg.Append("foobar"u8.ToArray());

        ReadOnlySpan<byte> currentHash = alg.GetCurrentHash();

        AreEqual(
            new UInt512(
                new(new(0xBDF47E35FEA1353BUL, 0x31800456716B6D83UL), new(0x49B346DEFDFFFFFFUL, 0xB2AFA956272A8B77UL)),
                new(new(0x6065B4EDE4EFC112UL, 0xCCD0BEB3AD4A8424UL), new(0xB2C53A71B44E08AAUL, 0xCFF9BBDD68CEC710UL))),
            new(
                BitConverter.ToUInt128(currentHash[..16]),
                BitConverter.ToUInt128(currentHash.Slice(16, 16)),
                BitConverter.ToUInt128(currentHash.Slice(32, 16)),
                BitConverter.ToUInt128(currentHash.Slice(48, 16))));
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
        Fnv1a512 alg = new(
            new(
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL)),
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFEA8UL))),
            new(
                new(new(0x47924F4EE8E0BBE9UL, 0x235E1AF0CF666F53UL), new(0x53782FA636FFFFFFUL, 0xFFFFFFFFFFFFF2DEUL)),
                new(new(0x16B70975CB3E6D09UL, 0xD1586436BD241831UL), new(0xE7DFC9BEA0A91CB4UL, 0x5367D553B5016026UL))));

        AreEqual(64, alg.HashLengthInBytes);
        AreEqual(
            new(
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL)),
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFEA8UL))),
            alg.FnvPrime);
        AreEqual(
            new(
                new(new(0x47924F4EE8E0BBE9UL, 0x235E1AF0CF666F53UL), new(0x53782FA636FFFFFFUL, 0xFFFFFFFFFFFFF2DEUL)),
                new(new(0x16B70975CB3E6D09UL, 0xD1586436BD241831UL), new(0xE7DFC9BEA0A91CB4UL, 0x5367D553B5016026UL))),
            alg.FnvOffsetBasis);
        using CancellationTokenSource cts = new();
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
        await using Stream stream = new MemoryStream("foobar"u8.ToArray());
#pragma warning restore CA2007 // Consider calling ConfigureAwait on the awaited task
        await alg.AppendAsync(stream, cts.Token).ConfigureAwait(true);

        ReadOnlySpan<byte> currentHash = alg.GetCurrentHash();

        AreEqual(
            new UInt512(
                new(new(0xBDF47E35FEA1353BUL, 0x31800456716B6D83UL), new(0x49B346DEFDFFFFFFUL, 0xB2AFA956272A8B77UL)),
                new(new(0x6065B4EDE4EFC112UL, 0xCCD0BEB3AD4A8424UL), new(0xB2C53A71B44E08AAUL, 0xCFF9BBDD68CEC710UL))),
            new(
                BitConverter.ToUInt128(currentHash[..16]),
                BitConverter.ToUInt128(currentHash.Slice(16, 16)),
                BitConverter.ToUInt128(currentHash.Slice(32, 16)),
                BitConverter.ToUInt128(currentHash.Slice(48, 16))));
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
        Fnv1a512 alg = new(
            new(
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL)),
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFEA8UL))),
            new(
                new(new(0x47924F4EE8E0BBE9UL, 0x235E1AF0CF666F53UL), new(0x53782FA636FFFFFFUL, 0xFFFFFFFFFFFFF2DEUL)),
                new(new(0x16B70975CB3E6D09UL, 0xD1586436BD241831UL), new(0xE7DFC9BEA0A91CB4UL, 0x5367D553B5016026UL))));

        AreEqual(64, alg.HashLengthInBytes);
        AreEqual(
            new(
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFEFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL)),
                new(new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFFFFUL), new(0xFFFFFFFFFFFFFFFFUL, 0xFFFFFFFFFFFFFEA8UL))),
            alg.FnvPrime);
        AreEqual(
            new(
                new(new(0x47924F4EE8E0BBE9UL, 0x235E1AF0CF666F53UL), new(0x53782FA636FFFFFFUL, 0xFFFFFFFFFFFFF2DEUL)),
                new(new(0x16B70975CB3E6D09UL, 0xD1586436BD241831UL), new(0xE7DFC9BEA0A91CB4UL, 0x5367D553B5016026UL))),
            alg.FnvOffsetBasis);

        const string Data = "foobar";
        int inputByteCount = UTF8.GetByteCount(Data);
        Span<byte> bytes = inputByteCount < 1024
            ? stackalloc byte[inputByteCount]
            : new byte[inputByteCount];

        AreEqual(inputByteCount, UTF8.GetBytes(Data, bytes));

        Span<byte> destination = stackalloc byte[alg.HashLengthInBytes];

        alg.Append(bytes);

        bool result = alg.TryGetCurrentHash(destination, out int bytesWritten);

        IsTrue(result);
        AreEqual(bytesWritten, destination.Length);
        AreEqual(
            new UInt512(
                new(new(0xBDF47E35FEA1353BUL, 0x31800456716B6D83UL), new(0x49B346DEFDFFFFFFUL, 0xB2AFA956272A8B77UL)),
                new(new(0x6065B4EDE4EFC112UL, 0xCCD0BEB3AD4A8424UL), new(0xB2C53A71B44E08AAUL, 0xCFF9BBDD68CEC710UL))),
            new(
                BitConverter.ToUInt128(destination[..16]),
                BitConverter.ToUInt128(destination.Slice(16, 16)),
                BitConverter.ToUInt128(destination.Slice(32, 16)),
                BitConverter.ToUInt128(destination.Slice(48, 16))));
    }

    /// <summary>
    /// Computes the FNV-1a 512-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.GetCurrentHash()" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 512-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private UInt512 Fnv1a512(in string data)
    {
        AreEqual(64, _alg.HashLengthInBytes);
        _alg.Append(UTF8.GetBytes(data));

        ReadOnlySpan<byte> currentHash = _alg.GetCurrentHash();

        return new(
            BitConverter.ToUInt128(currentHash[..16]),
            BitConverter.ToUInt128(currentHash.Slice(16, 16)),
            BitConverter.ToUInt128(currentHash.Slice(32, 16)),
            BitConverter.ToUInt128(currentHash.Slice(48, 16)));
    }

    /// <summary>
    /// Asynchronously computes the FNV-1a 512-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.AppendAsync(Stream, CancellationToken)" /> and .
    /// <see cref="NonCryptographicHashAlgorithm.GetCurrentHash()" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>The FNV-1a 512-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    //// ReSharper disable once InconsistentNaming
    private async Task<UInt512> Fnv1a512Async(string data, CancellationToken token = default)
    {
        AreEqual(64, _alg.HashLengthInBytes);
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
        await using Stream stream = new MemoryStream(UTF8.GetBytes(data));
#pragma warning restore CA2007 // Consider calling ConfigureAwait on the awaited task
        await _alg.AppendAsync(stream, token).ConfigureAwait(false);

        ReadOnlySpan<byte> currentHash = _alg.GetCurrentHash();

        return new(
            BitConverter.ToUInt128(currentHash[..16]),
            BitConverter.ToUInt128(currentHash.Slice(16, 16)),
            BitConverter.ToUInt128(currentHash.Slice(32, 16)),
            BitConverter.ToUInt128(currentHash.Slice(48, 16)));
    }

    /// <summary>
    /// Computes the FNV-1a 512-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.TryGetCurrentHash" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 512-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private UInt512 Fnv1a512Try(in string data)
    {
        AreEqual(64, _alg.HashLengthInBytes);

        int inputByteCount = UTF8.GetByteCount(data);
        Span<byte> bytes = inputByteCount < 1024
            ? stackalloc byte[inputByteCount]
            : new byte[inputByteCount];

        AreEqual(inputByteCount, UTF8.GetBytes(data, bytes));
        _alg.Append(bytes);

        Span<byte> destination = stackalloc byte[_alg.HashLengthInBytes];
        bool result = _alg.TryGetCurrentHash(destination, out int bytesWritten);

        IsTrue(result);
        AreEqual(bytesWritten, destination.Length);
        return new(
            BitConverter.ToUInt128(destination[..16]),
            BitConverter.ToUInt128(destination.Slice(16, 16)),
            BitConverter.ToUInt128(destination.Slice(32, 16)),
            BitConverter.ToUInt128(destination.Slice(48, 16)));
    }
}
