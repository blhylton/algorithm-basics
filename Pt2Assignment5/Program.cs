using System;

namespace Pt2Assignment5
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var inputs = input.Split(' ');
            ulong[] n = {ulong.Parse(inputs[0]), ulong.Parse(inputs[1])};
            
            var pisanoLength = FindPisanoPeriodLength(n[1]);

            var mod = n[0] % pisanoLength;

            Console.WriteLine(FibonacciModulo(mod, n[1]));

        }

        private static ulong FindPisanoPeriodLength(ulong m)
        {
            float a = 0, b = 1;
            ulong i = 0;
            for (i = 0; i < m * m; i++)
            {
                var temp = (a + b) % m;
                a = b;
                b = temp;

                if (a == 0 && b == 1) return i + 1;
            }


            return i;
        }
        
        private static ulong FibonacciModulo(ulong n, ulong m)
        {
            if(n <= 1)
            {
                return n;
            }

            ulong a = 0, b = 1;

            for (uint i = 2; i <= n; i++)
            {
                var temp = a + b;
                a = b % m;
                b = temp % m;
            }

            return b;
        }
    }
}