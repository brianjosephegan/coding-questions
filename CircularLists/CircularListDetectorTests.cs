using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLists;
using NUnit.Framework;

namespace CircularLists
{
    /// <summary>
    /// Tests for CircularListDetector class.
    /// </summary>
    [TestFixture]
    public class CircularListDetectorTests
    {
        /// <summary>
        /// Set up for every test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            detector = new CircularListDetector();
        }

        /// <summary>
        /// Checks that null is handled correctly.
        /// </summary>
        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => detector.Detect(null));

            StringAssert.Contains("list", ex.ParamName);
            StringAssert.Contains("list cannot be null", ex.Message);
        }

        /// <summary>
        /// Checks that a circular linked list is detected.
        /// </summary>
        [Test]
        public void Positive()
        {
            LinkedList.Node a = new LinkedList.Node("a");
            LinkedList.Node b = new LinkedList.Node("b");
            LinkedList.Node c = new LinkedList.Node("c");

            a.Next = b;
            b.Next = c;
            c.Next = b;

            LinkedList list = new LinkedList(a);

            Assert.IsTrue(detector.Detect(list));
        }

        /// <summary>
        /// Checks that a circular linked list is detected where the circle is at the head.
        /// </summary>
        [Test]
        public void PositiveHead()
        {
            LinkedList.Node a = new LinkedList.Node("a");
            LinkedList.Node b = new LinkedList.Node("b");
            LinkedList.Node c = new LinkedList.Node("c");

            a.Next = b;
            b.Next = c;
            c.Next = a;

            LinkedList list = new LinkedList(a);

            Assert.IsTrue(detector.Detect(list));
        }

        /// <summary>
        /// Checks that a non-circular linked list is not detected.
        /// </summary>
        [Test]
        public void Negative()
        {
            LinkedList.Node a = new LinkedList.Node("a");
            LinkedList.Node b = new LinkedList.Node("b");
            LinkedList.Node c = new LinkedList.Node("c");

            a.Next = b;
            b.Next = c;
            c.Next = null;

            LinkedList list = new LinkedList(a);

            Assert.IsFalse(detector.Detect(list));
        }

        /// <summary>
        /// Circular list detector.
        /// </summary>
        private CircularListDetector detector;
    }
}
