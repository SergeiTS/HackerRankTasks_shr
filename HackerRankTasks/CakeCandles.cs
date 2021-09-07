using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class CakeCandles
    {
        public static int BirthdayCakeCandles(int[] ar)
        {
            int cnt = 0;
            int maxArr = ar.Max();
            foreach ( int a in ar )
            {
                if ( a == maxArr )
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
