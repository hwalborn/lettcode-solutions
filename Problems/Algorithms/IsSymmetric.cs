using System;

namespace Problems.Algorithms
{
    public class IsSymmetric : ITest
    {
        public bool Solve(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return IsSameTree(root.left, root.right);
        }
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            else if (p == null || q == null)
            {
                return false;
            }
            if (p.val == q.val)
            {
                return IsSameTree(p.left, q.right) && IsSameTree(p.right, q.left);
            }
            return false;
        }

        public void Go()
        {
            var testTree1 = new TreeNode { val = 1, left = Tree1, right = Tree1 };
            var testTree2 = new TreeNode { val = 1, left = Tree1, right = Tree2 };
            Console.WriteLine(Solve(testTree1));
            Console.WriteLine(Solve(testTree2));
        }

        public TreeNode Tree1 => new TreeNode
        {
            val = 1,
            left = new TreeNode
            {
                val = 2,
                right = new TreeNode
                {
                    val = 4
                },
                left = new TreeNode
                {
                    val = 3
                }
            },
            right = new TreeNode
            {
                val = 2,
                left = new TreeNode
                {
                    val = 4
                },
                right = new TreeNode
                {
                    val = 3
                }
            }
        };

        public TreeNode Tree2 => new TreeNode
        {
            val = 1,
            left = new TreeNode
            {
                val = 1
            },
            right = new TreeNode
            {
                val = 2,
                left = new TreeNode
                {
                    val = 3
                }
            }
        };
    }
}
