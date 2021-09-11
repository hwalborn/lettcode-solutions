using System;

namespace Problems.Algorithms
{
    public class PathSum : ITest
    {
        private TreeNode node
        {
            get
            {
                return new TreeNode
                (
                    5,
                    new TreeNode
                    (
                        4,
                        new TreeNode
                        (
                            11,
                            new TreeNode(7),
                            new TreeNode(2)
                        )
                    ),
                    new TreeNode
                    (
                        8,
                        new TreeNode(13),
                        new TreeNode(4, null, new TreeNode(1))
                    )
                );
            }
        }

        private TreeNode node2
        {
            get
            {
                return new TreeNode(1, new TreeNode(2), new TreeNode(3));
            }
        }

        private bool Search(TreeNode root, int count, int targetCount)
        {
            count += root?.val ?? 0;
            if (root == null)
            {
                return false;
            }
            else if (count == targetCount && root.left == null && root.right == null)
            {
                return true;
            }
            else
            {
                var left = Search(root.left, count, targetCount);
                var right = Search(root.right, count, targetCount);
                return left ? left : right;
            }
        }

        public void Go()
        {
            var result = Search(node, 0, 22);
            Console.WriteLine(result);
            Console.WriteLine(Search(node2, 0, 5));
        }
    }
}