using System;

namespace BuyingCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            nbMonths(12000, 8000, 1000, 1.5);
        }
        
        public static int[] nbMonths(double startPriceOld, double startPriceNew, double savingPerMonth, double percentLossByMonth) {
            var monthLeft = 0;
            var savings = 0d;
            do
            {
                if (startPriceNew - (startPriceOld + savings) > 0)
                {
                    savings += savingPerMonth;
                }
                else
                {
                    break;
                }
                monthLeft++;
                startPriceNew -= startPriceNew * (percentLossByMonth / 100.0);
                startPriceOld -= startPriceOld * (percentLossByMonth / 100.0);
                //savings += savingPerMonth;
                
                if ((monthLeft + 1) % 2 == 0)
                    percentLossByMonth += 0.5d;
                Console.WriteLine(startPriceNew - (startPriceOld + savings));
                
            }
            while (true);
            
            return new[] {monthLeft,(int)Math.Ceiling(savings + startPriceOld - startPriceNew)};
        }
    }
}