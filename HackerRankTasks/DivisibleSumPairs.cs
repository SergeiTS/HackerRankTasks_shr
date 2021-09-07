using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class DivisibleSumPairs
    {
        public static int MDivisibleSumPairs(int n, int k, int[] ar)
        {
            int cnt = 0;
            for ( int i = 0; i < n - 1; i++ )
            {
                for ( int j = i + 1; j < n; j++ )
                {
                    if ( (ar[i] + ar[j]) % k == 0 )
                    {
                        cnt++;
                    }
                }

            }
            return cnt;
        }
    }
}
