// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Extensions.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Extension methods used by the unit tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTests;

using System;

/// <summary>
/// Extension methods used by the unit tests.
/// </summary>
internal static class Extensions
{
    /// <summary>
    /// Adds a zero byte on to the end of the byte array.
    /// </summary>
    /// <param name="bytes">The bytes.</param>
    /// <returns>The new array with a zero byte on the end.</returns>
    /// <exception cref="OverflowException">The array is multidimensional and contains more than
    /// <see cref="int.MaxValue"></see> elements.</exception>
    /// <exception cref="RankException">sourceArray and destinationArray have different ranks.</exception>
    /// <exception cref="ArrayTypeMismatchException">sourceArray and destinationArray are of incompatible
    /// types.</exception>
    /// <exception cref="InvalidCastException">At least one element in sourceArray cannot be cast to the
    /// type of destinationArray.</exception>
    /// <exception cref="ArgumentNullException">sourceArray is null.   -or-  destinationArray is
    /// null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">length is less than zero.</exception>
    /// <exception cref="ArgumentException">length is greater than the number of elements in sourceArray.
    /// -or-  length is greater than the number of elements in destinationArray.</exception>
    internal static byte[] AddZero(this byte[] bytes)
    {
        byte[] temp = new byte[bytes.Length + 1];

        Array.Copy(bytes, temp, bytes.Length);
        return temp;
    }
}
