using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>
    /// Unit tests for the <see cref="Str.CamelCase"/> method.
    /// </summary>
    public class StrTests
    {
        /// <summary>
        /// Verifies that an empty string contains zero words.
        /// </summary>
        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            // Arrange
            string s = "";

            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        /// <summary>
        /// Verifies that a null string contains zero words (do not trust the caller).
        /// </summary>
        [Test]
        public void CamelCase_Null_ReturnsZero()
        {
            Assert.That(Str.CamelCase(null), Is.EqualTo(0));
        }

        /// <summary>
        /// Verifies that a single lowercase word counts as one word.
        /// </summary>
        [Test]
        public void CamelCase_SingleLowercaseWord_ReturnsOne()
        {
            Assert.That(Str.CamelCase("hello"), Is.EqualTo(1));
        }

        /// <summary>
        /// Verifies that a single character counts as one word.
        /// </summary>
        [Test]
        public void CamelCase_SingleCharacter_ReturnsOne()
        {
            Assert.That(Str.CamelCase("a"), Is.EqualTo(1));
        }

        /// <summary>
        /// Verifies that two camelCase words are counted.
        /// </summary>
        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            Assert.That(Str.CamelCase("helloWorld"), Is.EqualTo(2));
        }

        /// <summary>
        /// Verifies a longer camelCase string with several words.
        /// </summary>
        [Test]
        public void CamelCase_ManyWords_ReturnsWordCount()
        {
            Assert.That(Str.CamelCase("thisIsCamelCase"), Is.EqualTo(4));
        }

        /// <summary>
        /// Verifies that each additional uppercase letter adds one word.
        /// </summary>
        [Test]
        public void CamelCase_EveryUppercaseStartsNewWord_ReturnsWordCount()
        {
            Assert.That(Str.CamelCase("oneTwoThreeFourFive"), Is.EqualTo(5));
        }

        /// <summary>
        /// Verifies that consecutive uppercase letters each count as a new word.
        /// </summary>
        [Test]
        public void CamelCase_ConsecutiveUppercase_CountsEach()
        {
            // a, A, B, C -> "a", "A", "B", "C" = 4 words
            Assert.That(Str.CamelCase("aABC"), Is.EqualTo(4));
        }

        /// <summary>
        /// Verifies that digits and lowercase letters within a word are not counted.
        /// </summary>
        [Test]
        public void CamelCase_WithDigitsInWords_CountsOnlyUppercaseBoundaries()
        {
            // user1Name2 -> "user1", "Name2" = 2 words
            Assert.That(Str.CamelCase("user1Name2"), Is.EqualTo(2));
        }
    }
}
