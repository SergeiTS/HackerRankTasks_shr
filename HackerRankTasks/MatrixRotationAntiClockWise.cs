using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class MatrixRotationAntiClockWise
    {
        public static void MMatrixRotation(List<List<int>> matrix, int r)
        {
            if ( MatrixRotation.GetParity(matrix) )
            {
                Console.WriteLine($"Number of elements in the array: {MatrixRotation.GetCount(matrix)}");
            }
            if ( r < 1 )
            {
                Console.WriteLine("Please, enter a number of matrix rotations greater than 0,\n");
            }
            int rows = matrix.Count;
            int columns = matrix[0].Count;


            int numRings = Math.Min(rows, columns) / 2;
            for ( int i = 0; i < numRings; i++ )
            {
                int numRotations = r % (2 * (rows + columns - 4 * i) - 4);
                for ( int rotation = 0; rotation < numRotations; rotation++ )
                {
                    // Rotate top row
                    for ( int j = i; j < columns - i - 1; j++ )
                    {
                        int tmp = matrix[i][j];
                        matrix[i][j] = matrix[i][j + 1];
                        matrix[i][j + 1] = tmp;
                    }
                    // Rotate right column
                    for ( int j = i; j < rows - i - 1; j++ )
                    {
                        int tmp = matrix[j][columns - i - 1];
                        matrix[j][columns - i - 1] = matrix[j + 1][columns - i - 1];
                        matrix[j + 1][columns - i - 1] = tmp;
                    }
                    // Rotate bottom row
                    for ( int j = columns - i - 1; j > i; j-- )
                    {
                        int tmp = matrix[rows - i - 1][j];
                        matrix[rows - i - 1][j] = matrix[rows - i - 1][j - 1];
                        matrix[rows - i - 1][j - 1] = tmp;
                    }
                    // Rotate left column
                    for ( int j = rows - i - 1; j > i + 1; j-- )
                    {
                        int tmp = matrix[j][i];
                        matrix[j][i] = matrix[j - 1][i];
                        matrix[j - 1][i] = tmp;
                    }
                }
            }
            MatrixRotation.PrintMatrixL(matrix);
        }
    }
}

