using System;

namespace Problems.Algorithms
{
    public class BalancedBinaryTree : ITest
    {
        private TreeNode BTree 
        {
            get 
            {
                var leftNode = new TreeNode(9);
                var rightNode = new TreeNode(20, new TreeNode(15), new TreeNode(7));
                return new TreeNode(3, leftNode, rightNode);
            }
        }

        private TreeNode BTreeTwo
        {
            get
            {
                var node4 = new TreeNode(4);
                var leftThree = new TreeNode(3, node4, node4);
                var rightThree = new TreeNode(3);
                var leftTwo = new TreeNode(2, leftThree, rightThree);
                var rightTwo = new TreeNode(2);
                return new TreeNode(1, leftTwo, rightTwo);
            }
        }

        private TreeNode BTreeThree
        {
            get
            {
                var rightThree = new TreeNode(3);
                var rightTwo = new TreeNode(2, null, rightThree);
                return new TreeNode(1, null, rightTwo);
            }
        }

        // find the max depth of the tree
        private int depth (TreeNode root)
        {
            if (root == null) {
                return 0;
            }
            return Math.Max(depth(root.left), depth(root.right)) + 1;
        }

        public bool Solution(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            var left = depth(root.left);
            var right = depth(root.right);

            // check depth of both sides, then go down and do again
            return Math.Abs(left - right) <= 1 && Solution(root.left) && Solution(root.right);
        }

        public bool SolutionOld(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            var leftDepth = FindDepth(root.left, 0);
            var rightDepth = FindDepth(root.right, 0);
            if (leftDepth - rightDepth <= 1 && leftDepth - rightDepth >= -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // nearly what I was doing!
        private int FindDepth(TreeNode node, int count)
        {
            if (node == null)
            {
                return count;
            }
            count++;
            var leftDepth = FindDepth(node.left, count);
            var rightDepth = FindDepth(node.right, count);

            if (leftDepth > rightDepth)
            {
                return leftDepth;
            }
            else
            {
                return rightDepth;
            }
        }

        public void Go()
        {
            Console.WriteLine(Solution(BTree));
            Console.WriteLine(Solution(null));
            Console.WriteLine(Solution(BTreeTwo));
            Console.WriteLine(Solution(BTreeThree));
        }
    }
}