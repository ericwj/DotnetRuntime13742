``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.778 (1909/November2018Update/19H2)
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.300-preview-015135
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|                                   Method |        Mean |     Error |    StdDev | Code Size |
|----------------------------------------- |------------:|----------:|----------:|----------:|
|                   FromByteRef_NoInlining |   204.94 ns |  1.213 ns |  1.135 ns |    2195 B |
|                 FromByteRef_FullInlining |    23.32 ns |  0.082 ns |  0.077 ns |    1296 B |
|             FromByteRef_InlineFieldReads |    89.27 ns |  0.337 ns |  0.298 ns |    1751 B |
|            FromByteRef_InlineStructReads |   143.18 ns |  0.496 ns |  0.439 ns |    1245 B |
|          FromByteRef_ManualFieldForField |    22.23 ns |  0.164 ns |  0.153 ns |    1198 B |
|                      FromSpan_NoInlining |   510.00 ns |  6.581 ns |  6.156 ns |    5288 B |
|                    FromSpan_FullInlining |   347.60 ns |  3.847 ns |  3.598 ns |    7982 B |
|                FromSpan_InlineFieldReads |   152.35 ns |  2.759 ns |  2.581 ns |    5568 B |
|               FromSpan_InlineStructReads |   233.63 ns |  2.727 ns |  2.417 ns |    4616 B |
| FromSpan_ManualFieldForField_Progressive | 1,042.15 ns | 12.135 ns | 11.351 ns |   12177 B |
|  FromSpan_ManualFieldForField_NoProgress |   915.45 ns |  5.443 ns |  4.545 ns |   10544 B |
