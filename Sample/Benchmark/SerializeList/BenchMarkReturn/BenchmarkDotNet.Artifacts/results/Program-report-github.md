``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.19 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
Frequency=2835939 Hz, Resolution=352.6169 ns, Timer=TSC
.NET Core SDK=2.1.301
  [Host]     : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT


```
|       Method |     Mean |     Error |    StdDev |
|------------- |---------:|----------:|----------:|
| NoYieldAsync | 94.86 ms | 1.0425 ms | 0.8705 ms |
|   YieldAsync | 90.54 ms | 0.9845 ms | 0.9209 ms |
