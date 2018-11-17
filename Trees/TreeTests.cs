using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Trees
{
    /// <summary>
    /// Tests for the Tree class.
    /// </summary>
    [TestFixture]
    class TreeTests
    {
        /// <summary>
        /// Set up for every test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            tree = new Tree<string>();
        }

        /// <summary>
        /// Checks that a tree with empty node is implemented correctly.
        /// </summary>
        [Test]
        public void EmptyNode()
        {
            Tree<string>.Node<string> node = new Tree<string>.Node<string>("a");

            Assert.AreEqual("a", node.Data);
            Assert.AreEqual(0, node.Children.Count);
        }

        /// <summary>
        /// Checks that adding a node is implemented correctly.
        /// </summary>
        [Test]
        public void AddNode()
        {
            Tree<string>.Node<string> node = new Tree<string>.Node<string>("a");
            node.Add("b");

            Assert.AreEqual(1, node.Children.Count);
        }

        /// <summary>
        /// Checks that removing a node is implemented correctly.
        /// </summary>
        [Test]
        public void RemoveNode()
        {

            Tree<string>.Node<string> node = new Tree<string>.Node<string>("a");
            node.Add("b");

            Assert.AreEqual(1, node.Children.Count);
            node.Remove("b");

            Assert.AreEqual(0, node.Children.Count);
        }

        /// <summary>
        /// Checks that breadth first traversal is implemented correctly.
        /// </summary>
        [Test]
        public void BreadthFirstTraverse()
        {
            tree.Root = new Tree<string>.Node<string>("a");
            tree.Root.Add("b");
            tree.Root.Add("c");
            tree.Root.Children[0].Add("d");

            CollectionAssert.AreEqual(new object[] { "a", "b", "c", "d" }, tree.BreadthFirstTraverse());
        }

        /// <summary>
        /// Checks that depth first search is implemented correctly.
        /// </summary>
        [Test]
        public void DepthFirstTraverse()
        {
            tree.Root = new Tree<string>.Node<string>("a");
            tree.Root.Add("b");
            tree.Root.Add("d");
            tree.Root.Children[0].Add("c");

            CollectionAssert.AreEqual(new object[] { "a", "b", "c", "d" }, tree.DepthFirstTraverse());
        }

        /// <summary>
        /// Tree.
        /// </summary>
        private Tree<string> tree;
    }
}
