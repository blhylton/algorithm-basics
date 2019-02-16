using System;

namespace Pt3Assignment3
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var n = long.Parse(input);
            input = Console.ReadLine();
            if (input == null) return;
            var splitInput = input.Split(' ');
            var a = new long[n];
            for (var i = 0; i < n; i++)
            {
                a[i] = long.Parse(splitInput[i]);
            }

            Array.Sort<long>(a, new Comparison<long>((i1, i2) => i2.CompareTo(i1)));
            
            input = Console.ReadLine();
            if (input == null) return;
            splitInput = input.Split(' ');
            var b = new long[n];
            for (var i = 0; i < n; i++)
            {
                b[i] = long.Parse(splitInput[i]);
            }
            
            Array.Sort<long>(b, new Comparison<long>((i1, i2) => i2.CompareTo(i1)));

            long sum = 0;
            for (var i = 0; i < n; i++)
            {
                sum += (a[i] * b[i]);
            }
            
            Console.WriteLine(sum);
        }
    }
}