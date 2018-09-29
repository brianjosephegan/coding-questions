using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Anagrams
{
    [TestFixture]
    class AnagramDetectorTests
    {
        [SetUp]
        public void SetUp()
        {
            detector = new AnagramDetector();
        }

        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => detector.AreAnagrams(null, "test"));

            StringAssert.Contains("input cannot be null or empty", ex.Message);
            StringAssert.Contains("input", ex.ParamName);
        }

        [Test]
        public void OtherNull()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => detector.AreAnagrams("test", null));

            StringAssert.Contains("otherInput cannot be null or empty", ex.Message);
            StringAssert.Contains("otherInput", ex.ParamName);
        }

        [Test]
        public void Empty()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => detector.AreAnagrams(string.Empty, "test"));

            StringAssert.Contains("input cannot be null or empty", ex.Message);
            StringAssert.Contains("input", ex.ParamName);
        }

        [Test]
        public void OtherEmpty()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => detector.AreAnagrams("test", string.Empty));

            StringAssert.Contains("otherInput cannot be null or empty", ex.Message);
            StringAssert.Contains("otherInput", ex.ParamName);
        }

        [TestCase("hello", "llohe")]
        [TestCase("Whoa! Hi!", "Hi! Whoa!")]
        public void Positive(string input, string otherInput)
        {
            Assert.IsTrue(detector.AreAnagrams(input, otherInput));
        }

        [TestCase("One One", "Two two two")]
        [TestCase("One one", "One one c")]
        [TestCase("A tree, a life, a bench", "A tree, a fence, a yard")]
        public void Negative(string input, string otherInput)
        {
            Assert.IsFalse(detector.AreAnagrams(input, otherInput));
        }

        private AnagramDetector detector;
    }
}
