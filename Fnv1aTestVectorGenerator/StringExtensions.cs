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
    /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
    /// <see cref="StringBuilder.MaxCapacity"></see>.</exception>
    // ReSharper disable once MethodNameNotMeaningful
    internal static string R10(this string data)
    {
        StringBuilder sb = new(10 * data.Length);

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
    /// <exception cref="ArgumentOutOfRangeException">capacity is less than zero.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed
    /// <see cref="StringBuilder.MaxCapacity"></see>.</exception>
    internal static string R500(this string data)
    {
        StringBuilder sb = new(500 * data.Length);

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
        StringBuilder sb = new(data.Length);

        foreach (char c in data)
        {
            if (controlCharacter || char.IsControl(c))
            {
                sb.Append(InvariantCulture, $"\\x{(uint)c:x2}");
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
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 64-bit hash of the specified data.</returns>
    // ReSharper disable once InconsistentNaming
    private static string Fnv1a64s(this string data)
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
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 128-bit hash of the specified data.</returns>
    // ReSharper disable once InconsistentNaming
    private static string Fnv1a128s(this string data)
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
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 256-bit hash of the specified data.</returns>
    // ReSharper disable once InconsistentNaming
    private static string Fnv1a256s(this string data)
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
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 512-bit hash of the specified data.</returns>
    // ReSharper disable once InconsistentNaming
    private static string Fnv1a512s(this string data)
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
    /// <param name="data">The data.</param>
    /// <returns>The FNV-1a 1024-bit hash of the specified data.</returns>
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once TooManyDeclarations
    private static string Fnv1a1024s(this string data)
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
    /// <param name="data">The string data to hash.</param>
    /// <param name="alg">The hash algorithm.</param>
    /// <param name="destination">The destination in which to place the hash result.</param>
    private static void CalculateHash(this string data, NonCryptographicHashAlgorithm alg, Span<byte> destination)
    {
        int inputByteCount = UTF8.GetByteCount(data);
        Span<byte> bytes = inputByteCount < 1024
            ? stackalloc byte[inputByteCount]
            : new byte[inputByteCount];

        UTF8.GetBytes(data, bytes);
        alg.Append(bytes);
        _ = alg.TryGetCurrentHash(destination, out int _);
    }
}
