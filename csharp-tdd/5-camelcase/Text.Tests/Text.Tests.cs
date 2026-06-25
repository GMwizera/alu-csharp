using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>
    /// Unit tests for the <see cref="Str.CamelCase"/> method.
    /// </summary>
    public class StrTests
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
        /// Empty string: contains zero words.
        /// </summary>
        [Test]
        [Description("Empty string")]
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
        /// Null string: treated as zero words (do not trust the caller).
        /// </summary>
        [Test]
        [Description("Null string")]
        public void CamelCase_Null_ReturnsZero()
        {
            Assert.That(Str.CamelCase(null), Is.EqualTo(0));
        }

        /// <summary>
        /// One word: a single lowercase word counts as one.
        /// </summary>
        [Test]
        [Description("One word")]
        public void CamelCase_OneWord_ReturnsOne()
        {
            Assert.That(Str.CamelCase("hello"), Is.EqualTo(1));
        }

        /// <summary>
        /// One word: a single character counts as one.
        /// </summary>
        [Test]
        [Description("One word - single character")]
        public void CamelCase_SingleCharacter_ReturnsOne()
        {
            Assert.That(Str.CamelCase("a"), Is.EqualTo(1));
        }

        /// <summary>
        /// Two words: one uppercase boundary yields two words.
        /// </summary>
        [Test]
        [Description("Two words")]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            Assert.That(Str.CamelCase("helloWorld"), Is.EqualTo(2));
        }

        /// <summary>
        /// Multiple words: several uppercase boundaries are all counted.
        /// </summary>
        [Test]
        [Description("Multiple words")]
        public void CamelCase_MultipleWords_ReturnsWordCount()
        {
            Assert.That(Str.CamelCase("thisIsCamelCase"), Is.EqualTo(4));
        }

        /// <summary>
        /// Multiple words: every uppercase letter starts a new word.
        /// </summary>
        [Test]
        [Description("Multiple words - five")]
        public void CamelCase_FiveWords_ReturnsFive()
        {
            Assert.That(Str.CamelCase("oneTwoThreeFourFive"), Is.EqualTo(5));
        }

        /// <summary>
        /// Multiple words: consecutive uppercase letters each start a word.
        /// </summary>
        [Test]
        [Description("Multiple words - consecutive uppercase")]
        public void CamelCase_ConsecutiveUppercase_CountsEach()
        {
            // a, A, B, C -> "a", "A", "B", "C" = 4 words
            Assert.That(Str.CamelCase("aABC"), Is.EqualTo(4));
        }

        /// <summary>
        /// Multiple words: digits inside words do not add to the count.
        /// </summary>
        [Test]
        [Description("Multiple words - with digits")]
        public void CamelCase_WithDigitsInWords_CountsOnlyUppercaseBoundaries()
        {
            // user1Name2 -> "user1", "Name2" = 2 words
            Assert.That(Str.CamelCase("user1Name2"), Is.EqualTo(2));
        }
    }
}
