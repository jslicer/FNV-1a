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
    using System;
    using System.Globalization;
    using System.Numerics;
    using System.Security.Cryptography;
    using System.Text;

    using Fnv1a;

    /// <summary>
    /// Contains the entry point of the application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The bottom 64 bytes.
        /// </summary>
        private static readonly BigInteger _Bottom64Bytes = BigInteger.Parse(
            "0FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
            NumberStyles.AllowHexSpecifier);

        /// <summary>
        /// The third 64 bytes.
        /// </summary>
        private static readonly BigInteger _Third64Bytes = BigInteger.Parse(
            "0FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF0000000000000000000000000000000000000000000000000000000000000000",
            NumberStyles.AllowHexSpecifier);

        /// <summary>
        /// The second 64 bytes.
        /// </summary>
        private static readonly BigInteger _Second64Bytes = BigInteger.Parse(
            "0FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000",
            NumberStyles.AllowHexSpecifier);

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(Test(string.Empty));
            Console.WriteLine(Test("a"));
            Console.WriteLine(Test("b"));
            Console.WriteLine(Test("c"));
            Console.WriteLine(Test("d"));
            Console.WriteLine(Test("e"));
            Console.WriteLine(Test("f"));
            Console.WriteLine(Test("fo"));
            Console.WriteLine(Test("foo"));
            Console.WriteLine(Test("foob"));
            Console.WriteLine(Test("fooba"));
            Console.WriteLine(Test("foobar"));
            Console.WriteLine(Test0(string.Empty));
            Console.WriteLine(Test0("a"));
            Console.WriteLine(Test0("b"));
            Console.WriteLine(Test0("c"));
            Console.WriteLine(Test0("d"));
            Console.WriteLine(Test0("e"));
            Console.WriteLine(Test0("f"));
            Console.WriteLine(Test0("fo"));
            Console.WriteLine(Test0("foo"));
            Console.WriteLine(Test0("foob"));
            Console.WriteLine(Test0("fooba"));
            Console.WriteLine(Test0("foobar"));
            Console.WriteLine(Test("ch"));
            Console.WriteLine(Test("cho"));
            Console.WriteLine(Test("chon"));
            Console.WriteLine(Test("chong"));
            Console.WriteLine(Test("chongo"));
            Console.WriteLine(Test("chongo "));
            Console.WriteLine(Test("chongo w"));
            Console.WriteLine(Test("chongo wa"));
            Console.WriteLine(Test("chongo was"));
            Console.WriteLine(Test("chongo was "));
            Console.WriteLine(Test("chongo was h"));
            Console.WriteLine(Test("chongo was he"));
            Console.WriteLine(Test("chongo was her"));
            Console.WriteLine(Test("chongo was here"));
            Console.WriteLine(Test("chongo was here!"));
            Console.WriteLine(Test("chongo was here!\n"));
            Console.WriteLine(Test0("ch"));
            Console.WriteLine(Test0("cho"));
            Console.WriteLine(Test0("chon"));
            Console.WriteLine(Test0("chong"));
            Console.WriteLine(Test0("chongo"));
            Console.WriteLine(Test0("chongo "));
            Console.WriteLine(Test0("chongo w"));
            Console.WriteLine(Test0("chongo wa"));
            Console.WriteLine(Test0("chongo was"));
            Console.WriteLine(Test0("chongo was "));
            Console.WriteLine(Test0("chongo was h"));
            Console.WriteLine(Test0("chongo was he"));
            Console.WriteLine(Test0("chongo was her"));
            Console.WriteLine(Test0("chongo was here"));
            Console.WriteLine(Test0("chongo was here!"));
            Console.WriteLine(Test0("chongo was here!\n"));
            Console.WriteLine(Test("cu"));
            Console.WriteLine(Test("cur"));
            Console.WriteLine(Test("curd"));
            Console.WriteLine(Test("curds"));
            Console.WriteLine(Test("curds "));
            Console.WriteLine(Test("curds a"));
            Console.WriteLine(Test("curds an"));
            Console.WriteLine(Test("curds and"));
            Console.WriteLine(Test("curds and "));
            Console.WriteLine(Test("curds and w"));
            Console.WriteLine(Test("curds and wh"));
            Console.WriteLine(Test("curds and whe"));
            Console.WriteLine(Test("curds and whey"));
            Console.WriteLine(Test("curds and whey\n"));
            Console.WriteLine(Test0("cu"));
            Console.WriteLine(Test0("cur"));
            Console.WriteLine(Test0("curd"));
            Console.WriteLine(Test0("curds"));
            Console.WriteLine(Test0("curds "));
            Console.WriteLine(Test0("curds a"));
            Console.WriteLine(Test0("curds an"));
            Console.WriteLine(Test0("curds and"));
            Console.WriteLine(Test0("curds and "));
            Console.WriteLine(Test0("curds and w"));
            Console.WriteLine(Test0("curds and wh"));
            Console.WriteLine(Test0("curds and whe"));
            Console.WriteLine(Test0("curds and whey"));
            Console.WriteLine(Test0("curds and whey\n"));
            Console.WriteLine(Test("hi"));
            Console.WriteLine(Test0("hi"));
            Console.WriteLine(Test("hello"));
            Console.WriteLine(Test0("hello"));
            Console.WriteLine(Test("\xff\x00\x00\x01"));
            Console.WriteLine(Test("\x01\x00\x00\xff"));
            Console.WriteLine(Test("\xff\x00\x00\x02"));
            Console.WriteLine(Test("\x02\x00\x00\xff"));
            Console.WriteLine(Test("\xff\x00\x00\x03"));
            Console.WriteLine(Test("\x03\x00\x00\xff"));
            Console.WriteLine(Test("\xff\x00\x00\x04"));
            Console.WriteLine(Test("\x04\x00\x00\xff"));
            Console.WriteLine(Test("\x40\x51\x4e\x44"));
            Console.WriteLine(Test("\x44\x4e\x51\x40"));
            Console.WriteLine(Test("\x40\x51\x4e\x4a"));
            Console.WriteLine(Test("\x4a\x4e\x51\x40"));
            Console.WriteLine(Test("\x40\x51\x4e\x54"));
            Console.WriteLine(Test("\x54\x4e\x51\x40"));
            Console.WriteLine(Test("127.0.0.1"));
            Console.WriteLine(Test0("127.0.0.1"));
            Console.WriteLine(Test("127.0.0.2"));
            Console.WriteLine(Test0("127.0.0.2"));
            Console.WriteLine(Test("127.0.0.3"));
            Console.WriteLine(Test0("127.0.0.3"));
            Console.WriteLine(Test("64.81.78.68"));
            Console.WriteLine(Test0("64.81.78.68"));
            Console.WriteLine(Test("64.81.78.74"));
            Console.WriteLine(Test0("64.81.78.74"));
            Console.WriteLine(Test("64.81.78.84"));
            Console.WriteLine(Test0("64.81.78.84"));
            Console.WriteLine(Test("feedface"));
            Console.WriteLine(Test0("feedface"));
            Console.WriteLine(Test("feedfacedaffdeed"));
            Console.WriteLine(Test0("feedfacedaffdeed"));
            Console.WriteLine(Test("feedfacedeadbeef"));
            Console.WriteLine(Test0("feedfacedeadbeef"));
            Console.WriteLine(Test("line 1\nline 2\nline 3"));
            Console.WriteLine(Test("chongo <Landon Curt Noll> /\\../\\"));
            Console.WriteLine(Test0("chongo <Landon Curt Noll> /\\../\\"));
            Console.WriteLine(Test("chongo (Landon Curt Noll) /\\../\\"));
            Console.WriteLine(Test0("chongo (Landon Curt Noll) /\\../\\"));
            Console.WriteLine(Test("http://antwrp.gsfc.nasa.gov/apod/astropix.html"));
            Console.WriteLine(Test("http://en.wikipedia.org/wiki/Fowler_Noll_Vo_hash"));
            Console.WriteLine(Test("http://epod.usra.edu/"));
            Console.WriteLine(Test("http://exoplanet.eu/"));
            Console.WriteLine(Test("http://hvo.wr.usgs.gov/cam3/"));
            Console.WriteLine(Test("http://hvo.wr.usgs.gov/cams/HMcam/"));
            Console.WriteLine(Test("http://hvo.wr.usgs.gov/kilauea/update/deformation.html"));
            Console.WriteLine(Test("http://hvo.wr.usgs.gov/kilauea/update/images.html"));
            Console.WriteLine(Test("http://hvo.wr.usgs.gov/kilauea/update/maps.html"));
            Console.WriteLine(Test("http://hvo.wr.usgs.gov/volcanowatch/current_issue.html"));
            Console.WriteLine(Test("http://neo.jpl.nasa.gov/risk/"));
            Console.WriteLine(Test("http://norvig.com/21-days.html"));
            Console.WriteLine(Test("http://primes.utm.edu/curios/home.php"));
            Console.WriteLine(Test("http://slashdot.org/"));
            Console.WriteLine(Test("http://tux.wr.usgs.gov/Maps/155.25-19.5.html"));
            Console.WriteLine(Test("http://volcano.wr.usgs.gov/kilaueastatus.php"));
            Console.WriteLine(Test("http://www.avo.alaska.edu/activity/Redoubt.php"));
            Console.WriteLine(Test("http://www.dilbert.com/fast/"));
            Console.WriteLine(Test("http://www.fourmilab.ch/gravitation/orbits/"));
            Console.WriteLine(Test("http://www.fpoa.net/"));
            Console.WriteLine(Test("http://www.ioccc.org/index.html"));
            Console.WriteLine(Test("http://www.isthe.com/cgi-bin/number.cgi"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/bio.html"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/index.html"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/src/calc/lucas-calc"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/tech/astro/venus2004.html"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/tech/astro/vita.html"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/tech/comp/c/expert.html"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/tech/comp/calc/index.html"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/tech/comp/fnv/index.html"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/tech/math/number/howhigh.html"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/tech/math/number/number.html"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/tech/math/prime/mersenne.html"));
            Console.WriteLine(Test("http://www.isthe.com/chongo/tech/math/prime/mersenne.html#largest"));
            Console.WriteLine(Test("http://www.lavarnd.org/cgi-bin/corpspeak.cgi"));
            Console.WriteLine(Test("http://www.lavarnd.org/cgi-bin/haiku.cgi"));
            Console.WriteLine(Test("http://www.lavarnd.org/cgi-bin/rand-none.cgi"));
            Console.WriteLine(Test("http://www.lavarnd.org/cgi-bin/randdist.cgi"));
            Console.WriteLine(Test("http://www.lavarnd.org/index.html"));
            Console.WriteLine(Test("http://www.lavarnd.org/what/nist-test.html"));
            Console.WriteLine(Test("http://www.macosxhints.com/"));
            Console.WriteLine(Test("http://www.mellis.com/"));
            Console.WriteLine(Test("http://www.nature.nps.gov/air/webcams/parks/havoso2alert/havoalert.cfm"));
            Console.WriteLine(Test("http://www.nature.nps.gov/air/webcams/parks/havoso2alert/timelines_24.cfm"));
            Console.WriteLine(Test("http://www.paulnoll.com/"));
            Console.WriteLine(Test("http://www.pepysdiary.com/"));
            Console.WriteLine(Test("http://www.sciencenews.org/index/home/activity/view"));
            Console.WriteLine(Test("http://www.skyandtelescope.com/"));
            Console.WriteLine(Test("http://www.sput.nl/~rob/sirius.html"));
            Console.WriteLine(Test("http://www.systemexperts.com/"));
            Console.WriteLine(Test("http://www.tq-international.com/phpBB3/index.php"));
            Console.WriteLine(Test("http://www.travelquesttours.com/index.htm"));
            Console.WriteLine(Test("http://www.wunderground.com/global/stations/89606.html"));
            Console.WriteLine(R10("21701"));
            Console.WriteLine(R10("M21701"));
            Console.WriteLine(R10("2^21701-1"));
            Console.WriteLine(R10("\x54\xc5"));
            Console.WriteLine(R10("\xc5\x54"));
            Console.WriteLine(R10("23209"));
            Console.WriteLine(R10("M23209"));
            Console.WriteLine(R10("2^23209-1"));
            Console.WriteLine(R10("\x5a\xa9"));
            Console.WriteLine(R10("\xa9\x5a"));
            Console.WriteLine(R10("391581216093"));
            Console.WriteLine(R10("391581*2^216093-1"));
            Console.WriteLine(R10("\x05\xf9\x9d\x03\x4c\x81"));
            Console.WriteLine(R10("FEDCBA9876543210"));
            Console.WriteLine(R10("\xfe\xdc\xba\x98\x76\x54\x32\x10"));
            Console.WriteLine(R10("EFCDAB8967452301"));
            Console.WriteLine(R10("\xef\xcd\xab\x89\x67\x45\x23\x01"));
            Console.WriteLine(R10("0123456789ABCDEF"));
            Console.WriteLine(R10("\x01\x23\x45\x67\x89\xab\xcd\xef"));
            Console.WriteLine(R10("1032547698BADCFE"));
            Console.WriteLine(R10("\x10\x32\x54\x76\x98\xba\xdc\xfe"));
            Console.WriteLine(R500("\x00"));
            Console.WriteLine(R500("\x07"));
            Console.WriteLine(R500("~"));
            Console.WriteLine(R500("\x7f"));
            Console.ReadLine();
        }

        /// <summary>
        /// Tests the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The test result string.</returns>
        private static string Test(this string data)
        {
            return "Test:" + Environment.NewLine
                + data + " 32: " + data.Fnv1a32s() + Environment.NewLine
                + data + " 64: " + data.Fnv1a64s() + Environment.NewLine
                + data + " 128: " + data.Fnv1a128s() + Environment.NewLine
                + data + " 256: " + data.Fnv1a256s() + Environment.NewLine
                + data + " 512: " + data.Fnv1a512s() + Environment.NewLine
                + data + " 1024: " + data.Fnv1a1024s() + Environment.NewLine;
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

            return "Test0:" + Environment.NewLine
                + printData + " 32: " + newData.Fnv1a32s() + Environment.NewLine
                + printData + " 64: " + newData.Fnv1a64s() + Environment.NewLine
                + printData + " 128: " + newData.Fnv1a128s() + Environment.NewLine
                + printData + " 256: " + newData.Fnv1a256s() + Environment.NewLine
                + printData + " 512: " + newData.Fnv1a512s() + Environment.NewLine
                + printData + " 1024: " + newData.Fnv1a1024s() + Environment.NewLine;
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

            return "R10:" + Environment.NewLine
                + printData.Print() + " 32: " + newData.Fnv1a32s() + Environment.NewLine
                + printData.Print() + " 64: " + newData.Fnv1a64s() + Environment.NewLine
                + printData.Print() + " 128: " + newData.Fnv1a128s() + Environment.NewLine
                + printData.Print() + " 256: " + newData.Fnv1a256s() + Environment.NewLine
                + printData.Print() + " 512: " + newData.Fnv1a512s() + Environment.NewLine
                + printData.Print() + " 1024: " + newData.Fnv1a1024s() + Environment.NewLine;
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

            return "R500:" + Environment.NewLine
                + printData.Print() + " 32: " + newData.Fnv1a32s() + Environment.NewLine
                + printData.Print() + " 64: " + newData.Fnv1a64s() + Environment.NewLine
                + printData.Print() + " 128: " + newData.Fnv1a128s() + Environment.NewLine
                + printData.Print() + " 256: " + newData.Fnv1a256s() + Environment.NewLine
                + printData.Print() + " 512: " + newData.Fnv1a512s() + Environment.NewLine
                + printData.Print() + " 1024: " + newData.Fnv1a1024s() + Environment.NewLine;
        }

        /// <summary>
        /// Returns a printable string (hex encodes any control characters).
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The printable string.</returns>
        private static string Print(this string data)
        {
            var isControl = false;
            var sb = new StringBuilder(data.Length);

            foreach (var c in data)
            {
                if (isControl || char.IsControl(c))
                {
                    sb.AppendFormat("\\x{0:x2}", (uint)c);
                    isControl = true;
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
                    + ((uint)BitConverter.ToInt32(alg.ComputeHash(Encoding.UTF8.GetBytes(data)), 0)).ToString("X8");
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
                    + ((ulong)BitConverter.ToInt64(alg.ComputeHash(Encoding.UTF8.GetBytes(data)), 0)).ToString("X16");
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
                var value = new BigInteger(alg.ComputeHash(Encoding.UTF8.GetBytes(data))).ToString("X32");

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
                var value =
                    new BigInteger(alg.ComputeHash(Encoding.UTF8.GetBytes(data))).ToString("X64");

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
                var hash = new BigInteger(alg.ComputeHash(Encoding.UTF8.GetBytes(data)));
                var value1 = (hash >> 256).ToString("X64");
                var value2 = (hash & _Bottom64Bytes).ToString("X64");

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
                var hash = new BigInteger(alg.ComputeHash(Encoding.UTF8.GetBytes(data)));
                var value1 = (hash >> 768).ToString("X64");
                var value2 = ((hash & _Second64Bytes) >> 512).ToString("X64");
                var value3 = ((hash & _Third64Bytes) >> 256).ToString("X64");
                var value4 = (hash & _Bottom64Bytes).ToString("X64");

                return "0x"
                    + value1.Substring(value1.Length - 64)
                    + value2.Substring(value2.Length - 64)
                    + value3.Substring(value3.Length - 64)
                    + value4.Substring(value4.Length - 64);
            }
        }
    }
}
