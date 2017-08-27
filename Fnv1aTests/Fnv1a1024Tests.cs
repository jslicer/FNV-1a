// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a1024Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Tests the FNV-1a 1024-bit algorithm.
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

    /// <inheritdoc />
    /// <summary>
    /// Tests the FNV-1a 1024-bit algorithm.
    /// </summary>
    [TestClass]
    // ReSharper disable once InconsistentNaming
    public sealed class Fnv1a1024Tests : System.IDisposable
    {
        /// <summary>
        /// The hash algorithm being tested.
        /// </summary>
        private System.Security.Cryptography.HashAlgorithm _Alg;

        /// <summary>
        /// The method to run before each test.
        /// </summary>
        [TestInitialize]
        public void Initialize() => this._Alg = new Fnv1a.Fnv1a1024();

        /// <summary>
        /// The method to run after each test.
        /// </summary>
        [TestCleanup]
        public void Cleanup() => this.Dispose();

        /// <inheritdoc />
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose() => this._Alg.Dispose();

        /// <summary>
        /// Tests the empty string against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector1() => AreEqual(
            Parse("0000000000000000005F7A76758ECC4D32E56D5A591028B74B29FC4223FDADA16C3BF34EDA3674DA9A21D9000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004C6D7EB6E73802734510A555F256CC005AE556BDE8CC9C6A93B21AFF4B16C71EE90B3", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a1024(string.Empty));

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector2() => AreEqual(
            Parse("000000000000000098D7C19FBCE653DF221B9F717D3490FF95CA87FDAEF30D1B823372F85B24A372F50E570000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000007685CD81A491DBCCC21AD06648D09A5C8CF5A78482054E91470B33DDE77252CAEF695AA", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a1024("a"));

        /// <summary>
        /// Tests the string "against the known vector result.
        /// </summary>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector3() => AreEqual(
            Parse("00000631175FA7AE643AD08723D312C9FD024ADB91F77F6B19587197A22BCDF23727166C4572D0B985D5AE00000000000000000000000000000000000000000000000000000000000000000000000000000000000000004270D11EF418EF08B8A49E1E825E547EB39937F819222F3B7FC92A0E4707900888847A554BACEC98B0", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a1024("foobar"));

        /// <summary>
        /// Computes the FNV-1a 1024-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private BigInteger Fnv1a1024(string data)
        {
            AreEqual(1024, this._Alg.HashSize);
            return new BigInteger(this._Alg.ComputeHash(UTF8.GetBytes(data)));
        }
    }
}
