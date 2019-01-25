using System;
using System.Numerics;

namespace Pt2Assignment2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var n = BigInteger.Parse(input);
            n = Fibonacci(n);
            Console.WriteLine((n % 10));
        }

        private static BigInteger Fibonacci(BigInteger n)
        {
            if(n <= 1)
            {
                return n;
            }

            BigInteger a = 0, b = 1;

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