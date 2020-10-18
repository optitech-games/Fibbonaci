using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace Main
{
    class Program
    {
        static void Main()
        {
            List<int> num = new List<int>(0);
            Console.WriteLine("Hur många tal?");
            int x = int.Parse(Console.ReadLine());
            int i = 0;
            int o = 1;
            int r;
            while (num.Count+1 != x)
            {
                r = i + o;
                o = i;
                i = r;
                num.Add(r);
            }
            Console.Write("alla nummer: "+0);
            foreach(int f in num) {Console.Write( ","+f); }
                
        }
    }
}
