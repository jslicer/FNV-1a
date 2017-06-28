// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2014
// </copyright>
// <summary>
//   Contains the entry point of the application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    using static System.Console;
    using static System.Text.Encoding;

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
            var writer = TextWriter.Null; ////Out;
            var reader = TextReader.Null; ////In;
            var sets = new ISet[]
            {
                new Set0(writer),
                new Set1(writer),
                new Set2(writer),
                new Set3(writer),
                new Set4(writer),
                new Set5(writer),
                new Set6(writer),
                new Set7(writer),
                new Set8(writer),
                new Set9(writer),
                new Set10(writer),
                new Set11(writer),
                new Set12(writer),
                new Set13(writer),
                new Set14(writer),
                new Set15(writer)
            };

            OutputEncoding = UTF8;
            for (var loop = 0; loop < 1000; loop++)
            {
                foreach (var set in sets)
                {
                    set.Perform();
                }
            }

            reader.ReadLine();
        }
    }
}
