using System;

namespace MyMath
{
    /// <summary>
    /// Provides matrix operations.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides every element of a matrix by a given integer.
        /// </summary>
        /// <param name="matrix">The matrix whose elements will be divided.</param>
        /// <param name="num">The divisor.</param>
        /// <returns>
        /// A new matrix containing the divided elements,
        /// <c>null</c> if <paramref name="matrix"/> is <c>null</c>,
        /// or <c>null</c> if <paramref name="num"/> is <c>0</c>.
        /// </returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            try
            {
                if (num == 0)
                {
                    throw new DivideByZeroException("Num cannot be 0");
                }

                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                int[,] result = new int[rows, cols];

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        result[r, c] = matrix[r, c] / num;
                    }
                }

                return result;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
