using System;

namespace Longest_Common_Prefix
{
    internal partial class Program
    {
        public class DivideAndConquer
        {
            static string LongestCommonPrefix(string[] strs)
            {
                if (strs == null || strs.Length == 0) return "";
                return LongestCommonPrefix(strs, 0, strs.Length - 1);
            }

            private static string LongestCommonPrefix(string[] strs, int l, int r)
            {
                if (l == r) return strs[l];
                int mid = (l + r) / 2;
                string lcpLeft = LongestCommonPrefix(strs, l, mid);
                string lcpRight = LongestCommonPrefix(strs, mid + 1, r);
                return CommonPrefix(lcpLeft, lcpRight);
            }

            private static string CommonPrefix(string left, string right)
            {
                int min = Math.Min(left.Length, right.Length);
                for (int i = 0; i < min; i++)
                {
                    if (left[i] != right[i])
                        return left.Substring(0, i);
                }
                
                return left.Substring(0, min);
            }
        }
    }
}