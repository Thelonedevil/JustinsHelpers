using JustinsHelpers.Maths.Factorial;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace JustinsHelpers.Maths
{
    public static class A000142Sequence
    {
        public static IEnumerable<BigInteger> Get()
        {
            var n = BigInteger.Zero;
            while (true)
            {
                yield return n.Factorial();
                n++;
            }
        }
        public static BigInteger Get(BigInteger index)
        {
            return index.Factorial();
        }
    }
}
