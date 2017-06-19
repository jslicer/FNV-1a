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
    using System.Numerics;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using static System.Globalization.CultureInfo;
    using static System.Globalization.NumberStyles;
    using static System.Numerics.BigInteger;
    using static System.Text.Encoding;

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
                Parse("6C62272E07BB014262B821756295C58D", AllowHexSpecifier, InvariantCulture),
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
                Parse("0D228CB696F1A8CAF78912B704E4A8964", AllowHexSpecifier, InvariantCulture),
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
                Parse("343E1662793C64BF6F0D3597BA446F18", AllowHexSpecifier, InvariantCulture),
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
            using (System.Security.Cryptography.HashAlgorithm alg = new Fnv1a.Fnv1a128())
            {
                AreEqual(128, alg.HashSize);
                return new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)));
            }
        }
    }
}
