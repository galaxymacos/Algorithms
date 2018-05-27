namespace RemoveDuplicatesfromSortedArray
{
    public static class TwoPointers
    {
        public static int RemoveDuplicates(int[] nums)    // NOTE only deal with sorted array
        {
            if (nums.Length == 0) return 0;
            int i = 0;    // store the length of the unduplicated subarray
            for (int j = 1; j < nums.Length; j++)    
            {
                if (nums[j] == nums[i]) continue;    // repetitive elements, do nothing
                nums[++i] = nums[j];    // unique elements, set it at the beginning of the sorted subarray
            }

            return i+1;
        }
    }
}