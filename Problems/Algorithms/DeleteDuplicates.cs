using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class DeleteDuplicates : ITest
    {
        public ListNode Solve(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            Traverse(head);
            return head;
        }

        private void Traverse(ListNode node)
        {
            if (node.next != null && node.next.val == node.val)
            {
                node.next = GetNextNonRepeat(node.next);
            }
            if (node.next == null)
            {
                return;
            }
            Traverse(node.next);
        }

        private ListNode? GetNextNonRepeat(ListNode node)
        {
            if (node.next == null)
            {
                return null;
            }
            else if (node.next.val != node.val)
            {
                return node.next;
            }
            return GetNextNonRepeat(node.next);
        }

        public void Go()
        {
            var node1 = ListNode.BuildListNodes(new List<int> {1,1,2,3,3});
            Solve(node1);
        }
    }
}
