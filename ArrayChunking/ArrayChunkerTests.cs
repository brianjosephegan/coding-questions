using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ArrayChunking
{
    /// <summary>
    /// Tests for BubbleSorter class.
    /// </summary>
    [TestFixture]
    class ArrayChunkerTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            chunker = new ArrayChunker();
        }

        /// <summary>
        /// Checks that null is handled correctly.
        /// </summary>
        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => { chunker.Chunk(null, 2); });

            StringAssert.Contains("input cannot be null", ex.Message);
            StringAssert.Contains("input", ex.ParamName);
        }

        /// <summary>
        /// Checks that a negative chunk size is handled correctly.
        /// </summary>
        [Test]
        public void Negative()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => { chunker.Chunk(new int[] { 1, 2, 3, 4 }, -1); });

            StringAssert.Contains("size cannot be less than or equal to zero", ex.Message);
            StringAssert.Contains("size", ex.ParamName);
        }

        /// <summary>
        /// Checks that zero chunk size is handled correctly.
        /// </summary>
        [Test]
        public void Zero()
        {

            ArgumentException ex = Assert.Throws<ArgumentException>(() => { chunker.Chunk(new int[] { 1, 2, 3, 4 }, 0); });

            StringAssert.Contains("size cannot be less than or equal to zero", ex.Message);
            StringAssert.Contains("size", ex.ParamName);
        }

        /// <summary>
        /// Checks that empty array is handled correctly.
        /// </summary>
        [Test]
        public void Empty()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => { chunker.Chunk(new int[] { }, 2); });

            StringAssert.Contains("input cannot be empty", ex.Message);
            StringAssert.Contains("input", ex.ParamName);
        }

        /// <summary>
        /// Checks that a chunk size of one is handled correctly.
        /// </summary>
        [Test]
        public void One()
        {
            CollectionAssert.AreEqual(new int[][] { new int[] { 1 }, new int[] { 2 }, new int[] { 3 } }, chunker.Chunk(new int[] { 1, 2, 3 }, 1));
        }

        /// <summary>
        /// Checks that an even chunk size is handled correctly.
        /// </summary>
        [Test]
        public void Even()
        {
            CollectionAssert.AreEqual(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } }, chunker.Chunk(new int[] { 1, 2, 3, 4 }, 2));
        }

        /// <summary>
        /// Checks that an odd chunk size is handlded correctly.
        /// </summary>
        [Test]
        public void Odd()
        {
            CollectionAssert.AreEqual(new int[][] { new int[] { 1, 2 }, new int[] { 3 } }, chunker.Chunk(new int[] { 1, 2, 3 }, 2));
        }

        /// <summary>
        /// Checks that a chunk size larger than the input array size is handled correctly.
        /// </summary>
        [Test]
        public void Larger()
        {
            CollectionAssert.AreEqual(new int[][] { new int[] { 1, 2, 3 } }, chunker.Chunk(new int[] { 1, 2, 3 }, 10));
        }

        /// <summary>
        /// Array chunker.
        /// </summary>
        private ArrayChunker chunker;
    }
}
