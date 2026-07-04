using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            Assert.AreEqual(-7, Operations.Add(-3, -4));
        }

        [Test]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            Assert.AreEqual(-1, Operations.Add(4, -5));
        }

        [Test]
        public void Add_WithZero_ReturnsOtherNumber()
        {
            Assert.AreEqual(7, Operations.Add(0, 7));
            Assert.AreEqual(7, Operations.Add(7, 0));
        }

        [Test]
        public void Add_TwoZeros_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Add(0, 0));
        }
    }
}
