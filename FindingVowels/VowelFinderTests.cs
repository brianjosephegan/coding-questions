using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FindingVowels
{
    /// <summary>
    /// Test for VowelFinder class.
    /// </summary>
    [TestFixture]
    class VowelFinderTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            finder = new VowelFinder();
        }

        /// <summary>
        /// Checks that null is handled correctly.
        /// </summary>
        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => { finder.Find(null); });

            StringAssert.Contains("input cannot be null", ex.Message);
            StringAssert.Contains("input", ex.ParamName);
        }

        /// <summary>
        /// Checks that correct number of vowels are found.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="expected">Expected number of vowels.</param>
        [TestCase("aeiou", 5)]
        [TestCase("AEIOU", 5)]
        [TestCase("abcdefghijklmnopqrstuvwxyz", 5)]
        [TestCase("bcdfghjkl", 0)]
        public void Positive(string input, int expected)
        {
            Assert.AreEqual(expected, finder.Find(input));
        }

        /// <summary>
        /// Vowel finder
        /// </summary>
        private VowelFinder finder;
    }
}
