using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace JustinsHelpers.Maths.Factorial
{
    public static class Helper
    {
        public static BigInteger Factorial(this BigInteger n)
        {
            return implementation(n, BigInteger.One);
        }
        private static BigInteger implementation(BigInteger n, BigInteger result)
        {
            if (n > BigInteger.Zero)
            {
                return implementation(n - BigInteger.One, result * n);
            }
            return result;
        }
    }
}
