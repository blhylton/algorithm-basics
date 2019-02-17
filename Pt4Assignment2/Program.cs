using System;

namespace Pt4Assignment2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var n = long.Parse(input);
            input = Console.ReadLine();
            if (input == null) return;
            var splitInput = input.Split(' ');

            var arr = new long[n];

            for (var i = 0; i < n; i++)
            {
                arr[i] = long.Parse(splitInput[i]);
            }
            
            Array.Sort(arr);
            
            Console.WriteLine(FindMajority(arr, n));
        }

        private static int FindMajority(long[] arr, long n)
        {
            for (var i = 0; i < (long) Math.Ceiling((double) n / 2); i++)
            {
                var j = (long) Math.Floor((double) n / 2) + i;
                if (arr[i] == arr[j])
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}