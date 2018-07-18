using System.Collections.Generic;
using System.Linq;

namespace MajorityElementII
{
    public class Solution
    {
        public IList<int> MajorityElement(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return new List<int>();
            int candidate1 = 0;
            int candidate2 = 1;
            int count1 = 0;
            int count2 = 0;

            foreach (var num in nums)
            {
                if (num == candidate1)
                    count1 += 1;
                else if (num == candidate2)
                    count2 += 1;
                else if (count1 == 0)
                {
                    candidate1 = num;
                    count1 = 1;
                }
                else if (count2 == 0)
                {
                    candidate2 = num;
                    count2 = 1;
                }
                else
                {
                    count1 -= 1;
                    count2 -= 1;
                }
            }

            IList<int> result = new List<int>();
            if (count1 != 0 && nums.Count(i => i == candidate1) > nums.Length / 3)
            {
                result.Add(candidate1);
            }

            if (count2 != 0 && nums.Count(i => i == candidate2) > nums.Length / 3)
            {
                result.Add(candidate2);
            }

            return result;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}