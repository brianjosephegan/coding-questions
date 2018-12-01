using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Stacks
{
    /// <summary>
    /// Tests for the Stack class.
    /// </summary>
    [TestFixture]
    class StackTests
    {
        /// <summary>
        /// Set up for every test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            stack = new Stack();
        }

        /// <summary>
        /// Checks that Add is implemented correctly.
        /// </summary>
        [Test]
        public void Add()
        {
            stack.Push(1);
            Assert.AreEqual(1, stack.Pop());
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        /// <summary>
        /// Checks that Remove is implemented correctly.
        /// </summary>
        [Test]
        public void Remove()
        {
            stack.Push(1);
            Assert.AreEqual(1, stack.Pop());
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        /// <summary>
        /// Checks that Peek is implemented correctly.
        /// </summary>
        [Test]
        public void Peek()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.Peek());
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Peek());
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Peek());
            Assert.AreEqual(1, stack.Pop());

            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        /// <summary>
        /// Checks that order of the Stack is implemented correctly.
        /// </summary>
        [Test]
        public void Order()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        /// <summary>
        /// Stack.
        /// </summary>
        private Stack stack;
    }
}
