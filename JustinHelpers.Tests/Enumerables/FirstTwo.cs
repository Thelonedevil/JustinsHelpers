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
    public class FirstTwo
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ReturnsFirstTwo()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            (var first,var second) = list.FirstTwo();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
            });
        }
        [Test]
        public void ThrowsIfLessThanTwoElements()
        {
            var list = new List<int> { 1 };
            Assert.Throws<ArgumentException>(() => list.FirstTwo());
        }
        [Test]
        public void OrDefaultReturnsFirstTwo()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            (var first, var second) = list.FirstTwoOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
            });
        }
        [Test]
        public void ReturnsFirstOneAndZeroForIntEnumerable()
        {
            var list = new List<int> { 1 };
            (var first, var second) = list.FirstTwoOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 0);
            });
        }
        [Test]
        public void ReturnsFirstOneAndNullForReferenceEnumerable()
        {
            var list = new List<string> { "A" };
            (var first, var second) = list.FirstTwoOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, null);
            });
        }
        [Test]
        public void ReturnsZeroAndZeroForIntEnumerable()
        {
            var list = Enumerable.Empty<int>();
            (var first, var second) = list.FirstTwoOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 0);
                Assert.AreEqual(second, 0);
            });
        }
        [Test]
        public void ReturnsNullAndNullForReferenceEnumerable()
        {
            var list = Enumerable.Empty<string>();
            (var first, var second) = list.FirstTwoOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, null);
                Assert.AreEqual(second, null);
            });
        }
    }
}
