``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.1889/21H2/November2021Update)
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.202
  [Host]     : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT AVX2


```
|     Method |      Mean |     Error |    StdDev |    Median | Allocated |
|----------- |----------:|----------:|----------:|----------:|----------:|
|   OpenVoid | 0.6538 ns | 0.0335 ns | 0.0297 ns | 0.6593 ns |         - |
| SealedVoid | 0.0307 ns | 0.0266 ns | 0.0555 ns | 0.0000 ns |         - |
