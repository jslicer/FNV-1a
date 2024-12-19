// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a128Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Tests the FNV-1a 128-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTests
{
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
    /// Tests the FNV-1a 128-bit algorithm.
    /// </summary>
    [TestClass]
    //// ReSharper disable once InconsistentNaming
    //// ReSharper disable once ClassTooBig
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a128Tests : IDisposable
#pragma warning restore IDE0079 // Remove unnecessary suppression
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning restore S101 // Types should be named in PascalCase
    {
#pragma warning restore IDE0079 // Remove unnecessary suppression
        /// <summary>
        /// The hash algorithm being tested.
        /// </summary>
        private HashAlgorithm _alg;

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
        public void Initialize() => _alg = new Fnv1a128();

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
            Parse("6C62272E07BB014262B821756295C58D", AllowHexSpecifier, InvariantCulture),
            Fnv1a128(string.Empty));

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
                Parse("6C62272E07BB014262B821756295C58D", AllowHexSpecifier, InvariantCulture),
                await Fnv1a128Async(string.Empty, cts.Token).ConfigureAwait(true));
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
            Parse("6C62272E07BB014262B821756295C58D", AllowHexSpecifier, InvariantCulture),
            Fnv1a128Try(string.Empty));

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
            Parse("0D228CB696F1A8CAF78912B704E4A8964", AllowHexSpecifier, InvariantCulture),
            Fnv1a128("a"));

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
                Parse("0D228CB696F1A8CAF78912B704E4A8964", AllowHexSpecifier, InvariantCulture),
                await Fnv1a128Async("a", cts.Token).ConfigureAwait(true));
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
            Parse("0D228CB696F1A8CAF78912B704E4A8964", AllowHexSpecifier, InvariantCulture),
            Fnv1a128Try("a"));

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
            Parse("343E1662793C64BF6F0D3597BA446F18", AllowHexSpecifier, InvariantCulture),
            Fnv1a128("foobar"));

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
                Parse("343E1662793C64BF6F0D3597BA446F18", AllowHexSpecifier, InvariantCulture),
                await Fnv1a128Async("foobar", cts.Token).ConfigureAwait(true));
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
        //// ReSharper disable once InconsistentNaming
        public void TestVector3Try() => AreEqual(
            Parse("343E1662793C64BF6F0D3597BA446F18", AllowHexSpecifier, InvariantCulture),
            Fnv1a128Try("foobar"));

        /// <summary>
        /// Tests the "Hello World" string against the known vector result.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
        /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        public void TestHelloWorld() => AreEqual(
            Parse("0CD7FECF582839515F3E6ECF66B967B77", AllowHexSpecifier, InvariantCulture),
            Fnv1a128("Hello World"));

        /// <summary>
        /// Tests the "Hello World" string against the known vector result.
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
        public async Task TestHelloWorldAsync()
        {
            using CancellationTokenSource cts = new();
            AreEqual(
                Parse("0CD7FECF582839515F3E6ECF66B967B77", AllowHexSpecifier, InvariantCulture),
                await Fnv1a128Async("Hello World", cts.Token).ConfigureAwait(true));
        }

        /// <summary>
        /// Tests the "Hello World" string against the known vector result.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
        /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        public void TestHelloWorldTry() => AreEqual(
            Parse("0CD7FECF582839515F3E6ECF66B967B77", AllowHexSpecifier, InvariantCulture),
            Fnv1a128Try("Hello World"));

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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAlternatePrimeAndZeroOffset()
        {
            using Fnv1a128 _ = new(
                Parse("0000000001000000000000000000013B", AllowHexSpecifier, InvariantCulture),
                BigInteger.Zero);
        }

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
            using Fnv1a128 alg = new(
                Parse("FFFFFFFFFEFFFFFFFFFFFFFFFFFFFEC4", AllowHexSpecifier, InvariantCulture),
                Parse("939DD8D1F844FEBD9D47DE8A9D6A3A72", AllowHexSpecifier, InvariantCulture));
            AreEqual(128, alg.HashSize);
            AreEqual(Parse("FFFFFFFFFEFFFFFFFFFFFFFFFFFFFEC4", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
            AreEqual(Parse("939DD8D1F844FEBD9D47DE8A9D6A3A72", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);
            AreEqual(
                Parse("0AA2376793386FBA25B67E764D2093DD8", AllowHexSpecifier, InvariantCulture),
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
            using Fnv1a128 alg = new(
                Parse("FFFFFFFFFEFFFFFFFFFFFFFFFFFFFEC4", AllowHexSpecifier, InvariantCulture),
                Parse("939DD8D1F844FEBD9D47DE8A9D6A3A72", AllowHexSpecifier, InvariantCulture));
            AreEqual(128, alg.HashSize);
            AreEqual(Parse("FFFFFFFFFEFFFFFFFFFFFFFFFFFFFEC4", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
            AreEqual(Parse("939DD8D1F844FEBD9D47DE8A9D6A3A72", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);
            using CancellationTokenSource cts = new();
            await using Stream stream = new MemoryStream("foobar"u8.ToArray());

            BigInteger actual = new((await alg.ComputeHashAsync(stream, cts.Token).ConfigureAwait(false)).AddZero());

            AreEqual(
                Parse("0AA2376793386FBA25B67E764D2093DD8", AllowHexSpecifier, InvariantCulture),
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
            using Fnv1a128 alg = new(
                Parse("FFFFFFFFFEFFFFFFFFFFFFFFFFFFFEC4", AllowHexSpecifier, InvariantCulture),
                Parse("939DD8D1F844FEBD9D47DE8A9D6A3A72", AllowHexSpecifier, InvariantCulture));
            AreEqual(128, alg.HashSize);
            AreEqual(Parse("FFFFFFFFFEFFFFFFFFFFFFFFFFFFFEC4", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
            AreEqual(Parse("939DD8D1F844FEBD9D47DE8A9D6A3A72", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);

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
                Parse("0AA2376793386FBA25B67E764D2093DD8", AllowHexSpecifier, InvariantCulture),
                new(destination));
        }

        /// <summary>
        /// Computes the FNV-1a 128-bit hash for the specified data using
        /// <see cref="HashAlgorithm.ComputeHash(byte[])" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 128-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private BigInteger Fnv1a128(in string data)
        {
            AreEqual(128, _alg.HashSize);
            return new(_alg.ComputeHash(UTF8.GetBytes(data)).AddZero());
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 128-bit hash for the specified data using
        /// <see cref="HashAlgorithm.ComputeHashAsync(Stream, CancellationToken)" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>The FNV-1a 128-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        //// ReSharper disable once InconsistentNaming
        private async Task<BigInteger> Fnv1a128Async(string data, CancellationToken token = default)
        {
            AreEqual(128, _alg.HashSize);
            await using Stream stream = new MemoryStream(UTF8.GetBytes(data));
            return new((await _alg.ComputeHashAsync(stream, token).ConfigureAwait(false)).AddZero());
        }

        /// <summary>
        /// Computes the FNV-1a 128-bit hash for the specified data using <see cref="HashAlgorithm.TryComputeHash" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 128-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private BigInteger Fnv1a128Try(in string data)
        {
            AreEqual(128, _alg.HashSize);

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
}
