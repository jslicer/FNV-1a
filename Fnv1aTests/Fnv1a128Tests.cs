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

    /// <inheritdoc />
    /// <summary>
    /// Tests the FNV-1a 128-bit algorithm.
    /// </summary>
    [TestClass]
    // ReSharper disable once InconsistentNaming
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a128Tests : System.IDisposable
#pragma warning restore S101 // Types should be named in PascalCase
    {
        /// <summary>
        /// The hash algorithm being tested.
        /// </summary>
        private System.Security.Cryptography.HashAlgorithm _alg;

        /// <summary>
        /// The method to run before each test.
        /// </summary>
        [TestInitialize]
        public void Initialize() => this._alg = new Fnv1a.Fnv1a128();

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
        /// <exception cref="System.ArgumentException">style is not a
        /// <see cref="System.Globalization.NumberStyles"></see> value.   -or-  style includes the
        /// <see cref="AllowHexSpecifier"></see> or <see cref="HexNumber"></see> flag along with another
        /// value.</exception>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector1() => AreEqual(
            Parse("6C62272E07BB014262B821756295C58D", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a128(string.Empty));

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        /// <exception cref="System.ArgumentException">style is not a
        /// <see cref="System.Globalization.NumberStyles"></see> value.   -or-  style includes the
        /// <see cref="AllowHexSpecifier"></see> or <see cref="HexNumber"></see> flag along with another
        /// value.</exception>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector2() => AreEqual(
            Parse("0D228CB696F1A8CAF78912B704E4A8964", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a128("a"));

        /// <summary>
        /// Tests the string against the known vector result.
        /// </summary>
        /// <exception cref="System.ArgumentException">style is not a
        /// <see cref="System.Globalization.NumberStyles"></see> value.   -or-  style includes the
        /// <see cref="AllowHexSpecifier"></see> or <see cref="HexNumber"></see> flag along with another
        /// value.</exception>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        // ReSharper disable once InconsistentNaming
        public void TestVector3() => AreEqual(
            Parse("343E1662793C64BF6F0D3597BA446F18", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a128("foobar"));

        /// <summary>
        /// Computes the FNV-1a 128-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 128-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        // ReSharper disable once InconsistentNaming
        private BigInteger Fnv1a128(string data)
        {
            AreEqual(128, this._alg.HashSize);
            return new BigInteger(this._alg.ComputeHash(UTF8.GetBytes(data)).AddZero());
        }
    }
}
