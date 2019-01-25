using System;

namespace Pt2Prac1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var inputs = input.Split(' ');
            long[] n = { long.Parse(inputs[0]), long.Parse(inputs[1]) };
            Console.WriteLine(EuclidGcd(n[0], n[1]));
        }

        private static long EuclidGcd(long a, long b)
        {
            while (true)
            {
                if (b == 0)
                {
                    return a;
                }

                var rem = a % b;
                a = b;
                b = rem;
            }
        }
    }
}