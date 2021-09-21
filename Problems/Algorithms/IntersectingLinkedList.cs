using System;

namespace Problems.Algorithms
{
    public class IntersectingLinkedList : ITest
    {
        private ListNode? RunningCheck(ListNode nodeA, ListNode nodeB)
        {
            if (nodeA == nodeB)
            {
                return nodeA;
            }
            if (nodeB.next == null)
            {
                return null;
            }
            return RunningCheck(nodeA, nodeB.next);
        }
        
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
            if (headA == null)
            {
                return null;
            }
            var runningCheck = RunningCheck(headA, headB);
            if (runningCheck != null)
            {
                return headA;
            }
            return GetIntersectionNode(headA.next, headB);
        }

        public void Go()
        {
            Console.WriteLine("YOU GOTTA IMPLEMENT THE GO METHOD, HOLT!");
        }
    }
}