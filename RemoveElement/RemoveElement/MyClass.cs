using System;

namespace RemoveElement
{
    public class MyClass
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int j = nums.Length;
            for (int i = 0; i < j; i++)
            {
                if (nums[i] != val) continue;    // if val is not found
                
                while(j>i)
                {
                    j--;
                    if (nums[j] == val) continue;
                    
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    break;
                }
            }
            var length = Array.IndexOf(nums, val);
            return length;
        }
    }
}