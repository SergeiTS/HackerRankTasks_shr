using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class FibonacciCaching
    {
        public static void AllFib(int n)
        {
            int[] memo = new int[n + 1];
            for ( int i = 0; i < n; i++ )
            {
                Console.WriteLine($"{i}: {Fib(i, memo)}");
            }
        }

        static int Fib(int n, int[] memo)
        {
            if ( n <= 0 )
                return 0;
            else if ( n == 1 )
                return 1;
            else if ( memo[n] > 0 )
                return memo[n];

            memo[n] = Fib(n - 1, memo) + Fib(n - 2, memo);
            return memo[n];
        }
    }
}
