``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2965)
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.202
  [Host]     : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT AVX2
  DefaultJob : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT AVX2


```
|     Method |      Mean |     Error |    StdDev |    Median | Allocated |
|----------- |----------:|----------:|----------:|----------:|----------:|
|   OpenVoid | 0.6555 ns | 0.0517 ns | 0.0484 ns | 0.6347 ns |         - |
| SealedVoid | 0.0120 ns | 0.0209 ns | 0.0163 ns | 0.0061 ns |         - |
