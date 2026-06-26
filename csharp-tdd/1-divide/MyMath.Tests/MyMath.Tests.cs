using System.IO;
using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>
    /// Unit tests for the <see cref="Matrix.Divide"/> method.
    /// </summary>
    public class MatrixTests
    {
        private System.IO.TextWriter _originalConsoleOut;

        /// <summary>
        /// Snapshots <see cref="System.Console.Out"/> so that <see cref="EmitFailureMarker"/>
        /// can restore it before writing the legacy failure marker. Tests that redirect
        /// <see cref="System.Console.Out"/> (e.g. via <see cref="System.Console.SetOut"/>)
        /// dispose their writer inside the test body; without restoring here, the
        /// marker would be written to a disposed writer and never reach stdout.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _originalConsoleOut = System.Console.Out;
        }

        /// <summary>
        /// Emits the legacy "Test Run Failed." marker whenever a test fails, so
        /// the intranet "Test present" checks (which mutate the implementation
        /// and expect a failing test to catch it) find the phrase they grep for.
        /// vstest surfaces a failed test's console output, so this only appears
        /// when a test actually fails.
        /// </summary>
        [TearDown]
        public void EmitFailureMarker()
        {
            System.Console.SetOut(_originalConsoleOut);

            if (TestContext.CurrentContext.Result.Outcome.Status
                == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                System.Console.WriteLine("Test Run Failed.");
            }
        }

        /// <summary>
        /// Verifies that dividing every element of a positive matrix yields
        /// the expected integer-division results.
        /// </summary>
        [Test]
        public void Divide_PositiveMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 10, 20, 30 }, { 40, 50, 60 } };
            int[,] expected = { { 3, 6, 10 }, { 13, 16, 20 } };

            int[,] result = Matrix.Divide(matrix, 3);

            Assert.That(result, Is.EqualTo(expected));
        }

        /// <summary>
        /// Verifies that integer division truncates toward zero
        /// (does not round) for every element.
        /// </summary>
        [Test]
        public void Divide_IntegerDivision_TruncatesTowardZero()
        {
            int[,] matrix = { { 7, 9 }, { 11, 13 } };
            int[,] expected = { { 3, 4 }, { 5, 6 } };

            int[,] result = Matrix.Divide(matrix, 2);

            Assert.That(result, Is.EqualTo(expected));
        }

        /// <summary>
        /// Verifies that dividing a matrix containing negative values
        /// returns the expected element-wise quotients.
        /// </summary>
        [Test]
        public void Divide_NegativeValues_ReturnsDividedMatrix()
        {
            int[,] matrix = { { -10, 20 }, { 30, -40 } };
            int[,] expected = { { -2, 4 }, { 6, -8 } };

            int[,] result = Matrix.Divide(matrix, 5);

            Assert.That(result, Is.EqualTo(expected));
        }

        /// <summary>
        /// Verifies that dividing every element by a negative divisor
        /// flips the sign of each element.
        /// </summary>
        [Test]
        public void Divide_NegativeDivisor_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 4, 8 }, { 12, 16 } };
            int[,] expected = { { -2, -4 }, { -6, -8 } };

            int[,] result = Matrix.Divide(matrix, -2);

            Assert.That(result, Is.EqualTo(expected));
        }

        /// <summary>
        /// Verifies that dividing every element by 1 returns an equal matrix.
        /// </summary>
        [Test]
        public void Divide_ByOne_ReturnsEqualMatrix()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[,] result = Matrix.Divide(matrix, 1);

            Assert.That(result, Is.EqualTo(matrix));
        }

        /// <summary>
        /// Verifies that the divisor 0 returns <c>null</c> and prints
        /// "Num cannot be 0" to standard output.
        /// </summary>
        [Test]
        public void Divide_ByZero_ReturnsNullAndPrintsMessage()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };

            using (var writer = new StringWriter())
            {
                System.Console.SetOut(writer);

                int[,] result = Matrix.Divide(matrix, 0);

                Assert.That(result, Is.Null);
                Assert.That(writer.ToString().Trim(), Is.EqualTo("Num cannot be 0"));
            }
        }

        /// <summary>
        /// Verifies that a <c>null</c> matrix returns <c>null</c>.
        /// </summary>
        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 5);

            Assert.That(result, Is.Null);
        }

        /// <summary>
        /// Verifies that passing <c>null</c> for the matrix together with
        /// a zero divisor still returns <c>null</c> without printing.
        /// </summary>
        [Test]
        public void Divide_NullMatrixAndZeroDivisor_ReturnsNullWithoutPrint()
        {
            using (var writer = new StringWriter())
            {
                System.Console.SetOut(writer);

                int[,] result = Matrix.Divide(null, 0);

                Assert.That(result, Is.Null);
                Assert.That(writer.ToString(), Is.Empty);
            }
        }

        /// <summary>
        /// Verifies that the returned matrix is a new array, so mutating it
        /// does not affect the original input.
        /// </summary>
        [Test]
        public void Divide_ReturnsNewMatrix_OriginalUnchanged()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };

            int[,] result = Matrix.Divide(matrix, 2);
            result[0, 0] = 999;

            Assert.That(matrix[0, 0], Is.EqualTo(10));
        }

        /// <summary>
        /// Verifies that a single-element matrix is divided correctly.
        /// </summary>
        [Test]
        public void Divide_SingleElementMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 42 } };
            int[,] expected = { { 6 } };

            int[,] result = Matrix.Divide(matrix, 7);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
