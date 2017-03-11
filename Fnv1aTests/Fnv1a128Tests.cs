// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a128Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Tests the FNV-1a 128-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTests
{
    using System.Globalization;
    using System.Numerics;
    using System.Security.Cryptography;
    using System.Text;

    using Fnv1a;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    /// <summary>
    /// Tests the FNV-1a 128-bit algorithm.
    /// </summary>
    [TestClass]
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a128Tests
    {
        /// <summary>
        /// Tests the empty string against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector1()
        {
            AreEqual(
                BigInteger.Parse("6C62272E07BB014262B821756295C58D", NumberStyles.AllowHexSpecifier),
                Fnv1a128(string.Empty));
        }

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector2()
        {
            AreEqual(
                BigInteger.Parse("0D228CB696F1A8CAF78912B704E4A8964", NumberStyles.AllowHexSpecifier),
                Fnv1a128("a"));
        }

        /// <summary>
        /// Tests the string against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector3()
        {
            AreEqual(
                BigInteger.Parse("343E1662793C64BF6F0D3597BA446F18", NumberStyles.AllowHexSpecifier),
                Fnv1a128("foobar"));
        }

        /// <summary>
        /// Computes the FNV-1a 128-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 128-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static BigInteger Fnv1a128(string data)
        {
            using (HashAlgorithm alg = new Fnv1a128())
            {
                AreEqual(128, alg.HashSize);
                return new BigInteger(alg.ComputeHash(Encoding.UTF8.GetBytes(data)));
            }
        }
    }
}
