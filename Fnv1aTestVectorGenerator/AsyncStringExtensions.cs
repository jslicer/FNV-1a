// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AsyncStringExtensions.cs" company="Copyright © Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2020
// </copyright>
// <summary>
//   Asynchronous extension methods for strings in order to generate test vectors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System;
    using System.Numerics;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    using Fnv1a;

    using static System.BitConverter;
    using static System.Environment;
    using static System.Globalization.CultureInfo;
    using static System.Text.Encoding;

    /// <summary>
    /// Asynchronous extension methods for strings in order to generate test vectors.
    /// </summary>
    internal static class AsyncStringExtensions
    {
        /// <summary>
        /// Asynchronously tests the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the test result string.</returns>
        internal static async Task<string> TestAsync(this string data) => "Test:" + NewLine
            + data + " 32: " + await data.Fnv1a32sAsync().ConfigureAwait(false) + NewLine
            + data + " 64: " + await data.Fnv1a64sAsync().ConfigureAwait(false) + NewLine
            + data + " 128: " + await data.Fnv1a128sAsync().ConfigureAwait(false) + NewLine
            + data + " 256: " + await data.Fnv1a256sAsync().ConfigureAwait(false) + NewLine
            + data + " 512: " + await data.Fnv1a512sAsync().ConfigureAwait(false) + NewLine
            + data + " 1024: " + await data.Fnv1a1024sAsync().ConfigureAwait(false) + NewLine;

        /// <summary>
        /// Asynchronously tests the specified data adding a trailing NULL byte.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the test result string.</returns>
        internal static async Task<string> Test0Async(this string data)
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
        /// Asynchronously tests the specified data repeated ten times.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the test result string.</returns>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="StringBuilder.MaxCapacity"></see>.</exception>
        internal static async Task<string> R10Async(this string data)
        {
            StringBuilder sb = new StringBuilder(10 * data.Length);

            for (int i = 0; i < 10; i++)
            {
                sb.Append(data);
            }

            string newData = sb.ToString();
            string printData = await data.PrintAsync().ConfigureAwait(false);

            return "R10:" + NewLine
                //// ReSharper disable AsyncConverter.CanBeUseAsyncMethodHighlighting
                + await printData.PrintAsync().ConfigureAwait(false) + " 32: " + await newData.Fnv1a32sAsync().ConfigureAwait(false) + NewLine
                + await printData.PrintAsync().ConfigureAwait(false) + " 64: " + await newData.Fnv1a64sAsync().ConfigureAwait(false) + NewLine
                + await printData.PrintAsync().ConfigureAwait(false) + " 128: " + await newData.Fnv1a128sAsync().ConfigureAwait(false) + NewLine
                + await printData.PrintAsync().ConfigureAwait(false) + " 256: " + await newData.Fnv1a256sAsync().ConfigureAwait(false) + NewLine
                + await printData.PrintAsync().ConfigureAwait(false) + " 512: " + await newData.Fnv1a512sAsync().ConfigureAwait(false) + NewLine
                + await printData.PrintAsync().ConfigureAwait(false) + " 1024: " + await newData.Fnv1a1024sAsync().ConfigureAwait(false) + NewLine;
                //// ReSharper enable AsyncConverter.CanBeUseAsyncMethodHighlighting
        }

        /// <summary>
        /// Asynchronously tests the specified data repeated five hundred times.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the test result string.</returns>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="StringBuilder.MaxCapacity"></see>.</exception>
        internal static async Task<string> R500Async(this string data)
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
        /// Asynchronously returns a printable string (hex encodes any control characters).
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the printable string.</returns>
        // ReSharper disable once RedundantAwait
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

            // ReSharper disable once AsyncConverter.AsyncAwaitMayBeElidedHighlighting
            //// ReSharper disable RedundantAwait
            return await Task.FromResult(sb.ToString()).ConfigureAwait(false);
            //// ReSharper enable RedundantAwait
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 32-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 32-bit hash of the specified
        /// data.</returns>
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
        /// Asynchronously computes the FNV-1a 64-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 64-bit hash of the specified
        /// data.</returns>
        // ReSharper disable once InconsistentNaming
        private static async Task<string> Fnv1a64sAsync(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a64())
            {
                return await Task.FromResult(string.Concat(
                   "0x",
                   ((ulong)ToInt64(alg.ComputeHash(UTF8.GetBytes(data)), 0)).ToString("X16", InvariantCulture))).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 128-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 128-bit hash of the specified
        /// data.</returns>
        // ReSharper disable once InconsistentNaming
        private static async Task<string> Fnv1a128sAsync(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a128())
            {
                string value =
                    new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)).AddZero()).ToString("X32", InvariantCulture);

                return await Task.FromResult(value is null ? null : string.Concat(
                    "0x",
                    value.AsSpan(value.Length - 32))).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 256-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 256-bit hash of the specified
        /// data.</returns>
        // ReSharper disable once InconsistentNaming
        private static async Task<string> Fnv1a256sAsync(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a256())
            {
                string value =
                    new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)).AddZero()).ToString("X64", InvariantCulture);

                return await Task.FromResult(value is null ? null : string.Concat(
                    "0x",
                    value.AsSpan(value.Length - 64))).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 512-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 512-bit hash of the specified
        /// data.</returns>
        // ReSharper disable once InconsistentNaming
        private static async Task<string> Fnv1a512sAsync(this string data)
        {
            using (HashAlgorithm alg = new Fnv1a512())
            {
                BigInteger hash = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)).AddZero());
                string value1 = (hash >> 256).ToString("X64", InvariantCulture);
                string value2 = (hash & Bitmasks.Bottom64Bytes).ToString("X64", InvariantCulture);

                return await Task.FromResult(value1 is null || value2 is null ? null : string.Concat(
                    "0x",
                    value1.AsSpan(value1.Length - 64),
                    value2.AsSpan(value2.Length - 64))).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Asynchronously computes the FNV-1a 1024-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}"/> containing the FNV-1a 1024-bit hash of the specified
        /// data.</returns>
        // ReSharper disable once InconsistentNaming
        // ReSharper disable once TooManyDeclarations
        private static async Task<string> Fnv1a1024sAsync(this string data)
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
                string allValues = value1 is null || value2 is null || value3 is null || value4 is null ? null : string.Concat(
                    value1.AsSpan(value1.Length - 64),
                    value2.AsSpan(value2.Length - 64),
                    value3.AsSpan(value3.Length - 64),
                    value4.AsSpan(value4.Length - 64));

                return await Task.FromResult("0x" + allValues).ConfigureAwait(false);
            }
        }
    }
}
