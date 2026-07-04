using System.Collections.Generic;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(new List<int>()));
        }

        [Test]
        public void Max_SingleElement_ReturnsThatElement()
        {
            Assert.AreEqual(7, Operations.Max(new List<int> { 7 }));
        }

        [Test]
        public void Max_AllPositive_ReturnsLargest()
        {
            Assert.AreEqual(9, Operations.Max(new List<int> { 1, 9, 3, 5 }));
        }

        [Test]
        public void Max_AllNegative_ReturnsLeastNegative()
        {
            Assert.AreEqual(-1, Operations.Max(new List<int> { -5, -1, -3, -10 }));
        }

        [Test]
        public void Max_MixedSigns_ReturnsLargest()
        {
            Assert.AreEqual(8, Operations.Max(new List<int> { -2, 8, 0, -7, 3 }));
        }

        [Test]
        public void Max_DuplicateMaxValues_ReturnsThatValue()
        {
            Assert.AreEqual(4, Operations.Max(new List<int> { 4, 2, 4, 1, 4 }));
        }

        [Test]
        public void Max_LastElementIsLargest_ReturnsLastElement()
        {
            Assert.AreEqual(100, Operations.Max(new List<int> { 1, 2, 3, 100 }));
        }
    }
}
