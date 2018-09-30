using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Palindromes
{
    /// <summary>
    /// Tests for PalindromeDetector class.
    /// </summary>
    [TestFixture]
    class PalindromeDetectorTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            detector = new PalindromeDetector();
        }

        /// <summary>
        /// Checks that null is handled correctly as input.
        /// </summary>
        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => detector.IsPalindrome(null));

            StringAssert.Contains("input cannot be null", ex.Message);
        }

        /// <summary>
        /// Positive test cases where the inputs are palindromes.
        /// </summary>
        /// <param name="input">String to check if it is a palindrome.</param>
        [TestCase("aba")]
        [TestCase("1000000001")]
        [TestCase("level")]
        public void Positive(string input)
        {
            Assert.IsTrue(detector.IsPalindrome(input));
        }

        /// <summary>
        /// Negative test cases where the inputs are not palindromes.
        /// </summary>
        /// <param name="input">String to check if it is a palindrome.</param>
        [TestCase(" aba")]
        [TestCase("aba ")]
        [TestCase("greetings")]
        [TestCase("Fish")]
        public void Negative(string input)
        {
            Assert.IsFalse(detector.IsPalindrome(input));
        }

        /// <summary>
        /// Palindrome detector.
        /// </summary>
        private PalindromeDetector detector;
    }
}
