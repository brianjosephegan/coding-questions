using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SentenceCapitalization
{
    /// <summary>
    /// Tests for SentenceCapitalizer class.
    /// </summary>
    [TestFixture]
    class SentenceCapitalizerTests
    {
        /// <summary>
        /// Set up for every test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            capitalizer = new SentenceCapitalizer();
        }

        /// <summary>
        /// Checks that null is handed correctly.
        /// </summary>
        [Test]
        public void Null()
        {

            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => capitalizer.Capitalize(null));

            StringAssert.Contains("input cannot be null", ex.Message);
            StringAssert.Contains("input", ex.ParamName);
        }

        /// <summary>
        /// Checks that capitalize is implemented correctly.
        /// </summary>
        /// <param name="input">Sentence to capitalize.</param>
        /// <param name="expected">Expected capitalized sentence.</param>
        [TestCase("hi there, how is it going?", "Hi There, How Is It Going?")]
        [TestCase("i love breakfast at bill miller bbq", "I Love Breakfast At Bill Miller Bbq")]
        public void Capitalize(string input, string expected)
        {
            Assert.AreEqual(expected, capitalizer.Capitalize(expected));
        }

        /// <summary>
        /// Sentence capitalizer.
        /// </summary>
        private SentenceCapitalizer capitalizer;
    }
}
