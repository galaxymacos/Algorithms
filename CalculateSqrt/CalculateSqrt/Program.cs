using System;

namespace CalculateSqrt
{
    public class MyClass
    {
        private static int leftBound = -1;
        private static int intMax = (int) Math.Sqrt(int.MaxValue);

        public static int Sqrt(int x)
        {
            leftBound = -1;
            return Sqrt(x, 1, x);
        }

        public static int Sqrt(int x, int left, int right)
        {
            int mid = (right - left) / 2 + left;
            if (left == mid)    // no elements between left and mid
                return mid;
            if (mid > intMax || mid * mid > x)
            {
                if (leftBound == mid - 1)
                    return leftBound;
                return Sqrt(x, left, mid);
            }

            if (mid * mid < x)
            {
                leftBound = mid;
                return Sqrt(x, mid, right);
            }

            return mid;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MyClass.Sqrt(2147395599));
        }
    }
}