// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fnv1a1024Tests.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Tests the FNV-1a 1024-bit algorithm.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTests
{
    using System;
    using System.Globalization;
    using System.Numerics;
    using System.Security.Cryptography;

    using Fnv1a;

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
    //// ReSharper disable once InconsistentNaming
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable S101 // Types should be named in PascalCase
    public sealed class Fnv1a1024Tests : IDisposable
#pragma warning restore IDE0079 // Remove unnecessary suppression
#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning restore S101 // Types should be named in PascalCase
    {
#pragma warning restore IDE0079 // Remove unnecessary suppression
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
        public void Initialize() => this._alg = new Fnv1a1024();

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
            Parse("0000000000000000005F7A76758ECC4D32E56D5A591028B74B29FC4223FDADA16C3BF34EDA3674DA9A21D9000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004C6D7EB6E73802734510A555F256CC005AE556BDE8CC9C6A93B21AFF4B16C71EE90B3", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a1024(string.Empty));

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
            Parse("0000000000000000005F7A76758ECC4D32E56D5A591028B74B29FC4223FDADA16C3BF34EDA3674DA9A21D9000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004C6D7EB6E73802734510A555F256CC005AE556BDE8CC9C6A93B21AFF4B16C71EE90B3", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a1024Try(string.Empty));

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
            Parse("000000000000000098D7C19FBCE653DF221B9F717D3490FF95CA87FDAEF30D1B823372F85B24A372F50E570000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000007685CD81A491DBCCC21AD06648D09A5C8CF5A78482054E91470B33DDE77252CAEF695AA", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a1024("a"));

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
            Parse("000000000000000098D7C19FBCE653DF221B9F717D3490FF95CA87FDAEF30D1B823372F85B24A372F50E570000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000007685CD81A491DBCCC21AD06648D09A5C8CF5A78482054E91470B33DDE77252CAEF695AA", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a1024Try("a"));

        /// <summary>
        /// Tests the string "foobar" against the known vector result.
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
            Parse("00000631175FA7AE643AD08723D312C9FD024ADB91F77F6B19587197A22BCDF23727166C4572D0B985D5AE00000000000000000000000000000000000000000000000000000000000000000000000000000000000000004270D11EF418EF08B8A49E1E825E547EB39937F819222F3B7FC92A0E4707900888847A554BACEC98B0", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a1024("foobar"));

        /// <summary>
        /// Tests the string "foobar" against the known vector result.
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
            Parse("00000631175FA7AE643AD08723D312C9FD024ADB91F77F6B19587197A22BCDF23727166C4572D0B985D5AE00000000000000000000000000000000000000000000000000000000000000000000000000000000000000004270D11EF418EF08B8A49E1E825E547EB39937F819222F3B7FC92A0E4707900888847A554BACEC98B0", AllowHexSpecifier, InvariantCulture),
            this.Fnv1a1024Try("foobar"));

        /// <summary>
        /// Tests the alternate prime and zero offset.
        /// </summary>
        /// <exception cref="ArgumentException">style is not a
        /// <see cref="NumberStyles" /> value.   -or-  style includes the
        /// <see cref="AllowHexSpecifier" /> or <see cref="HexNumber" /> flag along with another
        /// value.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The offset basis must be non-zero.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="FormatException">value does not comply with the input pattern specified by
        /// style.</exception>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAlternatePrimeAndZeroOffset()
        {
            using Fnv1a1024 _ = new (
                Parse("000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000018D", AllowHexSpecifier, InvariantCulture),
                BigInteger.Zero);
        }

        /// <summary>
        /// Tests the alternate prime and non-zero offset.
        /// </summary>
        ////[TestMethod]
        public void TestAlternatePrimeAndOffset()
        {
            // TODO: implement the test.
        }

        /// <summary>
        /// Tests the alternate prime and non-zero offset.
        /// </summary>
        ////[TestMethod]
        //// ReSharper disable once TooManyDeclarations
        public void TestAlternatePrimeAndOffsetTry()
        {
            // TODO: implement the test.
        }

        /// <summary>
        /// Computes the FNV-1a 1024-bit hash for the specified data using
        /// <see cref="HashAlgorithm.ComputeHash(byte[])" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private BigInteger Fnv1a1024(in string data)
        {
            AreEqual(1024, this._alg.HashSize);
            return new (this._alg.ComputeHash(UTF8.GetBytes(data)).AddZero());
        }

        /// <summary>
        /// Computes the FNV-1a 1024-bit hash for the specified data using <see cref="HashAlgorithm.TryComputeHash" />.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
        /// <exception cref="AssertFailedException">Thrown if expected is not equal to actual.</exception>
        //// ReSharper disable once InconsistentNaming
        private BigInteger Fnv1a1024Try(in string data)
        {
            AreEqual(1024, this._alg.HashSize);

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
            return new (destination);
        }
    }
}
