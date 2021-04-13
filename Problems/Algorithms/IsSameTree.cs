using System;

namespace Problems.Algorithms
{
    public class IsSameTree : ITest
    {
        public bool Solve(TreeNode p, TreeNode q)
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
                return Solve(p.left, q.left) && Solve(p.right, q.right);
            }
            return false;
        }
        public void Go()
        {
            Console.WriteLine(Solve(Tree3, Tree1));
            // Console.WriteLine(Solve(Tree1, Tree2));
            // Console.WriteLine(Solve(Tree1, TreeNull));
        }

        public TreeNode Tree1 => new TreeNode 
        {
            val = 1,
            left = new TreeNode
            {
                val = 2
            },
            right = new TreeNode
            {
                val = 3
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
                val = 2
            }
        };

        public TreeNode TreeNull = new TreeNode
        {
            val = 1,
            left = new TreeNode
            {
                val = 2
            }
        };

        public TreeNode Tree3 => new TreeNode
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
                },
                right = new TreeNode
                {
                    val = 5
                }
            }
        };
    }
}
