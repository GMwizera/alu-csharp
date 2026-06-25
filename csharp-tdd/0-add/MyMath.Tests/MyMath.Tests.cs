using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>
    /// Unit tests for the <see cref="Operations.Add"/> method.
    /// </summary>
    public class OperationsTests
    {
        [Test]
        public void Add_TwoPositiveIntegers_ReturnsSum()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Add_TwoNegativeIntegers_ReturnsSum()
        {
            int result = Operations.Add(-4, -6);

            Assert.That(result, Is.EqualTo(-10));
        }

        [Test]
        public void Add_PositiveAndNegativeInteger_ReturnsSum()
        {
            int result = Operations.Add(10, -3);

            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Add_WithZero_ReturnsOtherOperand()
        {
            Assert.That(Operations.Add(0, 7), Is.EqualTo(7));
            Assert.That(Operations.Add(7, 0), Is.EqualTo(7));
            Assert.That(Operations.Add(0, 0), Is.EqualTo(0));
        }

        [Test]
        public void Add_IsCommutative()
        {
            Assert.That(Operations.Add(8, 5), Is.EqualTo(Operations.Add(5, 8)));
        }

        [TestCase(1, 1, 2)]
        [TestCase(-1, 1, 0)]
        [TestCase(100, 250, 350)]
        [TestCase(-50, -50, -100)]
        [TestCase(int.MaxValue, 0, int.MaxValue)]
        [TestCase(int.MinValue, 0, int.MinValue)]
        public void Add_VariousInputs_ReturnsExpectedSum(int a, int b, int expected)
        {
            Assert.That(Operations.Add(a, b), Is.EqualTo(expected));
        }
    }
}
