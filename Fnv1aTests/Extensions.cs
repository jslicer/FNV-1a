// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Extensions.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2020
// </copyright>
// <summary>
//   Extension methods used by the unit tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTests
{
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
        internal static byte[] AddZero(this byte[] bytes)
        {
            byte[] temp = new byte[bytes.Length + 16];

            System.Array.Copy(bytes, temp, bytes.Length);
            return temp;
        }
    }
}
