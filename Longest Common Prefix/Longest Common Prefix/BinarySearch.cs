using System.Linq;

namespace Longest_Common_Prefix
{
    internal partial class Program
    {
        public class BinarySearch
        {
            static string LongestCommonPrefix(string[] strs)
            {
                // check if the array is empty 
                if (strs == null || strs.Length == 0) return "";

                int minLen = strs.Select(str => str.Length).Concat(new[] {int.MaxValue}).Min();

                // set the range of common prefix
                int low = 1;
                int high = minLen;

                // binary search framework of length
                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    if (_IsCommonPrefix(strs, mid)) // find if the arry has a common prefix of length "mid"
                        low = mid + 1;
                    else
                    {
                        high = mid - 1;
                    }
                }

                return strs[0].Substring(0, (low + high) / 2);
            }

            private static bool _IsCommonPrefix(string[] strs, int mid)
            {
                string s = strs[0].Substring(0, mid);
                return strs.All(str => str.StartsWith(s));
            }
        }
    }
}