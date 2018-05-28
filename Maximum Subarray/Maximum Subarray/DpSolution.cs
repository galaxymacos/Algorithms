using System;

namespace Maximum_Subarray
{
    public class DpSolution
    {
        public static int MaxSubArray(int[] nums)
        {
            var dp = new int[nums.Length];    // dp[i] means the maximum subarray ending with nums[i]
            dp[0] = nums[0];    // the maximum subarray ending with nums[0] is nums[0]
            int max = dp[0];
            
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = nums[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
                max = Math.Max(max, dp[i]);
            }

            return max;
        }
    }
}