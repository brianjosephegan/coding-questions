using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz
{
    /// <summary>
    /// Tests for FizzBuzz class.
    /// </summary>
    [TestFixture]
    class FizzBuzzTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            fizzBuzz = new FizzBuzz();
        }

        /// <summary>
        /// Checks that a negative number of lines is handled correctly.
        /// </summary>
        [Test]
        public void Negative()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => { fizzBuzz.Print(-1); });

            StringAssert.Contains("number cannot be less than or equal to zero", ex.Message);
        }

        /// <summary>
        /// Checks that zero number of lines is handled correctly.
        /// </summary>
        [Test]
        public void Zero()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => { fizzBuzz.Print(-1); });

            StringAssert.Contains("number cannot be less than or equal to zero", ex.Message);
        }

        /// <summary>
        /// Checks that positive number of lines is handled correctly.
        /// </summary>
        /// <param name="number">Number of lines to print.</param>
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(30)]
        public void Positive(int number)
        {
            fizzBuzz.Print(number);
        }

        private FizzBuzz fizzBuzz;
    }
}
