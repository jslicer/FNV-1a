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

This will output 85944171F73967E8 as the FNV-1A 64-bit hash of the string "foobar".

## Benchmark Results

<!-- BENCHMARK_RESULTS_START -->
```

BenchmarkDotNet v0.15.6, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method    | Mean        | Error     | StdDev    |
|---------- |------------:|----------:|----------:|
| Fnv1A32   |    180.1 μs |   0.11 μs |   0.09 μs |
| Fnv1A64   |    152.2 μs |   0.30 μs |   0.28 μs |
| Fnv1A128  |    922.5 μs |   2.60 μs |   2.30 μs |
| Fnv1A256  |  5,687.8 μs |  11.63 μs |  10.88 μs |
| Fnv1A512  | 19,059.5 μs |  75.20 μs |  66.66 μs |
| Fnv1A1024 | 89,402.9 μs | 794.42 μs | 704.23 μs |
<!-- BENCHMARK_RESULTS_END -->

Special thanks to [crookseta](https://github.com/crookseta) for the [missing-values](https://github.com/crookseta/missing-values) project which allowed for the 256- and 512-bit variants to not have to use [BigInteger](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger), which was very slow.
