using System;

namespace Pt2Assignment2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var n = ulong.Parse(input);
            n = FibonacciLastDigit(n);
            Console.WriteLine(n);
        }

        private static ulong FibonacciLastDigit(ulong n)
        {
            if(n <= 1)
            {
                return n;
            }

            ulong a = 0, b = 1;

            for (uint i = 2; i <= n; i++)
            {
                var temp = a + b;
                a = b % 10;
                b = temp % 10;
            }

            return b;
        }
    }
}