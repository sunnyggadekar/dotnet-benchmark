``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2486/21H2/November2021Update)
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.202
  [Host]     : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT AVX2


```
|            Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
|------------------ |---------:|---------:|---------:|-------:|----------:|
|     DateSeperated | 95.56 ns | 1.768 ns | 1.476 ns | 0.0612 |      96 B |
| DateSeperatedSpan | 62.47 ns | 0.479 ns | 0.425 ns |      - |         - |
