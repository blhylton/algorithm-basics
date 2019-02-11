using System;

namespace Pt3Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var n = ulong.Parse(input);
            ulong count10 = 0, count5 = 0, count = 0;

            count10 = (n - (n % 10)) / 10;
            n = n - (count10 * 10);
            count5 = (n - n % 5) / 5;
            n = n - (count5 * 5);
            count = count10 + count5 + n;
            
            Console.WriteLine(count);
        }
    }
}