using JustinsHelpers.Maths;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;

namespace JustinsHelpers.Tests.Maths
{
    [TestFixture,ExcludeFromCodeCoverage]
    public class A000142
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void First10AreCorrect()
        {
            var first10 = A000142Sequence.Get().Take(10).ToList();
            Assert.AreEqual(new List<BigInteger> { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 }, first10);
        }

        [Test]
        public void TenthIsCorrect()
        {
            Assert.AreEqual((BigInteger)362880, A000142Sequence.Get(9));
        }
        [Test]
        public void OneHunderedthIsCorrect()
        {
            Assert.AreEqual(BigInteger.Parse("933262154439441526816992388562667004907159682643816214685929638952175999932299156089414639761565182862536979208272237582511852109168640000000000000000000000"), A000142Sequence.Get(99));
        }
    }
}
