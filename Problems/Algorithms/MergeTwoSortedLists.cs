using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class MergeTwoSortedLists : ITest
    {
        public ListNode Solve(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return  null;
            }

            var nextNode = new ListNode();
            if (l2 != null && (l1 == null || l1.val > l2.val))
            {
                nextNode.val = l2.val;
                nextNode.next = Solve(l1, l2.next);
            }
            else
            {
                nextNode.val = l1.val;
                nextNode.next = Solve(l1.next, l2);
            }
            return nextNode;
        }
        public void Go()
        {
            var l1 = ListNode.BuildListNodes(new List<int>{1,2,4});
            var l2 = ListNode.BuildListNodes(new List<int>{-23,3,4});
            var merged1 = Solve(l1, l2);
            var merge2 = Solve(l1, null);
            var merge3 = Solve(null, l2);
            var merge4 = Solve(l2, l1);
            Console.WriteLine(merged1);
        }
    }
}
