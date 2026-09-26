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
AMD EPYC 7763 3.09GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method              | PayloadLength | Mean             | Error         | StdDev        | Ratio  | RatioSD |
|-------------------- |-------------- |-----------------:|--------------:|--------------:|-------:|--------:|
| **Fnv1A32Block**        | **32**            |         **51.89 ns** |      **0.178 ns** |      **0.158 ns** |   **1.00** |    **0.00** |
| Fnv1A32SingleByte   | 32            |         97.28 ns |      0.147 ns |      0.130 ns |   1.87 |    0.01 |
| Fnv1A64Block        | 32            |         45.73 ns |      0.106 ns |      0.089 ns |   0.88 |    0.00 |
| Fnv1A64SingleByte   | 32            |         99.53 ns |      0.202 ns |      0.169 ns |   1.92 |    0.01 |
| Fnv1A128Block       | 32            |        233.73 ns |      0.126 ns |      0.112 ns |   4.50 |    0.01 |
| Fnv1A128SingleByte  | 32            |        171.06 ns |      0.338 ns |      0.300 ns |   3.30 |    0.01 |
| Fnv1A256Block       | 32            |        887.34 ns |      0.394 ns |      0.307 ns |  17.10 |    0.05 |
| Fnv1A256SingleByte  | 32            |        921.90 ns |      0.432 ns |      0.337 ns |  17.77 |    0.05 |
| Fnv1A512Block       | 32            |      2,243.25 ns |      2.235 ns |      1.866 ns |  43.23 |    0.13 |
| Fnv1A512SingleByte  | 32            |      2,181.54 ns |      2.049 ns |      1.711 ns |  42.04 |    0.13 |
| Fnv1A1024Block      | 32            |     22,742.22 ns |     77.422 ns |     68.633 ns | 438.25 |    1.81 |
| Fnv1A1024SingleByte | 32            |     22,516.68 ns |     26.041 ns |     20.331 ns | 433.90 |    1.33 |
|                     |               |                  |               |               |        |         |
| **Fnv1A32Block**        | **1024**          |      **1,822.90 ns** |      **0.640 ns** |      **0.500 ns** |   **1.00** |    **0.00** |
| Fnv1A32SingleByte   | 1024          |      3,258.08 ns |      2.772 ns |      2.315 ns |   1.79 |    0.00 |
| Fnv1A64Block        | 1024          |      1,554.27 ns |      2.542 ns |      2.122 ns |   0.85 |    0.00 |
| Fnv1A64SingleByte   | 1024          |      3,248.66 ns |      1.490 ns |      1.244 ns |   1.78 |    0.00 |
| Fnv1A128Block       | 1024          |      7,526.53 ns |      5.227 ns |      4.081 ns |   4.13 |    0.00 |
| Fnv1A128SingleByte  | 1024          |      5,791.14 ns |      5.541 ns |      4.627 ns |   3.18 |    0.00 |
| Fnv1A256Block       | 1024          |     27,536.27 ns |      8.551 ns |      7.141 ns |  15.11 |    0.01 |
| Fnv1A256SingleByte  | 1024          |     29,427.08 ns |     14.366 ns |     12.736 ns |  16.14 |    0.01 |
| Fnv1A512Block       | 1024          |     68,826.32 ns |    173.005 ns |    144.467 ns |  37.76 |    0.08 |
| Fnv1A512SingleByte  | 1024          |     71,289.40 ns |     71.615 ns |     66.989 ns |  39.11 |    0.04 |
| Fnv1A1024Block      | 1024          |    724,420.84 ns |    383.474 ns |    339.940 ns | 397.40 |    0.21 |
| Fnv1A1024SingleByte | 1024          |    717,789.00 ns |  1,226.696 ns |  1,024.347 ns | 393.76 |    0.55 |
|                     |               |                  |               |               |        |         |
| **Fnv1A32Block**        | **65536**         |    **120,764.84 ns** |     **47.293 ns** |     **41.924 ns** |   **1.00** |    **0.00** |
| Fnv1A32SingleByte   | 65536         |    207,715.25 ns |    159.710 ns |    149.393 ns |   1.72 |    0.00 |
| Fnv1A64Block        | 65536         |     99,014.38 ns |     54.201 ns |     45.260 ns |   0.82 |    0.00 |
| Fnv1A64SingleByte   | 65536         |    205,160.13 ns |     61.727 ns |     48.192 ns |   1.70 |    0.00 |
| Fnv1A128Block       | 65536         |    481,393.80 ns |    195.283 ns |    182.668 ns |   3.99 |    0.00 |
| Fnv1A128SingleByte  | 65536         |    420,077.98 ns |    255.164 ns |    199.215 ns |   3.48 |    0.00 |
| Fnv1A256Block       | 65536         |  1,761,018.53 ns |    787.504 ns |    657.602 ns |  14.58 |    0.01 |
| Fnv1A256SingleByte  | 65536         |  1,863,929.78 ns |    511.131 ns |    426.818 ns |  15.43 |    0.01 |
| Fnv1A512Block       | 65536         |  4,458,048.74 ns | 10,795.845 ns |  9,570.235 ns |  36.92 |    0.08 |
| Fnv1A512SingleByte  | 65536         |  4,506,757.56 ns |  9,355.028 ns |  8,750.699 ns |  37.32 |    0.07 |
| Fnv1A1024Block      | 65536         | 46,411,430.32 ns | 32,530.500 ns | 30,429.050 ns | 384.31 |    0.28 |
| Fnv1A1024SingleByte | 65536         | 45,873,638.80 ns | 82,994.045 ns | 73,572.059 ns | 379.86 |    0.60 |
<!-- BENCHMARK_RESULTS_END -->

Special thanks to [crookseta](https://github.com/crookseta) for the [missing-values](https://github.com/crookseta/missing-values) project which allowed for the 256- and 512-bit variants to not have to use [BigInteger](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger), which was very slow.
