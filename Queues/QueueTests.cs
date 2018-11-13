using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Queues
{
    /// <summary>
    /// Tests for the Queue class.
    /// </summary>
    [TestFixture]
    class QueueTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            queue = new Queue<int>();
        }

        /// <summary>
        /// Checks that Peek is implemented correctly.
        /// </summary>
        [Test]
        public void Peek()
        {
            queue.Add(1);
            queue.Add(2);

            Assert.AreEqual(1, queue.Peek());
            Assert.AreEqual(1, queue.Remove());
            Assert.AreEqual(2, queue.Peek());
            Assert.AreEqual(2, queue.Remove());
            Assert.Throws<InvalidOperationException>(() => queue.Peek());
        }

        /// <summary>
        /// Checks that Add is implemented correctly.
        /// </summary>
        [Test]
        public void Add()
        {
            Assert.DoesNotThrow(() => queue.Add(1));
        }

        /// <summary>
        /// Checks that Remove is implemented correctly.
        /// </summary>
        [Test]
        public void Remove()
        {
            queue.Add(1);
            Assert.AreEqual(1, queue.Remove());
        }

        /// <summary>
        /// Checks that order of the Queue is implemented correctly.
        /// </summary>
        [Test]
        public void Order()
        {
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            Assert.AreEqual(1, queue.Remove());
            Assert.AreEqual(2, queue.Remove());
            Assert.AreEqual(3, queue.Remove());
            Assert.Throws<InvalidOperationException>(() => queue.Remove());
        }

        /// <summary>
        /// Queue.
        /// </summary>
        private Queue<int> queue;
    }
}
