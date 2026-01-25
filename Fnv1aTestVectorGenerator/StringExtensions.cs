// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Extension methods for strings in order to generate test vectors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator;

using System;
using System.IO.Hashing;
using System.Numerics;
using System.Text;

using Fnv1a;

using static System.BitConverter;
using static System.Environment;
using static System.Globalization.CultureInfo;
using static System.Text.Encoding;

/// <summary>
/// Extension methods for strings in order to generate test vectors.
/// </summary>
internal static class StringExtensions
{
    /// <summary>
    /// The thirty-two string.
    /// </summary>
    private const string ThirtyTwo = " 32: ";

    /// <summary>
    /// The sixty-four string.
    /// </summary>
    private const string SixtyFour = " 64: ";

    /// <summary>
    /// The one hundred twenty-eight string.
    /// </summary>
    private const string OneHundredTwentyEight = " 128: ";

    /// <summary>
    /// The two hundred fifty-six string.
    /// </summary>
    private const string TwoHundredFiftySix = " 256: ";

    /// <summary>
    /// The five hundred twelve string.
    /// </summary>
    private const string FiveHundredTwelve = " 512: ";

    /// <summary>
    /// The one thousand twenty-four string.
    /// </summary>
    private const string OneThousandTwentyFour = " 1024: ";

    /// <summary>
    /// Extensions for strings to test its data.
    /// </summary>
    extension(string data)
    {
        /// <summary>
        /// Tests the specified data.
        /// </summary>
        /// <returns>The test result string.</returns>
#pragma warning disable S2325 // Make a static method.
        internal string Test() =>
#pragma warning restore S2325 // Make a static method.
            "Test:" + NewLine
            + data + ThirtyTwo + data.Fnv1a32s() + NewLine
            + data + SixtyFour + data.Fnv1a64s() + NewLine
            + data + OneHundredTwentyEight + data.Fnv1a128s() + NewLine
            + data + TwoHundredFiftySix + data.Fnv1a256s() + NewLine
            + data + FiveHundredTwelve + data.Fnv1a512s() + NewLine
            + data + OneThousandTwentyFour + data.Fnv1a1024s() + NewLine;

        /// <summary>
        /// Tests the specified data adding a trailing NULL byte.
        /// </summary>
        /// <returns>The test result string.</returns>
#pragma warning disable S2325 // Make a static method.
        internal string Test0()
#pragma warning restore S2325 // Make a static method.
        {
            string newData = data + '\0';
            string printData = data.Print();

            return "Test0:" + NewLine
                + printData + ThirtyTwo + newData.Fnv1a32s() + NewLine
                + printData + SixtyFour + newData.Fnv1a64s() + NewLine
                + printData + OneHundredTwentyEight + newData.Fnv1a128s() + NewLine
                + printData + TwoHundredFiftySix + newData.Fnv1a256s() + NewLine
                + printData + FiveHundredTwelve + newData.Fnv1a512s() + NewLine
                + printData + OneThousandTwentyFour + newData.Fnv1a1024s() + NewLine;
        }

        /// <summary>
        /// Tests the specified data repeated ten times.
        /// </summary>
        /// <returns>The test result string.</returns>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="StringBuilder.MaxCapacity"></see>.</exception>
        // ReSharper disable once MethodNameNotMeaningful
#pragma warning disable S2325 // Make a static method.
        internal string R10()
#pragma warning restore S2325 // Make a static method.
        {
            StringBuilder sb = new(10 * data.Length);

            for (int i = 0; i < 10; i++)
            {
                sb = sb.Append(data);
            }

            string newData = sb.ToString();
            string printData = data.Print();

            return "R10:" + NewLine
                + printData.Print() + ThirtyTwo + newData.Fnv1a32s() + NewLine
                + printData.Print() + SixtyFour + newData.Fnv1a64s() + NewLine
                + printData.Print() + OneHundredTwentyEight + newData.Fnv1a128s() + NewLine
                + printData.Print() + TwoHundredFiftySix + newData.Fnv1a256s() + NewLine
                + printData.Print() + FiveHundredTwelve + newData.Fnv1a512s() + NewLine
                + printData.Print() + OneThousandTwentyFour + newData.Fnv1a1024s() + NewLine;
        }

