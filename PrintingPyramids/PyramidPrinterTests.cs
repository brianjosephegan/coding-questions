using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PrintingPyramids
{
    /// <summary>
    /// Tests for PyramidPrinter class.
    /// </summary>
    [TestFixture]
    class PyramidPrinterTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            printer = new PyramidPrinter();
        }

        /// <summary>
        /// Checks that negative number is handled correctly.
        /// </summary>
        [Test]
        public void Negative()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => { printer.Print(-1); });

            StringAssert.Contains("number cannot be negative", ex.Message);
            StringAssert.Contains("number", ex.ParamName);
        }

        /// <summary>
        /// Checks that zero is handled correctly.
        /// </summary>
        [Test]
        public void Zero()
        {
            printer.Print(0);
        }

        /// <summary>
        /// Checks that positive numbers are handled correctly.
        /// </summary>
        /// <param name="input">Number of layers to print.</param>
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Positive(int input)
        {
            printer.Print(input);
        }

        /// <summary>
        /// Pyram
        /// </summary>
        private PyramidPrinter printer;
    }
}
