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
/// Tests the FNV-1a 1024-bit algorithm.
/// </summary>
[TestClass]
//// ReSharper disable once InconsistentNaming
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
public sealed class Fnv1a1024Tests : IDisposable
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
    public void Initialize() => _alg = new Fnv1a1024();

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
    //// ReSharper disable once InconsistentNaming
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
    //// ReSharper disable once InconsistentNaming
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
    //// ReSharper disable once InconsistentNaming
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
    //// ReSharper disable once InconsistentNaming
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
    //// ReSharper disable once InconsistentNaming
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
    //// ReSharper disable once InconsistentNaming
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
    //// ReSharper disable once InconsistentNaming
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
    //// ReSharper disable once InconsistentNaming
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
    public void TestAlternatePrimeAndOffset()
    {
        using Fnv1a1024 alg = new(
            Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture),
            Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture));
        AreEqual(1024, alg.HashSize);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);
        AreEqual(
            Parse("0FFFFF9B774FDA8BCCBF8B3E7B64243F4430D7797E8226A689AFF30AD0636B4201DF5B8F3F729BD2E902A55FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFBC8C7FAAFBAB2D7BE9668F533508133ADE995502CFCBF5E793BD4706FA802C94A598E8EC87A9462180", AllowHexSpecifier, InvariantCulture),
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
        using Fnv1a1024 alg = new(
            Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture),
            Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture));
        AreEqual(1024, alg.HashSize);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);
        using CancellationTokenSource cts = new();
        await using Stream stream = new MemoryStream("foobar"u8.ToArray());

        BigInteger actual = new((await alg.ComputeHashAsync(stream, cts.Token).ConfigureAwait(false)).AddZero());

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
    public void TestAlternatePrimeAndOffsetTry()
    {
        using Fnv1a1024 alg = new(
            Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture),
            Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture));
        AreEqual(1024, alg.HashSize);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE72", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
        AreEqual(Parse("FFFFFFFFFFFFFFFFFFA085898A7133B2CD1A92A5A6EFD748B4D603BDDC02525E93C40CB125C98B2565DE26FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFB392814918C7FD8CBAEF5AAA0DA933FFA51AA942173363956C4DE500B4E938E116F4C", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);

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
            Parse("0FFFFF9B774FDA8BCCBF8B3E7B64243F4430D7797E8226A689AFF30AD0636B4201DF5B8F3F729BD2E902A55FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFBC8C7FAAFBAB2D7BE9668F533508133ADE995502CFCBF5E793BD4706FA802C94A598E8EC87A9462180", AllowHexSpecifier, InvariantCulture),
            new(destination));
    }

    /// <summary>
    /// Computes the FNV-1a 1024-bit hash for the specified data using
    /// <see cref="HashAlgorithm.ComputeHash(byte[])" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private BigInteger Fnv1a1024(in string data)
    {
        AreEqual(1024, _alg.HashSize);
        return new(_alg.ComputeHash(UTF8.GetBytes(data)).AddZero());
    }

    /// <summary>
    /// Asynchronously computes the FNV-1a 1024-bit hash for the specified data using
    /// <see cref="HashAlgorithm.ComputeHashAsync(Stream, CancellationToken)" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    //// ReSharper disable once InconsistentNaming
    private async Task<BigInteger> Fnv1a1024Async(string data, CancellationToken token = default)
    {
        AreEqual(1024, _alg.HashSize);
        await using Stream stream = new MemoryStream(UTF8.GetBytes(data));
        return new((await _alg.ComputeHashAsync(stream, token).ConfigureAwait(false)).AddZero());
    }

    /// <summary>
    /// Computes the FNV-1a 1024-bit hash for the specified data using <see cref="HashAlgorithm.TryComputeHash" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private BigInteger Fnv1a1024Try(in string data)
    {
        AreEqual(1024, _alg.HashSize);

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