        /// <summary>
        /// Tests the specified data repeated five hundred times.
        /// </summary>
        /// <returns>The test result string.</returns>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="StringBuilder.MaxCapacity"></see>.</exception>
#pragma warning disable S2325 // Make a static method.
        internal string R500()
#pragma warning restore S2325 // Make a static method.
        {
            StringBuilder sb = new(500 * data.Length);

            for (int i = 0; i < 500; i++)
            {
                sb = sb.Append(data);
            }

            string newData = sb.ToString();
            string printData = data.Print();

            return "R500:" + NewLine
                + printData.Print() + ThirtyTwo + newData.Fnv1a32s() + NewLine
                + printData.Print() + SixtyFour + newData.Fnv1a64s() + NewLine
                + printData.Print() + OneHundredTwentyEight + newData.Fnv1a128s() + NewLine
                + printData.Print() + TwoHundredFiftySix + newData.Fnv1a256s() + NewLine
                + printData.Print() + FiveHundredTwelve + newData.Fnv1a512s() + NewLine
                + printData.Print() + OneThousandTwentyFour + newData.Fnv1a1024s() + NewLine;
        }

        /// <summary>
        /// Returns a printable string (hex encodes any control characters).
        /// </summary>
        /// <returns>The printable string.</returns>
#pragma warning disable S2325 // Make a static method.
        private string Print()
#pragma warning restore S2325 // Make a static method.
        {
            bool controlCharacter = false;
            StringBuilder sb = new(data.Length);

            foreach (char c in data)
            {
                if (controlCharacter || char.IsControl(c))
                {
                    sb = sb.Append(InvariantCulture, $"\\x{(uint)c:x2}");
                    controlCharacter = true;
                }
                else
                {
                    sb = sb.Append(c);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Computes the FNV-1a 32-bit hash for the specified data.
        /// </summary>
        /// <returns>The FNV-1a 32-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
#pragma warning disable S2325 // Make a static method.
        private string Fnv1a32s()
#pragma warning restore S2325 // Make a static method.
        {
            NonCryptographicHashAlgorithm alg = new Fnv1a32();

            // ReSharper disable once ComplexConditionExpression
            Span<byte> destination = stackalloc byte[1 + alg.HashLengthInBytes];

            data.CalculateHash(alg, destination);
            return "0x"
                   + ((uint)ToInt32(destination)).ToString("X8", InvariantCulture);
        }

        /// <summary>
        /// Computes the FNV-1a 64-bit hash for the specified data.
        /// </summary>
        /// <returns>The FNV-1a 64-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
#pragma warning disable S2325 // Make a static method.
        private string Fnv1a64s()
#pragma warning restore S2325 // Make a static method.
        {
            NonCryptographicHashAlgorithm alg = new Fnv1a64();

            // ReSharper disable once ComplexConditionExpression
            Span<byte> destination = stackalloc byte[1 + alg.HashLengthInBytes];

            data.CalculateHash(alg, destination);
            return "0x"
                   + ((ulong)ToInt64(destination)).ToString("X16", InvariantCulture);
        }

        /// <summary>
        /// Computes the FNV-1a 128-bit hash for the specified data.
        /// </summary>
        /// <returns>The FNV-1a 128-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
#pragma warning disable S2325 // Make a static method.
        private string Fnv1a128s()
#pragma warning restore S2325 // Make a static method.
        {
            NonCryptographicHashAlgorithm alg = new Fnv1a128();

            // ReSharper disable once ComplexConditionExpression
            Span<byte> destination = stackalloc byte[1 + alg.HashLengthInBytes];

            data.CalculateHash(alg, destination);

            string value = new BigInteger(destination).ToString("X32", InvariantCulture);

            return $"0x{value.AsSpan(value.Length - 32)}";
        }

        /// <summary>
        /// Computes the FNV-1a 256-bit hash for the specified data.
        /// </summary>
        /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
#pragma warning disable S2325 // Make a static method.
        private string Fnv1a256s()
#pragma warning restore S2325 // Make a static method.
        {
            NonCryptographicHashAlgorithm alg = new Fnv1a256();

            // ReSharper disable once ComplexConditionExpression
            Span<byte> destination = stackalloc byte[1 + alg.HashLengthInBytes];

            data.CalculateHash(alg, destination);

            string value = new BigInteger(destination).ToString("X64", InvariantCulture);

            return $"0x{value.AsSpan(value.Length - 64)}";
        }

        /// <summary>
        /// Computes the FNV-1a 512-bit hash for the specified data.
        /// </summary>
        /// <returns>The FNV-1a 512-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
#pragma warning disable S2325 // Make a static method.
        private string Fnv1a512s()
#pragma warning restore S2325 // Make a static method.
        {
            NonCryptographicHashAlgorithm alg = new Fnv1a512();

            // ReSharper disable once ComplexConditionExpression
            Span<byte> destination = stackalloc byte[1 + alg.HashLengthInBytes];

            data.CalculateHash(alg, destination);

            BigInteger hash = new(destination);
            string value1 = (hash >> 256).ToString("X64", InvariantCulture);
            string value2 = (hash & Bitmasks.Bottom64Bytes).ToString("X64", InvariantCulture);

            return string.Concat(
                "0x",
                value1.AsSpan(value1.Length - 64),
                value2.AsSpan(value2.Length - 64));
        }

        /// <summary>
        /// Computes the FNV-1a 1024-bit hash for the specified data.
        /// </summary>
        /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        // ReSharper disable once TooManyDeclarations
#pragma warning disable S2325 // Make a static method.
        private string Fnv1a1024s()
#pragma warning restore S2325 // Make a static method.
        {
            NonCryptographicHashAlgorithm alg = new Fnv1a1024();

            // ReSharper disable once ComplexConditionExpression
            Span<byte> destination = stackalloc byte[1 + alg.HashLengthInBytes];

            data.CalculateHash(alg, destination);

            BigInteger hash = new(destination);
            string value1 = (hash >> 768).ToString("X64", InvariantCulture);
            //// ReSharper disable ComplexConditionExpression
            string value2 = ((hash & Bitmasks.Second64Bytes) >> 512).ToString("X64", InvariantCulture);
            string value3 = ((hash & Bitmasks.Third64Bytes) >> 256).ToString("X64", InvariantCulture);
            //// ReSharper enable ComplexConditionExpression
            string value4 = (hash & Bitmasks.Bottom64Bytes).ToString("X64", InvariantCulture);
            string allValues = string.Concat(
                value1.AsSpan(value1.Length - 64),
                value2.AsSpan(value2.Length - 64),
                value3.AsSpan(value3.Length - 64),
                value4.AsSpan(value4.Length - 64));

            return "0x" + allValues;
        }

        /// <summary>
        /// Calculates the hash of the string data using the given hash algorithm and places the hash result in the
        /// specified destination.
        /// </summary>
        /// <param name="alg">The hash algorithm.</param>
        /// <param name="destination">The destination in which to place the hash result.</param>
#pragma warning disable S2325 // Make a static method.
        private void CalculateHash(NonCryptographicHashAlgorithm alg, Span<byte> destination)
#pragma warning restore S2325 // Make a static method.
        {
            int inputByteCount = UTF8.GetByteCount(data);
            Span<byte> bytes = inputByteCount < 1024
                ? stackalloc byte[inputByteCount]
                : new byte[inputByteCount];

            _ = UTF8.GetBytes(data, bytes);
            alg.Append(bytes);
            _ = alg.TryGetCurrentHash(destination, out int _);
        }
    }
}
