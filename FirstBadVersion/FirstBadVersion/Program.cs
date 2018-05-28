using System;

// There must be at least one bad version

namespace FirstBadVersion
{
    public class DiscussionAnswer
    {
        // The first bad version should have no bad version before it ( or it is the first version )
        static bool IsBadVersion(int version)
        {
            return (version < 10);
        }

        public static int FirstBadVersion(int n)
        {
            return FirstBadVersion(1, n);
        }

        private static int FirstBadVersion(int l, int r)
        {
            int mid = (r - l) / 2 + l;
            if (IsBadVersion(mid))
            {
                if (!IsBadVersion(mid - 1) || mid == 1)    // If mid is the first bad version
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
            Console.WriteLine(DiscussionAnswer.FirstBadVersion(100));
        }
    }
}