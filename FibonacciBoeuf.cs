using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    static class FibonacciBoeuf
    {
        public static int Calculate(int n)
        {
            return 
                n == 0 ? 0 : n == 1 ? 1 :
                Calculate(n - 1) + Calculate(n - 2);
        }
    }
}
