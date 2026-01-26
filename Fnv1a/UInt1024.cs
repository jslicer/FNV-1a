// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UInt1024.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Lightweight 1,024-bit unsigned integer optimized for FNV-1a operations.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1a;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/// <summary>
/// Minimal 1,024-bit unsigned integer helper for the FNV-1a 1024-bit variant.
/// </summary>
public struct UInt1024 : IEquatable<UInt1024>
{
#pragma warning disable CS0169 // Fields accessed via spans
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value 0
#pragma warning disable S1144 // Fields accessed via spans
#pragma warning disable CA1823 // Fields accessed via spans
#pragma warning disable S3459 // Remove unassigned field or set its value.
#pragma warning disable RCS1169 // Make field read-only
#pragma warning disable IDE0044 // Make field readonly
#pragma warning disable S2933 // Make readonly
    private ulong _w0;
    private ulong _w1;
    private ulong _w2;
    private ulong _w3;
    private ulong _w4;
    private ulong _w5;
    private ulong _w6;
    private ulong _w7;
    private ulong _w8;
    private ulong _w9;
    private ulong _w10;
    private ulong _w11;
    private ulong _w12;
    private ulong _w13;
    private ulong _w14;
    private ulong _w15;
#pragma warning restore S2933 // Make readonly
#pragma warning restore RCS1169 // Make field read-only
#pragma warning restore IDE0044 // Make field readonly
#pragma warning restore S3459 // Remove unassigned field or set its value.
#pragma warning restore CA1823 // Fields accessed via spans
#pragma warning restore S1144 // Fields accessed via spans
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value 0
#pragma warning restore CS0169 // Fields accessed via spans

    /// <summary>
    /// Initializes a new instance of the <see cref="UInt1024"/> struct.
    /// </summary>
    /// <param name="w0">The w0.</param>
    /// <param name="w1">The w1.</param>
    /// <param name="w2">The w2.</param>
    /// <param name="w3">The w3.</param>
    /// <param name="w4">The w4.</param>
    /// <param name="w5">The w5.</param>
    /// <param name="w6">The w6.</param>
    /// <param name="w7">The w7.</param>
    /// <param name="w8">The w8.</param>
    /// <param name="w9">The w9.</param>
    /// <param name="w10">The W10.</param>
    /// <param name="w11">The W11.</param>
    /// <param name="w12">The W12.</param>
    /// <param name="w13">The W13.</param>
    /// <param name="w14">The W14.</param>
    /// <param name="w15">The W15.</param>
    // ReSharper disable once TooManyDependencies
#pragma warning disable IDE0290 // Use primary constructor
    public UInt1024(
        ulong w0,
        ulong w1,
        ulong w2,
        ulong w3,
        ulong w4,
        ulong w5,
        ulong w6,
        ulong w7,
        ulong w8,
        ulong w9,
        ulong w10,
        ulong w11,
        ulong w12,
        ulong w13,
        ulong w14,
        ulong w15)
    {
        _w0 = w15;
        _w1 = w14;
        _w2 = w13;
        _w3 = w12;
        _w4 = w11;
        _w5 = w10;
        _w6 = w9;
        _w7 = w8;
        _w8 = w7;
        _w9 = w6;
        _w10 = w5;
        _w11 = w4;
        _w12 = w3;
        _w13 = w2;
        _w14 = w1;
        _w15 = w0;
    }
#pragma warning restore IDE0290 // Use primary constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="UInt1024" /> struct from a little-endian byte span.
    /// </summary>
    /// <param name="littleEndian">The little-endian representation.</param>
    public UInt1024(ReadOnlySpan<byte> littleEndian)
        : this() => littleEndian.CopyTo(MemoryMarshal.AsBytes(GetWords()));

    /// <summary>
    /// Gets the 1024-bit zero value.
    /// </summary>
    /// <value>
    /// The 1024-bit zero value.
    /// </value>
    public static UInt1024 Zero { get; } = new(
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL,
        0x0000000000000000UL);

    /// <summary>
    /// Gets a value indicating whether the number is zero.
    /// </summary>
    internal bool IsZero
    {
        get
        {
            foreach (ulong word in GetReadOnlyWords())
            {
                if (word != 0UL)
                {
                    return false;
                }
            }

            return true;
        }
    }

