using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class MagicSquare
    {
        public static int FormingMagicSquare(int[][] s)
        {
            List<int> ss = new List<int>();
            for ( int m = 0; m < s.Length; m++ )
            {
                for ( int n = 0; n < s[m].Length; n++ )
                {
                    ss.Add(s[m][n]);
                }
            }

            List<int> cst = new List<int>();
            int sum;
            int[][] solutions = new int[][] {
            new int[] {8, 1, 6, 3, 5, 7, 4, 9, 2 },
            new int[] {6, 1, 8, 7, 5, 3, 2, 9, 4 },
            new int[] {4, 9, 2, 3, 5, 7, 8, 1, 6 },
            new int[] {2, 9, 4, 7, 5, 3, 6, 1, 8 },
            new int[] {8, 3, 4, 1, 5, 9, 6, 7, 2 },
            new int[] {4, 3, 8, 9, 5, 1, 2, 7, 6 },
            new int[] {6, 7, 2, 1, 5, 9, 8, 3, 4 },
            new int[] {2, 7, 6, 9, 5, 1, 4, 3, 8 },
            };

            for ( int i = 0; i < solutions.Length; i++ )
            {
                sum = 0;
                for ( int j = 0; j < ss.Count; j++ )
                {
                        sum += Math.Abs(solutions[i][j] - ss[j]);
                }
                cst.Add(sum);
            }
            return cst.Min();
        }
    }
}
