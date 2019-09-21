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
    public class FirstFour
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ReturnsFirstFour()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var (first,second,third,fourth) = list.FirstFour();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 3);
                Assert.AreEqual(fourth, 4);
            });
        }
        [Test]
        public void ThrowsIfOneElement()
        {
            var list = new List<int> { 1 };
            Assert.Throws<ArgumentException>(() => list.FirstFour());
        }
        [Test]
        public void ThrowsIfTwoElements()
        {
            var list = new List<int> { 1, 2 };
            Assert.Throws<ArgumentException>(() => list.FirstFour());
        }
        [Test]
        public void ThrowsIfThreeElements()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.Throws<ArgumentException>(() => list.FirstFour());
        }
        [Test]
        public void OrDefaultReturnsFirstFour()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var (first, second, third, fourth) = list.FirstFourOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 3);
                Assert.AreEqual(fourth, 4);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstOneAndZerosForIntEnumerable()
        {
            var list = new List<int> { 1 };
            var (first, second, third, fourth) = list.FirstFourOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 0);
                Assert.AreEqual(third, 0);
                Assert.AreEqual(fourth, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstOneAndNullsForReferenceEnumerable()
        {
            var list = new List<string> { "A" };
            var (first, second, third, fourth) = list.FirstFourOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, null);
                Assert.AreEqual(third, null);
                Assert.AreEqual(fourth, null);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstTwoAndZerosForIntEnumerable()
        {
            var list = new List<int> { 1 ,2};
            var (first, second, third, fourth) = list.FirstFourOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 0);
                Assert.AreEqual(fourth, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstTwoAndNullsForReferenceEnumerable()
        {
            var list = new List<string> { "A" ,"B"};
            var (first, second, third, fourth) = list.FirstFourOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, "B");
                Assert.AreEqual(third, null);
                Assert.AreEqual(fourth, null);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstThreeAndZerosForIntEnumerable()
        {
            var list = new List<int> { 1, 2, 3 };
            var (first, second, third, fourth) = list.FirstFourOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 3);
                Assert.AreEqual(fourth, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstThreeAndNullsForReferenceEnumerable()
        {
            var list = new List<string> { "A", "B", "C" };
            var (first, second, third, fourth) = list.FirstFourOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, "B");
                Assert.AreEqual(third, "C");                  
                Assert.AreEqual(fourth, null);
            });
        }

        [Test]
        public void OrDefaultReturnsZerosForIntEnumerable()
        {
            var list = Enumerable.Empty<int>();
            var (first, second, third, fourth) = list.FirstFourOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 0);
                Assert.AreEqual(second, 0);
                Assert.AreEqual(third, 0);
                Assert.AreEqual(fourth, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsNullsForReferenceEnumerable()
        {
            var list = Enumerable.Empty<string>();
            var (first, second, third, fourth) = list.FirstFourOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, null);
                Assert.AreEqual(second, null);
                Assert.AreEqual(third, null);
                Assert.AreEqual(fourth, null);
            });
        }
    }
}
