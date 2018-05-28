using System;

namespace SearchInsertPosition
{
    public static class MyClass {
        public static int SearchInsert(int[] nums, int target) {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                    return i;
            }

            return nums.Length;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1, 3, 5, 6};
            Console.WriteLine(MyClass.SearchInsert(arr,5));
        }
    }
}