using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ArrayDiff(new int[] {1,2}, new int[] {1}));
        }
        
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            foreach (var itemb in b)
            {
                if(a.Any(x=>x==itemb))
                    a = a.Where(val => val != itemb).ToArray();
            }

            return a;
        }
    }
}