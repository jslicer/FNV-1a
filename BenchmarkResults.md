```

BenchmarkDotNet v0.15.6, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method    | Mean        | Error     | StdDev    |
|---------- |------------:|----------:|----------:|
| Fnv1A32   |    179.9 μs |   0.03 μs |   0.02 μs |
| Fnv1A64   |    151.6 μs |   0.03 μs |   0.03 μs |
| Fnv1A128  |    925.0 μs |   1.51 μs |   1.26 μs |
| Fnv1A256  |  5,622.3 μs |   6.46 μs |   5.73 μs |
| Fnv1A512  | 19,297.4 μs |   8.28 μs |   7.74 μs |
| Fnv1A1024 | 89,152.6 μs | 180.52 μs | 160.02 μs |
