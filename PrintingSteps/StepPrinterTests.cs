using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PrintingSteps
{
    /// <summary>
    /// Test for StepPrinter class.
    /// </summary>
    [TestFixture]
    class StepPrinterTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            printer = new StepPrinter();
        }

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
        /// Step printer.
        /// </summary>
        private StepPrinter printer;
    }
}
