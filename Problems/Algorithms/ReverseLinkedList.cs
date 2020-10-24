using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class ReverseLinkedList : ITest
    {
        public ListNode Solve(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            var newHead = Reverse(head, null);
            return newHead;
        }

        public ListNode Reverse(ListNode node,ListNode? previousNode)
        {
            var tempNode = node.next;
            if (node.next == null)
            {
                node.next = previousNode;
                return node;
            }
            node.next = previousNode;
            return Reverse(tempNode, node);
        }

        public void Go()
        {
            var nodes = ListNode.BuildListNodes(new List<int>{1,2,3,4,5});
            Console.WriteLine(Solve(nodes));
        }
    }
}