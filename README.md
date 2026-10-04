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

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method              | PayloadLength | Mean             | Error         | StdDev        | Ratio  | RatioSD |
|-------------------- |-------------- |-----------------:|--------------:|--------------:|-------:|--------:|
| **Fnv1A32Block**        | **32**            |         **55.40 ns** |      **0.166 ns** |      **0.147 ns** |   **1.00** |    **0.00** |
| Fnv1A32SingleByte   | 32            |         98.14 ns |      0.150 ns |      0.133 ns |   1.77 |    0.01 |
| Fnv1A64Block        | 32            |         46.52 ns |      0.186 ns |      0.174 ns |   0.84 |    0.00 |
| Fnv1A64SingleByte   | 32            |        100.15 ns |      0.173 ns |      0.154 ns |   1.81 |    0.01 |
| Fnv1A128Block       | 32            |        234.44 ns |      0.245 ns |      0.204 ns |   4.23 |    0.01 |
| Fnv1A128SingleByte  | 32            |        209.67 ns |      0.291 ns |      0.258 ns |   3.79 |    0.01 |
| Fnv1A256Block       | 32            |        887.83 ns |      0.793 ns |      0.662 ns |  16.03 |    0.04 |
| Fnv1A256SingleByte  | 32            |        925.60 ns |      1.354 ns |      1.200 ns |  16.71 |    0.05 |
| Fnv1A512Block       | 32            |      2,189.70 ns |      3.028 ns |      2.832 ns |  39.53 |    0.11 |
| Fnv1A512SingleByte  | 32            |      2,205.52 ns |      2.006 ns |      1.675 ns |  39.81 |    0.11 |
| Fnv1A1024Block      | 32            |     22,394.22 ns |     38.016 ns |     31.745 ns | 404.26 |    1.17 |
| Fnv1A1024SingleByte | 32            |     22,763.12 ns |     68.925 ns |     61.101 ns | 410.92 |    1.50 |
|                     |               |                  |               |               |        |         |
| **Fnv1A32Block**        | **1024**          |      **1,897.42 ns** |      **0.893 ns** |      **0.792 ns** |   **1.00** |    **0.00** |
| Fnv1A32SingleByte   | 1024          |      3,261.41 ns |      1.801 ns |      1.406 ns |   1.72 |    0.00 |
| Fnv1A64Block        | 1024          |      1,552.87 ns |      0.843 ns |      0.658 ns |   0.82 |    0.00 |
| Fnv1A64SingleByte   | 1024          |      3,249.57 ns |      1.699 ns |      1.419 ns |   1.71 |    0.00 |
| Fnv1A128Block       | 1024          |      7,522.72 ns |     12.036 ns |      9.397 ns |   3.96 |    0.01 |
| Fnv1A128SingleByte  | 1024          |      6,695.46 ns |      3.015 ns |      2.354 ns |   3.53 |    0.00 |
| Fnv1A256Block       | 1024          |     27,610.77 ns |     92.071 ns |     81.618 ns |  14.55 |    0.04 |
| Fnv1A256SingleByte  | 1024          |     28,857.94 ns |      9.198 ns |      7.681 ns |  15.21 |    0.01 |
| Fnv1A512Block       | 1024          |     69,913.22 ns |    152.061 ns |    134.798 ns |  36.85 |    0.07 |
| Fnv1A512SingleByte  | 1024          |     72,050.12 ns |    296.322 ns |    277.180 ns |  37.97 |    0.14 |
| Fnv1A1024Block      | 1024          |    718,263.79 ns |    709.576 ns |    592.528 ns | 378.55 |    0.34 |
| Fnv1A1024SingleByte | 1024          |    726,504.43 ns |  1,289.493 ns |  1,076.785 ns | 382.89 |    0.57 |
|                     |               |                  |               |               |        |         |
| **Fnv1A32Block**        | **65536**         |    **120,776.62 ns** |     **21.601 ns** |     **18.038 ns** |   **1.00** |    **0.00** |
| Fnv1A32SingleByte   | 65536         |    207,514.00 ns |    156.227 ns |    146.135 ns |   1.72 |    0.00 |
| Fnv1A64Block        | 65536         |     99,453.35 ns |     90.052 ns |     79.828 ns |   0.82 |    0.00 |
| Fnv1A64SingleByte   | 65536         |    205,440.51 ns |    213.681 ns |    199.877 ns |   1.70 |    0.00 |
| Fnv1A128Block       | 65536         |    498,421.63 ns |    779.690 ns |    729.323 ns |   4.13 |    0.01 |
| Fnv1A128SingleByte  | 65536         |    378,891.90 ns |    265.410 ns |    207.214 ns |   3.14 |    0.00 |
| Fnv1A256Block       | 65536         |  1,757,220.07 ns |  2,264.139 ns |  2,007.100 ns |  14.55 |    0.02 |
| Fnv1A256SingleByte  | 65536         |  1,823,655.84 ns |    946.122 ns |    790.055 ns |  15.10 |    0.01 |
| Fnv1A512Block       | 65536         |  4,370,055.91 ns |  6,558.820 ns |  5,814.223 ns |  36.18 |    0.05 |
| Fnv1A512SingleByte  | 65536         |  4,451,021.02 ns | 11,001.032 ns | 10,290.372 ns |  36.85 |    0.08 |
| Fnv1A1024Block      | 65536         | 45,785,933.98 ns | 71,835.493 ns | 56,084.428 ns | 379.10 |    0.45 |
| Fnv1A1024SingleByte | 65536         | 46,425,259.16 ns | 36,342.892 ns | 30,347.961 ns | 384.39 |    0.25 |
<!-- BENCHMARK_RESULTS_END -->

Special thanks to [crookseta](https://github.com/crookseta) for the [missing-values](https://github.com/crookseta/missing-values) project which allowed for the 256- and 512-bit variants to not have to use [BigInteger](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger), which was very slow.
