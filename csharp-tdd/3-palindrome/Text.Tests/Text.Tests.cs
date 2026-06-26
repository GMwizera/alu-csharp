using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void IsPalindrome_NullString_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(null));
        }

        [Test]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("a"));
        }

        [Test]
        public void IsPalindrome_SimplePalindromeLowerCase_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("level"));
        }

        [Test]
        public void IsPalindrome_MixedCasePalindrome_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }

        [Test]
        public void IsPalindrome_NotAPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("hello"));
        }

        [Test]
        public void IsPalindrome_PunctuationAndSpacesIgnored_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void IsPalindrome_PhraseNotPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("This is not a palindrome"));
        }

        [Test]
        public void IsPalindrome_AlphanumericPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("12321"));
        }

        [Test]
        public void IsPalindrome_OnlyPunctuation_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("!!!,,,..."));
        }

        [Test]
        public void IsPalindrome_EvenLengthPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("abba"));
        }
    }
}
