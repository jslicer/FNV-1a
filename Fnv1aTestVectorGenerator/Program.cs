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
    using System.Numerics;
    using System.Security.Cryptography;
    using System.Text;

    using Fnv1a;

    using static System.BitConverter;
    using static System.Console;
    using static System.Environment;
    using static System.Globalization.CultureInfo;
    using static System.Globalization.NumberStyles;
    using static System.Numerics.BigInteger;
    using static System.Text.Encoding;

    /// <summary>
    /// Contains the entry point of the application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The bottom 64 bytes.
        /// </summary>
        private static readonly BigInteger _Bottom64Bytes = Parse(
            "0FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
            AllowHexSpecifier,
            InvariantCulture);

        /// <summary>
        /// The third 64 bytes.
        /// </summary>
        private static readonly BigInteger _Third64Bytes = Parse(
            "0FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF0000000000000000000000000000000000000000000000000000000000000000",
            AllowHexSpecifier,
            InvariantCulture);

        /// <summary>
        /// The second 64 bytes.
        /// </summary>
        private static readonly BigInteger _Second64Bytes = Parse(
            "0FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000",
            AllowHexSpecifier,
            InvariantCulture);

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        private static void Main()
        {
            var writer = TextWriter.Null; ////Out;
            var reader = TextReader.Null; ////In;

            OutputEncoding = UTF8;
            for (var loop = 0; loop < 1000; loop++)
            {
                Set0(writer);
                Set1(writer);
                Set2(writer);
                Set3(writer);
                Set4(writer);
                Set5(writer);
                Set6(writer);
                Set7(writer);
                Set8(writer);
                Set9(writer);
                Set10(writer);
                Set11(writer);
                Set12(writer);
                Set13(writer);
                Set14(writer);
                Set15(writer);
            }

            reader.ReadLine();
        }

        /// <summary>
        /// Performs Set 0.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set0(TextWriter writer)
        {
            writer.WriteLine(string.Empty.Test());
            writer.WriteLine("a".Test());
            writer.WriteLine("b".Test());
            writer.WriteLine("c".Test());
            writer.WriteLine("d".Test());
            writer.WriteLine("e".Test());
            writer.WriteLine("f".Test());
            writer.WriteLine("fo".Test());
            writer.WriteLine("foo".Test());
            writer.WriteLine("foob".Test());
            writer.WriteLine("fooba".Test());
            writer.WriteLine("foobar".Test());
        }

        /// <summary>
        /// Performs Set 1.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set1(TextWriter writer)
        {
            writer.WriteLine(string.Empty.Test0());
            writer.WriteLine("a".Test0());
            writer.WriteLine("b".Test0());
            writer.WriteLine("c".Test0());
            writer.WriteLine("d".Test0());
            writer.WriteLine("e".Test0());
            writer.WriteLine("f".Test0());
            writer.WriteLine("fo".Test0());
            writer.WriteLine("foo".Test0());
            writer.WriteLine("foob".Test0());
            writer.WriteLine("fooba".Test0());
            writer.WriteLine("foobar".Test0());
        }

         /// <summary>
        /// Performs Set 2.
        /// </summary>
        /// <param name="writer">The writer.</param>
       private static void Set2(TextWriter writer)
        {
            writer.WriteLine("ch".Test());
            writer.WriteLine("cho".Test());
            writer.WriteLine("chon".Test());
            writer.WriteLine("chong".Test());
            writer.WriteLine("chongo".Test());
            writer.WriteLine("chongo ".Test());
            writer.WriteLine("chongo w".Test());
            writer.WriteLine("chongo wa".Test());
            writer.WriteLine("chongo was".Test());
            writer.WriteLine("chongo was ".Test());
            writer.WriteLine("chongo was h".Test());
            writer.WriteLine("chongo was he".Test());
            writer.WriteLine("chongo was her".Test());
            writer.WriteLine("chongo was here".Test());
            writer.WriteLine("chongo was here!".Test());
            writer.WriteLine("chongo was here!\n".Test());
        }

        /// <summary>
        /// Performs Set 3.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set3(TextWriter writer)
        {
            writer.WriteLine("ch".Test0());
            writer.WriteLine("cho".Test0());
            writer.WriteLine("chon".Test0());
            writer.WriteLine("chong".Test0());
            writer.WriteLine("chongo".Test0());
            writer.WriteLine("chongo ".Test0());
            writer.WriteLine("chongo w".Test0());
            writer.WriteLine("chongo wa".Test0());
            writer.WriteLine("chongo was".Test0());
            writer.WriteLine("chongo was ".Test0());
            writer.WriteLine("chongo was h".Test0());
            writer.WriteLine("chongo was he".Test0());
            writer.WriteLine("chongo was her".Test0());
            writer.WriteLine("chongo was here".Test0());
            writer.WriteLine("chongo was here!".Test0());
            writer.WriteLine("chongo was here!\n".Test0());
        }

        /// <summary>
        /// Performs Set 4.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set4(TextWriter writer)
        {
            writer.WriteLine("cu".Test());
            writer.WriteLine("cur".Test());
            writer.WriteLine("curd".Test());
            writer.WriteLine("curds".Test());
            writer.WriteLine("curds ".Test());
            writer.WriteLine("curds a".Test());
            writer.WriteLine("curds an".Test());
            writer.WriteLine("curds and".Test());
            writer.WriteLine("curds and ".Test());
            writer.WriteLine("curds and w".Test());
            writer.WriteLine("curds and wh".Test());
            writer.WriteLine("curds and whe".Test());
            writer.WriteLine("curds and whey".Test());
            writer.WriteLine("curds and whey\n".Test());
        }

        /// <summary>
        /// Performs Set 5.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set5(TextWriter writer)
        {
            writer.WriteLine("cu".Test0());
            writer.WriteLine("cur".Test0());
            writer.WriteLine("curd".Test0());
            writer.WriteLine("curds".Test0());
            writer.WriteLine("curds ".Test0());
            writer.WriteLine("curds a".Test0());
            writer.WriteLine("curds an".Test0());
            writer.WriteLine("curds and".Test0());
            writer.WriteLine("curds and ".Test0());
            writer.WriteLine("curds and w".Test0());
            writer.WriteLine("curds and wh".Test0());
            writer.WriteLine("curds and whe".Test0());
            writer.WriteLine("curds and whey".Test0());
            writer.WriteLine("curds and whey\n".Test0());
        }

        /// <summary>
        /// Performs Set 6.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set6(TextWriter writer)
        {
            writer.WriteLine("hi".Test());
            writer.WriteLine("hi".Test0());
            writer.WriteLine("hello".Test());
            writer.WriteLine("hello".Test0());
        }

        /// <summary>
        /// Performs Set 7.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set7(TextWriter writer)
        {
            writer.WriteLine("\xff\x00\x00\x01".Test());
            writer.WriteLine("\x01\x00\x00\xff".Test());
            writer.WriteLine("\xff\x00\x00\x02".Test());
            writer.WriteLine("\x02\x00\x00\xff".Test());
            writer.WriteLine("\xff\x00\x00\x03".Test());
            writer.WriteLine("\x03\x00\x00\xff".Test());
            writer.WriteLine("\xff\x00\x00\x04".Test());
            writer.WriteLine("\x04\x00\x00\xff".Test());
            writer.WriteLine("\x40\x51\x4e\x44".Test());
            writer.WriteLine("\x44\x4e\x51\x40".Test());
            writer.WriteLine("\x40\x51\x4e\x4a".Test());
            writer.WriteLine("\x4a\x4e\x51\x40".Test());
            writer.WriteLine("\x40\x51\x4e\x54".Test());
            writer.WriteLine("\x54\x4e\x51\x40".Test());
        }

        /// <summary>
        /// Performs Set 8.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set8(TextWriter writer)
        {
            writer.WriteLine("127.0.0.1".Test());
            writer.WriteLine("127.0.0.1".Test0());
            writer.WriteLine("127.0.0.2".Test());
            writer.WriteLine("127.0.0.2".Test0());
            writer.WriteLine("127.0.0.3".Test());
            writer.WriteLine("127.0.0.3".Test0());
        }

        /// <summary>
        /// Performs Set 9.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set9(TextWriter writer)
        {
            writer.WriteLine("64.81.78.68".Test());
            writer.WriteLine("64.81.78.68".Test0());
            writer.WriteLine("64.81.78.74".Test());
            writer.WriteLine("64.81.78.74".Test0());
            writer.WriteLine("64.81.78.84".Test());
            writer.WriteLine("64.81.78.84".Test0());
        }

        /// <summary>
        /// Performs Set 10.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set10(TextWriter writer)
        {
            writer.WriteLine("feedface".Test());
            writer.WriteLine("feedface".Test0());
            writer.WriteLine("feedfacedaffdeed".Test());
            writer.WriteLine("feedfacedaffdeed".Test0());
            writer.WriteLine("feedfacedeadbeef".Test());
            writer.WriteLine("feedfacedeadbeef".Test0());
        }

        /// <summary>
        /// Performs Set 11.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set11(TextWriter writer)
        {
            writer.WriteLine("line 1\nline 2\nline 3".Test());
        }

        /// <summary>
        /// Performs Set 12.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set12(TextWriter writer)
        {
            writer.WriteLine("chongo <Landon Curt Noll> /\\../\\".Test());
            writer.WriteLine("chongo <Landon Curt Noll> /\\../\\".Test0());
            writer.WriteLine("chongo (Landon Curt Noll) /\\../\\".Test());
            writer.WriteLine("chongo (Landon Curt Noll) /\\../\\".Test0());
        }

        /// <summary>
        /// Performs Set 13.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set13(TextWriter writer)
        {
            writer.WriteLine("http://antwrp.gsfc.nasa.gov/apod/astropix.html".Test());
            writer.WriteLine("http://en.wikipedia.org/wiki/Fowler_Noll_Vo_hash".Test());
            writer.WriteLine("http://epod.usra.edu/".Test());
            writer.WriteLine("http://exoplanet.eu/".Test());
            writer.WriteLine("http://hvo.wr.usgs.gov/cam3/".Test());
            writer.WriteLine("http://hvo.wr.usgs.gov/cams/HMcam/".Test());
            writer.WriteLine("http://hvo.wr.usgs.gov/kilauea/update/deformation.html".Test());
            writer.WriteLine("http://hvo.wr.usgs.gov/kilauea/update/images.html".Test());
            writer.WriteLine("http://hvo.wr.usgs.gov/kilauea/update/maps.html".Test());
            writer.WriteLine("http://hvo.wr.usgs.gov/volcanowatch/current_issue.html".Test());
            writer.WriteLine("http://neo.jpl.nasa.gov/risk/".Test());
            writer.WriteLine("http://norvig.com/21-days.html".Test());
            writer.WriteLine("http://primes.utm.edu/curios/home.php".Test());
            writer.WriteLine("http://slashdot.org/".Test());
            writer.WriteLine("http://tux.wr.usgs.gov/Maps/155.25-19.5.html".Test());
            writer.WriteLine("http://volcano.wr.usgs.gov/kilaueastatus.php".Test());
            writer.WriteLine("http://www.avo.alaska.edu/activity/Redoubt.php".Test());
            writer.WriteLine("http://www.dilbert.com/fast/".Test());
            writer.WriteLine("http://www.fourmilab.ch/gravitation/orbits/".Test());
            writer.WriteLine("http://www.fpoa.net/".Test());
            writer.WriteLine("http://www.ioccc.org/index.html".Test());
            writer.WriteLine("http://www.isthe.com/cgi-bin/number.cgi".Test());
            writer.WriteLine("http://www.isthe.com/chongo/bio.html".Test());
            writer.WriteLine("http://www.isthe.com/chongo/index.html".Test());
            writer.WriteLine("http://www.isthe.com/chongo/src/calc/lucas-calc".Test());
            writer.WriteLine("http://www.isthe.com/chongo/tech/astro/venus2004.html".Test());
            writer.WriteLine("http://www.isthe.com/chongo/tech/astro/vita.html".Test());
            writer.WriteLine("http://www.isthe.com/chongo/tech/comp/c/expert.html".Test());
            writer.WriteLine("http://www.isthe.com/chongo/tech/comp/calc/index.html".Test());
            writer.WriteLine("http://www.isthe.com/chongo/tech/comp/fnv/index.html".Test());
            writer.WriteLine("http://www.isthe.com/chongo/tech/math/number/howhigh.html".Test());
            writer.WriteLine("http://www.isthe.com/chongo/tech/math/number/number.html".Test());
            writer.WriteLine("http://www.isthe.com/chongo/tech/math/prime/mersenne.html".Test());
            writer.WriteLine("http://www.isthe.com/chongo/tech/math/prime/mersenne.html#largest".Test());
            writer.WriteLine("http://www.lavarnd.org/cgi-bin/corpspeak.cgi".Test());
            writer.WriteLine("http://www.lavarnd.org/cgi-bin/haiku.cgi".Test());
            writer.WriteLine("http://www.lavarnd.org/cgi-bin/rand-none.cgi".Test());
            writer.WriteLine("http://www.lavarnd.org/cgi-bin/randdist.cgi".Test());
            writer.WriteLine("http://www.lavarnd.org/index.html".Test());
            writer.WriteLine("http://www.lavarnd.org/what/nist-test.html".Test());
            writer.WriteLine("http://www.macosxhints.com/".Test());
            writer.WriteLine("http://www.mellis.com/".Test());
            writer.WriteLine("http://www.nature.nps.gov/air/webcams/parks/havoso2alert/havoalert.cfm".Test());
            writer.WriteLine("http://www.nature.nps.gov/air/webcams/parks/havoso2alert/timelines_24.cfm".Test());
            writer.WriteLine("http://www.paulnoll.com/".Test());
            writer.WriteLine("http://www.pepysdiary.com/".Test());
            writer.WriteLine("http://www.sciencenews.org/index/home/activity/view".Test());
            writer.WriteLine("http://www.skyandtelescope.com/".Test());
            writer.WriteLine("http://www.sput.nl/~rob/sirius.html".Test());
            writer.WriteLine("http://www.systemexperts.com/".Test());
            writer.WriteLine("http://www.tq-international.com/phpBB3/index.php".Test());
            writer.WriteLine("http://www.travelquesttours.com/index.htm".Test());
            writer.WriteLine("http://www.wunderground.com/global/stations/89606.html".Test());
        }

        /// <summary>
        /// Performs Set 14.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set14(TextWriter writer)
        {
            writer.WriteLine("21701".R10());
            writer.WriteLine("M21701".R10());
            writer.WriteLine("2^21701-1".R10());
            writer.WriteLine("\x54\xc5".R10());
            writer.WriteLine("\xc5\x54".R10());
            writer.WriteLine("23209".R10());
            writer.WriteLine("M23209".R10());
            writer.WriteLine("2^23209-1".R10());
            writer.WriteLine("\x5a\xa9".R10());
            writer.WriteLine("\xa9\x5a".R10());
            writer.WriteLine("391581216093".R10());
            writer.WriteLine("391581*2^216093-1".R10());
            writer.WriteLine("\x05\xf9\x9d\x03\x4c\x81".R10());
            writer.WriteLine("FEDCBA9876543210".R10());
            writer.WriteLine("\xfe\xdc\xba\x98\x76\x54\x32\x10".R10());
            writer.WriteLine("EFCDAB8967452301".R10());
            writer.WriteLine("\xef\xcd\xab\x89\x67\x45\x23\x01".R10());
            writer.WriteLine("0123456789ABCDEF".R10());
            writer.WriteLine("\x01\x23\x45\x67\x89\xab\xcd\xef".R10());
            writer.WriteLine("1032547698BADCFE".R10());
            writer.WriteLine("\x10\x32\x54\x76\x98\xba\xdc\xfe".R10());
        }

        /// <summary>
        /// Performs Set 15.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void Set15(TextWriter writer)
        {
            writer.WriteLine("\x00".R500());
            writer.WriteLine("\x07".R500());
            writer.WriteLine("~".R500());
            writer.WriteLine("\x7f".R500());
        }

        /// <summary>
        /// Tests the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The test result string.</returns>
        private static string Test(this string data)
        {
            return "Test:" + NewLine
                + data + " 32: " + data.Fnv1a32s() + NewLine
                + data + " 64: " + data.Fnv1a64s() + NewLine
                + data + " 128: " + data.Fnv1a128s() + NewLine
                + data + " 256: " + data.Fnv1a256s() + NewLine
                + data + " 512: " + data.Fnv1a512s() + NewLine
                + data + " 1024: " + data.Fnv1a1024s() + NewLine;
        }

        /// <summary>
        /// Tests the specified data adding a trailing NULL byte.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The test result string.</returns>
        private static string Test0(this string data)
        {
            var newData = data + '\0';
            var printData = data.Print();

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
        private static string R10(this string data)
        {
            var sb = new StringBuilder(10 * data.Length);

            for (var i = 0; i < 10; i++)
            {
                sb.Append(data);
            }

            var newData = sb.ToString();
            var printData = data.Print();

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
        private static string R500(this string data)
        {
            var sb = new StringBuilder(500 * data.Length);

            for (var i = 0; i < 500; i++)
            {
                sb.Append(data);
            }

            var newData = sb.ToString();
            var printData = data.Print();

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
            var controlCharacter = false;
            var sb = new StringBuilder(data.Length);

            foreach (var c in data)
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
                var value = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data))).ToString("X32", InvariantCulture);

                return "0x" + value.Substring(value.Length - 32);
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
                var value = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data))).ToString("X64", InvariantCulture);

                return "0x" + value.Substring(value.Length - 64);
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
                var hash = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)));
                var value1 = (hash >> 256).ToString("X64", InvariantCulture);
                var value2 = (hash & _Bottom64Bytes).ToString("X64", InvariantCulture);

                return "0x" + value1.Substring(value1.Length - 64) + value2.Substring(value2.Length - 64);
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
                var hash = new BigInteger(alg.ComputeHash(UTF8.GetBytes(data)));
                var value1 = (hash >> 768).ToString("X64", InvariantCulture);
                var value2 = ((hash & _Second64Bytes) >> 512).ToString("X64", InvariantCulture);
                var value3 = ((hash & _Third64Bytes) >> 256).ToString("X64", InvariantCulture);
                var value4 = (hash & _Bottom64Bytes).ToString("X64", InvariantCulture);

                return "0x"
                    + value1.Substring(value1.Length - 64)
                    + value2.Substring(value2.Length - 64)
                    + value3.Substring(value3.Length - 64)
                    + value4.Substring(value4.Length - 64);
            }
        }
    }
}
