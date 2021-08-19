// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a256Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Tests the FNV-1a 256-bit algorithm.
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
    /// Tests the FNV-1a 256-bit algorithm.
    /// </summary>
    [TestClass]
    // ReSharper disable once InconsistentNaming
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a256Tests : System.IDisposable
#pragma warning restore S101 // Types should be named in PascalCase
#pragma warning restore IDE0079 // Remove unnecessary suppression
    {
        /// <summary>
        /// The hash algorithm being tested.
        /// </summary>
        private System.Security.Cryptography.HashAlgorithm _alg;

        /// <summary>
        /// The method to run before each test.
        /// </summary>
        [TestInitialize]
        public void Initialize() => this._alg = new Fnv1a.Fnv1a256();

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
            Parse("DD268DBCAAC550362D98C384C4E576CCC8B1536847B6BBB31023B4C8CAEE0535", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256(string.Empty));

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
            Parse("63323FB0F35303EC28DC751D0A33BDFA4DE6A99B7266494F6183B2716811637C", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256("a"));

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
            Parse("B055EA2F306CADAD4F0F81C02D3889DC32453DAD5AE35B753BA1A91084AF3428", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256("foobar"));

        /// <summary>
        /// Computes the FNV-1a 256-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        // ReSharper disable once InconsistentNaming
        private string Fnv1a256(string data)
        {
            AreEqual(256, this._alg.HashSize);

            string value = new BigInteger(this._alg.ComputeHash(UTF8.GetBytes(data)).AddZero()).ToString("X64", InvariantCulture);

            return value[^64..];
        }
    }
}
