using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void CamelCase_NullString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }

        [Test]
        public void CamelCase_SingleLowercaseWord_ReturnsOne()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            Assert.AreEqual(2, Str.CamelCase("helloWorld"));
        }

        [Test]
        public void CamelCase_FiveWords_ReturnsFive()
        {
            Assert.AreEqual(5, Str.CamelCase("saveChangesInTheEditor"));
        }

        [Test]
        public void CamelCase_SingleLetter_ReturnsOne()
        {
            Assert.AreEqual(1, Str.CamelCase("a"));
        }

        [Test]
        public void CamelCase_ConsecutiveCapitals_CountsEachAsAWord()
        {
            Assert.AreEqual(3, Str.CamelCase("getHTTPResponse"));
        }
    }
}
