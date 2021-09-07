using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class PrimeNumberCheck
    {
        public static bool IsPrime(int n)
        {
            //for ( int x = 2; x * x <= n; x++ )
            for ( int x = 2; Math.Sqrt(n) >= x; x++ )
            {
                if ( n % x == 0 )
                {
                    return false;
                }
            }
            return true;
        }
    }
}
