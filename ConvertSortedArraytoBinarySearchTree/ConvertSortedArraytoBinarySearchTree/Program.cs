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
            int midIndex = nums.Length / 2;
            TreeNode head = new TreeNode(nums[midIndex]);
            TreeNode looper = head;
            bool isEven;
            if (nums.Length % 2 == 0)
                isEven = true;
            else
                isEven = false;
            for (int i = midIndex-1; i >= 0; i--)
            {
                if (isEven&&nums.Length>4)
                {
                    
                     looper.left = new TreeNode(nums[i-1]);
                    looper.left.right = new TreeNode(nums[i]);
                    isEven = false;
                    looper = looper.left;
                    i--;
                }
                else
                {                    
                    looper.left = new TreeNode(nums[i]);
                    looper = looper.left;
                }
            }

            looper = head;
            for (int i = midIndex+1; i < nums.Length; i++)
            {
                looper.right = new TreeNode(nums[i]);
                looper = looper.right;
            }
            
            return head;
        }

        public TreeNode SortedArrayToBST2(int[] nums)
        {
            if (nums.Length == 0)
                return null;
            return CreateTree(nums);
        }

        private TreeNode CreateTree(int[] nums)
        {
            
            if(nums.Length == 1)
                return new TreeNode(nums[0]);
            if (nums.Length == 0)
                return null;
            if (nums.Length == 2)
            {
                if (nums[0] > nums[1])
                {
                    TreeNode result = new TreeNode(nums[0]) {left = new TreeNode(nums[1])};
                    return result;
                }
                else
                {
                    TreeNode result = new TreeNode(nums[0]) {right = new TreeNode(nums[1])};
                    return result;
                }
            }
            var array = nums.SubArray(nums.Length/2+nums.Length%2 == 1?1:0,nums.Length/2);
            Console.WriteLine("why");    // TODO
            foreach (var item in array)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine();
            TreeNode root =
                new TreeNode(nums[nums.Length / 2])
                {
                    left = CreateTree(nums.SubArray(0, nums.Length / 2)),    // [-10,-3]
                    right = CreateTree(nums.SubArray(nums.Length/2+nums.Length%2 == 1?1:0,nums.Length/2))// [5,9]
                };
            return root;
        }
    }

    public static class ArrayExtension
    {
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Console.WriteLine("Length is "+length);
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] arr = {-10,-3,0,5,9};
            solution.SortedArrayToBST2(arr);
        }
    }
}