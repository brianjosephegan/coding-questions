using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BubbleSort
{
    /// <summary>
    /// Tests for BubbleSorter class.
    /// </summary>
    [TestFixture]
    class BubbleSorterTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            sorter = new BubbleSorter();
        }

        /// <summary>
        /// Checks that null is handled correctly as an input.
        /// </summary>
        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => sorter.Sort(null));

            StringAssert.Contains("numbers cannot be null", ex.Message);
        }

        /// <summary>
        /// Checks that sequence of numbers can be sorted correctly.
        /// </summary>
        /// <param name="expected">Expected array of integers.</param>
        /// <param name="input">Array of integers to sort.</param>
        [TestCase(new int[] {}, new int[] {})]
        [TestCase(new int[] { -1 }, new int[] { -1 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { -124, -40, 0, 7, 21, 100, 500 }, new int[] { 100, -40, 500, -124, 0, 21, 7 })]
        public void Sort(int[] expected, int[] input)
        {
            CollectionAssert.AreEqual(expected, sorter.Sort(input));
        }

        /// <summary>
        /// Bubble sorter.
        /// </summary>
        private BubbleSorter sorter;
    }
}
