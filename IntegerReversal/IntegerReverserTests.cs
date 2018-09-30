using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace IntegerReversal
{
    /// <summary>
    /// Tests for IntegerReverser class
    /// </summary>
    [TestFixture]
    class IntegerReverserTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            reverser = new IntegerReverser();
        }

        /// <summary>
        /// Checks that zero is reversed correctly.
        /// </summary>
        [Test]
        public void Zero()
        {
            Assert.AreEqual(0, reverser.Reverse(0));
        }

        /// <summary>
        /// Checks that positive numbers are reversed correctly.
        /// </summary>
        /// <param name="input">Integer to reversed.</param>
        /// <param name="expected">Expected reversed integer.</param>
        [TestCase(5, 5)]
        [TestCase(15, 51)]
        [TestCase(90, 9)]
        [TestCase(2359, 9532)]
        public void Positive(int input, int expected)
        {
            Assert.AreEqual(expected, reverser.Reverse(input));
        }

        /// <summary>
        /// Checks that negative numbers are reversed correctly.
        /// </summary>
        /// <param name="input">Integer to reversed.</param>
        /// <param name="expected">Expected reversed integer.</param>
        [TestCase(-5, -5)]
        [TestCase(-15, -51)]
        [TestCase(-90, -9)]
        [TestCase(-2359, -9532)]
        public void Negative(int input, int expected)
        {
            Assert.AreEqual(expected, reverser.Reverse(input));
        }

        /// <summary>
        /// Integer reverser.
        /// </summary>
        private IntegerReverser reverser;
    }
}
