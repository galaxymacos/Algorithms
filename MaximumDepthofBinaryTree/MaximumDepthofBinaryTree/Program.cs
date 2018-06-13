using System;

namespace MaximumDepthofBinaryTree
{
    
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
 
    public class Solution
    {
        private int _maxLength;
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            FindMaxDepth(root, 1);
            return _maxLength;
        }

        private void FindMaxDepth(TreeNode root, int maxDepth)
        {
            if (maxDepth > _maxLength)
                _maxLength = maxDepth;
            if(root.left!=null)
                FindMaxDepth(root.left,maxDepth+1);
            if(root.right!=null)
                FindMaxDepth(root.right,maxDepth+1);
        }
    }

    public class OneLineSolution
    {
        public int MaxDepth(TreeNode root)
        {
            return root == null ? 0 : Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}