```

BenchmarkDotNet v0.15.6, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method    | Mean        | Error     | StdDev    |
|---------- |------------:|----------:|----------:|
| Fnv1A32   |    179.9 μs |   0.07 μs |   0.06 μs |
| Fnv1A64   |    150.0 μs |   0.04 μs |   0.03 μs |
| Fnv1A128  |  1,189.1 μs |  24.71 μs |  72.85 μs |
| Fnv1A256  |  5,621.3 μs |   4.06 μs |   3.39 μs |
| Fnv1A512  | 19,311.2 μs |  20.70 μs |  18.35 μs |
| Fnv1A1024 | 88,004.9 μs | 841.03 μs | 786.70 μs |
