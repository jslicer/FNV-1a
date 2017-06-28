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
    using System.Numerics;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using static System.Globalization.CultureInfo;
    using static System.Globalization.NumberStyles;
    using static System.Numerics.BigInteger;
    using static System.Text.Encoding;

    using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

    /// <summary>
    /// Tests the FNV-1a 512-bit algorithm.
    /// </summary>
    [TestClass]
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a512Tests : System.IDisposable
    {
        /// <summary>
        /// The hash algorithm being tested.
        /// </summary>
        private System.Security.Cryptography.HashAlgorithm _Alg;

        /// <summary>
        /// The method to run before each test.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            this._Alg = new Fnv1a.Fnv1a512();
        }

        /// <summary>
        /// The method to run after each test.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            this.Dispose();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this._Alg.Dispose();
        }

        /// <summary>
        /// Tests the empty string against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector1()
        {
            AreEqual(
                Parse("0B86DB0B1171F4416DCA1E50F309990ACAC87D059C90000000000000000000D21E948F68A34C192F62EA79BC942DBE7CE182036415F56E34BAC982AAC4AFE9FD9", AllowHexSpecifier, InvariantCulture),
                this.Fnv1a512(string.Empty));
        }

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector2()
        {
            AreEqual(
                Parse("043A992DC8FC5AD7DE493E3D696D6F85D64326EC07000000000000000011986F90C2532CAF5BE7D88291BAA894A395225328B196BD6A8A643FE12CD87B27FF88", AllowHexSpecifier, InvariantCulture),
                this.Fnv1a512("a"));
        }

        /// <summary>
        /// Tests the string against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector3()
        {
            AreEqual(
                Parse("00EC738D9C6FD969D05F0B35F6C0ED53ADCACCCD8E0000004BF99F58EE4196AFB9700E20110830FEA5396B76280E47FD022B6E81331CA1A9CED729C364BE7788", AllowHexSpecifier, InvariantCulture),
                this.Fnv1a512("foobar"));
        }

        /// <summary>
        /// Computes the FNV-1a 512-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 512-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private BigInteger Fnv1a512(string data)
        {
            AreEqual(512, this._Alg.HashSize);
            return new BigInteger(this._Alg.ComputeHash(UTF8.GetBytes(data)));
        }
    }
}
