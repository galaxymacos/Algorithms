namespace Longest_Common_Prefix
{
    internal partial class Program
    {
        public class HorizontalScanning
        {
            public string LongestCommonPrefix(string[] strs)
            {
                if (strs == null || strs.Length == 0) return "";

                string prefix = strs[0]; // pretend the first string is LCP (longest common prefix)

                // see if other strings also has a prefix of strs[0]
                for (int i = 1; i < strs.Length; i++)
                {
                    while (!strs[i].StartsWith(prefix)) //  if not, cut the last letter of prefix and compare again
                    {
                        prefix = prefix.Substring(0, prefix.Length - 1);
                        if (prefix.Length == 0) return "";    // if there is no letter left in LCP, return ""
                    }
                }

                return prefix;
            }
        }
    }
}