using JustinsHelpers.Tuples.AsEnumerable;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace JustinsHelpers.Tests.Tuples
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class AsEnumerable
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void CorrectLengthForSmallTuple()
        {
            var testTuple = (1,2);
            var result = testTuple.AsEnumerable().ToList();
            Assert.AreEqual(result.Count, 2);
        }
        [Test]
        public void CorrectLengthForMediumTuple()
        {
            var testTuple = (1, 2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);
            var result = testTuple.AsEnumerable().ToList();
            Assert.AreEqual(result.Count, 16);
        }
        [Test]
        public void ThrowsIfNotTuple()
        {
            Assert.Throws<ArgumentException>(() => new object().AsEnumerable().ToList());
        }
    }
}
