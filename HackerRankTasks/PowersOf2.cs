using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class PowersOf2
    {
        public static int MPowersOf2(int n)
        {
            if ( n < 1 )
            {
                Console.WriteLine(0);
                return 0;
            }
            else if ( n == 1 )
            {
                Console.WriteLine(1);
                return 1;

            }
            else
            {
                int prev = MPowersOf2(n / 2);
                int curr = prev * 2;
                Console.WriteLine(curr);
                return curr;
            }
        }
    }
}
