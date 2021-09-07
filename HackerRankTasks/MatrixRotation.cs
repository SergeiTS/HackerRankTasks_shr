using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class MatrixRotation
    {
        #region Helper methods
        public static List<int> ConvertToList(List<List<int>> ls)
        {
            List<int> result = new List<int>();
            int rows = ls.Count;
            for ( int i = 0; i < rows; i++ )
            {
                int rowsI = ls[i].Count;
                for ( int j = 0; j < rowsI; j++ )
                {
                    result.Add(ls[i][j]);
                }

            }
            return result;
        }
        public static int GetCount(List<List<int>> ls)
        {
            int result = 0;
            int rows = ls.Count;
            for ( int i = 0; i < rows; i++ )
            {
                result += ls[i].Count;
            }
            return result;
        }
        public static bool GetParity(List<List<int>> ls)
        {
            List<int> rList = new List<int>();
            int rows = ls.Count;
            for ( int s = 0; s < rows; s++ )
            {
                int rowsS = ls[s].Count;
                for ( int i = 0; i < rowsS; i++ )
                {
                    rList.Add(ls[s][i]);
                }
            }
            int rowsR = rList.Count;
            for ( int j = 1; j < rowsR; j++ )
            {
                if ( rList[j] != rList[j - 1] )
                {
                    PrintMatrix(rList);
                    Console.WriteLine("There are different elements.");
                    return false;
                }
            }
            PrintMatrix(rList);
            Console.WriteLine("All the elements are equal.");
            return true;
        }
        public static void PrintMatrixL(List<List<int>> ls)
        {
            int rows = ls.Count;
            for ( int i = 0; i < rows; i++ )
            {
                //int rowsI = ls[i].Count;
                //Console.WriteLine();
                //for ( int j = 0; j < rowsI; j++ )
                //{
                //    Console.Write($"{ls[i][j]}   ");
                //}
                Console.WriteLine(String.Join(" ", ls[i]));
            }
            Console.WriteLine();
        }
        public static void PrintMatrix(List<int> mList)
        {
            foreach ( var ml in mList )
            {
                Console.Write($"{ml} ");
            }
            Console.WriteLine();
        }
        public static void PrintArray(int[] mList)
        {
            foreach ( var ml in mList )
            {
                Console.Write($"{ml} ");
            }
            Console.WriteLine();
        }
        #endregion Helper methods
    }
}
