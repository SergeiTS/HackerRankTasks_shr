using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    public static class ArrayReverse
    {
        public static void Reverse(int[] array)
        {
            for ( int i = 0; i < array.Length / 2; i++ )
            {
                int other = array.Length - i - 1;
                int temp = array[i];
                array[i] = array[other];
                array[other] = temp;
            }
            foreach ( int a in array )
            {
                Console.Write($"{a} ");
            }
        }
    }
}
