using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class BinaryTreePreorderTraversal : ITest
    {
        private TreeNode treeOne
        {
            get
            {
                return new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
            }
        }
        private void BuildPreorder(TreeNode root, ref List<int> collection)
        {
            if (root == null)
            {
                return;
            }
            collection.Add(root.val);
            BuildPreorder(root.left, ref collection);
            BuildPreorder(root.right, ref collection);
        }
        public void Go()
        {
            var results = new List<int>();
            BuildPreorder(treeOne, ref results);
            var huh = 1234;
        }
    }
}