using System;

namespace Pt2Assignment6
{
    class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var n = ulong.Parse(input);
            var pisanoLength = FindPisanoPeriodLength(10);

            var mod = (n+2) % pisanoLength;
            Console.WriteLine((Fibonacci(mod) - 1) % 10);

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
        
        private static ulong Fibonacci(ulong n)
        {
            if(n <= 1)
            {
                return n;
            }

            ulong a = 0, b = 1;

            for (uint i = 2; i <= n; i++)
            {
                var temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}