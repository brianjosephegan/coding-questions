using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MaxChars
{
    /// <summary>
    /// Tests for MaxCharFinder class.
    /// </summary>
    [TestFixture]
    class MaxCharFinderTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            finder = new MaxCharFinder();
        }

        /// <summary>
        /// Checks that null is handled correctly as an input.
        /// </summary>
        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => finder.Find(null));

            StringAssert.Contains("input cannot be null", ex.Message);
        }

        /// <summary>
        /// Checks that empty string is handled correctly as an input.
        /// </summary>
        [Test]
        public void Empty()
        {
            Assert.AreEqual(null, finder.Find(string.Empty));
        }

        /// <summary>
        /// Checks that a single character is handled correctly as an input.
        /// </summary>
        [Test]
        public void Character()
        {
            Assert.AreEqual('a', finder.Find("a"));
        }

        /// <summary>
        /// Checks that a sentence is handled correctly as an input.
        /// </summary>
        [Test]
        public void Sentence()
        {
            Assert.AreEqual('a', finder.Find("abcdefghijklmnaaaaa"));
        }

        /// <summary>
        /// Checks that numbers are handled correctly as an input.
        /// </summary>
        [Test]
        public void Numbers()
        {
            Assert.AreEqual('1', finder.Find("ab1c1d1e1f1g1"));
        }

        /// <summary>
        /// Maximum character finder.
        /// </summary>
        private MaxCharFinder finder;
    }
}
