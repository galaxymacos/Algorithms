using System;
using System.Security.Cryptography.X509Certificates;

namespace ConvertSortedArraytoBinarySearchTree
{
 
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
 
    public class Solution {
        

        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
                return null;
            if(nums.Length == 1)
                return new TreeNode(nums[0]);
            if(nums.Length == 2)
                return new TreeNode(nums[0]){right = new TreeNode(nums[1])};
            int midIndex = nums.Length / 2;
            return new TreeNode(nums[midIndex])
            {
                left = SortedArrayToBST(nums.SubArray(0, midIndex)),
                right = SortedArrayToBST(nums.SubArray(midIndex+1, nums.Length - midIndex-1))    // TODO check
            };

        }
    }

    public static class ArrayExtension
    {
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
//            Console.WriteLine("Length is "+length);
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] arr = {-1,0,1,2};
            solution.SortedArrayToBST(arr);
        }
    }
}