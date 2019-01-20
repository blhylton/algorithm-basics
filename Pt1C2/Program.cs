using System;
using System.Linq;
using System.Collections.Generic;

namespace Pt1C2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var input = Console.ReadLine();
            if (input == null) return;
            var tokens = input.Split(' ').Select(long.Parse).ToList();
            if (tokens.Count != int.Parse(n)) return;

            Console.WriteLine( MaxPairwiseProduct(tokens).ToString());
        }

        private static long MaxPairwiseProduct(IEnumerable<long> numbers)
        {
            long a = 0;
            long b = 0;
            foreach (var num in numbers)
            {
                if (num > a)
                {
                    if (a > b)
                    {
                        b = a;
                    }

                    a = num;
                    continue;
                }

                if (num > b)
                {
                    b = num;
                }
            }
            
            return a * b;
        }
    }
}