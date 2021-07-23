using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Interval = System.ValueTuple<int, int>;

namespace Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class Intervals
    {
        private static Interval[] Interval => new[] {(-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26)};


        [Benchmark]
        public void SumIntervalsMySolutionLinq()
        {
            SumIntervalsMySolutionLinqInternal(Interval);
        }
        
        [Benchmark]
        public void SumIntervalsMySolutionNoLinq()
        {
            SumIntervalsMySolutionNoLinqInternal(Interval);
        }
        
        [Benchmark]
        public void SumIntervalsMySolutionNoLinqHashSet()
        {
            SumIntervalsMySolutionNoLinqInternalSet(Interval);
        }
        
        [Benchmark]
        public void SumIntervalsCleverest()
        {
            SumIntervalsCleverestInternal(Interval);
        }

        [Benchmark]
        public void SumIntervalsOLogN()
        {
            SumIntervalsOLogNInternal(Interval);
        }

        private static int SumIntervalsMySolutionLinqInternal((int, int)[] intervals)
        {
            var array = new List<int>();
            for (var i = 0; i < intervals.Length; i++)
            {
                for(var k = intervals[i].Item1; k < intervals[i].Item2; k++)
                {
                    array.Add(k);
                }
            }
            return array.Distinct().Count();
        }
        
        private static int SumIntervalsMySolutionNoLinqInternal((int, int)[] intervals)
        {
            var array = new List<int>();
            for (var i = 0; i < intervals.Length; i++)
            {
                for(var k = intervals[i].Item1; k < intervals[i].Item2; k++)
                {
                    if(!array.Contains(k))
                        array.Add(k);
                }
            }

            return array.Count;
        }
        
        private static int SumIntervalsMySolutionNoLinqInternalSet((int, int)[] intervals)
        {
            var array = new HashSet<int>();
            for (var i = 0; i < intervals.Length; i++)
            {
                for(var k = intervals[i].Item1; k < intervals[i].Item2; k++)
                {
                    if (!array.Contains(k))
                        array.Add(k);
                }
            }

            return array.Count;
        }
        
        private static int SumIntervalsCleverestInternal((int, int)[] intervals)
        {
            return intervals
                .SelectMany(i => Enumerable.Range(i.Item1, i.Item2 - i.Item1))
                .Distinct()
                .Count();
        }
        
        private static int SumIntervalsOLogNInternal((int min, int max)[] intervals)
        {
            var prevMax = int.MinValue;
        
            return intervals
                .OrderBy(x => x.min)
                .ThenBy(x => x.max)
                .Aggregate(0, (acc, x) => acc += prevMax < x.max ? - Math.Max(x.min, prevMax) + (prevMax = x.max) : 0);
        }
    }
}