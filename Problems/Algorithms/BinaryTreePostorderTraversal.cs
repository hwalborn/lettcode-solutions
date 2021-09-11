using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class BinaryTreePostorderTraversal : ITest
    {
        private void GetPostorder(TreeNode root, ref List<int> collection)
        {
            if (root == null)
            {
                return;
            }
            collection.Insert(0, root.val);
            GetPostorder(root.left, ref collection);
            GetPostorder(root.right, ref collection);
        }

        public void Go()
        {
            
        }
    }
}