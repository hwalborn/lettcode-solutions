using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class BTreeInorderTrav : ITest
    {
        private ListNode Examples => ListNode.BuildListNodes(new List<int>{1,2,3});
        private TreeNode Nodes
        {
            get
            {
                var rightNode = new TreeNode(2, new TreeNode(3));
                return new TreeNode(1, null, rightNode);
            }
        }
        private TreeNode Nodes2
        {
            get
            {
                var leftNode = new TreeNode(1);
                return new TreeNode(3, leftNode, new TreeNode(2));
            }
        }

        public List<int> Solve(TreeNode node, List<int> list)
        {
            var currList = list;
            if(node == null)
            {
                return currList;
            } else if (node.left == null && node.right != null) {
                currList.Add(node.val);
                currList = Solve(node.right, currList);
            } else if (node.left == null && node.right == null) {
                currList.Add(node.val);
            } else {
                currList = Solve(node.left, currList);
                currList.Add(node.val);
                currList = Solve(node.right, currList);
            }
            return currList;
        }

        public void Go()
        {
            var result = Solve(Nodes, new List<int>());
            Console.WriteLine();
        }
    }
}