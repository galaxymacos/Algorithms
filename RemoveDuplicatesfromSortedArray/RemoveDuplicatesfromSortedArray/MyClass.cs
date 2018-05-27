using System.Collections.Generic;

namespace RemoveDuplicatesfromSortedArray
{
    public class MyClass {
        public static int RemoveDuplicatesUnsorted(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            int j = nums.Length;
            for (int i = 0; i < j; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i],i);
                }
                else
                {
                    nums[i] = nums[--j];
                    i--;
                }
            }

            return j;
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            int j = 0;
            var list = new List<int>();
            while (i < nums.Length)
            {
                if (!list.Contains(nums[i]))    // if the current element doesn't have duplicate yet
                {
                    list.Add(nums[i]);    // mark it as having the duplicate
                    nums[j] = nums[i];    // set it to the begining of the array
                    j++;
                }
                i++;
            }
            return j;
        }

        
    }
}