using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LinkedLists
{
    /// <summary>
    /// Tests for LinkedList class.
    /// </summary>
    [TestFixture]
    class LinkedListTests
    {
        /// <summary>
        /// Set up for every test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            list = new LinkedList();
        }

        /// <summary>
        /// Checks that InsertFirst is implemented correctly.
        /// </summary>
        [Test]
        public void InsertFirst()
        {
            list.InsertFirst(1);
            Assert.AreEqual(1, list.GetFirst());
            list.InsertFirst(2);
            Assert.AreEqual(2, list.GetFirst());
        }

        /// <summary>
        /// Checks that Size is implemented correctly.
        /// </summary>
        [Test]
        public void Size()
        {
            Assert.AreEqual(0, list.Size());
            list.InsertFirst(1);
            list.InsertFirst(1);
            list.InsertFirst(1);
            list.InsertFirst(1);
            Assert.AreEqual(4, list.Size());
        }

        /// <summary>
        /// Checks that GetFirst is implemented correctly.
        /// </summary>
        [Test]
        public void GetFirst()
        {
            list.InsertFirst(1);
            Assert.AreEqual(1, list.GetFirst());
            list.InsertFirst(2);
            Assert.AreEqual(2, list.GetFirst());
        }

        /// <summary>
        /// Checks that GetLast is implemented correctly.
        /// </summary>
        [Test]
        public void GetLast()
        {
            list.InsertFirst(2);
            Assert.AreEqual(2, list.GetLast());
            list.InsertFirst(1);
            Assert.AreEqual(2, list.GetLast());
        }

        /// <summary>
        /// Checks that Clear is implemented correctly.
        /// </summary>
        [Test]
        public void Clear()
        {
            Assert.AreEqual(0, list.Size());
            list.InsertFirst(1);
            list.InsertFirst(1);
            list.InsertFirst(1);
            list.InsertFirst(1);
            Assert.AreEqual(4, list.Size());
            list.Clear();
            Assert.AreEqual(0, list.Size());
        }

        /// <summary>
        /// Checks that Remove when linked list is empty is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveFirstEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
        }

        /// <summary>
        /// Checks that Remove when linked list has one item is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveFirstOne()
        {
            list.InsertFirst(1);
            list.RemoveFirst();
            Assert.AreEqual(0, list.Size());
            Assert.Throws<InvalidOperationException>(() => list.GetFirst());
        }

        /// <summary>
        /// Checks that Remove when linked list has three items is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveFirstThree()
        {
            list.InsertFirst('c');
            list.InsertFirst('b');
            list.InsertFirst('a');
            list.RemoveFirst();
            Assert.AreEqual(2, list.Size());
            Assert.AreEqual('b', list.GetFirst());
            list.RemoveFirst();
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual('c', list.GetFirst());
        }

        /// <summary>
        /// Checks that RemoveLast when linked list is empty is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveLastEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => list.RemoveLast());
        }

        /// <summary>
        /// Checks that Remove when linked list has one item is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveLastOne()
        {

            list.InsertFirst(1);
            list.RemoveLast();
            Assert.AreEqual(0, list.Size());
            Assert.Throws<InvalidOperationException>(() => list.GetFirst());
        }

        /// <summary>
        /// Checks that Remove when linked list has two items is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveLastTwo()
        {
            list.InsertFirst('b');
            list.InsertFirst('a');

            list.RemoveLast();

            Assert.AreEqual(1, list.Size());
            Assert.AreEqual('a', list.GetFirst());
        }

        /// <summary>
        /// Checks that Remove when linked list has three items is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveLastThree()
        {
            list.InsertFirst('c');
            list.InsertFirst('b');
            list.InsertFirst('a');

            list.RemoveLast();

            Assert.AreEqual(2, list.Size());
            Assert.AreEqual('b', list.GetLast());
        }

        [Test]
        public void InsertLast()
        {
            list.InsertFirst('a');
            list.InsertLast('b');

            Assert.AreEqual(2, list.Size());
            Assert.AreEqual('b', list.GetLast());
        }

        /// <summary>
        /// Checks that GetAt is implemented correctly.
        /// </summary>
        [Test]
        public void GetAt()
        {
            Assert.Throws<InvalidOperationException>(() => list.GetAt(10));

            list.InsertLast(1);
            list.InsertLast(2);
            list.InsertLast(3);
            list.InsertLast(4);

            Assert.AreEqual(1, list.GetAt(0));
            Assert.AreEqual(2, list.GetAt(1));
            Assert.AreEqual(3, list.GetAt(2));
            Assert.AreEqual(4, list.GetAt(3));
        }

        /// <summary>
        /// Checks that RemoveAt when linked list is empty is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveAtEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => list.RemoveAt(0));
        }

        /// <summary>
        /// Checks that RemoveAt using the first item in the linked list is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveAtFirst()
        {
            list.InsertLast(1);
            list.InsertLast(2);
            list.InsertLast(3);
            list.InsertLast(4);
            Assert.AreEqual(1, list.GetFirst());
            list.RemoveAt(0);
            Assert.AreEqual(2, list.GetFirst());
        }

        /// <summary>
        /// Checks that RemoveAt using any item in the linked list is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveAtGiven()
        {
            list.InsertLast(1);
            list.InsertLast(2);
            list.InsertLast(3);
            list.InsertLast(4);
            Assert.AreEqual(2, list.GetAt(1));
            list.RemoveAt(1);
            Assert.AreEqual(3, list.GetAt(1));
        }

        /// <summary>
        /// Checks that RemoveAt using the last item in the linked list is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveAtLast()
        {
            list.InsertLast(1);
            list.InsertLast(2);
            list.InsertLast(3);
            list.InsertLast(4);
            Assert.AreEqual(4, list.GetLast());
            list.RemoveAt(3);
            Assert.AreEqual(3, list.GetLast());
        }

        /// <summary>
        /// Checks that InsertAt when the linked list is empty is implemented correctly.
        /// </summary>
        [Test]
        public void InsertAtEmpty()
        {
            list.InsertAt("hi", 0);

            Assert.AreEqual(1, list.Size());
            Assert.AreEqual("hi", list.GetAt(0));
        }

        /// <summary>
        /// Checks that InsertArt at the start of the linked list is implemented correctly.
        /// </summary>
        [Test]
        public void InsertAtFirst()
        {
            list.InsertLast("a");
            list.InsertLast("b");
            list.InsertLast("c");
            list.InsertAt("hi", 0);
            Assert.AreEqual(4, list.Size());
            Assert.AreEqual("hi", list.GetAt(0));
            Assert.AreEqual("a", list.GetAt(1));
            Assert.AreEqual("b", list.GetAt(2));
            Assert.AreEqual("c", list.GetAt(3));
        }

        /// <summary>
        /// Checks that InsertAt in the middle of the linked list is implemented correctly.
        /// </summary>
        [Test]
        public void InsertAtGiven()
        {
            list.InsertLast("a");
            list.InsertLast("b");
            list.InsertLast("c");
            list.InsertLast("d");
            list.InsertAt("hi", 2);
            Assert.AreEqual(5, list.Size());
            Assert.AreEqual("a", list.GetAt(0));
            Assert.AreEqual("b", list.GetAt(1));
            Assert.AreEqual("hi", list.GetAt(2));
            Assert.AreEqual("c", list.GetAt(3));
            Assert.AreEqual("d", list.GetAt(4));
        }

        /// <summary>
        /// Checks that InsertArt at the end of the linked list is implemented correctly.
        /// </summary>
        [Test]
        public void InsertAtLast()
        {
            list.InsertLast("a");
            list.InsertLast("b");
            list.InsertAt("hi", 2);
            Assert.AreEqual(3, list.Size());
            Assert.AreEqual("a", list.GetAt(0));
            Assert.AreEqual("b", list.GetAt(1));
            Assert.AreEqual("hi", list.GetAt(2));
        }

        /// <summary>
        /// Checks that InsertAt outside the size of the linked list is implemented correctly.
        /// </summary>
        [Test]
        public void InsertAtOutside()
        {
            Assert.Throws<InvalidOperationException>(() => list.InsertAt("hi", 100));
        }

        /// <summary>
        /// Checks that ForEach is implemented correctly.
        /// </summary>
        [Test]
        public void ForEach()
        {

            list.InsertLast(1);
            list.InsertLast(2);
            list.InsertLast(3);
            list.InsertLast(4);

            list.ForEach((o) => { return (int)o * 2; });

            Assert.AreEqual(2, list.GetAt(0));
            Assert.AreEqual(4, list.GetAt(1));
            Assert.AreEqual(6, list.GetAt(2));
            Assert.AreEqual(8, list.GetAt(3));
        }

        /// <summary>
        /// Linked list.
        /// </summary>
        private LinkedList list;
    }
}
