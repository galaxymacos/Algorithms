using System;

namespace BalancedBinaryTree
{
    
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
 
    public class Solution {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            if (!IsSameLength(root)) return false;
            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        private bool IsSameLength(TreeNode root)
        {
            if (root == null)
                return true;
            int leftTreeDepth = FindTreeDepth(root.left);
            int rightTreeDepth = FindTreeDepth(root.right);
            if (Math.Abs(leftTreeDepth - rightTreeDepth) <= 1)
                return true;
            return false;
        }

        private int FindTreeDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            return Math.Max(FindTreeDepth(root.left), FindTreeDepth(root.right)) + 1;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
           
        }
    }
}