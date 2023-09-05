``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2965)
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.202
  [Host]     : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT AVX2


```
|          Method |     Mean |   Error |   StdDev |   Gen0 | Allocated |
|---------------- |---------:|--------:|---------:|-------:|----------:|
| SingleOrDefault | 476.9 ns | 1.96 ns |  1.73 ns | 0.0248 |      40 B |
|  FirstOrDefault | 253.2 ns | 4.25 ns |  5.52 ns | 0.0253 |      40 B |
|           First | 257.1 ns | 1.20 ns |  0.94 ns | 0.0253 |      40 B |
|          Single | 497.1 ns | 9.75 ns | 13.01 ns | 0.0248 |      40 B |
