using System;
using System.Collections.Generic;

namespace Pt4Assignment1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var splitInput = input.Split(' ');
            var n = long.Parse(splitInput[0]);
            var arr = new long[n];

            for (var i = 0; i < n; i++)
            {
                arr[i] = long.Parse(splitInput[i + 1]);
            }

            input = Console.ReadLine();
            if (input == null) return;
            splitInput = input.Split(' ');
            var k = long.Parse(splitInput[0]);

            for (var i = 0; i < k; i++)
            {
                Console.Write(BinarySearch(long.Parse(splitInput[i + 1]), arr));
                Console.Write(' ');
            }
        }

        private static long BinarySearch(long needle, long[] haystack)
        {
            var i = (long)0;
            var j = (long)haystack.Length - 1;
            var m = (long)j;
            
            while (i <= j)
            {
                m = i + (long)Math.Floor((double)(j - i) / 2);

                if (haystack[m] == needle) return m;

                if (haystack[m] < needle) i = m + 1;

                else j = m - 1;
            }

            return -1;
        }
    }
}