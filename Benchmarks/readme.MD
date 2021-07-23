BenchmarkDotNet=v0.13.0, OS=macOS Big Sur 11.3.1 (20E241) [Darwin 20.4.0]
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.301
[Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


|                              Method |       Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------------------ |-----------:|----------:|----------:|-------:|-------:|------:|----------:|
|                   SumIntervalsOLogN |   323.1 ns |   6.31 ns |   9.63 ns | 0.1135 |      - |     - |     712 B |
| SumIntervalsMySolutionNoLinqHashSet | 3,892.4 ns |  54.19 ns |  48.03 ns | 0.9613 |      - |     - |   6,072 B |
|          SumIntervalsMySolutionLinq | 8,922.1 ns |  37.11 ns |  32.90 ns | 2.0294 | 0.0153 |     - |  12,824 B |
|        SumIntervalsMySolutionNoLinq | 8,960.4 ns |  69.44 ns |  61.56 ns | 0.3510 |      - |     - |   2,296 B |
|               SumIntervalsCleverest | 9,876.6 ns | 196.12 ns | 233.46 ns | 1.3885 |      - |     - |   8,776 B |

// * Hints *
Outliers
Intervals.SumIntervalsOLogN: Default                   -> 1 outlier  was  removed (349.74 ns)
Intervals.SumIntervalsMySolutionNoLinqHashSet: Default -> 1 outlier  was  removed (4.04 us)
Intervals.SumIntervalsMySolutionLinq: Default          -> 1 outlier  was  removed, 2 outliers were detected (8.84 us, 9.10 us)
Intervals.SumIntervalsMySolutionNoLinq: Default        -> 1 outlier  was  removed (9.59 us)
Intervals.SumIntervalsCleverest: Default               -> 1 outlier  was  removed (10.59 us)

// * Legends *
Mean      : Arithmetic mean of all measurements
Error     : Half of 99.9% confidence interval
StdDev    : Standard deviation of all measurements
Gen 0     : GC Generation 0 collects per 1000 operations
Gen 1     : GC Generation 1 collects per 1000 operations
Gen 2     : GC Generation 2 collects per 1000 operations
Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
1 ns      : 1 Nanosecond (0.000000001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
// ** Remained 0 benchmark(s) to run **
Run time: 00:01:34 (94.68 sec), executed benchmarks: 5

Global total time: 00:01:38 (98.51 sec), executed benchmarks: 5
// * Artifacts cleanup *
