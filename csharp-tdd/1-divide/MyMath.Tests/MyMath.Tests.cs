using System;
using System.IO;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            Assert.IsNull(Matrix.Divide(null, 2));
        }

        [Test]
        public void Divide_ByZero_ReturnsNullAndPrintsMessage()
        {
            int[,] m = { { 1, 2 }, { 3, 4 } };
            string output;
            int[,] result;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                result = Matrix.Divide(m, 0);
                output = sw.ToString();
            }
            var stdout = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
            Console.SetOut(stdout);

            Assert.IsNull(result);
            Assert.IsTrue(output.Contains("Num cannot be 0"));
        }

        [Test]
        public void Divide_NormalCase_ReturnsDividedMatrix()
        {
            int[,] m = { { 10, 20 }, { 30, 40 } };
            int[,] expected = { { 5, 10 }, { 15, 20 } };
            Assert.AreEqual(expected, Matrix.Divide(m, 2));
        }

        [Test]
        public void Divide_IntegerTruncation_TruncatesTowardZero()
        {
            int[,] m = { { 7, 8 }, { 9, 10 } };
            int[,] expected = { { 2, 2 }, { 3, 3 } };
            Assert.AreEqual(expected, Matrix.Divide(m, 3));
        }

        [Test]
        public void Divide_NegativeDivisor_ReturnsNegatedQuotients()
        {
            int[,] m = { { 4, -6 }, { 8, -10 } };
            int[,] expected = { { -2, 3 }, { -4, 5 } };
            Assert.AreEqual(expected, Matrix.Divide(m, -2));
        }

        [Test]
        public void Divide_EmptyMatrix_ReturnsEmptyMatrix()
        {
            int[,] m = new int[0, 0];
            int[,] result = Matrix.Divide(m, 5);
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.GetLength(0));
            Assert.AreEqual(0, result.GetLength(1));
        }
    }
}
