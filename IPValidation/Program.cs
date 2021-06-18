using System;
using System.Text.RegularExpressions;

namespace IPValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is_valid_IP("192.168.0.1"));
        }
        public static bool is_valid_IP(string ipAddress)
        {
            return new Regex (@"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)(\.(?!$)|$)){4}$").IsMatch(ipAddress);
        }
    }
}