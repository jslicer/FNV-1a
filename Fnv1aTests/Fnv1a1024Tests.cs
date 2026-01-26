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
    /// The foobar string.
    /// </summary>
    private const string Foobar = "foobar";

    /// <summary>
    /// The alternate prime.
    /// </summary>
    private static readonly UInt1024 _AlternatePrime = new(
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFEFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFE72UL);

    /// <summary>
    /// The alternate offset basis.
    /// </summary>
    private static readonly UInt1024 _AlternateOffsetBasis = new(
        0xFFFFFFFFFFFFFFFFUL,
        0xFFA085898A7133B2UL,
        0xCD1A92A5A6EFD748UL,
        0xB4D603BDDC02525EUL,
        0x93C40CB125C98B25UL,
        0x65DE26FFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFFFFFFUL,
        0xFFFFFFFFFFFB3928UL,
        0x14918C7FD8CBAEF5UL,
        0xAAA0DA933FFA51AAUL,
        0x942173363956C4DEUL,
        0x500B4E938E116F4CUL);

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
        _alg = new Fnv1a1024();
        _alg.Reset();
    }

    /// <summary>
    /// Tests the empty string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector1() => AreEqual(
        new(
            0x0000000000000000UL,
            0x005F7A76758ECC4DUL,
            0x32E56D5A591028B7UL,
            0x4B29FC4223FDADA1UL,
            0x6C3BF34EDA3674DAUL,
            0x9A21D90000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x000000000004C6D7UL,
            0xEB6E73802734510AUL,
            0x555F256CC005AE55UL,
            0x6BDE8CC9C6A93B21UL,
            0xAFF4B16C71EE90B3UL),
        Fnv1a1024(string.Empty));

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
            new(
                0x0000000000000000UL,
                0x005F7A76758ECC4DUL,
                0x32E56D5A591028B7UL,
                0x4B29FC4223FDADA1UL,
                0x6C3BF34EDA3674DAUL,
                0x9A21D90000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x000000000004C6D7UL,
                0xEB6E73802734510AUL,
                0x555F256CC005AE55UL,
                0x6BDE8CC9C6A93B21UL,
                0xAFF4B16C71EE90B3UL),
            await Fnv1a1024Async(string.Empty, cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the empty string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector1Try() => AreEqual(
        new(
            0x0000000000000000UL,
            0x005F7A76758ECC4DUL,
            0x32E56D5A591028B7UL,
            0x4B29FC4223FDADA1UL,
            0x6C3BF34EDA3674DAUL,
            0x9A21D90000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x000000000004C6D7UL,
            0xEB6E73802734510AUL,
            0x555F256CC005AE55UL,
            0x6BDE8CC9C6A93B21UL,
            0xAFF4B16C71EE90B3UL),
        Fnv1a1024Try(string.Empty));

    /// <summary>
    /// Tests the string "a" against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector2() => AreEqual(
        new(
            0x0000000000000000UL,
            0x98D7C19FBCE653DFUL,
            0x221B9F717D3490FFUL,
            0x95CA87FDAEF30D1BUL,
            0x823372F85B24A372UL,
            0xF50E570000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000007685CD8UL,
            0x1A491DBCCC21AD06UL,
            0x648D09A5C8CF5A78UL,
            0x482054E91470B33DUL,
            0xDE77252CAEF695AAUL),
        Fnv1a1024("a"));

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
            new(
                0x0000000000000000UL,
                0x98D7C19FBCE653DFUL,
                0x221B9F717D3490FFUL,
                0x95CA87FDAEF30D1BUL,
                0x823372F85B24A372UL,
                0xF50E570000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000007685CD8UL,
                0x1A491DBCCC21AD06UL,
                0x648D09A5C8CF5A78UL,
                0x482054E91470B33DUL,
                0xDE77252CAEF695AAUL),
            await Fnv1a1024Async("a", cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the string "a" against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector2Try() => AreEqual(
        new(
            0x0000000000000000UL,
            0x98D7C19FBCE653DFUL,
            0x221B9F717D3490FFUL,
            0x95CA87FDAEF30D1BUL,
            0x823372F85B24A372UL,
            0xF50E570000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000007685CD8UL,
            0x1A491DBCCC21AD06UL,
            0x648D09A5C8CF5A78UL,
            0x482054E91470B33DUL,
            0xDE77252CAEF695AAUL),
        Fnv1a1024Try("a"));

    /// <summary>
    /// Tests the string "foobar" against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector3() => AreEqual(
        new(
            0x00000631175FA7AEUL,
            0x643AD08723D312C9UL,
            0xFD024ADB91F77F6BUL,
            0x19587197A22BCDF2UL,
            0x3727166C4572D0B9UL,
            0x85D5AE0000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000042UL,
            0x70D11EF418EF08B8UL,
            0xA49E1E825E547EB3UL,
            0x9937F819222F3B7FUL,
            0xC92A0E4707900888UL,
            0x847A554BACEC98B0UL),
        Fnv1a1024(Foobar));

    /// <summary>
    /// Tests the string "foobar" against the known vector result.
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
            new(
                0x00000631175FA7AEUL,
                0x643AD08723D312C9UL,
                0xFD024ADB91F77F6BUL,
                0x19587197A22BCDF2UL,
                0x3727166C4572D0B9UL,
                0x85D5AE0000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000042UL,
                0x70D11EF418EF08B8UL,
                0xA49E1E825E547EB3UL,
                0x9937F819222F3B7FUL,
                0xC92A0E4707900888UL,
                0x847A554BACEC98B0UL),
            await Fnv1a1024Async(Foobar, cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the string "foobar" against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector3Try() => AreEqual(
        new(
            0x00000631175FA7AEUL,
            0x643AD08723D312C9UL,
            0xFD024ADB91F77F6BUL,
            0x19587197A22BCDF2UL,
            0x3727166C4572D0B9UL,
            0x85D5AE0000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000042UL,
            0x70D11EF418EF08B8UL,
            0xA49E1E825E547EB3UL,
            0x9937F819222F3B7FUL,
            0xC92A0E4707900888UL,
            0x847A554BACEC98B0UL),
        Fnv1a1024Try(Foobar));

    /// <summary>
    /// Tests the string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector4() => AreEqual(
        new(
            0xFD40C54ADB30B16FUL,
            0xD3B5020075165BCAUL,
            0xA391C47ED5598B8CUL,
            0xB8354A81011D1F5CUL,
            0x809A231C31CC8873UL,
            0xC7DC840000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000002060C527CDUL,
            0xAFE7B3DE88B930FFUL,
            0x61BFFB975575E8EBUL,
            0x7CAAB48E688BB6B3UL,
            0x552D7074847733A7UL,
            0x26E137C1330AA0FDUL,
            0x2822FD5B3A9FB541UL),
        Fnv1a1024("chongo was here!\n"));

    /// <summary>
    /// Tests the string against the known vector result.
    /// </summary>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public async Task TestVector4Async()
    {
        using CancellationTokenSource cts = new();
        AreEqual(
            new(
                0xFD40C54ADB30B16FUL,
                0xD3B5020075165BCAUL,
                0xA391C47ED5598B8CUL,
                0xB8354A81011D1F5CUL,
                0x809A231C31CC8873UL,
                0xC7DC840000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000002060C527CDUL,
                0xAFE7B3DE88B930FFUL,
                0x61BFFB975575E8EBUL,
                0x7CAAB48E688BB6B3UL,
                0x552D7074847733A7UL,
                0x26E137C1330AA0FDUL,
                0x2822FD5B3A9FB541UL),
            await Fnv1a1024Async("chongo was here!\n", cts.Token).ConfigureAwait(true));
    }

    /// <summary>
    /// Tests the string against the known vector result.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestVector4Try() => AreEqual(
        new(
            0xFD40C54ADB30B16FUL,
            0xD3B5020075165BCAUL,
            0xA391C47ED5598B8CUL,
            0xB8354A81011D1F5CUL,
            0x809A231C31CC8873UL,
            0xC7DC840000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000000000000000UL,
            0x0000002060C527CDUL,
            0xAFE7B3DE88B930FFUL,
            0x61BFFB975575E8EBUL,
            0x7CAAB48E688BB6B3UL,
            0x552D7074847733A7UL,
            0x26E137C1330AA0FDUL,
            0x2822FD5B3A9FB541UL),
        Fnv1a1024Try("chongo was here!\n"));

    /// <summary>
    /// Tests the alternate prime and zero offset.
    /// </summary>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    [TestMethod]
    //// ReSharper disable once UnusedMember.Global
    public void TestAlternatePrimeAndZeroOffset() =>
        ThrowsExactly<ArgumentOutOfRangeException>(() => _ = new Fnv1a1024(
            new(
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000010000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x0000000000000000UL,
                0x000000000000018DUL),
            UInt1024.Zero));

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
        Fnv1a1024 alg = new(_AlternatePrime, _AlternateOffsetBasis);

        alg.Append("foobar"u8.ToArray());
        AreEqual(128, alg.HashLengthInBytes);
        AreEqual(_AlternatePrime, alg.FnvPrime);
        AreEqual(_AlternateOffsetBasis, alg.FnvOffsetBasis);
        AreEqual(
            new(
                0xFFFFF9B774FDA8BCUL,
                0xCBF8B3E7B64243F4UL,
                0x430D7797E8226A68UL,
                0x9AFF30AD0636B420UL,
                0x1DF5B8F3F729BD2EUL,
                0x902A55FFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFBCUL,
                0x8C7FAAFBAB2D7BE9UL,
                0x668F533508133ADEUL,
                0x995502CFCBF5E793UL,
                0xBD4706FA802C94A5UL,
                0x98E8EC87A9462180UL),
            new UInt1024(alg.GetCurrentHash()));
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
        Fnv1a1024 alg = new(_AlternatePrime, _AlternateOffsetBasis);

        AreEqual(128, alg.HashLengthInBytes);
        AreEqual(_AlternatePrime, alg.FnvPrime);
        AreEqual(_AlternateOffsetBasis, alg.FnvOffsetBasis);
        using CancellationTokenSource cts = new();
