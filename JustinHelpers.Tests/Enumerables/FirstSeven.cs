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
    public class FirstSeven
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ReturnsFirstSeven()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var (first, second, third, fourth, fifth,sixth,seventh) = list.FirstSeven();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 3);
                Assert.AreEqual(fourth, 4);
                Assert.AreEqual(fifth, 5);
                Assert.AreEqual(sixth, 6);
                Assert.AreEqual(seventh, 7);
            });
        }
        [Test]
        public void ThrowsIfOneElement()
        {
            var list = new List<int> { 1 };
            Assert.Throws<ArgumentException>(() => list.FirstSeven());
        }
        [Test]
        public void ThrowsIfTwoElements()
        {
            var list = new List<int> { 1, 2 };
            Assert.Throws<ArgumentException>(() => list.FirstSeven());
        }
        [Test]
        public void ThrowsIfThreeElements()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.Throws<ArgumentException>(() => list.FirstSeven());
        }
        [Test]
        public void ThrowsIfFourElements()
        {
            var list = new List<int> { 1, 2, 3, 4 };
            Assert.Throws<ArgumentException>(() => list.FirstSeven());
        }
        [Test]
        public void ThrowsIfFiveElements()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            Assert.Throws<ArgumentException>(() => list.FirstSeven());
        }
        [Test]
        public void OrDefaultReturnsFirstSeven()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var (first, second, third, fourth,fifth,sixth,seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 3);
                Assert.AreEqual(fourth, 4);
                Assert.AreEqual(fifth, 5);
                Assert.AreEqual(sixth, 6);
                Assert.AreEqual(seventh, 7);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstOneAndZerosForIntEnumerable()
        {
            var list = new List<int> { 1 };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 0);
                Assert.AreEqual(third, 0);
                Assert.AreEqual(fourth, 0);
                Assert.AreEqual(fifth, 0);
                Assert.AreEqual(sixth, 0);
                Assert.AreEqual(seventh, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstOneAndNullsForReferenceEnumerable()
        {
            var list = new List<string> { "A" };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, null);
                Assert.AreEqual(third, null);
                Assert.AreEqual(fourth, null);
                Assert.AreEqual(fifth, null);
                Assert.AreEqual(sixth, null);
                Assert.AreEqual(seventh, null);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstTwoAndZerosForIntEnumerable()
        {
            var list = new List<int> { 1, 2 };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 0);
                Assert.AreEqual(fourth, 0);
                Assert.AreEqual(fifth, 0);
                Assert.AreEqual(sixth, 0);
                Assert.AreEqual(seventh, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstTwoAndNullsForReferenceEnumerable()
        {
            var list = new List<string> { "A", "B" };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, "B");
                Assert.AreEqual(third, null);
                Assert.AreEqual(fourth, null);
                Assert.AreEqual(fifth, null);
                Assert.AreEqual(sixth, null);
                Assert.AreEqual(seventh, null);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstThreeAndZerosForIntEnumerable()
        {
            var list = new List<int> { 1, 2, 3 };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 3);
                Assert.AreEqual(fourth, 0);
                Assert.AreEqual(fifth, 0);
                Assert.AreEqual(sixth, 0);
                Assert.AreEqual(seventh, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstThreeAndNullsForReferenceEnumerable()
        {
            var list = new List<string> { "A", "B", "C" };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, "B");
                Assert.AreEqual(third, "C");
                Assert.AreEqual(fourth, null);
                Assert.AreEqual(fifth, null);
                Assert.AreEqual(sixth, null);
                Assert.AreEqual(seventh, null);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstFourAndZerosForIntEnumerable()
        {
            var list = new List<int> { 1, 2, 3, 4 };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 3);
                Assert.AreEqual(fourth, 4);
                Assert.AreEqual(fifth, 0);
                Assert.AreEqual(sixth, 0);
                Assert.AreEqual(seventh, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstFourAndNullsForReferenceEnumerable()
        {
            var list = new List<string> { "A", "B", "C", "D" };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, "B");
                Assert.AreEqual(third, "C");
                Assert.AreEqual(fourth, "D");
                Assert.AreEqual(fifth, null);
                Assert.AreEqual(sixth, null);
                Assert.AreEqual(seventh, null);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstFiveAndZerosForIntEnumerable()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 3);
                Assert.AreEqual(fourth, 4);
                Assert.AreEqual(fifth, 5);
                Assert.AreEqual(sixth, 0);
                Assert.AreEqual(seventh, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstFiveAndNullsForReferenceEnumerable()
        {
            var list = new List<string> { "A", "B", "C", "D", "E" };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, "B");
                Assert.AreEqual(third, "C");
                Assert.AreEqual(fourth, "D");
                Assert.AreEqual(fifth, "E");
                Assert.AreEqual(sixth, null);
                Assert.AreEqual(seventh, null);
            });
        }

        [Test]
        public void OrDefaultReturnsFirstSixAndZerosForIntEnumerable()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6 };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 1);
                Assert.AreEqual(second, 2);
                Assert.AreEqual(third, 3);
                Assert.AreEqual(fourth, 4);
                Assert.AreEqual(fifth, 5);
                Assert.AreEqual(sixth, 6);
                Assert.AreEqual(seventh, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsFirstSixAndNullsForReferenceEnumerable()
        {
            var list = new List<string> { "A", "B", "C", "D", "E", "F" };
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, "A");
                Assert.AreEqual(second, "B");
                Assert.AreEqual(third, "C");
                Assert.AreEqual(fourth, "D");
                Assert.AreEqual(fifth, "E");
                Assert.AreEqual(sixth, "F");
                Assert.AreEqual(seventh, null);
            });
        }

        [Test]
        public void OrDefaultReturnsZerosForIntEnumerable()
        {
            var list = Enumerable.Empty<int>();
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, 0);
                Assert.AreEqual(second, 0);
                Assert.AreEqual(third, 0);
                Assert.AreEqual(fourth, 0);
                Assert.AreEqual(fifth, 0);
                Assert.AreEqual(sixth, 0);
                Assert.AreEqual(seventh, 0);
            });
        }
        [Test]
        public void OrDefaultReturnsNullsForReferenceEnumerable()
        {
            var list = Enumerable.Empty<string>();
            var (first, second, third, fourth, fifth, sixth, seventh) = list.FirstSevenOrDefault();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(first, null);
                Assert.AreEqual(second, null);
                Assert.AreEqual(third, null);
                Assert.AreEqual(fourth, null);
                Assert.AreEqual(fifth, null);
                Assert.AreEqual(sixth, null);
            });
        }
    }
}
