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

        // find the max depth of the tree
        private int depth (TreeNode root)
        {
            if (root == null) {
                return 0;
            }
            return Math.Max(depth(root.left), depth(root.right)) + 1;
        }

        public void PrintLevels(TreeNode root)
        {
            var maxDepth = this.depth(root);
            Console.WriteLine(maxDepth);
            // var currentLevel = 1;
            for (int i = 1; i <= maxDepth; i++)
            {
                printCurrentLevel(root, i);
            }
        }


        public virtual void printCurrentLevel(TreeNode root, int level)
        {
            if (root == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.Write(root.val + " " + "at level " + level + " ");
            }
            else if (level > 1)
            {
                printCurrentLevel(root.left, level - 1);
                printCurrentLevel(root.right, level - 1);
            }
        }

        // public virtual int? getCurrentLevel(TreeNode root, int level)
        // {
        //     if (root == null)
        //     {
        //         return 1;
        //     }
        //     if (root.left == null && root.right == null)
        //     {
        //         return level;
        //     }
        //     else if (level > 1)
        //     {
        //         getCurrentLevel(root.left, level - 1);
        //         getCurrentLevel(root.right, level - 1);
        //     }
        // }

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
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var temp = (TreeNode) queue.Dequeue();
                    if (temp.left == null && temp.right == null && count >= 1)
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
                }
                count++;
            }
            return count;
        }

        public void Go()
        {
            Console.WriteLine(MinDepth(BTree));
            Console.WriteLine(MinDepth(BTreeTwo));
            Console.WriteLine(MinDepth(BTreeThree));
            // PrintLevels(BTreeThree);
        }
    }
}