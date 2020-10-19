using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Linq;
using Fibonacci;

namespace Main
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vem är vackrast (O/E)?");
            var t = Console.ReadLine();

            Console.WriteLine("Hur många tal?");
            int x = int.Parse(Console.ReadLine());

            var num = Calculate(t, x);

            Console.Write("alla nummer: " + 0);
            foreach (int f in num) { Console.Write("," + f); }
        }

        private static ICollection<int> Calculate(string type, int x)
        {
            switch (type.ToLower())
            {
                case "o": return Calculate1(x);
                case "e": return Calculate2(x);
                default: throw new ApplicationException($"Vi känner inte '{type}', sorry.");
            }
        }

        static ICollection<int> Calculate1(int x)
        {
            List<int> num = new List<int>(0);

            int i = 0;
            int o = 1;
            int r;

            while (num.Count + 1 != x)
            {
                r = i + o;
                o = i;
                i = r;
                num.Add(r);
            }

            return num;
        }

        static ICollection<int> Calculate2(int n)
        {
            return Enumerable.Range(0, n)
                .Select(i => FibonacciBoeuf.Calculate(i))
                .ToArray();
        }
    }
}
