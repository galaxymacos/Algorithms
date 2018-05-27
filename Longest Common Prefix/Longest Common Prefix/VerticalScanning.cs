namespace Longest_Common_Prefix
{
    internal partial class Program
    {
        public class VerticalScanning
        {
            static string LongestCommonPrefix(string[] strs)
            {
                if (strs == null || strs.Length == 0) return "";
                for (int i = 0; i < strs[0].Length; i++)    // iterate every char in the first string in the array
                {
                    char c = strs[0][i];
                    
                    for (int j = 1; j < strs.Length; j++)    // see if every char in the same index in other strings are equal to that
                    {
                        if (strs[j].Length == i || strs[j][i] != c)    // if the index surpass one of the string's length, or the char in that index is not the same
                            return strs[0].Substring(0, i);            // return the substring before this index
                    }
                }

                return strs[0];    // the first string is the longest common prefix (because all the characters in it are verified to be in the other strings)
            }
        }
    }
}