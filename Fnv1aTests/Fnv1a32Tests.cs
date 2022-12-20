// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a32Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Tests the FNV-1a 32-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using static System.Text.Encoding;

    using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    /// <inheritdoc />
    /// <summary>
    /// Tests the FNV-1a 32-bit algorithm.
    /// </summary>
    [TestClass]
    // ReSharper disable once InconsistentNaming
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
        private System.Security.Cryptography.HashAlgorithm _alg;

        /// <summary>
        /// The method to run before each test.
        /// </summary>
        [TestInitialize]
        public void Initialize() => this._alg = new Fnv1a.Fnv1a32();

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
        // ReSharper disable once InconsistentNaming
        public void TestVector1() => AreEqual(0x811C9DC5, this.Fnv1a32(string.Empty));

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector2() => AreEqual(0xE40C292C, this.Fnv1a32("a"));

        /// <summary>
        /// Tests the string against the known vector result.
        /// </summary>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector3() => AreEqual(0xBF9CF968, this.Fnv1a32("foobar"));

        /// <summary>
        /// Computes the FNV-1a 32-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 32-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        // ReSharper disable once InconsistentNaming
        private uint Fnv1a32(in string data)
        {
            AreEqual(32, this._alg.HashSize);
            return (uint)BitConverter.ToInt32(this._alg.ComputeHash(UTF8.GetBytes(data)), 0);
        }
    }
}
