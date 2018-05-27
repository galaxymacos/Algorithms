using System.Collections.Generic;
using System.Linq;

namespace Longest_Common_Prefix
{
    internal partial class Program
    {
        public class MyClass
        {
            static string LongestCommonPrefix(string[] strs)
            {
                List<string> list = new List<string>(strs.Where(str => !string.IsNullOrWhiteSpace(str)));
                if (list.Count == 0 || list.Count != strs.Length)
                {
                    return "";
                }

                int startIndex = 0;
                string result = "";

                int minLength = int.MaxValue;
                foreach (var str in list)
                {
                    if (str.Length < minLength)
                        minLength = str.Length;
                }

                while (true)
                {
                    char s = list[0][startIndex];
                    foreach (var str in list)
                    {
                        if (str[startIndex] != s)
                            goto outOfLoop;
                    }

                    result += s;
                    startIndex++;
                    if (startIndex >= minLength)
                    {
                        goto outOfLoop;
                    }
                }

                outOfLoop:
                return result;
            }
            
        }
    }
}