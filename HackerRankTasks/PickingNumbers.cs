using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class PickingNumbers
    {
        public static int MPickingNumbers(List<int> a)
        {
            int cnt = 0;
            List<int> resL = new List<int>();
            a.Sort();
            if ( (a.Max() - a.Min()) <= 1 )
            {
                return a.Count;
            }
            for ( int i = 0; i < a.Count - 1; i++ )
            {
                for ( int j = i + 1; j < a.Count; j++ )
                {
                    if ( Math.Abs(a[i] - a[j]) <= 1 )
                    {
                        cnt++;
                    }
                    else
                    {
                        resL.Add(cnt + 1);
                        cnt = 0;
                        break;
                    }
                }
            }
            return resL.Max();
        }
    }
}
