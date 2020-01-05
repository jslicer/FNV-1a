// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Extensions.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides extension methods for generating test vectors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.Numerics;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    using Fnv1a;

    using static System.BitConverter;
    using static System.Environment;
    using static System.Globalization.CultureInfo;
    using static System.Globalization.NumberStyles;
    using static System.Numerics.BigInteger;
    using static System.Text.Encoding;

    /// <summary>
    /// Provides extension methods for generating test vectors.
    /// </summary>
    internal static class Extensions
    {
        /// <summary>
        /// The bottom 64 bytes.
        /// </summary>
        private static readonly BigInteger _Bottom64Bytes = Parse(
            "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
            AllowHexSpecifier,
            InvariantCulture);

        /// <summary>
        /// The third 64 bytes.
        /// </summary>
        private static readonly BigInteger _Third64Bytes = Parse(
            "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF0000000000000000000000000000000000000000000000000000000000000000",
            AllowHexSpecifier,
            InvariantCulture);

        /// <summary>
        /// The second 64 bytes.
        /// </summary>
        private static readonly BigInteger _Second64Bytes = Parse(
            "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000",
            AllowHexSpecifier,
            InvariantCulture);

        /// <summary>
        /// Tests the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The test result string.</returns>
        public static string Test(this string data) => "Test:" + NewLine
            + data + " 32: " + data.Fnv1a32s() + NewLine
            + data + " 64: " + data.Fnv1a64s() + NewLine
            + data + " 128: " + data.Fnv1a128s() + NewLine
            + data + " 256: " + data.Fnv1a256s() + NewLine
            + data + " 512: " + data.Fnv1a512s() + NewLine
            + data + " 1024: " + data.Fnv1a1024s() + NewLine;

        /// <summary>
        /// Asynchronously tests the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the test result string.</returns>
        public static async Task<string> TestAsync(this string data) => "Test:" + NewLine
            + data + " 32: " + await data.Fnv1a32sAsync().ConfigureAwait(false) + NewLine
            + data + " 64: " + await data.Fnv1a64sAsync().ConfigureAwait(false) + NewLine
            + data + " 128: " + await data.Fnv1a128sAsync().ConfigureAwait(false) + NewLine
            + data + " 256: " + await data.Fnv1a256sAsync().ConfigureAwait(false) + NewLine
            + data + " 512: " + await data.Fnv1a512sAsync().ConfigureAwait(false) + NewLine
            + data + " 1024: " + await data.Fnv1a1024sAsync().ConfigureAwait(false) + NewLine;

        /// <summary>
        /// Tests the specified data adding a trailing NULL byte.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The test result string.</returns>
        public static string Test0(this string data)
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
        /// Asynchronously tests the specified data adding a trailing NULL byte.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the test result string.</returns>
        public static async Task<string> Test0Async(this string data)
        {
            string newData = data + '\0';
            string printData = await data.PrintAsync().ConfigureAwait(false);

            return "Test0:" + NewLine
                + printData + " 32: " + await newData.Fnv1a32sAsync().ConfigureAwait(false) + NewLine
                + printData + " 64: " + await newData.Fnv1a64sAsync().ConfigureAwait(false) + NewLine
                + printData + " 128: " + await newData.Fnv1a128sAsync().ConfigureAwait(false) + NewLine
                + printData + " 256: " + await newData.Fnv1a256sAsync().ConfigureAwait(false) + NewLine
                + printData + " 512: " + await newData.Fnv1a512sAsync().ConfigureAwait(false) + NewLine
                + printData + " 1024: " + await newData.Fnv1a1024sAsync().ConfigureAwait(false) + NewLine;
        }

        /// <summary>
        /// Tests the specified data repeated ten times.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The test result string.</returns>
        public static string R10(this string data)
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
        /// Asynchronously tests the specified data repeated ten times.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the test result string.</returns>
        public static async Task<string> R10Async(this string data)
        {
            StringBuilder sb = new StringBuilder(10 * data.Length);

            for (int i = 0; i < 10; i++)
            {
                sb.Append(data);
            }

            string newData = sb.ToString();
            string printData = await data.PrintAsync().ConfigureAwait(false);

            return "R10:" + NewLine
                + printData.Print() + " 32: " + await newData.Fnv1a32sAsync().ConfigureAwait(false) + NewLine
                + printData.Print() + " 64: " + await newData.Fnv1a64sAsync().ConfigureAwait(false) + NewLine
                + printData.Print() + " 128: " + await newData.Fnv1a128sAsync().ConfigureAwait(false) + NewLine
                + printData.Print() + " 256: " + await newData.Fnv1a256sAsync().ConfigureAwait(false) + NewLine
                + printData.Print() + " 512: " + await newData.Fnv1a512sAsync().ConfigureAwait(false) + NewLine
                + printData.Print() + " 1024: " + await newData.Fnv1a1024sAsync().ConfigureAwait(false) + NewLine;
        }

        /// <summary>
        /// Tests the specified data repeated five hundred times.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The test result string.</returns>
        public static string R500(this string data)
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
        /// Asynchronously tests the specified data repeated five hundred times.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the test result string.</returns>
        public static async Task<string> R500Async(this string data)
        {
            StringBuilder sb = new StringBuilder(500 * data.Length);

            for (int i = 0; i < 500; i++)
            {
                sb.Append(data);
            }

            string newData = sb.ToString();
            string printData = await data.PrintAsync().ConfigureAwait(false);

            return "R500:" + NewLine
                + await printData.PrintAsync().ConfigureAwait(false) + " 32: " + await newData.Fnv1a32sAsync().ConfigureAwait(false) + NewLine
                + await printData.PrintAsync().ConfigureAwait(false) + " 64: " + await newData.Fnv1a64sAsync().ConfigureAwait(false) + NewLine
                + await printData.PrintAsync().ConfigureAwait(false) + " 128: " + await newData.Fnv1a128sAsync().ConfigureAwait(false) + NewLine
                + await printData.PrintAsync().ConfigureAwait(false) + " 256: " + await newData.Fnv1a256sAsync().ConfigureAwait(false) + NewLine
                + await printData.PrintAsync().ConfigureAwait(false) + " 512: " + await newData.Fnv1a512sAsync().ConfigureAwait(false) + NewLine
                + await printData.PrintAsync().ConfigureAwait(false) + " 1024: " + await newData.Fnv1a1024sAsync().ConfigureAwait(false) + NewLine;
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
        /// Asynchronously returns a printable string (hex encodes any control characters).
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the printable string.</returns>
        private static async Task<string> PrintAsync(this string data)
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

            return await Task.FromResult(sb.ToString()).ConfigureAwait(false);
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
        /// Asynchronously computes the FNV-1a 32-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 32-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static async Task<string> Fnv1a32sAsync(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a32())
            {
                return await Task.FromResult("0x"
                    + ((uint)ToInt32(alg.ComputeHash(UTF8.GetBytes(data)), 0)).ToString("X8", InvariantCulture)).ConfigureAwait(false);
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
        /// Asynchronously computes the FNV-1a 64-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 64-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static async Task<string> Fnv1a64sAsync(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a64())
            {
                return await Task.FromResult("0x"
                    + ((ulong)ToInt64(alg.ComputeHash(UTF8.GetBytes(data)), 0)).ToString("X16", InvariantCulture)).ConfigureAwait(false);
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

                return "0x" + value.Substring(value.Length - 32);
            }
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 128-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 128-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static async Task<string> Fnv1a128sAsync(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a128())
            {
                string value = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)).AddZero()).ToString("X32", InvariantCulture);

                return await Task.FromResult("0x" + value.Substring(value.Length - 32)).ConfigureAwait(false);
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

                return "0x" + value.Substring(value.Length - 64);
            }
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 256-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 256-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static async Task<string> Fnv1a256sAsync(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a256())
            {
                string value = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)).AddZero()).ToString("X64", InvariantCulture);

                return await Task.FromResult("0x" + value.Substring(value.Length - 64)).ConfigureAwait(false);
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
                string value2 = (hash & _Bottom64Bytes).ToString("X64", InvariantCulture);

                return "0x" + value1.Substring(value1.Length - 64) + value2.Substring(value2.Length - 64);
            }
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 512-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 512-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static async Task<string> Fnv1a512sAsync(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a512())
            {
                BigInteger hash = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)).AddZero());
                string value1 = (hash >> 256).ToString("X64", InvariantCulture);
                string value2 = (hash & _Bottom64Bytes).ToString("X64", InvariantCulture);

                return await Task.FromResult("0x" + value1.Substring(value1.Length - 64) + value2.Substring(value2.Length - 64)).ConfigureAwait(false);
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
                string value2 = ((hash & _Second64Bytes) >> 512).ToString("X64", InvariantCulture);
                string value3 = ((hash & _Third64Bytes) >> 256).ToString("X64", InvariantCulture);
                string value4 = (hash & _Bottom64Bytes).ToString("X64", InvariantCulture);

                return "0x"
                    + value1.Substring(value1.Length - 64)
                    + value2.Substring(value2.Length - 64)
                    + value3.Substring(value3.Length - 64)
                    + value4.Substring(value4.Length - 64);
            }
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 1024-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 1024-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static async Task<string> Fnv1a1024sAsync(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a1024())
            {
                BigInteger hash = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)).AddZero());
                string value1 = (hash >> 768).ToString("X64", InvariantCulture);
                string value2 = ((hash & _Second64Bytes) >> 512).ToString("X64", InvariantCulture);
                string value3 = ((hash & _Third64Bytes) >> 256).ToString("X64", InvariantCulture);
                string value4 = (hash & _Bottom64Bytes).ToString("X64", InvariantCulture);

                return await Task.FromResult("0x"
                    + value1.Substring(value1.Length - 64)
                    + value2.Substring(value2.Length - 64)
                    + value3.Substring(value3.Length - 64)
                    + value4.Substring(value4.Length - 64)).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Adds a zero byte on to the end of the byte array.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>The new array with a zero byte on the end.</returns>
        private static byte[] AddZero(this byte[] bytes)
        {
            byte[] temp = new byte[bytes.Length + 1];

            System.Array.Copy(bytes, temp, bytes.Length);
            return temp;
        }
    }
}
