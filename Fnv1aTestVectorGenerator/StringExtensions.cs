// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Extension methods for strings in order to generate test vectors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.Numerics;
    using System.Security.Cryptography;
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
        /// Tests the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The test result string.</returns>
        internal static string Test(this string data) => "Test:" + NewLine
            + data + " 32: " + data.Fnv1a32s() + NewLine
            + data + " 64: " + data.Fnv1a64s() + NewLine
            + data + " 128: " + data.Fnv1a128s() + NewLine
            + data + " 256: " + data.Fnv1a256s() + NewLine
            + data + " 512: " + data.Fnv1a512s() + NewLine
            + data + " 1024: " + data.Fnv1a1024s() + NewLine;

        /// <summary>
        /// Tests the specified data adding a trailing NULL byte.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The test result string.</returns>
        internal static string Test0(this string data)
        {
            string newData = data + '\0';
            string printData = data.Print();

            return "Test0:" + NewLine
                + printData + " 32: " + newData.Fnv1a32s() + NewLine
                + printData + " 64: " + newData.Fnv1a64s() + NewLine
                + printData + " 128: " + newData.Fnv1a128s() + NewLine
                + printData + " 256: " + newData.Fnv1a256s() + NewLine
                + printData + " 512: " + newData.Fnv1a512s() + NewLine
                + printData + " 1024: " + newData.Fnv1a1024s() + NewLine;
        }

        /// <summary>
        /// Tests the specified data repeated ten times.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The test result string.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="StringBuilder.MaxCapacity"></see>.</exception>
        // ReSharper disable once MethodNameNotMeaningful
        internal static string R10(this string data)
        {
            StringBuilder sb = new StringBuilder(10 * data.Length);

            for (int i = 0; i < 10; i++)
            {
                sb.Append(data);
            }

            string newData = sb.ToString();
            string printData = data.Print();

            return "R10:" + NewLine
                + printData.Print() + " 32: " + newData.Fnv1a32s() + NewLine
                + printData.Print() + " 64: " + newData.Fnv1a64s() + NewLine
                + printData.Print() + " 128: " + newData.Fnv1a128s() + NewLine
                + printData.Print() + " 256: " + newData.Fnv1a256s() + NewLine
                + printData.Print() + " 512: " + newData.Fnv1a512s() + NewLine
                + printData.Print() + " 1024: " + newData.Fnv1a1024s() + NewLine;
        }

        /// <summary>
        /// Tests the specified data repeated five hundred times.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The test result string.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="StringBuilder.MaxCapacity"></see>.</exception>
        internal static string R500(this string data)
        {
            StringBuilder sb = new StringBuilder(500 * data.Length);

            for (int i = 0; i < 500; i++)
            {
                sb.Append(data);
            }

            string newData = sb.ToString();
            string printData = data.Print();

            return "R500:" + NewLine
                + printData.Print() + " 32: " + newData.Fnv1a32s() + NewLine
                + printData.Print() + " 64: " + newData.Fnv1a64s() + NewLine
                + printData.Print() + " 128: " + newData.Fnv1a128s() + NewLine
                + printData.Print() + " 256: " + newData.Fnv1a256s() + NewLine
                + printData.Print() + " 512: " + newData.Fnv1a512s() + NewLine
                + printData.Print() + " 1024: " + newData.Fnv1a1024s() + NewLine;
        }

        /// <summary>
        /// Returns a printable string (hex encodes any control characters).
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The printable string.</returns>
        private static string Print(this string data)
        {
            bool controlCharacter = false;
            StringBuilder sb = new StringBuilder(data.Length);

            foreach (char c in data)
            {
                if (controlCharacter || char.IsControl(c))
                {
                    sb.AppendFormat(InvariantCulture, "\\x{0:x2}", (uint)c);
                    controlCharacter = true;
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Computes the FNV-1a 32-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 32-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static string Fnv1a32s(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a32())
            {
                return "0x"
                    + ((uint)ToInt32(alg.ComputeHash(UTF8.GetBytes(data)), 0)).ToString("X8", InvariantCulture);
            }
        }

        /// <summary>
        /// Computes the FNV-1a 64-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 64-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static string Fnv1a64s(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a64())
            {
                return "0x"
                    + ((ulong)ToInt64(alg.ComputeHash(UTF8.GetBytes(data)), 0)).ToString("X16", InvariantCulture);
            }
        }

        /// <summary>
        /// Computes the FNV-1a 128-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 128-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static string Fnv1a128s(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a128())
            {
                string value = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)).AddZero()).ToString("X32", InvariantCulture);

                return "0x" + value?.Substring(value.Length - 32);
            }
        }

        /// <summary>
        /// Computes the FNV-1a 256-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static string Fnv1a256s(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a256())
            {
                string value = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)).AddZero()).ToString("X64", InvariantCulture);

                return "0x" + value?.Substring(value.Length - 64);
            }
        }

        /// <summary>
        /// Computes the FNV-1a 512-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 512-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static string Fnv1a512s(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a512())
            {
                BigInteger hash = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)).AddZero());
                string value1 = (hash >> 256).ToString("X64", InvariantCulture);
                string value2 = (hash & Bitmasks.Bottom64Bytes).ToString("X64", InvariantCulture);

                return "0x" + value1?.Substring(value1.Length - 64) + value2?.Substring(value2.Length - 64);
            }
        }

        /// <summary>
        /// Computes the FNV-1a 1024-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static string Fnv1a1024s(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a1024())
            {
                BigInteger hash = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)).AddZero());
                string value1 = (hash >> 768).ToString("X64", InvariantCulture);
                //// ReSharper disable ComplexConditionExpression
                string value2 = ((hash & Bitmasks.Second64Bytes) >> 512).ToString("X64", InvariantCulture);
                string value3 = ((hash & Bitmasks.Third64Bytes) >> 256).ToString("X64", InvariantCulture);
                //// ReSharper enable ComplexConditionExpression
                string value4 = (hash & Bitmasks.Bottom64Bytes).ToString("X64", InvariantCulture);

                return "0x"
                    + value1?.Substring(value1.Length - 64)
                    + value2?.Substring(value2.Length - 64)
                    + value3?.Substring(value3.Length - 64)
                    + value4?.Substring(value4.Length - 64);
            }
        }
    }
}
