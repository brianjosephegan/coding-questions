using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLists;
using NUnit.Framework;

namespace FindMidpoint
{
    /// <summary>
    /// Tests for MidpointFinder class.
    /// </summary>
    [TestFixture]
    public class MidpointFinderTests
    {
        /// <summary>
        /// Set up for every test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            finder = new MidpointFinder();
        }

        /// <summary>
        /// Checks that null is handled correctly.
        /// </summary>
        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => { finder.Find(null); });

            StringAssert.Contains("list", ex.ParamName);
            StringAssert.Contains("list cannot be null", ex.Message);
        }

        /// <summary>
        /// Checks that finding the midpoint in a list of two nodes is implemented correctly.
        /// </summary>
        [Test]
        public void FindTwo()
        {
            LinkedList list = new LinkedList();
            list.InsertLast("a");
            list.InsertLast("b");
            Assert.AreEqual("a", finder.Find(list));
        }

        /// <summary>
        /// Checks that finding the midpoint in a list of three nodes is implemented correctly.
        /// </summary>
        [Test]
        public void FindThree()
        {
            LinkedList list = new LinkedList();
            list.InsertLast("a");
            list.InsertLast("b");
            list.InsertLast("c");
            Assert.AreEqual("b", finder.Find(list));
        }

        /// <summary>
        /// Checks that finding the midpoint in a list of four nodes is implemented correctly.
        /// </summary>
        [Test]
        public void FindFour()
        {
            LinkedList list = new LinkedList();
            list.InsertLast("a");
            list.InsertLast("b");
            list.InsertLast("c");
            list.InsertLast("d");
            Assert.AreEqual("b", finder.Find(list));
        }

        /// <summary>
        /// Checks that finding the midpoint in a list of five nodes is implemented correctly.
        /// </summary>
        [Test]
        public void FindFive()
        {
            LinkedList list = new LinkedList();
            list.InsertLast("a");
            list.InsertLast("b");
            list.InsertLast("c");
            list.InsertLast("d");
            list.InsertLast("e");
            Assert.AreEqual("c", finder.Find(list));
        }

        /// <summary>
        /// Midpoint finder.
        /// </summary>
        private MidpointFinder finder;
    }
}
