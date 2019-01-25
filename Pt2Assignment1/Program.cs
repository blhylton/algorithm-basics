using System;

namespace Pt2Prac2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var n = long.Parse(input);
            Console.WriteLine(Fibonacci(n));
        }

        private static long Fibonacci(long n)
        {
            if(n <= 1)
            {
                return n;
            }

            long a = 0, b = 1;

            for (var i = 2; i <= n; i++)
            {
                var temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}