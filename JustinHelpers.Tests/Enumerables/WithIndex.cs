using NUnit.Framework;
using System.Collections.Generic;
using JustinsHelpers.Enumerables.WithIndex;
using System.Linq;
using System;
using System.Diagnostics.CodeAnalysis;

namespace JustinsHelpers.Tests
{
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class WithIndex
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OrderIsTheSame()
        {
            List<string> test = new List<string> { "A" };
            (var item, var index) = test.WithIndex().FirstOrDefault();
            Assert.IsTrue(item == "A");
        }
        [Test]
        public void IndexStartsAtZero()
        {
            List<string> test = new List<string> { "A" };
            (var item, var index) = test.WithIndex().FirstOrDefault();
            Assert.IsTrue(index == 0);
        }
        [Test]
        public void IndexStartsAtOne()
        {
            List<string> test = new List<string> { "A" };
            (var item, var index) = test.WithIndex(true).FirstOrDefault();
            Assert.IsTrue(index == 1);
        }
        [Test]
        public void ThrowsIfEmpty()
        {
            Assert.Throws<ArgumentException>(()=>Enumerable.Empty<string>().WithIndex());
        }

    }
}