using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using JustinsHelpers.Maths.Fibonacci;
using System.Linq;
using System.Numerics;

namespace JustinsHelpers.Tests.Maths
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class Fibonacci
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void First10AreCorrect()
        {
            var first10 = FibonacciSequence.Get().Take(10).ToList();
            Assert.AreEqual(new List<BigInteger> {0,1,1,2,3,5,8,13,21,34 }, first10);
        }

        [Test]
        public void TenthIsCorrect()
        {
            Assert.AreEqual((BigInteger)34, FibonacciSequence.Get(9));
        }
        [Test]
        public void OneHunderedthIsCorrect()
        {
            Assert.AreEqual(BigInteger.Parse("218922995834555169026"), FibonacciSequence.Get(99));
        }
        [Test]
        public void OneThousandnthIsCorrect()
        {
            Assert.AreEqual(BigInteger.Parse("26863810024485359386146727202142923967616609318986952340123175997617981700247881689338369654483356564191827856161443356312976673642210350324634850410377680367334151172899169723197082763985615764450078474174626"), FibonacciSequence.Get(999));
        }
    }
}
