using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringReversal
{
    /// <summary>
    /// Tests for StringReverser class
    /// </summary>
    [TestFixture]
    class StringReverserTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            reverser = new StringReverser();
        }

        /// <summary>
        /// Checks that null is handled correctly as an input.
        /// </summary>
        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => reverser.Reverse(null));

            StringAssert.Contains("input cannot be null", ex.Message);
        }

        /// <summary>
        /// Checks that a normal string can be reversed correctly.
        /// </summary>
        [Test]
        public void Normal()
        {
            Assert.AreEqual("abcd", reverser.Reverse("dcba"));
        }

        /// <summary>
        /// Checks that a string with spaces can be reversed correctly.
        /// </summary>
        [Test]
        public void Spaces()
        {
            Assert.AreEqual("  abcd", reverser.Reverse("dcba  "));
        }

        /// <summary>
        /// Checks that a string with numbers can be reversed correctly.
        /// </summary>
        [Test]
        public void Numbers()
        {
            Assert.AreEqual("1234567890", reverser.Reverse("0987654321"));
        }

        /// <summary>
        /// Checks that a string that is a sentence can be reversed correctly.
        /// </summary>
        [Test]
        public void Sentence()
        {
            Assert.AreEqual(".ecnetnes a si sihT", reverser.Reverse("This is a sentence."));
        }

        /// <summary>
        /// String reverser.
        /// </summary>
        private StringReverser reverser;
    }
}
