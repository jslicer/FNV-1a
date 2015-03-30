// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="VinSolutions">
//   Copyright © VinSolutions 2014
// </copyright>
// <summary>
//   Contains the entry point of the application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1a
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    /// <summary>
    /// Contains the entry point of the application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine(Fnv1a32(string.Empty).ToString("X8"));
            Console.WriteLine(Fnv1a32("a").ToString("X8"));
            Console.WriteLine(Fnv1a32("b").ToString("X8"));
            Console.WriteLine(Fnv1a32("c").ToString("X8"));
            Console.WriteLine(Fnv1a32("d").ToString("X8"));
            Console.WriteLine(Fnv1a32("e").ToString("X8"));
            Console.WriteLine(Fnv1a32("f").ToString("X8"));
            Console.WriteLine(Fnv1a32("fo").ToString("X8"));
            Console.WriteLine(Fnv1a32("foo").ToString("X8"));
            Console.WriteLine(Fnv1a32("foob").ToString("X8"));
            Console.WriteLine(Fnv1a32("fooba").ToString("X8"));
            Console.WriteLine(Fnv1a32("foobar").ToString("X8"));
            Console.WriteLine();
            Console.WriteLine(Fnv1a64(string.Empty).ToString("X16"));
            Console.WriteLine(Fnv1a64("a").ToString("X16"));
            Console.WriteLine(Fnv1a64("b").ToString("X16"));
            Console.WriteLine(Fnv1a64("c").ToString("X16"));
            Console.WriteLine(Fnv1a64("d").ToString("X16"));
            Console.WriteLine(Fnv1a64("e").ToString("X16"));
            Console.WriteLine(Fnv1a64("f").ToString("X16"));
            Console.WriteLine(Fnv1a64("fo").ToString("X16"));
            Console.WriteLine(Fnv1a64("foo").ToString("X16"));
            Console.WriteLine(Fnv1a64("foob").ToString("X16"));
            Console.WriteLine(Fnv1a64("fooba").ToString("X16"));
            Console.WriteLine(Fnv1a64("foobar").ToString("X16"));
            Console.ReadLine();
        }

        /// <summary>
        /// Computes the FNV-1a 32-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 32-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static uint Fnv1a32(string data)
        {
            using (HashAlgorithm alg = new Fnv1a32())
            {
                return (uint)BitConverter.ToInt32(alg.ComputeHash(Encoding.UTF8.GetBytes(data)), 0);
            }
        }

        /// <summary>
        /// Computes the FNV-1a 64-bit hash for the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The FNV-1a 64-bit hash of the specified data.</returns>
        // ReSharper disable once InconsistentNaming
        private static ulong Fnv1a64(string data)
        {
            using (HashAlgorithm alg = new Fnv1a64())
            {
                return (ulong)BitConverter.ToInt64(alg.ComputeHash(Encoding.UTF8.GetBytes(data)), 0);
            }
        }
    }
}
