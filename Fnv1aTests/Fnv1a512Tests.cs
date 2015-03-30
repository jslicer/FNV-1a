// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a512Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Tests the FNV-1a 512-bit algorithm.
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

    /// <summary>
    /// Tests the FNV-1a 512-bit algorithm.
    /// </summary>
    [TestClass]
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a512Tests
    {
        /// <summary>
        /// Tests the empty string against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector1()
        {
            Assert.AreEqual(
                BigInteger.Parse("0B86DB0B1171F4416DCA1E50F309990ACAC87D059C90000000000000000000D21E948F68A34C192F62EA79BC942DBE7CE182036415F56E34BAC982AAC4AFE9FD9", NumberStyles.AllowHexSpecifier),
                Fnv1a512(string.Empty));
        }

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector2()
        {
            Assert.AreEqual(
                BigInteger.Parse("043A992DC8FC5AD7DE493E3D696D6F85D64326EC07000000000000000011986F90C2532CAF5BE7D88291BAA894A395225328B196BD6A8A643FE12CD87B27FF88", NumberStyles.AllowHexSpecifier),
                Fnv1a512("a"));
        }

        /// <summary>
        /// Tests the string "foobar" against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector3()
        {
            Assert.AreEqual(
                BigInteger.Parse("00EC738D9C6FD969D05F0B35F6C0ED53ADCACCCD8E0000004BF99F58EE4196AFB9700E20110830FEA5396B76280E47FD022B6E81331CA1A9CED729C364BE7788", NumberStyles.AllowHexSpecifier),
                Fnv1a512("foobar"));
        }

        /// <summary>
        /// Computes the FNV-1a 512-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 512-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static BigInteger Fnv1a512(string data)
        {
            using (HashAlgorithm alg = new Fnv1a512())
            {
                return new BigInteger(alg.ComputeHash(Encoding.UTF8.GetBytes(data)));
            }
        }
    }
}
