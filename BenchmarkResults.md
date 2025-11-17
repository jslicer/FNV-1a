```

BenchmarkDotNet v0.15.6, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method    | Mean        | Error     | StdDev    |
|---------- |------------:|----------:|----------:|
| Fnv1A32   |    179.9 μs |   0.05 μs |   0.04 μs |
| Fnv1A64   |    151.6 μs |   0.03 μs |   0.02 μs |
| Fnv1A128  |  1,172.5 μs |  36.83 μs | 105.66 μs |
| Fnv1A256  |  5,609.5 μs |   1.64 μs |   1.45 μs |
| Fnv1A512  | 18,977.2 μs |  48.15 μs |  42.68 μs |
| Fnv1A1024 | 87,582.7 μs | 498.86 μs | 466.64 μs |
