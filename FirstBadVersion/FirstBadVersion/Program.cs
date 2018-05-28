using System;

namespace FirstBadVersion
{
    public class MyClass
    {
        static bool IsBadVersion(int version)
        {
            return (version < 10);
        }

        public static int FirstBadVersion(int n)
        {
            return FirstBadVersion(1, n);
        }

        public static int FirstBadVersion(int l, int r)
        {
            int mid = (r - l) / 2 + l;
            if (IsBadVersion(mid))
            {
                if (!IsBadVersion(mid - 1) || mid == 1)
                {
                    return mid;
                }
                else
                {
                    return FirstBadVersion(l, mid - 1);
                }
            }
            else
            {
                return FirstBadVersion(mid + 1, r);
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MyClass.FirstBadVersion(100));
        }
    }
}