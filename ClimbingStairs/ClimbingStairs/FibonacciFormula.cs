﻿using System;

namespace ClimbingStairs
{
    public class FibonacciFormula
    {
        public int ClimbStairs(int n)
        {
            double sqrt5 = Math.Sqrt(5);
            double fibn = Math.Pow((1 + sqrt5) / 2, n + 1) - Math.Pow((1 - sqrt5)/2,n+1);
            return (int) (fibn / sqrt5);
        }
    }
}