using System;

namespace LongUnivaluePath
{
    public class TreeNode
    {
        public readonly int Val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            Val = x;
        }
    }
    
    public class FsSolution
    {
        public static int LongestUnivaluePath(TreeNode root)
        {
            int[] res = new int[1];
            if (root != null) dfs(root, res);
            return res[0];
        }

        private static int dfs(TreeNode root, int[] res)
        {
            int l = root.left != null ? dfs(root.left, res) : 0;
            int r = root.right != null ? dfs(root.right, res) : 0;
            int lrest = root.left!= null && root.left.Val == root.Val ? l + 1 : 0;
            int rrest = root.right != null && root.right.Val == root.Val ? r + 1 : 0;
            res[0] = Math.Max(res[0], lrest + rrest);
            return Math.Max(lrest, rrest);
        }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}