using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BinarySearchTrees
{
    /// <summary>
    /// Tests for BinarySearchTree class.
    /// </summary>
    [TestFixture]
    class BinarySearchTreeTests
    {
        /// <summary>
        /// Set up for every test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            tree = new BinarySearchTree();
        }

        /// <summary>
        /// Checks that Insert is implemented correctly.
        /// </summary>
        [Test]
        public void Insert()
        {
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(17);

            Assert.AreEqual(5, tree.Root.Data);
            Assert.AreEqual(15, tree.Root.Right.Data);
            Assert.AreEqual(17, tree.Root.Right.Right.Data);
        }

        /// <summary>
        /// Checks that Contains is implemented correctly when the binary search tree does conatin the data.
        /// </summary>
        [Test]
        public void ContainsPositive()
        {
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(20);
            tree.Insert(0);
            tree.Insert(-5);
            tree.Insert(3);

            Assert.IsTrue(tree.Contains(3));
        }

        /// <summary>
        /// Checks that Contains is implemented correctly when the binary search tree does not conatin the data.
        /// </summary>
        [Test]
        public void ContainsNegative()
        {
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(20);
            tree.Insert(0);
            tree.Insert(-5);
            tree.Insert(3);

            Assert.IsFalse(tree.Contains(-3));
        }

        /// <summary>
        /// Checks that Validate is implemented correctly when the binary search tree is valid.
        /// </summary>
        [Test]
        public void ValidatePositive()
        {
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(0);
            tree.Insert(20);

            Assert.IsTrue(tree.Validate());
        }

        /// <summary>
        /// Checks that Validate is implemented correctly when the binary search tree is not valid.
        /// </summary>
        [Test]
        public void ValidateNegative()
        {
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(0);
            tree.Insert(20);
            tree.Root.Left.Left.Right = new BinarySearchTree.Node(999);

            Assert.IsFalse(tree.Validate());
        }

        /// <summary>
        /// Binary search tree.
        /// </summary>
        private BinarySearchTree tree;
    }
}
