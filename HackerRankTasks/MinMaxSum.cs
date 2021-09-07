using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class MinMaxSum
    {
        public static void MiniMaxSum(long[] arr)
        {
            
            List<long> arrL = arr.ToList<long>();
            arrL.Sort();
            List<long> arrMin = new List<long>(arrL.Take(arrL.Count - 1));
            arrL.RemoveAt(0);
            long minSum = arrMin.Sum();
            long maxSum = arrL.Sum();

            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}
