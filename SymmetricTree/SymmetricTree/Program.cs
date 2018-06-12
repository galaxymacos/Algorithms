using System;
using System.Collections.Generic;
using System.Linq;

namespace SymmetricTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            if (root.left == null && root.right == null)
                return true;
            var leftTree = root.left;
            var rightTree = root.right;
            if (leftTree == null && rightTree != null)
                return false;
            if (leftTree != null && rightTree == null)
                return false;

            List<int> leftList = DfsInOrder(leftTree);
            List<int> rightList = DfsInReverseOrder(rightTree);
            foreach (var element in leftList)
            {
                Console.Write(element);
            }

            Console.WriteLine();
            foreach (var i in rightList)
            {
                Console.Write(i);
            }
            
            if (leftList.Count != rightList.Count)
                return false;
            return !leftList.Where((t, i) => t != rightList[i]).Any();
        }

        private List<int> DfsInOrder(TreeNode treeNode)
        {
            List<int> list = new List<int>();
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();
            treeNodes.Enqueue(treeNode);
            while (treeNodes.Count != 0)
            {
                TreeNode currentNode = treeNodes.Dequeue();
                if(currentNode != null)
                list.Add(currentNode.val);
                else
                {
                    list.Add(0);
                    continue;
                }
                treeNodes.Enqueue(currentNode.left);
                treeNodes.Enqueue(currentNode.right);
            }

            return list;
        }
        
        private List<int> DfsInReverseOrder(TreeNode treeNode)
        {
            List<int> list = new List<int>();
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();
            treeNodes.Enqueue(treeNode);
            while (treeNodes.Count != 0)
            {
                TreeNode currentNode = treeNodes.Dequeue();
                if(currentNode != null)
                list.Add(currentNode.val);
                else
                {
                    list.Add(0);
                    continue;
                }
                treeNodes.Enqueue(currentNode.right);
                treeNodes.Enqueue(currentNode.left);
            }

            return list;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            TreeNode head = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(2)
            };
            head.left.left = new TreeNode(3);
            head.left.right = new TreeNode(4);
            head.right.left = new TreeNode(4);
            head.right.right = new TreeNode(3);
            Solution solution = new Solution();
            Console.WriteLine(solution.IsSymmetric(head));
            
        }
    }
}