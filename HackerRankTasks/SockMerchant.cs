using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class SockMerchant
    {
        public static int MSockMerchant(int n, int[] ar)
        {
            int cnt = 0;
            for ( int i = 0; i < n - 1; i++ )
            {
                for ( int j = i + 1; j < n; j++ )
                {
                    if ( (ar[i] == ar[j]) && (ar[i] != 0) )
                    {
                        cnt++;
                        ar[i] = 0;
                        ar[j] = 0;
                    }
                }
            }
            return cnt;
        }
    }
}
