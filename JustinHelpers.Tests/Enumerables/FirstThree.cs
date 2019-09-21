using NUnit.Framework;
using System;
using System.Collections.Generic;
using JustinsHelpers.Enumerables.FirstN;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace JustinsHelpers.Tests
{
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FirstThree
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ReturnsFirstThree()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            (var first,var second,var third) = list.FirstThree();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 3);
            });
        }
        [Test]
        public void ThrowsIfOneElement()
        {
            var list = new List<int> { 1 };
            Assert.Throws<ArgumentException>(() => list.FirstThree());
        }
        [Test]
        public void ThrowsIfTwoElements()
        {
            var list = new List<int> { 1, 2 };
            Assert.Throws<ArgumentException>(() => list.FirstThree());
        }
        [Test]
        public void OrDefaultReturnsFirstThree()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            (var first, var second, var third) = list.FirstThreeOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 3);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstOneAndZeroForIntEnumerable()
        {
            var list = new List<int> { 1 };
            (var first, var second, var third) = list.FirstThreeOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 0);
                Assert.AreEqual(third, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstOneAndNullForReferenceEnumerable()
        {
            var list = new List<string> { "A" };
            (var first, var second, var third) = list.FirstThreeOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, null);
                Assert.AreEqual(third, null);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstOneAndSecondOneAndZeroForIntEnumerable()
        {
            var list = new List<int> { 1 ,2};
            (var first, var second, var third) = list.FirstThreeOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstOneAndSecondOneAndNullForReferenceEnumerable()
        {
            var list = new List<string> { "A" ,"B"};
            (var first, var second, var third) = list.FirstThreeOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, "B");
                Assert.AreEqual(third, null);
            });
        }

        [Test]
        public void OrDefaultReturnsZeroAndZeroForIntEnumerable()
        {
            var list = Enumerable.Empty<int>();
            (var first, var second, var third) = list.FirstThreeOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 0);
                Assert.AreEqual(second, 0);
                Assert.AreEqual(third, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsNullAndNullForReferenceEnumerable()
        {
            var list = Enumerable.Empty<string>();
            (var first, var second, var third) = list.FirstThreeOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, null);
                Assert.AreEqual(second, null);
                Assert.AreEqual(third, null);
            });
        }
    }
}