    /// <summary>
    /// Implements the operator ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator ==(UInt1024 left, UInt1024 right) => left.Equals(right);

    /// <summary>
    /// Implements the operator !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator !=(UInt1024 left, UInt1024 right) => !left.Equals(right);

    /// <summary>
    /// Indicates whether this instance and a specified object are equal.
    /// </summary>
    /// <param name="obj">The object to compare with the current instance.</param>
    /// <returns>
    ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the
    /// same value; otherwise, <see langword="false" />.
    /// </returns>
    public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is UInt1024 other && Equals(other);

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter;
    /// otherwise, <see langword="false" />.
    /// </returns>
    public readonly bool Equals(UInt1024 other) => other._w0 == _w0
        && other._w1 == _w1
        && other._w2 == _w2
        && other._w3 == _w3
        && other._w4 == _w4
        && other._w5 == _w5
        && other._w6 == _w6
        && other._w7 == _w7
        && other._w8 == _w8
        && other._w9 == _w9
        && other._w10 == _w10
        && other._w11 == _w11
        && other._w12 == _w12
        && other._w13 == _w13
        && other._w14 == _w14
        && other._w15 == _w15;

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>
    /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
    /// </returns>
    public override readonly int GetHashCode() => HashCode.Combine(
        (ulong)HashCode.Combine(
            (ulong)HashCode.Combine(_w0, _w1, _w2, _w3, _w4, _w5, _w6, _w7),
            _w8,
            _w9,
            _w10,
            _w11,
            _w12,
            _w13,
            _w14),
        _w15);

    /// <summary>
    /// Returns a <see cref="string" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    public override readonly string ToString() =>
        $"0x{_w0:X16}{_w1:X16}{_w2:X16}{_w3:X16}{_w4:X16}{_w5:X16}{_w6:X16}{_w7:X16}{_w8:X16}{_w9:X16}{_w10:X16}{_w11:X16}{_w12:X16}{_w13:X16}{_w14:X16}{_w15:X16}";

    /// <summary>
    /// Applies an XOR with the supplied byte to the least-significant word.
    /// </summary>
    /// <param name="value">The byte to XOR.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void Xor(byte value) => _w0 ^= value;

    /// <summary>
    /// Multiplies this value by the provided multiplier modulo 2^1024.
    /// </summary>
    /// <param name="multiplier">The multiplier.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //// ReSharper disable once MethodTooLong
    internal void Multiply(UInt1024 multiplier)
    {
        ReadOnlySpan<ulong> left = GetReadOnlyWords();
        ReadOnlySpan<ulong> right = multiplier.GetReadOnlyWords();
        Span<ulong> destination = GetWords();
        Span<ulong> product = stackalloc ulong[32];

        product.Clear();
        for (int i = 0; i < 16; i++)
        {
            UInt128 carry = 0;

            for (int j = 0; j < 16; j++)
            {
                int index = i + j;
                UInt128 mul = (UInt128)left[i] * right[j];
                UInt128 combined = product[index] + (UInt128)(ulong)mul + (ulong)carry;

                product[index] = (ulong)combined;

                // ReSharper disable once ComplexConditionExpression
                carry = (combined >> 64) + (mul >> 64) + (carry >> 64);
            }

            int carryIndex = i + 16;

#pragma warning disable RCS1239 // Use 'for' statement instead of 'while' statement
            while (carry != 0)
            {
                UInt128 combined = product[carryIndex] + (UInt128)(ulong)carry;

                product[carryIndex] = (ulong)combined;

                // ReSharper disable once ComplexConditionExpression
                carry = (combined >> 64) + (carry >> 64);
                carryIndex++;
            }
#pragma warning restore RCS1239 // Use 'for' statement instead of 'while' statement
        }

        product[..16].CopyTo(destination);
    }

    /// <summary>
    /// Writes the current value to the provided destination in little-endian order.
    /// </summary>
    /// <param name="destination">The destination span.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void WriteLittleEndian(Span<byte> destination) =>
        MemoryMarshal.AsBytes(GetReadOnlyWords()).CopyTo(destination);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private Span<ulong> GetWords() => MemoryMarshal.CreateSpan(ref _w0, 16);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ReadOnlySpan<ulong> GetReadOnlyWords() => MemoryMarshal.CreateReadOnlySpan(ref _w0, 16);
}
