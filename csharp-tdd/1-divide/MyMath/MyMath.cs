using System;

namespace MyMath
{
    /// <summary>
    /// Provides operations on integer matrices.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides every element of <paramref name="matrix"/> by <paramref name="num"/>.
        /// </summary>
        /// <param name="matrix">The matrix whose elements will be divided.</param>
        /// <param name="num">The divisor.</param>
        /// <returns>
        /// A new matrix containing the divided elements, or <c>null</c> if
        /// <paramref name="matrix"/> is <c>null</c> or <paramref name="num"/> is <c>0</c>.
        /// </returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = matrix[i, j] / num;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            return result;
        }
    }
}
