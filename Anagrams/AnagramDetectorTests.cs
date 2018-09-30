using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Anagrams
{
    /// <summary>
    /// Tests for AnagramDetector class.
    /// </summary>
    [TestFixture]
    class AnagramDetectorTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            detector = new AnagramDetector();
        }

        /// <summary>
        /// Checks that null is handled correctly as the first input.
        /// </summary>
        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => detector.AreAnagrams(null, "test"));

            StringAssert.Contains("input cannot be null or empty", ex.Message);
            StringAssert.Contains("input", ex.ParamName);
        }

        /// <summary>
        /// Checks that null is handled correctly as the other input.
        /// </summary>
        [Test]
        public void OtherNull()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => detector.AreAnagrams("test", null));

            StringAssert.Contains("otherInput cannot be null or empty", ex.Message);
            StringAssert.Contains("otherInput", ex.ParamName);
        }

        /// <summary>
        /// Checks that the empty string is handled correctly as the first input.
        /// </summary>
        [Test]
        public void Empty()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => detector.AreAnagrams(string.Empty, "test"));

            StringAssert.Contains("input cannot be null or empty", ex.Message);
            StringAssert.Contains("input", ex.ParamName);
        }

        /// <summary>
        /// Checks that the empty string is handled correctly as the other input.
        /// </summary>
        [Test]
        public void OtherEmpty()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => detector.AreAnagrams("test", string.Empty));

            StringAssert.Contains("otherInput cannot be null or empty", ex.Message);
            StringAssert.Contains("otherInput", ex.ParamName);
        }

        /// <summary>
        /// Positive test cases where the inputs are anagrams of each other.
        /// </summary>
        /// <param name="input">String to check if it is an anagram.</param>
        /// <param name="otherInput">Other string to check if it is an anagram.</param>
        [TestCase("hello", "llohe")]
        [TestCase("Whoa! Hi!", "Hi! Whoa!")]
        public void Positive(string input, string otherInput)
        {
            Assert.IsTrue(detector.AreAnagrams(input, otherInput));
        }

        /// <summary>
        /// Positive test cases where the inputs are not anagrams of each other.
        /// </summary>
        /// <param name="input">String to check if it is an anagram.</param>
        /// <param name="otherInput">Other string to check if it is an anagram.</param>
        [TestCase("One One", "Two two two")]
        [TestCase("One one", "One one c")]
        [TestCase("A tree, a life, a bench", "A tree, a fence, a yard")]
        public void Negative(string input, string otherInput)
        {
            Assert.IsFalse(detector.AreAnagrams(input, otherInput));
        }

        /// <summary>
        /// Anagram detector.
        /// </summary>
        private AnagramDetector detector;
    }
}
