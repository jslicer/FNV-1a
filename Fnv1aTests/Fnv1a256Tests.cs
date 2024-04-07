// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a256Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Tests the FNV-1a 256-bit algorithm.
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
    /// Tests the FNV-1a 256-bit algorithm.
    /// </summary>
    [TestClass]
    //// ReSharper disable once InconsistentNaming
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a256Tests : IDisposable
#pragma warning restore S101 // Types should be named in PascalCase
#pragma warning restore IDE0079 // Remove unnecessary suppression
    {
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
        public void Initialize() => this._alg = new Fnv1a256();

        /// <summary>
        /// The method to run after each test.
        /// </summary>
        [TestCleanup]
        public void Cleanup() => this.Dispose();

        /// <inheritdoc />
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose() => this._alg.Dispose();

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
            Parse("DD268DBCAAC550362D98C384C4E576CCC8B1536847B6BBB31023B4C8CAEE0535", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256(string.Empty));

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
                Parse("DD268DBCAAC550362D98C384C4E576CCC8B1536847B6BBB31023B4C8CAEE0535", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
                await this.Fnv1a256Async(string.Empty, cts.Token).ConfigureAwait(true));
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
            Parse("DD268DBCAAC550362D98C384C4E576CCC8B1536847B6BBB31023B4C8CAEE0535", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256Try(string.Empty));

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
            Parse("63323FB0F35303EC28DC751D0A33BDFA4DE6A99B7266494F6183B2716811637C", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256("a"));

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
                Parse("63323FB0F35303EC28DC751D0A33BDFA4DE6A99B7266494F6183B2716811637C", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
                await this.Fnv1a256Async("a", cts.Token).ConfigureAwait(true));
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
            Parse("63323FB0F35303EC28DC751D0A33BDFA4DE6A99B7266494F6183B2716811637C", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256Try("a"));

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
            Parse("B055EA2F306CADAD4F0F81C02D3889DC32453DAD5AE35B753BA1A91084AF3428", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256("foobar"));

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
                Parse("B055EA2F306CADAD4F0F81C02D3889DC32453DAD5AE35B753BA1A91084AF3428", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
                await this.Fnv1a256Async("foobar", cts.Token).ConfigureAwait(true));
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
            Parse("B055EA2F306CADAD4F0F81C02D3889DC32453DAD5AE35B753BA1A91084AF3428", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256Try("foobar"));

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
            using Fnv1a256 _ = new(
                Parse("0000000000000000000001000000000000000000000000000000000000000163", AllowHexSpecifier, InvariantCulture),
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
            using Fnv1a256 alg = new(
                Parse("FFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE9C", AllowHexSpecifier, InvariantCulture),
                Parse("22D97243553AAFC9D2673C7B3B1A8933374EAC97B849444CEFDC4B373511FACA", AllowHexSpecifier, InvariantCulture));
            AreEqual(256, alg.HashSize);
            AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE9C", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
            AreEqual(Parse("22D97243553AAFC9D2673C7B3B1A8933374EAC97B849444CEFDC4B373511FACA", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);
            AreEqual(
                Parse("3EA7324391B13110A5EA99E1F173600686094AA0B741AE2A343DF42F38836088", AllowHexSpecifier, InvariantCulture),
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
            using Fnv1a256 alg = new(
                Parse("FFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE9C", AllowHexSpecifier, InvariantCulture),
                Parse("22D97243553AAFC9D2673C7B3B1A8933374EAC97B849444CEFDC4B373511FACA", AllowHexSpecifier, InvariantCulture));
            AreEqual(256, alg.HashSize);
            AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE9C", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
            AreEqual(Parse("22D97243553AAFC9D2673C7B3B1A8933374EAC97B849444CEFDC4B373511FACA", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);
            using CancellationTokenSource cts = new();
            await using Stream stream = new MemoryStream("foobar"u8.ToArray());

            BigInteger actual = new((await alg.ComputeHashAsync(stream, cts.Token).ConfigureAwait(false)).AddZero());

            AreEqual(
                Parse("3EA7324391B13110A5EA99E1F173600686094AA0B741AE2A343DF42F38836088", AllowHexSpecifier, InvariantCulture),
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
            using Fnv1a256 alg = new(
                Parse("FFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE9C", AllowHexSpecifier, InvariantCulture),
                Parse("22D97243553AAFC9D2673C7B3B1A8933374EAC97B849444CEFDC4B373511FACA", AllowHexSpecifier, InvariantCulture));
            AreEqual(256, alg.HashSize);
            AreEqual(Parse("FFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE9C", AllowHexSpecifier, InvariantCulture), alg.FnvPrime);
            AreEqual(Parse("22D97243553AAFC9D2673C7B3B1A8933374EAC97B849444CEFDC4B373511FACA", AllowHexSpecifier, InvariantCulture), alg.FnvOffsetBasis);

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
                Parse("3EA7324391B13110A5EA99E1F173600686094AA0B741AE2A343DF42F38836088", AllowHexSpecifier, InvariantCulture),
                new(destination));
        }

        /// <summary>
        /// Computes the FNV-1a 256-bit hash for the specified data using
        /// <see cref="HashAlgorithm.ComputeHash(byte[])" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private string Fnv1a256(in string data)
        {
            AreEqual(256, this._alg.HashSize);

            string value = new BigInteger(this._alg.ComputeHash(UTF8.GetBytes(data)).AddZero())
                .ToString("X64", InvariantCulture);

            return value?[^64..];
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 256-bit hash for the specified data using
        /// <see cref="HashAlgorithm.ComputeHashAsync(Stream, CancellationToken)" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        //// ReSharper disable once InconsistentNaming
        private async Task<string> Fnv1a256Async(string data, CancellationToken token = default)
        {
            AreEqual(256, this._alg.HashSize);
            await using Stream stream = new MemoryStream(UTF8.GetBytes(data));

            string value =
                new BigInteger((await this._alg.ComputeHashAsync(stream, token).ConfigureAwait(false)).AddZero())
                .ToString("X64", InvariantCulture);

            return value?[^64..];
        }

        /// <summary>
        /// Computes the FNV-1a 256-bit hash for the specified data using <see cref="HashAlgorithm.TryComputeHash" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private string Fnv1a256Try(in string data)
        {
            AreEqual(256, this._alg.HashSize);

            int inputByteCount = UTF8.GetByteCount(data);
            Span<byte> bytes = inputByteCount < 1024
                ? stackalloc byte[inputByteCount]
                : new byte[inputByteCount];

            UTF8.GetBytes(data, bytes);

            // ReSharper disable once ComplexConditionExpression
            Span<byte> destination = stackalloc byte[1 + (this._alg.HashSize / 8)];
            bool result = this._alg.TryComputeHash(bytes, destination, out int bytesWritten);

            IsTrue(result);
            IsTrue(destination.Length >= bytesWritten);

            string value = new BigInteger(destination).ToString("X64", InvariantCulture);

            return value?[^64..];
        }
    }
}
