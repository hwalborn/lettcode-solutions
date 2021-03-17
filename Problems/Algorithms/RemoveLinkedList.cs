using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class RemoveLinkedList : ITest
    {
        public ListNode Solve(ListNode head, int val)
        {
            var newList = BuildList(head, null, val);
            return newList;
        }

        public ListNode BuildList(ListNode node, ListNode previousNode, int val)
        {
            if (node == null)
            {
                return null;
            }
            if (previousNode == null && node.val == val)
            {
                return BuildList(node.next, null, val);
            }
            if (node.val == val)
            {
                return BuildList(node.next, previousNode, val);
            }
            else
            {
                node.next = BuildList(node.next, node, val);
                return node;
            }
        }


        public void Go()
        {
            var nodes = ListNode.BuildListNodes(new List<int> {1,2,6,3,4,5,6});
            var nodes2 = ListNode.BuildListNodes(new List<int> {1,2,2,1});
            var nodes3 = ListNode.BuildListNodes(new List<int> {6,6,6,7,2,1});
            Console.WriteLine(Solve(nodes, 6));
            Solve(nodes2, 2);
            Solve(nodes3, 6);
        }
    }
}
