using System;
using System.Collections.Generic;
using System.Linq;

namespace Pt4Assignment3
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var n = int.Parse(input);

            input = Console.ReadLine();
            var splitInput = input.Split(' ');

            var arr = new long[n];

            for (var i = 0; i < n; i++)
            {
                arr[i] = long.Parse(splitInput[i]);
            }
            
            QuickSort3(arr, 0, n - 1 );
            
            Console.WriteLine(string.Join(" ", arr));
            
        }

        private static void QuickSort3(long[] arr, int l, int r)
        {
            if (l >= r) return;

            var i = 0;
            var j = 0;

            Partition3(arr, l, r, ref i, ref j);
            
            QuickSort3(arr, l, i);
            QuickSort3(arr, j, r);

        }

        private static void Partition3(long[] arr, int l, int r, ref int i, ref int j)
        {
            var m = l;
            
            //Get random pivot
            var rand = new Random();
            var p = arr[rand.Next(l, r)];

            while (m <= r)
            {
                if (arr[m] < p)
                {
                    Swap(ref arr[l], ref arr[m]);
                    m++;
                    l++;
                }
                else if (arr[m] == p)
                {
                    m++;
                }
                else
                {
                    Swap(ref arr[m], ref arr[r]);
                    r--;
                }
            }

            i = l - 1;
            j = m;
        }

        private static void Swap(ref long a, ref long b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}