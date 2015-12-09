// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a64Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Tests the FNV-1a 64-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTests
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    using Fnv1a;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests the FNV-1a 64-bit algorithm.
    /// </summary>
    [TestClass]
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a64Tests
    {
        /// <summary>
        /// Tests the empty string against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector1()
        {
            Assert.AreEqual(0xcbf29ce484222325, Fnv1a64(string.Empty));
        }

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector2()
        {
            Assert.AreEqual(0xaf63dc4c8601ec8c, Fnv1a64("a"));
        }

        /// <summary>
        /// Tests the string "foobar" against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector3()
        {
            Assert.AreEqual(0x85944171f73967e8, Fnv1a64("foobar"));
        }

        /// <summary>
        /// Computes the FNV-1a 64-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 64-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static ulong Fnv1a64(string data)
        {
            using (HashAlgorithm alg = new Fnv1a64())
            {
                Assert.AreEqual(64, alg.HashSize);
                return (ulong)BitConverter.ToInt64(alg.ComputeHash(Encoding.UTF8.GetBytes(data)), 0);
            }
        }
    }
}
