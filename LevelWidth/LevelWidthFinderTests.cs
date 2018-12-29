using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees;
using NUnit.Framework;

namespace LevelWidth
{
    /// <summary>
    /// Tests for the LevelWidthFinder class.
    /// </summary>
    [TestFixture]
    public class LevelWidthFinderTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            finder = new LevelWidthFinder();
        }

        /// <summary>
        /// Checks that a null tree is handled correctly.
        /// </summary>
        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => finder.Find(null));

            StringAssert.Contains("tree cannot be null", ex.Message);
        }

        /// <summary>
        /// Checks that a tree with no levels finds correct widths.
        /// </summary>
        [Test]
        public void NoLevels()
        {
            Tree tree = new Tree();

            CollectionAssert.AreEqual(new int[] { 0 }, finder.Find(tree));
        }

        /// <summary>
        /// Checks that a tree with one levels finds correct widths.
        /// </summary>
        [Test]
        public void OneLevel()
        {
            Tree tree = new Tree();
            tree.Root = new Tree.Node(0);

            CollectionAssert.AreEqual(new int[] { 1 }, finder.Find(tree));
        }

        /// <summary>
        /// Checks that a tree with three levels finds correct widths.
        /// </summary>
        [Test]
        public void ThreeLevels()
        {
            Tree tree = new Tree();
            tree.Root = new Tree.Node(0);
            tree.Root.Add(1);
            tree.Root.Add(2);
            tree.Root.Add(3);
            tree.Root.Children[0].Add(4);
            tree.Root.Children[0].Add(5);

            CollectionAssert.AreEqual(new int[] { 1, 3, 2 }, finder.Find(tree));
        }

        /// <summary>
        /// Checks that a tree with four levels finds the correct widths.
        /// </summary>
        [Test]
        public void FourLevels()
        {
            Tree tree = new Tree();
            tree.Root = new Tree.Node(0);
            tree.Root.Add(1);
            tree.Root.Children[0].Add(2);
            tree.Root.Children[0].Add(3);
            tree.Root.Children[0].Children[0].Add(4);

            CollectionAssert.AreEqual(new int[] { 1, 1, 2, 1 }, finder.Find(tree));
        }

        /// <summary>
        /// Level width finder.
        /// </summary>
        private LevelWidthFinder finder;
    }
}
