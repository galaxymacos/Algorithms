using System;

namespace ProductofArrayExceptSelf
{
    
    public class Solution {
        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }
            int[] leftSum = new int[nums.Length] ;
            int[] rightSum = new int[nums.Length];
            leftSum[0] = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (i == 1)
                    leftSum[i] = nums[0];
                else
                    leftSum[i] = leftSum[i - 1] * nums[i-1];
            }

            rightSum[nums.Length - 1] = 0;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (i == nums.Length - 2)
                    rightSum[i] = nums[nums.Length - 1];
                else
                {
                    rightSum[i] = rightSum[i + 1] * nums[i + 1];
                }
            }

            int[] result = new int[nums.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0)
                    result[i] = rightSum[i];
                else if (i == result.Length - 1)
                    result[i] = leftSum[i];
                else
                {
                    result[i] = leftSum[i] * rightSum[i];
                }
            }

            return result;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.ProductExceptSelf(new[] {1});
        }
    }
}