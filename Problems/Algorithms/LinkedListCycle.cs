using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class LinkedListCycle : ITest
    {
        private ListNode node
        {
            get
            {
                var nodeNumberTwo = new ListNode(2);
                return new ListNode
                (
                    1, nodeNumberTwo
                );
            }
        }
        
        private bool Solution(ListNode head, List<int> values)
        {
            
            var hashRef = head.GetHashCode();
            if (values.Contains(hashRef))
            {
                return true;
            }
            else if (head.next == null)
            {
                return false;
            }
            values.Add(hashRef);
            return Solution(head.next, values);
        }
        public void Go()
        {

            Console.WriteLine(Solution(node, new List<int>()));
        }
    }
}