// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a64Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Tests the FNV-1a 64-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTests
{
    using System;
    using System.Security.Cryptography;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using static System.Text.Encoding;

    using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    /// <inheritdoc />
    /// <summary>
    /// Tests the FNV-1a 64-bit algorithm.
    /// </summary>
    [TestClass]
    //// ReSharper disable once InconsistentNaming
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a64Tests : IDisposable
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
        public void Initialize() => this._alg = new Fnv1a.Fnv1a64();

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
        public void TestVector1() => AreEqual(0xCBF29CE484222325, this.Fnv1a64(string.Empty));

        /// <summary>
        /// Tests the empty string against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector1Try() => AreEqual(0xCBF29CE484222325, this.Fnv1a64Try(string.Empty));

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector2() => AreEqual(0xAF63DC4C8601EC8C, this.Fnv1a64("a"));

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector2Try() => AreEqual(0xAF63DC4C8601EC8C, this.Fnv1a64Try("a"));

        /// <summary>
        /// Tests the string against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector3() => AreEqual(0x85944171F73967E8, this.Fnv1a64("foobar"));

        /// <summary>
        /// Tests the string against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector3Try() => AreEqual(0x85944171F73967E8, this.Fnv1a64Try("foobar"));

        /// <summary>
        /// Computes the FNV-1a 64-bit hash for the specified data using
        /// <see cref="HashAlgorithm.ComputeHash(byte[])" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 64-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private ulong Fnv1a64(in string data)
        {
            AreEqual(64, this._alg.HashSize);
            return (ulong)BitConverter.ToInt64(this._alg.ComputeHash(UTF8.GetBytes(data)), 0);
        }

        /// <summary>
        /// Computes the FNV-1a 64-bit hash for the specified data using <see cref="HashAlgorithm.TryComputeHash" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 64-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private ulong Fnv1a64Try(in string data)
        {
            AreEqual(64, this._alg.HashSize);

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
            return (ulong)BitConverter.ToInt64(destination);
        }
    }
}
