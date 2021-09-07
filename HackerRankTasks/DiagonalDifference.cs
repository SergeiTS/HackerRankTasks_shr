using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    public static class DiagonalDifference
    {
        public static int MDiagonalDifference(List<List<int>> arr)
        {
            int sumD1 = 0, sumD2 = 0;
            int count = arr.Count;
            for ( int i = 0; i < count; i++ )
            {
                sumD1 += arr[i][i];
                sumD2 += arr[i][count - i - 1];
            }
            return Math.Abs(sumD1 - sumD2);

        }
    }
}