#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
        await using Stream stream = new MemoryStream("foobar"u8.ToArray());
#pragma warning restore CA2007 // Consider calling ConfigureAwait on the awaited task
        await alg.AppendAsync(stream, cts.Token).ConfigureAwait(false);
        AreEqual(
            new(
                0xFFFFF9B774FDA8BCUL,
                0xCBF8B3E7B64243F4UL,
                0x430D7797E8226A68UL,
                0x9AFF30AD0636B420UL,
                0x1DF5B8F3F729BD2EUL,
                0x902A55FFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFBCUL,
                0x8C7FAAFBAB2D7BE9UL,
                0x668F533508133ADEUL,
                0x995502CFCBF5E793UL,
                0xBD4706FA802C94A5UL,
                0x98E8EC87A9462180UL),
            new UInt1024(alg.GetCurrentHash()));
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
        Fnv1a1024 alg = new(_AlternatePrime, _AlternateOffsetBasis);

        AreEqual(128, alg.HashLengthInBytes);
        AreEqual(_AlternatePrime, alg.FnvPrime);
        AreEqual(_AlternateOffsetBasis, alg.FnvOffsetBasis);

        const string Data = Foobar;
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
            new(
                0xFFFFF9B774FDA8BCUL,
                0xCBF8B3E7B64243F4UL,
                0x430D7797E8226A68UL,
                0x9AFF30AD0636B420UL,
                0x1DF5B8F3F729BD2EUL,
                0x902A55FFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFFFUL,
                0xFFFFFFFFFFFFFFBCUL,
                0x8C7FAAFBAB2D7BE9UL,
                0x668F533508133ADEUL,
                0x995502CFCBF5E793UL,
                0xBD4706FA802C94A5UL,
                0x98E8EC87A9462180UL),
            new UInt1024(destination));
    }

    /// <summary>
    /// Computes the FNV-1a 1024-bit hash for the specified data using
    /// <see cref="NonCryptographicHashAlgorithm.Append(byte[])" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
    /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
    //// ReSharper disable once InconsistentNaming
    private UInt1024 Fnv1a1024(string data)
    {
        AreEqual(128, _alg.HashLengthInBytes);
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
    private async Task<UInt1024> Fnv1a1024Async(string data, CancellationToken token = default)
    {
        AreEqual(128, _alg.HashLengthInBytes);
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
    private UInt1024 Fnv1a1024Try(string data)
    {
        AreEqual(128, _alg.HashLengthInBytes);

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
