using System;
using System.Collections.Generic;
using System.Linq;
using Interval = System.ValueTuple<int, int>;

namespace SumOfIntervals
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SumIntervals(new[] { (1, 5), (10, 20), (1, 6), (16, 19), (5, 11) }));
            
        }
        
        public static int SumIntervals((int, int)[] intervals)
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
    }
}