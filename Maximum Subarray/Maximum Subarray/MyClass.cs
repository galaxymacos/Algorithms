namespace Maximum_Subarray
{
    public class MyClass
    {
        public static int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int maxSum = int.MinValue;
            for (int subArrayLength = 1; subArrayLength <= nums.Length; subArrayLength++)
            {
                for (int startIndex = 0; startIndex+subArrayLength <= nums.Length; startIndex++)
                {
                    int sum = 0;
                    for (int i = 0; i < subArrayLength; i++)
                    {
                        sum += nums[startIndex + i];
                    }

                    if (sum > maxSum)
                        maxSum = sum;
                }
            }

            return maxSum;
        }
    }
}