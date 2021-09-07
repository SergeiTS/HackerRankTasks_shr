using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class Kangaroo
    {
        public static string MKangaroo(int x1, int v1, int x2, int v2)
        {
            for ( int i = 0; i <= 10000; i++ )
            {
                x1 += v1;
                x2 += v2;
                if ( x1 == x2 )
                {
                    return "YES";
                }
                else
                {
                    continue;
                }
            }
            return "NO";
        }
    }
}
