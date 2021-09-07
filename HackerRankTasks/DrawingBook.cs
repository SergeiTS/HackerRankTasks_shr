using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class DrawingBook
    {
        public static int PageCount(int n, int p)
        {
            // #1
            //int cnt;
            //if ( n % 2 == 0 )
            //{
            //    int r = n / 2 - 1;
            //    if ( p == 1 || p == n )
            //    {
            //        cnt = 0;
            //    }
            //    else
            //    {
            //        cnt = p / 2;
            //        if ( cnt > r / 2 )
            //        {
            //            cnt = r - cnt + 1;
            //        }
            //    }
            //}
            //else
            //{
            //    int r = n / 2;
            //    if ( p == 1 || p == n || p == n - 1 )
            //    {
            //        cnt = 0;
            //    }
            //    else
            //    {
            //        cnt = p / 2;
            //        if ( cnt > r / 2 )
            //        {
            //            cnt = r - cnt;
            //        }
            //    }
            //}
            //return cnt;
            // #2
            return Math.Min(p/2, (n/2 - p/2)) ;
        }
    }
}
