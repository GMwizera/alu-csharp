using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }

        [Test]
        public void UniqueChar_NullString_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(null));
        }

        [Test]
        public void UniqueChar_SingleCharacter_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("a"));
        }

        [Test]
        public void UniqueChar_FirstCharacterUnique_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("hello"));
        }

        [Test]
        public void UniqueChar_UniqueInMiddle_ReturnsCorrectIndex()
        {
            Assert.AreEqual(2, Str.UniqueChar("aabcb"));
        }

        [Test]
        public void UniqueChar_AllCharactersRepeat_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabbcc"));
        }

        [Test]
        public void UniqueChar_LeetcodeExample_ReturnsTwo()
        {
            Assert.AreEqual(2, Str.UniqueChar("leetcode"));
        }

        [Test]
        public void UniqueChar_LoveleetExample_ReturnsTwo()
        {
            Assert.AreEqual(2, Str.UniqueChar("loveleetcode"));
        }

        [Test]
        public void UniqueChar_LastCharacterUnique_ReturnsLastIndex()
        {
            Assert.AreEqual(4, Str.UniqueChar("aabbc"));
        }

        [Test]
        public void UniqueChar_TwoSameCharacters_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aa"));
        }
    }
}
