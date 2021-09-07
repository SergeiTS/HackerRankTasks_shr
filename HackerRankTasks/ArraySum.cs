using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    public static class ArraySum
    {
        public static int MArraySum(int[] ar)
        {
            int result = 0;
            foreach ( int a in ar )
            {
                result += a;
            }
            return result;
        }
    }
}
