using System;
using System.Linq;

namespace Are_They_Same
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int[] a = new int[1];
            int[] b = new int[2];
            Console.WriteLine(comp(a, b));
        }
        
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null)
                return false;
            if(b.Length == 0 || a.Length == 0)
            {
                return b.Length == 0 && a.Length == 0;
            }
    
  
            var same = 0;
            foreach (var t in a)
            {
                for (var j = 0; j < b.Length; j++)
                {
                    if (!b[j].Equals(t * t)) continue;
                    same++;
                    b[j] = 0;
                    break;
                }
            }
            return same == a.Length;
        }
    }
}