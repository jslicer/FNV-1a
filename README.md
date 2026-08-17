# FNV-1a
FNV-1a hash algorithm in C#

This small project is an implementation of the [FNV-1a](http://www.isthe.com/chongo/tech/comp/fnv/index.html) hash algorithm for 32-, 64-, 128-, 256-, 512- and 1024-bit variants.
All implemented classes descend from the [System.IO.Hashing](https://learn.microsoft.com/en-us/dotnet/api/system.io.hashing)'s [NonCryptographicHashAlgorithm](https://learn.microsoft.com/en-us/dotnet/api/system.io.hashing.noncryptographichashalgorithm), which should make for easy adoption.

Example:

```cs
namespace Fnv1aTest
{
    using System;
    using System.Globalization;
    using System.IO.Hashing;
    using System.Text;
    
    using Fnv1a;
    
    public static class Program
    {
        public static void Main()
        {
            NonCryptographicHashAlgorithm alg = new Fnv1a64();

            alg.Append(Encoding.UTF8.GetBytes("foobar"));
            Console.WriteLine(((ulong)BitConverter.ToInt64(alg.GetCurrentHash(), 0)).ToString("X8", CultureInfo.InvariantCulture));
        }
    }
}
```

This will output 85944171F73967E8 as the FNV-1a 64-bit hash of the string "foobar".

## Benchmark Results

<!-- BENCHMARK_RESULTS_START -->
```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 3.12GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method              | PayloadLength | Mean             | Error         | StdDev        | Ratio  | RatioSD |
|-------------------- |-------------- |-----------------:|--------------:|--------------:|-------:|--------:|
| **Fnv1A32Block**        | **32**            |         **53.77 ns** |      **0.071 ns** |      **0.059 ns** |   **1.00** |    **0.00** |
| Fnv1A32SingleByte   | 32            |         96.01 ns |      0.138 ns |      0.122 ns |   1.79 |    0.00 |
| Fnv1A64Block        | 32            |         44.84 ns |      0.054 ns |      0.048 ns |   0.83 |    0.00 |
| Fnv1A64SingleByte   | 32            |         98.42 ns |      0.065 ns |      0.051 ns |   1.83 |    0.00 |
| Fnv1A128Block       | 32            |        233.02 ns |      0.292 ns |      0.273 ns |   4.33 |    0.01 |
| Fnv1A128SingleByte  | 32            |        170.69 ns |      0.294 ns |      0.261 ns |   3.17 |    0.01 |
| Fnv1A256Block       | 32            |        887.43 ns |      1.040 ns |      0.922 ns |  16.51 |    0.02 |
| Fnv1A256SingleByte  | 32            |        905.15 ns |      0.660 ns |      0.551 ns |  16.83 |    0.02 |
| Fnv1A512Block       | 32            |      2,183.07 ns |      3.500 ns |      2.923 ns |  40.60 |    0.07 |
| Fnv1A512SingleByte  | 32            |      2,247.67 ns |      6.015 ns |      5.332 ns |  41.80 |    0.11 |
| Fnv1A1024Block      | 32            |     22,418.97 ns |     53.490 ns |     50.035 ns | 416.97 |    1.00 |
| Fnv1A1024SingleByte | 32            |     22,701.82 ns |     15.738 ns |     12.287 ns | 422.24 |    0.50 |
|                     |               |                  |               |               |        |         |
| **Fnv1A32Block**        | **1024**          |      **1,891.96 ns** |      **0.316 ns** |      **0.264 ns** |   **1.00** |    **0.00** |
| Fnv1A32SingleByte   | 1024          |      3,259.02 ns |      3.095 ns |      2.744 ns |   1.72 |    0.00 |
| Fnv1A64Block        | 1024          |      1,551.15 ns |      0.387 ns |      0.323 ns |   0.82 |    0.00 |
| Fnv1A64SingleByte   | 1024          |      3,246.56 ns |      2.240 ns |      1.870 ns |   1.72 |    0.00 |
| Fnv1A128Block       | 1024          |      7,580.69 ns |      3.063 ns |      2.715 ns |   4.01 |    0.00 |
| Fnv1A128SingleByte  | 1024          |      5,842.92 ns |      4.436 ns |      3.705 ns |   3.09 |    0.00 |
| Fnv1A256Block       | 1024          |     27,541.37 ns |     13.532 ns |     11.300 ns |  14.56 |    0.01 |
| Fnv1A256SingleByte  | 1024          |     29,486.55 ns |     12.478 ns |     11.061 ns |  15.59 |    0.01 |
| Fnv1A512Block       | 1024          |     68,644.13 ns |    101.904 ns |     90.335 ns |  36.28 |    0.05 |
| Fnv1A512SingleByte  | 1024          |     70,752.02 ns |    115.946 ns |    108.456 ns |  37.40 |    0.06 |
| Fnv1A1024Block      | 1024          |    715,140.42 ns |    299.602 ns |    265.590 ns | 377.99 |    0.14 |
| Fnv1A1024SingleByte | 1024          |    725,413.95 ns |    179.404 ns |    149.811 ns | 383.42 |    0.09 |
|                     |               |                  |               |               |        |         |
| **Fnv1A32Block**        | **65536**         |    **116,803.66 ns** |     **19.588 ns** |     **17.364 ns** |   **1.00** |    **0.00** |
| Fnv1A32SingleByte   | 65536         |    207,254.81 ns |     81.050 ns |     63.279 ns |   1.77 |    0.00 |
| Fnv1A64Block        | 65536         |     99,375.62 ns |     22.139 ns |     20.709 ns |   0.85 |    0.00 |
| Fnv1A64SingleByte   | 65536         |    205,256.42 ns |    146.290 ns |    122.159 ns |   1.76 |    0.00 |
| Fnv1A128Block       | 65536         |    485,890.54 ns |    224.069 ns |    209.594 ns |   4.16 |    0.00 |
| Fnv1A128SingleByte  | 65536         |    387,834.85 ns |    347.389 ns |    290.085 ns |   3.32 |    0.00 |
| Fnv1A256Block       | 65536         |  1,763,287.44 ns |  1,399.332 ns |  1,308.936 ns |  15.10 |    0.01 |
| Fnv1A256SingleByte  | 65536         |  1,837,939.85 ns |    895.023 ns |    837.205 ns |  15.74 |    0.01 |
| Fnv1A512Block       | 65536         |  4,470,060.11 ns | 19,386.205 ns | 18,133.868 ns |  38.27 |    0.15 |
| Fnv1A512SingleByte  | 65536         |  4,539,126.70 ns |  7,463.546 ns |  6,616.239 ns |  38.86 |    0.06 |
| Fnv1A1024Block      | 65536         | 45,710,933.52 ns | 22,539.272 ns | 18,821.313 ns | 391.35 |    0.17 |
| Fnv1A1024SingleByte | 65536         | 46,438,965.66 ns | 17,102.178 ns | 14,281.093 ns | 397.58 |    0.13 |
<!-- BENCHMARK_RESULTS_END -->

Special thanks to [crookseta](https://github.com/crookseta) for the [missing-values](https://github.com/crookseta/missing-values) project which allowed for the 256- and 512-bit variants to not have to use [BigInteger](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger), which was very slow.
