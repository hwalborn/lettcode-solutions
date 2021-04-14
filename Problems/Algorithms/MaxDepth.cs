using System;

namespace Problems.Algorithms
{
    public class MaxDepth : ITest
    {
        public int Solve(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return FindMax(root.left, root.right);
        }

        public int FindMax(TreeNode left, TreeNode right, int count = 1)
        {
            if (left == null && right == null)
            {
                return count;
            }
            count++;
            var countLeft = FindMax(left?.left, left?.right, count);
            var countRight = FindMax(right?.left, right?.right, count);
            return countLeft > countRight ? countLeft : countRight;
        }

        public void Go()
        {
            Console.WriteLine(Solve(Tree1));
        }

        public TreeNode Tree1 => new TreeNode 
        {
            val = 3,
            left = new TreeNode
            {
                val = 9
            },
            right = new TreeNode
            {
                val = 20,
                left = new TreeNode
                {
                    val = 15
                },
                right = new TreeNode
                {
                    val = 7
                }
            }
        };
    }
}
