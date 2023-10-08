// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a256Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Tests the FNV-1a 256-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTests
{
    using System;
    using System.Globalization;
    using System.Numerics;
    using System.Security.Cryptography;

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
    //// ReSharper disable once InconsistentNaming
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a256Tests : IDisposable
#pragma warning restore S101 // Types should be named in PascalCase
#pragma warning restore IDE0079 // Remove unnecessary suppression
    {
        /// <summary>
        /// The hash algorithm being tested.
        /// </summary>
        private HashAlgorithm _alg;

        /// <summary>
        /// The method to run before each test.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
        /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
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
        /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
        /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector1() => AreEqual(
            Parse("DD268DBCAAC550362D98C384C4E576CCC8B1536847B6BBB31023B4C8CAEE0535", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256(string.Empty));

        /// <summary>
        /// Tests the empty string against the known vector result.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
        /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector1Try() => AreEqual(
            Parse("DD268DBCAAC550362D98C384C4E576CCC8B1536847B6BBB31023B4C8CAEE0535", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256Try(string.Empty));

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
        /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector2() => AreEqual(
            Parse("63323FB0F35303EC28DC751D0A33BDFA4DE6A99B7266494F6183B2716811637C", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256("a"));

        /// <summary>
        /// Tests the string "a" against the known vector result.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
        /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector2Try() => AreEqual(
            Parse("63323FB0F35303EC28DC751D0A33BDFA4DE6A99B7266494F6183B2716811637C", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256Try("a"));

        /// <summary>
        /// Tests the string against the known vector result.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
        /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector3() => AreEqual(
            Parse("B055EA2F306CADAD4F0F81C02D3889DC32453DAD5AE35B753BA1A91084AF3428", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256("foobar"));

        /// <summary>
        /// Tests the string against the known vector result.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a <see cref="NumberStyles" /> value.   -or-  style
        /// includes the <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        [TestMethod]
        //// ReSharper disable once InconsistentNaming
        public void TestVector3Try() => AreEqual(
            Parse("B055EA2F306CADAD4F0F81C02D3889DC32453DAD5AE35B753BA1A91084AF3428", AllowHexSpecifier, InvariantCulture).ToString("X64", InvariantCulture),
            this.Fnv1a256Try("foobar"));

        /// <summary>
        /// Computes the FNV-1a 256-bit hash for the specified data using
        /// <see cref="HashAlgorithm.ComputeHash(byte[])" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private string Fnv1a256(in string data)
        {
            AreEqual(256, this._alg.HashSize);

            string value = new BigInteger(this._alg.ComputeHash(UTF8.GetBytes(data)).AddZero())
                .ToString("X64", InvariantCulture);

            return value?[^64..];
        }

        /// <summary>
        /// Computes the FNV-1a 256-bit hash for the specified data using <see cref="HashAlgorithm.TryComputeHash" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private string Fnv1a256Try(in string data)
        {
            AreEqual(256, this._alg.HashSize);

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

            string value = new BigInteger(destination).ToString("X64", InvariantCulture);

            return value?[^64..];
        }
    }
}
