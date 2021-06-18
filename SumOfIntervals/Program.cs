using System;
using System.Linq;
using Interval = System.ValueTuple<int, int>;

namespace SumOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SumIntervals(new Interval[] { (-1, 4), (-5, -3) }));
            
        }
        
        public static int SumIntervals((int, int)[] intervals)
        {
            for (var i = 0; i < intervals.Length; i++)
            {
                if (intervals[i].Item1 < 0 && intervals[i].Item2 < 0)
                {
                    if(intervals[i+1].Item1< intervals[i].Item1)
                }
            }
        }
    }
}