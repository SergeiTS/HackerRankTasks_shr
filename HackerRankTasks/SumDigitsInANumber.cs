using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class SumDigitsInANumber
    {
        public static int SumDigits(int n)
        {
            int sum = 0;
            while ( n > 0 )
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
