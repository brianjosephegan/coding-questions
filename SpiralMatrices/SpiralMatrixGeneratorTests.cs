using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SpiralMatrices
{
    /// <summary>
    /// Test for SpiralMatrixGenerator class.
    /// </summary>
    [TestFixture]
    class SpiralMatrixGeneratorTests
    {
        /// <summary>
        /// Setup for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            generator = new SpiralMatrixGenerator();
        }

        /// <summary>
        /// Checks that a negative number is handled correctly.
        /// </summary>
        [Test]
        public void Negative()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => { generator.Generate(-1); });

            StringAssert.Contains("number cannot be negative", ex.Message);
            StringAssert.Contains("number", ex.ParamName);
        }

        /// <summary>
        /// Checks that zero is handled correctly.
        /// </summary>
        [Test]
        public void Zero()
        {
            CollectionAssert.IsEmpty(generator.Generate(0));
        }

        /// <summary>
        /// Checks that a positive number is handled correctly.
        /// </summary>
        /// <param name="number">Number of rows and columns to generate in the matrix.</param>
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Positive(int number)
        {
            int[][] results = generator.Generate(number);

            foreach (int[] result in results)
            {
                Console.WriteLine(string.Join(",", result));
            }
        }

        private SpiralMatrixGenerator generator;
    }
}
