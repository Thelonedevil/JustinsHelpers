using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace JustinsHelpers.Maths.Fibonacci
{

    public static class FibonacciSequence
    {
        public static IEnumerable<BigInteger> Get()
        {
            yield return BigInteger.Zero;
            yield return BigInteger.One;
            var cur = BigInteger.One;
            var next = BigInteger.One;
            while (true)
            {
                yield return next;
                var tmp = cur + next;
                cur = next;
                next = tmp;
            }
        }
        public static BigInteger Get(int index)
        {
            return Get().Take(index + 1).Last();
        }
    }

}
