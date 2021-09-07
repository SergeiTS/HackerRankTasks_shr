using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class BetweenTwoSets
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            int cnt = 0;
            bool res = true;
            int amax = a.Max();
            int bmin = b.Min();
            var range = Enumerable.Range(amax, (Math.Abs(bmin - amax) + 1));
            int rcount = range.Count();
            for ( int i = 0; i < rcount; i++ )
            {
                res = true;
                for ( int n = 0; n < a.Count; n++ )
                {
                    if ( range.ElementAt(i) % a[n] != 0)
                    {
                        res = false;
                        break;
                    }
                }
                for ( int m = 0; m < b.Count; m++ )
                {
                    if ( !res )
                    {
                        break;
                    }
                    if ( b[m] % range.ElementAt(i) != 0 )
                    {
                        res = false;
                        break;
                    }
                }
                if ( res )
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
