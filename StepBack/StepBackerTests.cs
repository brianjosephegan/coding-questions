using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLists;
using NUnit.Framework;

namespace StepBack
{
    /// <summary>
    /// Tests for StepBacker class.
    /// </summary>
    [TestFixture]
    public class StepBackerTests
    {
        /// <summary>
        /// Setup for every test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            stepBack = new StepBacker();
        }

        /// <summary>
        /// Checks that a null linked list is handled correctly.
        /// </summary>
        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => { stepBack.StepBack(null, 1); });

            StringAssert.Contains("list", ex.ParamName);
            StringAssert.Contains("list cannot be null", ex.Message);
        }

        /// <summary>
        /// Checks tha a negative n is handled correctly.
        /// </summary>
        [Test]
        public void Negative()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => { stepBack.StepBack(new LinkedList(), -1); });

            StringAssert.Contains("n", ex.ParamName);
            StringAssert.Contains("n cannot be negative", ex.Message);
        }

        /// <summary>
        /// Checks that FromLast is implemented correctly.
        /// </summary>
        [Test]
        public void FromLast()
        {
            LinkedList list = new LinkedList();

            list.InsertLast("a");
            list.InsertLast("b");
            list.InsertLast("c");
            list.InsertLast("d");
            list.InsertLast("e");

            Assert.AreEqual("b", stepBack.StepBack(list, 3));
        }

        /// <summary>
        /// Step backer.
        /// </summary>
        private StepBacker stepBack;
    }
}
