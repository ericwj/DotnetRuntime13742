``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.329 (2004/?/20H1)
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.100-preview.5.20279.10
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT


```
|                                   Method |      Mean |     Error |    StdDev | Code Size |
|----------------------------------------- |----------:|----------:|----------:|----------:|
|                   FromByteRef_NoInlining | 202.61 ns |  1.870 ns |  1.750 ns |    1829 B |
|                 FromByteRef_FullInlining |  24.27 ns |  0.215 ns |  0.190 ns |    1429 B |
|             FromByteRef_InlineFieldReads |  89.66 ns |  0.597 ns |  0.559 ns |    1593 B |
|            FromByteRef_InlineStructReads | 145.44 ns |  1.759 ns |  1.559 ns |    1279 B |
|          FromByteRef_ManualFieldForField |  22.35 ns |  0.124 ns |  0.116 ns |    1233 B |
|  FromByteRef_ManualFieldForField_BigData |  22.34 ns |  0.100 ns |  0.084 ns |    1211 B |
|                      FromSpan_NoInlining | 335.91 ns |  6.640 ns |  6.211 ns |    5035 B |
|                    FromSpan_FullInlining | 253.12 ns |  3.687 ns |  3.268 ns |    5867 B |
|                FromSpan_InlineFieldReads | 132.00 ns |  2.440 ns |  2.163 ns |    4371 B |
|               FromSpan_InlineStructReads | 221.04 ns |  1.556 ns |  1.456 ns |    3877 B |
| FromSpan_ManualFieldForField_Progressive | 969.68 ns | 10.910 ns | 10.205 ns |   10544 B |
|  FromSpan_ManualFieldForField_NoProgress | 779.83 ns |  6.176 ns |  5.777 ns |    8509 B |
