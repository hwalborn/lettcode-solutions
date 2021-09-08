using System;
using System.Collections;

namespace Problems.Algorithms
{
    public class MinimumDepthBTree : ITest
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
                return new TreeNode(2,
                    null,
                    new TreeNode(3,
                        null,
                        new TreeNode(4,
                            null,
                            new TreeNode(5,
                                null,
                                new TreeNode(6)
                            )
                        )
                    )
                );
            }
        }

        private TreeNode BTreeThree
        {
            get
            {
                return new TreeNode(1,
                    new TreeNode(2, new TreeNode(4), new TreeNode(5)),
                    new TreeNode(3)
                );
            }
        }

        private int depth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Min(depth(root.left), depth(root.right)) + 1;
        }

        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var queue = new Queue();
            queue.Enqueue(root);

            var count = 1;

            while(queue.Count != 0)
            {
                var temp = (TreeNode) queue.Dequeue();
                if (temp.left == null && temp.right == null && count > 1)
                {
                    return count;
                }
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
                count++;
            }

            return 1;
        }

        public void Go()
        {
            // Console.WriteLine(MinDepth(BTree));
            // Console.WriteLine(MinDepth(BTreeTwo));
            Console.WriteLine(MinDepth(BTreeThree));
        }
    }
}