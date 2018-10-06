using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FibonacciSeries
{
    /// <summary>
    /// Test for FibonacciGenerator class.
    /// </summary>
    [TestFixture]
    class FibonacciGeneratorTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            generator = new FibonacciGenerator();
        }

        /// <summary>
        /// Checks that a negative number is handled correctly.
        /// </summary>
        [Test]
        public void Negative()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => generator.Generate(-1));

            StringAssert.Contains("number cannot be negative", ex.Message);
            StringAssert.Contains("number", ex.ParamName);
        }

        /// <summary>
        /// Checks that a zero is handled correctly.
        /// </summary>
        [Test]
        public void Zero()
        {
            Assert.AreEqual(0, generator.Generate(0));
        }

        /// <summary>
        /// Checks that one is handled correctly.
        /// </summary>
        [Test]
        public void One()
        {
            Assert.AreEqual(1, generator.Generate(1));
        }

        /// <summary>
        /// Checks that a positive numbers are handled correctly.
        /// </summary>
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(39, 63245986)]
        public void Positive(int number, int expected)
        {
            Assert.AreEqual(expected, generator.Generate(number));
        }

        /// <summary>
        /// Fibonacci generator.
        /// </summary>
        private FibonacciGenerator generator;
    }
}
