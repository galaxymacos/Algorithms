namespace SameTree
{
    public class MyClass
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null)
                return q == null;
            if (q == null)
                return false;
            if (q.Val != p.Val)
                return false;
            bool isleftSameTree = IsSameTree(p.left, q.left);
            return isleftSameTree && IsSameTree(p.right, q.right);
        }
    }
}