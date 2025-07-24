// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a1024Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Tests the FNV-1a 1024-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTests;

using System;
using System.Globalization;
using System.IO;
using System.IO.Hashing;
using System.Numerics;
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

/// <summary>
/// Tests the FNV-1a 1024-bit algorithm.
/// </summary>
[TestClass]
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
#pragma warning disable CA1515 // Consider making public types internal
// ReSharper disable once InconsistentNaming
// ReSharper disable once UnusedType.Global
public sealed class Fnv1a1024Tests
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
        _alg = new Fnv1a1024();
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
        Parse("0000000000000000005F7A76758ECC4D32E56D5A591028B74B29FC4223FDADA16C3BF34EDA3674DA9A21D9000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004C6D7EB6E73802734510A555F256CC005AE556BDE8CC9C6A93B21AFF4B16C71EE90B3", AllowHexSpecifier, InvariantCulture),
        Fnv1a1024(string.Empty));

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
            Parse("0000000000000000005F7A76758ECC4D32E56D5A591028B74B29FC4223FDADA16C3BF34EDA3674DA9A21D9000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004C6D7EB6E73802734510A555F256CC005AE556BDE8CC9C6A93B21AFF4B16C71EE90B3", AllowHexSpecifier, InvariantCulture),
            await Fnv1a1024Async(string.Empty, cts.Token).ConfigureAwait(true));
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
        Parse("0000000000000000005F7A76758ECC4D32E56D5A591028B74B29FC4223FDADA16C3BF34EDA3674DA9A21D9000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004C6D7EB6E73802734510A555F256CC005AE556BDE8CC9C6A93B21AFF4B16C71EE90B3", AllowHexSpecifier, InvariantCulture),
        Fnv1a1024Try(string.Empty));

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
        Parse("000000000000000098D7C19FBCE653DF221B9F717D3490FF95CA87FDAEF30D1B823372F85B24A372F50E570000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000007685CD81A491DBCCC21AD06648D09A5C8CF5A78482054E91470B33DDE77252CAEF695AA", AllowHexSpecifier, InvariantCulture),
        Fnv1a1024("a"));

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
            Parse("000000000000000098D7C19FBCE653DF221B9F717D3490FF95CA87FDAEF30D1B823372F85B24A372F50E570000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000007685CD81A491DBCCC21AD06648D09A5C8CF5A78482054E91470B33DDE77252CAEF695AA", AllowHexSpecifier, InvariantCulture),
            await Fnv1a1024Async("a", cts.Token).ConfigureAwait(true));
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
        Parse("000000000000000098D7C19FBCE653DF221B9F717D3490FF95CA87FDAEF30D1B823372F85B24A372F50E570000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000007685CD81A491DBCCC21AD06648D09A5C8CF5A78482054E91470B33DDE77252CAEF695AA", AllowHexSpecifier, InvariantCulture),
        Fnv1a1024Try("a"));

    /// <summary>
    /// Tests the string "foobar" against the known vector result.
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
        Parse("00000631175FA7AE643AD08723D312C9FD024ADB91F77F6B19587197A22BCDF23727166C4572D0B985D5AE00000000000000000000000000000000000000000000000000000000000000000000000000000000000000004270D11EF418EF08B8A49E1E825E547EB39937F819222F3B7FC92A0E4707900888847A554BACEC98B0", AllowHexSpecifier, InvariantCulture),
        Fnv1a1024("foobar"));

    /// <summary>
    /// Tests the string "foobar" against the known vector result.
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
            Parse("00000631175FA7AE643AD08723D312C9FD024ADB91F77F6B19587197A22BCDF23727166C4572D0B985D5AE00000000000000000000000000000000000000000000000000000000000000000000000000000000000000004270D11EF418EF08B8A49E1E825E547EB39937F819222F3B7FC92A0E4707900888847A554BACEC98B0", AllowHexSpecifier, InvariantCulture),
            await Fnv1a1024Async("foobar", cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the string "foobar" against the known vector result.
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
        Parse("00000631175FA7AE643AD08723D312C9FD024ADB91F77F6B19587197A22BCDF23727166C4572D0B985D5AE00000000000000000000000000000000000000000000000000000000000000000000000000000000000000004270D11EF418EF08B8A49E1E825E547EB39937F819222F3B7FC92A0E4707900888847A554BACEC98B0", AllowHexSpecifier, InvariantCulture),
        Fnv1a1024Try("foobar"));

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
        ThrowsExactly<ArgumentOutOfRangeException>(() => _ = new Fnv1a1024(
            Parse("000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000018D", AllowHexSpecifier, InvariantCulture),
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
    //// ReSharper disable once UnusedMember.Global
    public void TestAlternatePrimeAndOffset()
    {
        Fnv1a1024 alg = new(
            Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture),
            Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture));

        alg.Append("foobar"u8.ToArray());
        AreEqual(128, alg.HashLengthInBytes - 1);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);
        AreEqual(
            Parse("0FFFFF9B774FDA8BCCBF8B3E7B64243F4430D7797E8226A689AFF30AD0636B4201DF5B8F3F729BD2E902A55FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFBC8C7FAAFBAB2D7BE9668F533508133ADE995502CFCBF5E793BD4706FA802C94A598E8EC87A9462180", AllowHexSpecifier, InvariantCulture),
            new(alg.GetCurrentHash()));
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
        Fnv1a1024 alg = new(
            Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture),
            Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture));
        AreEqual(128, alg.HashLengthInBytes - 1);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);
        using CancellationTokenSource cts = new();
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
        await using Stream stream = new MemoryStream("foobar"u8.ToArray());
