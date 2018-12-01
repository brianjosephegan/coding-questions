using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queues;
using NUnit.Framework;

namespace QueueWeave
{
    [TestFixture]
    class QueueWeaverTests
    {
        /// <summary>
        /// Set up for every test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            weaver = new QueueWeaver();
        }

        /// <summary>
        /// Checks that a null first queue is handled correctly.
        /// </summary>
        [Test]
        public void NullOne()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => weaver.Weave(null, new Queue()));

            StringAssert.Contains("one cannot be null", ex.Message);
        }

        /// <summary>
        /// Checks that a null second queue is handled correctly.
        /// </summary>
        [Test]
        public void NullTwo()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => weaver.Weave(new Queue(), null));

            StringAssert.Contains("two cannot be null", ex.Message);
        }

        /// <summary>
        /// Checks that an even number of elements is handled correctly.
        /// </summary>
        [Test]
        public void Even()
        {
            Queue one = new Queue();
            one.Add(1);
            one.Add(2);
            one.Add(3);
            one.Add(4);
            Queue two = new Queue();
            two.Add("one");
            two.Add("two");
            two.Add("three");
            two.Add("four");

            Queue result = weaver.Weave(one, two);
            Assert.AreEqual(1, result.Remove());
            Assert.AreEqual("one", result.Remove());
            Assert.AreEqual(2, result.Remove());
            Assert.AreEqual("two", result.Remove());
            Assert.AreEqual(3, result.Remove());
            Assert.AreEqual("three", result.Remove());
            Assert.AreEqual(4, result.Remove());
            Assert.AreEqual("four", result.Remove());
            Assert.Throws<InvalidOperationException>(() => result.Remove());
        }

        /// <summary>
        /// Checks that an odd number of elements is implemented correctly.
        /// </summary>
        [Test]
        public void Odd()
        {
            Queue one = new Queue();
            one.Add(1);
            one.Add(2);
            Queue two = new Queue();
            two.Add("one");
            two.Add("two");
            two.Add("three");

            Queue result = weaver.Weave(one, two);
            Assert.AreEqual(1, result.Remove());
            Assert.AreEqual("one", result.Remove());
            Assert.AreEqual(2, result.Remove());
            Assert.AreEqual("two", result.Remove());
            Assert.AreEqual("three", result.Remove());
            Assert.Throws<InvalidOperationException>(() => result.Remove());
        }

        /// <summary>
        /// Queue weaver.
        /// </summary>
        private QueueWeaver weaver;
    }
}
