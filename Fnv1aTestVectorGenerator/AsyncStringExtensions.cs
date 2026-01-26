// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AsyncStringExtensions.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Asynchronous extension methods for strings in order to generate test vectors.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator;

using System;
using System.Text;
using System.Threading;
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
    /// The FNV-1A 32-bit hasher.
    /// </summary>
    private static readonly ThreadLocal<Fnv1a32> _Fnv1A32Hasher = new(static () => new());

    /// <summary>
    /// The FNV-1A 64-bit hasher.
    /// </summary>
    private static readonly ThreadLocal<Fnv1a64> _Fnv1A64Hasher = new(static () => new());

    /// <summary>
    /// The FNV-1A 128-bit hasher.
    /// </summary>
    private static readonly ThreadLocal<Fnv1a128> _Fnv1A128Hasher = new(static () => new());

    /// <summary>
    /// The FNV-1A 256-bit hasher.
    /// </summary>
    private static readonly ThreadLocal<Fnv1a256> _Fnv1A256Hasher = new(static () => new());

    /// <summary>
    /// The FNV-1A 512-bit hasher.
    /// </summary>
    private static readonly ThreadLocal<Fnv1a512> _Fnv1A512Hasher = new(static () => new());

    /// <summary>
    /// The FNV-1A 1024-bit hasher.
    /// </summary>
    private static readonly ThreadLocal<Fnv1a1024> _Fnv1A1024Hasher = new(static () => new());

    /// <summary>
    /// Asynchronous extensions for strings to test its data.
    /// </summary>
    extension(string data)
    {
        /// <summary>
        /// Asynchronously tests the specified data.
        /// </summary>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}" /> containing the test result string.</returns>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
#pragma warning disable S2325 // Make a static method.
        internal Task<string> TestAsync(CancellationToken token = default)
#pragma warning restore S2325 // Make a static method.
        {
            token.ThrowIfCancellationRequested();

            byte[] payload = UTF8.GetBytes(data);

            // ReSharper disable once ComplexConditionExpression
            string result = "Test:" + NewLine
                + data + ThirtyTwo + ComputeFnv1A32(payload) + NewLine
                + data + SixtyFour + ComputeFnv1A64(payload) + NewLine
                + data + OneHundredTwentyEight + ComputeFnv1A128(payload) + NewLine
                + data + TwoHundredFiftySix + ComputeFnv1A256(payload) + NewLine
                + data + FiveHundredTwelve + ComputeFnv1A512(payload) + NewLine
                + data + OneThousandTwentyFour + ComputeFnv1A1024(payload) + NewLine;

            return Task.FromResult(result);
        }

        /// <summary>
        /// Asynchronously tests the specified data adding a trailing NULL byte.
        /// </summary>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}" /> containing the test result string.</returns>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
#pragma warning disable S2325 // Make a static method.
        internal async Task<string> Test0Async(CancellationToken token = default)
#pragma warning restore S2325 // Make a static method.
        {
            string newData = data + '\0';
            byte[] payload = UTF8.GetBytes(newData);
            string printData = await data.PrintAsync(token).ConfigureAwait(false);

            return "Test0:" + NewLine
                + printData + ThirtyTwo + ComputeFnv1A32(payload) + NewLine
                + printData + SixtyFour + ComputeFnv1A64(payload) + NewLine
                + printData + OneHundredTwentyEight + ComputeFnv1A128(payload) + NewLine
                + printData + TwoHundredFiftySix + ComputeFnv1A256(payload) + NewLine
                + printData + FiveHundredTwelve + ComputeFnv1A512(payload) + NewLine
                + printData + OneThousandTwentyFour + ComputeFnv1A1024(payload) + NewLine;
        }

        /// <summary>
        /// Asynchronously tests the specified data repeated ten times.
        /// </summary>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}" /> containing the test result string.</returns>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="StringBuilder.MaxCapacity" />.</exception>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
#pragma warning disable S2325 // Make a static method.
        internal async Task<string> R10Async(CancellationToken token = default)
#pragma warning restore S2325 // Make a static method.
        {
            StringBuilder sb = new(10 * data.Length);

            for (int i = 0; i < 10; i++)
            {
                sb.Append(data);
            }

            string newData = sb.ToString();
            byte[] payload = UTF8.GetBytes(newData);
            string printable = await newData.PrintAsync(token).ConfigureAwait(false);

            return "R10:" + NewLine
                + printable + ThirtyTwo + ComputeFnv1A32(payload) + NewLine
                + printable + SixtyFour + ComputeFnv1A64(payload) + NewLine
                + printable + OneHundredTwentyEight + ComputeFnv1A128(payload) + NewLine
                + printable + TwoHundredFiftySix + ComputeFnv1A256(payload) + NewLine
                + printable + FiveHundredTwelve + ComputeFnv1A512(payload) + NewLine
                + printable + OneThousandTwentyFour + ComputeFnv1A1024(payload) + NewLine;
        }

        /// <summary>
        /// Asynchronously tests the specified data repeated five hundred times.
        /// </summary>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}" /> containing the test result string.</returns>
        /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
        /// <see cref="StringBuilder.MaxCapacity" />.</exception>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
#pragma warning disable S2325 // Make a static method.
        internal async Task<string> R500Async(CancellationToken token = default)
#pragma warning restore S2325 // Make a static method.
        {
            StringBuilder sb = new(500 * data.Length);

            for (int i = 0; i < 500; i++)
            {
                sb.Append(data);
            }

            string newData = sb.ToString();
            byte[] payload = UTF8.GetBytes(newData);
            string printable = await newData.PrintAsync(token).ConfigureAwait(false);

            return "R500:" + NewLine
                + printable + ThirtyTwo + ComputeFnv1A32(payload) + NewLine
                + printable + SixtyFour + ComputeFnv1A64(payload) + NewLine
                + printable + OneHundredTwentyEight + ComputeFnv1A128(payload) + NewLine
                + printable + TwoHundredFiftySix + ComputeFnv1A256(payload) + NewLine
                + printable + FiveHundredTwelve + ComputeFnv1A512(payload) + NewLine
                + printable + OneThousandTwentyFour + ComputeFnv1A1024(payload) + NewLine;
        }

        /// <summary>
        /// Asynchronously returns a printable string (hex encodes any control characters).
        /// </summary>
        /// <param name="token">The optional cancellation token.</param>
        /// <returns>An asynchronous <see cref="Task{TResult}" /> containing the printable string.</returns>
        /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
        // ReSharper disable once RedundantAwait
#pragma warning disable S2325 // Make a static method.
        private Task<string> PrintAsync(CancellationToken token = default)
#pragma warning restore S2325 // Make a static method.
        {
            bool controlCharacter = false;
            StringBuilder sb = new(data.Length);

            foreach (char c in data)
            {
                token.ThrowIfCancellationRequested();
                if (controlCharacter || char.IsControl(c))
                {
                    _ = sb.Append(InvariantCulture, $"\\x{(uint)c:x2}");
                    controlCharacter = true;
                }
                else
                {
                    sb.Append(c);
                }
            }

            return Task.FromResult(sb.ToString());
        }
    }

    /// <summary>
    /// Computes the FNV-1A 32-bit hash of the given data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The hash value in hexadecimal.</returns>
    private static string ComputeFnv1A32(ReadOnlySpan<byte> data)
    {
        Fnv1a32 hasher = _Fnv1A32Hasher.Value!;

        hasher.Reset();
        hasher.Append(data);
        return "0x" + ((uint)ToInt32(hasher.GetCurrentHash(), 0)).ToString("X8", InvariantCulture);
    }

    /// <summary>
    /// Computes the FNV-1A 64-bit hash of the given data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The hash value in hexadecimal.</returns>
    private static string ComputeFnv1A64(ReadOnlySpan<byte> data)
    {
        Fnv1a64 hasher = _Fnv1A64Hasher.Value!;

        hasher.Reset();
        hasher.Append(data);
        return "0x" + ((ulong)ToInt64(hasher.GetCurrentHash(), 0)).ToString("X16", InvariantCulture);
    }

    /// <summary>
    /// Computes the FNV-1A 128-bit hash of the given data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The hash value in hexadecimal.</returns>
    private static string ComputeFnv1A128(ReadOnlySpan<byte> data)
    {
        Fnv1a128 hasher = _Fnv1A128Hasher.Value!;

        hasher.Reset();
        hasher.Append(data);
        return FormatBigEndianHex(hasher.GetCurrentHash());
    }

    /// <summary>
    /// Computes the FNV-1A 256-bit hash of the given data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The hash value in hexadecimal.</returns>
    private static string ComputeFnv1A256(ReadOnlySpan<byte> data)
    {
        Fnv1a256 hasher = _Fnv1A256Hasher.Value!;

        hasher.Reset();
        hasher.Append(data);
        return FormatBigEndianHex(hasher.GetCurrentHash());
    }

    /// <summary>
    /// Computes the FNV-1A 512-bit hash of the given data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The hash value in hexadecimal.</returns>
    private static string ComputeFnv1A512(ReadOnlySpan<byte> data)
    {
        Fnv1a512 hasher = _Fnv1A512Hasher.Value!;

        hasher.Reset();
        hasher.Append(data);
        return FormatBigEndianHex(hasher.GetCurrentHash());
    }

    /// <summary>
    /// Computes the FNV-1A 1024-bit hash of the given data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The hash value in hexadecimal.</returns>
    private static string ComputeFnv1A1024(ReadOnlySpan<byte> data)
    {
        Fnv1a1024 hasher = _Fnv1A1024Hasher.Value!;

        hasher.Reset();
        hasher.Append(data);
        return FormatBigEndianHex(hasher.GetCurrentHash());
    }

    /// <summary>
    /// Formats the little endian value as big endian hexadecimal.
    /// </summary>
    /// <param name="littleEndian">The little endian value.</param>
    /// <returns>The little endian value as big endian hexadecimal.</returns>
    private static string FormatBigEndianHex(byte[] littleEndian)
    {
        Span<byte> bigEndian = stackalloc byte[littleEndian.Length];

        littleEndian.AsSpan().CopyTo(bigEndian);
        bigEndian.Reverse();
        return "0x" + System.Convert.ToHexString(bigEndian);
    }
}
