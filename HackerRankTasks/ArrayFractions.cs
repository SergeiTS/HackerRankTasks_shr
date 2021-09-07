using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    public static class ArrayFractions
    {
        public static void PlusMinus(int[] arr)
        {
            decimal positive, negative, zero;
            decimal cPositive = 0, cNegative = 0, cZeroes = 0;

            foreach ( int a in arr )
            {
                if ( a > 0 )
                {
                    cPositive++;
                }
                else if ( a < 0 )
                {
                    cNegative++;
                }
                else
                {
                    cZeroes++;
                }
            }
            decimal arrLength = arr.Length;
            positive = cPositive / arrLength;
            negative = cNegative / arrLength;
            zero = cZeroes / arrLength;

            Console.WriteLine(positive);
            Console.WriteLine(negative);
            Console.WriteLine(zero);

        }
    }
}