#pragma warning restore CA2007 // Consider calling ConfigureAwait on the awaited task
        await alg.AppendAsync(stream, cts.Token).ConfigureAwait(false);

        BigInteger actual = new(alg.GetCurrentHash());

        AreEqual(
            Parse("0FFFFF9B774FDA8BCCBF8B3E7B64243F4430D7797E8226A689AFF30AD0636B4201DF5B8F3F729BD2E902A55FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFBC8C7FAAFBAB2D7BE9668F533508133ADE995502CFCBF5E793BD4706FA802C94A598E8EC87A9462180", AllowHexSpecifier, InvariantCulture),
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
    //// ReSharper disable once UnusedMember.Global
    public void TestAlternatePrimeAndOffsetTry()
    {
        Fnv1a1024 alg = new(
            Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture),
            Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture));
        AreEqual(128, alg.HashLengthInBytes - 1);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);

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
        IsGreaterThanOrEqualTo(bytesWritten, destination.Length);
        AreEqual(
            Parse("0FFFFF9B774FDA8BCCBF8B3E7B64243F4430D7797E8226A689AFF30AD0636B4201DF5B8F3F729BD2E902A55FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFBC8C7FAAFBAB2D7BE9668F533508133ADE995502CFCBF5E793BD4706FA802C94A598E8EC87A9462180", AllowHexSpecifier, InvariantCulture),
            new(destination));
    }

    /// <summary>
    /// Computes the FNV-1a 1024-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.Append(byte[])" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private BigInteger Fnv1a1024(in string data)
    {
        AreEqual(128, _alg.HashLengthInBytes - 1);
        _alg.Append(UTF8.GetBytes(data));
        return new(_alg.GetCurrentHash());
    }

    /// <summary>
    /// Asynchronously computes the FNV-1a 1024-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.AppendAsync(Stream, CancellationToken)" /> and .
    /// <see cref="NonCryptographicHashAlgorithm.GetCurrentHash()" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    //// ReSharper disable once InconsistentNaming
    private async Task<BigInteger> Fnv1a1024Async(string data, CancellationToken token = default)
    {
        AreEqual(128, _alg.HashLengthInBytes - 1);
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
        await using Stream stream = new MemoryStream(UTF8.GetBytes(data));
#pragma warning restore CA2007 // Consider calling ConfigureAwait on the awaited task
        await _alg.AppendAsync(stream, token).ConfigureAwait(false);
        return new(_alg.GetCurrentHash());
    }

    /// <summary>
    /// Computes the FNV-1a 1024-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.TryGetCurrentHash" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private BigInteger Fnv1a1024Try(in string data)
    {
        AreEqual(128, _alg.HashLengthInBytes - 1);

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
        return new(destination);
    }
}
