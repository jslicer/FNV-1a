// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a32Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Tests the FNV-1a 32-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTests
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using Fnv1a;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using static System.Text.Encoding;
    using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    /// <inheritdoc />
    /// <summary>
    /// Tests the FNV-1a 32-bit algorithm.
    /// </summary>
    [TestClass]
    //// ReSharper disable once InconsistentNaming
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a32Tests : IDisposable
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
        [TestInitialize]
        public void Initialize() => this._alg = new Fnv1a32();

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
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector1() => AreEqual(0x811C9DC5U, this.Fnv1a32(string.Empty));

        /// <summary>
        /// Tests the empty string against the known vector result.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public async Task TestVector1Async()
        {
            using CancellationTokenSource cts = new();
            AreEqual(0x811C9DC5U, await this.Fnv1a32Async(string.Empty, cts.Token).ConfigureAwait(true));
        }

        /// <summary>
        /// Tests the empty string against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector1Try() => AreEqual(0x811C9DC5U, this.Fnv1a32Try(string.Empty));

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector2() => AreEqual(0xE40C292CU, this.Fnv1a32("a"));

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public async Task TestVector2Async()
        {
            using CancellationTokenSource cts = new();
            AreEqual(0xE40C292CU, await this.Fnv1a32Async("a", cts.Token).ConfigureAwait(true));
        }

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector2Try() => AreEqual(0xE40C292CU, this.Fnv1a32Try("a"));

        /// <summary>
        /// Tests the string against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector3() => AreEqual(0xBF9CF968U, this.Fnv1a32("foobar"));

        /// <summary>
        /// Tests the string against the known vector result.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public async Task TestVector3Async()
        {
            using CancellationTokenSource cts = new();
            AreEqual(0xBF9CF968U, await this.Fnv1a32Async("foobar", cts.Token).ConfigureAwait(true));
        }

        /// <summary>
        /// Tests the string against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector3Try() => AreEqual(0xBF9CF968U, this.Fnv1a32Try("foobar"));

        /// <summary>
        /// Tests the alternate prime and zero offset.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAlternatePrimeAndZeroOffset()
        {
            using Fnv1a32 _ = new(0xB3CB2E29U, 0x0U);
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
            using Fnv1a32 alg = new(0xB3CB2E29U, 0x319712C3U);
            AreEqual(32, alg.HashSize);
            AreEqual(0xB3CB2E29U, alg.FnvPrime);
            AreEqual(0x319712C3U, alg.FnvOffsetBasis);
            AreEqual(0xBF9CF968U, (uint)BitConverter.ToInt32(this._alg.ComputeHash("foobar"u8.ToArray()), 0));
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
            using Fnv1a32 alg = new(0xB3CB2E29U, 0x319712C3U);
            AreEqual(32, alg.HashSize);
            AreEqual(0xB3CB2E29U, alg.FnvPrime);
            AreEqual(0x319712C3U, alg.FnvOffsetBasis);
            using CancellationTokenSource cts = new();
            await using Stream stream = new MemoryStream("foobar"u8.ToArray());

            uint actual = (uint)BitConverter.ToInt32(
                await this._alg.ComputeHashAsync(stream, cts.Token).ConfigureAwait(false), 0);

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
        public void TestAlternatePrimeAndOffsetTry()
        {
            using Fnv1a32 alg = new(0xB3CB2E29U, 0x319712C3U);
            AreEqual(32, alg.HashSize);
            AreEqual(0xB3CB2E29U, alg.FnvPrime);
            AreEqual(0x319712C3U, alg.FnvOffsetBasis);

            const string Data = "foobar";
            int inputByteCount = UTF8.GetByteCount(Data);
            Span<byte> bytes = inputByteCount < 1024
                ? stackalloc byte[inputByteCount]
                : new byte[inputByteCount];

            UTF8.GetBytes(Data, bytes);

            // ReSharper disable once ComplexConditionExpression
            Span<byte> destination = stackalloc byte[1 + (this._alg.HashSize / 8)];
            bool result = this._alg.TryComputeHash(bytes, destination, out int bytesWritten);

            IsTrue(result);
            IsTrue(destination.Length >= bytesWritten);
            AreEqual(0xBF9CF968U, (uint)BitConverter.ToInt32(destination));
        }

        /// <summary>
        /// Computes the FNV-1a 32-bit hash for the specified data using
        /// <see cref="HashAlgorithm.ComputeHash(byte[])" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 32-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private uint Fnv1a32(in string data)
        {
            AreEqual(32, this._alg.HashSize);
            return (uint)BitConverter.ToInt32(this._alg.ComputeHash(UTF8.GetBytes(data)), 0);
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 32-bit hash for the specified data using
        /// <see cref="HashAlgorithm.ComputeHashAsync(Stream, CancellationToken)" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>The FNV-1a 32-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        //// ReSharper disable once InconsistentNaming
        private async Task<uint> Fnv1a32Async(string data, CancellationToken token = default)
        {
            AreEqual(32, this._alg.HashSize);
            await using Stream stream = new MemoryStream(UTF8.GetBytes(data));
            return (uint)BitConverter.ToInt32(
                await this._alg.ComputeHashAsync(stream, token).ConfigureAwait(false), 0);
        }

        /// <summary>
        /// Computes the FNV-1a 32-bit hash for the specified data using <see cref="HashAlgorithm.TryComputeHash" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 32-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private uint Fnv1a32Try(in string data)
        {
            AreEqual(32, this._alg.HashSize);

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
            return (uint)BitConverter.ToInt32(destination);
        }
    }
}
