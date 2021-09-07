using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    public static class BigSum
    {
        public static long AVeryBigSum(long[] ar)
        {
            long result = 0;
            foreach ( long a in ar )
            {
                result += a;
            }
            return result;
        }
    }
}
