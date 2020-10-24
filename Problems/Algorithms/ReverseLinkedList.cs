using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class ReverseLinkedList : ITest
    {
        public ListNode Solve(ListNode head)
        {
            var newHead = Reverse(head, null);
            return newHead;
        }

        public ListNode Reverse(ListNode node,ListNode? previousNode)
        {
            if (node.next == null)
            {
                node.next = previousNode;
                return node;
            }
            if (previousNode != null)
            {
                previousNode.next = node;
            }
            return Reverse(node.next, node);
        }

        public void Go()
        {
            var nodes = ListNode.BuildListNodes(new List<int>{1,2,3,4,5});
            Console.WriteLine(Solve(nodes));
        }
    }
}