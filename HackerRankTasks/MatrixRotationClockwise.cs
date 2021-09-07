using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class MatrixRotationClockWise
    {
        // Main algorithm: in order to rotate the whole matrix, we'll just rotate one ring at a time
        // We can do this in-place to achieve O(1) additional space complexity
        public static void MMatrixRotation(List<List<int>> matrix, int r)
        {
            if ( MatrixRotation.GetParity(matrix) )
            {
                Console.WriteLine($"Number of elements in the array: {MatrixRotation.GetCount(matrix)}");
            }
            if ( r < 1 )
            {
                Console.WriteLine("Please, enter a number of matrix rotations greater than 0,\n" +
                    "initial matrix:");
                //MatrixRotation.PrintMatrixL(matrix);
            }
            int rows = matrix.Count;
            int columns = matrix[0].Count;


            int numRings = Math.Min(rows, columns) / 2;
            for ( int i = 0; i < numRings; i++ )
            {
                // Subtract the number of 360 degree rotations from R
                // A 360 degree rotation = rotating the same number of times as the perimeter of the current ring
                int numRotations = r % (2 * (rows + columns - 4 * i) - 4);
                for ( int rotation = 0; rotation < numRotations; rotation++ )
                {
                    // Rotate the current ring:
                    // - In order to not use additional memory, we'll just swap elements
                    // - We need to repeatedly swap the last element in the top row until it becomes the first element
                    // - Then we need to swap that element down to the bottom of the left column
                    // - Then we need to swap that element over to the bottom of the right column
                    // - Then we need to swap that element to the 2nd highest element in the right column
                    // - Then the ring will be rotated! See an example below:

                    // Let's rotate the outer-most ring on the following 4x4 matrix (hint: follow the '4')
                    // 1 2 3 4
                    // 5 6 7 8
                    // 9 10 11 12
                    // 13 14 15 16

                    // Iteration 1
                    // 4 1 2 3
                    // 5 6 7 8
                    // 9 10 11 12
                    // 13 14 15 16

                    // Iteration 2
                    // 5 1 2 3
                    // 9 6 7 8
                    // 13 10 11 12
                    // 4 14 15 16


                    // Iteration 3
                    // 5 1 2 3
                    // 9 6 7 8
                    // 13 10 11 12
                    // 14 15 16 4


                    // Iteration 4 - finished, the outer ring is rotated!
                    // 5 1 2 3
                    // 9 6 7 4
                    // 13 10 11 8
                    // 14 15 16 12

                    // Rotate top row
                    for ( int j = columns - i - 1; j > i; j-- )
                    {
                        int tmp = matrix[i][j];
                        matrix[i][j] = matrix[i][j - 1];
                        matrix[i][j - 1] = tmp;
                    }
                    // Rotate left column
                    for ( int j = i; j < rows - i - 1; j++ )
                    {
                        int tmp = matrix[j][i];
                        matrix[j][i] = matrix[j + 1][i];
                        matrix[j + 1][i] = tmp;
                    }
                    // Rotate bottom row
                    for ( int j = i; j < columns - i - 1; j++ )
                    {
                        int tmp = matrix[rows - i - 1][j];
                        matrix[rows - i - 1][j] = matrix[rows - i - 1][j + 1];
                        matrix[rows - i - 1][j + 1] = tmp;
                    }
                    // Rotate right column
                    for ( int j = rows - i - 1; j > i + 1; j-- )
                    {
                        int tmp = matrix[j][columns - i - 1];
                        matrix[j][columns - i - 1] = matrix[j - 1][columns - i - 1];
                        matrix[j - 1][columns - i - 1] = tmp;
                    }
                }
            }
            // Output final matrix
            MatrixRotation.PrintMatrixL(matrix);

        }

        // Additional info: A faster algorithm (same time complexity, but lower constant factor) exists 
        // for rotating matrices by 90 degrees (extendable to 180, 270, etc). Simply transpose the 
        // matrix then swap every left column with its matching right column.
        // i.e To rotate a 3x3 matrix by 90 degrees, transpose the matrix than swap column 1 with column 3
    }
}
