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
