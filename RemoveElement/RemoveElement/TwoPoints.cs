namespace RemoveElement
{
    public class TwoPoints
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;    // nums[0~i] doesn't contain val  
            for (int j = 0; j < nums.Length; j++)    // find elements other than val in nums
            {
                if (nums[j] == val) continue;
                nums[i] = nums[j];    // set that elements at the beginning 
                i++;
            }

            return i;
        }
    }
}