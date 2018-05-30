namespace SameTree
{
    public class SimplerRecursion
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null || q == null) return p == q;
            return p.Val == q.Val && IsSameTree(p.left, p.right) && IsSameTree(q.left, q.right);
        }
    }
}