``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-3610QM CPU 2.30GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2241013 Hz, Resolution=446.2268 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|  Method |     Mean |     Error |    StdDev |
|-------- |---------:|----------:|----------:|
| NoYield | 60.93 ms | 1.1103 ms | 0.9843 ms |
|   Yield | 98.26 ms | 0.7158 ms | 0.6346 ms |
