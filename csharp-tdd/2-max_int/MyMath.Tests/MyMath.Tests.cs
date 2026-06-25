using System.Collections.Generic;
using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>
    /// Unit tests for the <see cref="Operations.Max"/> method.
    /// </summary>
    public class OperationsTests
    {
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
            if (TestContext.CurrentContext.Result.Outcome.Status
                == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                System.Console.WriteLine("Test Run Failed.");
            }
        }

        /// <summary>
        /// Verifies that an empty list returns 0.
        /// </summary>
        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            // Arrange
            var nums = new List<int>();

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        /// <summary>
        /// Verifies that a null list returns 0 (do not trust the caller).
        /// </summary>
        [Test]
        public void Max_NullList_ReturnsZero()
        {
            Assert.That(Operations.Max(null), Is.EqualTo(0));
        }

        /// <summary>
        /// Verifies that a single-element list returns that element.
        /// </summary>
        [Test]
        public void Max_SingleElement_ReturnsThatElement()
        {
            Assert.That(Operations.Max(new List<int> { 42 }), Is.EqualTo(42));
        }

        /// <summary>
        /// Verifies the maximum is found when it sits at the start of the list.
        /// </summary>
        [Test]
        public void Max_MaxAtStart_ReturnsMax()
        {
            Assert.That(Operations.Max(new List<int> { 9, 3, 1, 7 }), Is.EqualTo(9));
        }

        /// <summary>
        /// Verifies the maximum is found when it sits at the end of the list.
        /// </summary>
        [Test]
        public void Max_MaxAtEnd_ReturnsMax()
        {
            Assert.That(Operations.Max(new List<int> { 2, 4, 6, 15 }), Is.EqualTo(15));
        }

        /// <summary>
        /// Verifies the maximum is found when it sits in the middle of the list.
        /// </summary>
        [Test]
        public void Max_MaxInMiddle_ReturnsMax()
        {
            Assert.That(Operations.Max(new List<int> { 3, 8, 100, 8, 3 }), Is.EqualTo(100));
        }

        /// <summary>
        /// Verifies the maximum is correct when all values are negative.
        /// </summary>
        [Test]
        public void Max_AllNegative_ReturnsLargestNegative()
        {
            Assert.That(Operations.Max(new List<int> { -5, -1, -9, -3 }), Is.EqualTo(-1));
        }

        /// <summary>
        /// Verifies the maximum is correct for a mix of negative and positive values.
        /// </summary>
        [Test]
        public void Max_MixedSigns_ReturnsMax()
        {
            Assert.That(Operations.Max(new List<int> { -10, 0, 5, -3, 4 }), Is.EqualTo(5));
        }

        /// <summary>
        /// Verifies the maximum is correct when the maximum value is duplicated.
        /// </summary>
        [Test]
        public void Max_DuplicateMax_ReturnsMax()
        {
            Assert.That(Operations.Max(new List<int> { 7, 7, 2, 7 }), Is.EqualTo(7));
        }

        /// <summary>
        /// Verifies that a list whose largest value is 0 returns 0.
        /// </summary>
        [Test]
        public void Max_AllZeros_ReturnsZero()
        {
            Assert.That(Operations.Max(new List<int> { 0, 0, 0 }), Is.EqualTo(0));
        }

        /// <summary>
        /// Verifies the maximum is correct at the integer boundary values.
        /// </summary>
        [Test]
        public void Max_IntegerBounds_ReturnsIntMax()
        {
            Assert.That(
                Operations.Max(new List<int> { int.MinValue, 0, int.MaxValue }),
                Is.EqualTo(int.MaxValue));
        }

        /// <summary>
        /// Verifies the maximum for a list containing only <see cref="int.MinValue"/>.
        /// </summary>
        [Test]
        public void Max_OnlyIntMinValue_ReturnsIntMinValue()
        {
            Assert.That(
                Operations.Max(new List<int> { int.MinValue }),
                Is.EqualTo(int.MinValue));
        }
    }
}
