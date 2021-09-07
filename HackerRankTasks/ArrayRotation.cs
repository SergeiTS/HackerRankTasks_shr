using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class ArrayRotation
    {
        public static void LeftShiftArray<T>(T[] a, int d)
        {
            d %= a.Length;
            T[] buffer = new T[d];
            Array.Copy(a, buffer, d);
            Array.Copy(a, d, a, 0, a.Length - d);
            Array.Copy(buffer, 0, a, a.Length - d, d);
        }

        public static int[] RotLeft(int[] a, int d)
        {
            int rowsMatrix = a.Length;
            int[] temp = new int[d];

            for ( int i = 0; i < d; i++ )
                temp[i] = a[i];

            for ( int i = d; i < rowsMatrix; i++ )
            {
                a[i - d] = a[i];
            }

            for ( int i = 0; i < d; i++ )
                a[rowsMatrix - d + i] = temp[i];
            return a;
        }
    }
}
