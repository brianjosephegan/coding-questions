using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringReversal
{
    [TestFixture]
    class StringReverserTests
    {
        [SetUp]
        public void SetUp()
        {
            reverser = new StringReverser();
        }

        [Test]
        public void Null()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => reverser.Reverse(null));

            StringAssert.Contains("input cannot be null", ex.Message);
        }

        [Test]
        public void Normal()
        {
            Assert.AreEqual("abcd", reverser.Reverse("dcba"));
        }

        [Test]
        public void Spaces()
        {
            Assert.AreEqual("  abcd", reverser.Reverse("dcba  "));
        }

        [Test]
        public void Numbers()
        {
            Assert.AreEqual("1234567890", reverser.Reverse("0987654321"));
        }

        [Test]
        public void Sentence()
        {
            Assert.AreEqual(".ecnetnes a si sihT", reverser.Reverse("This is a sentence."));
        }

        private StringReverser reverser;
    }
}
