using System.Collections.Generic;
using System.Linq;

namespace Problems.Algorithms
{
    public class AddTwoNumbers : ITest
    {
        public ListNode Solve(ListNode l1, ListNode l2)
        {
            var result = BuildSolution(l1, l2, 0);
            return result;
        }

        public ListNode BuildSolution(ListNode? nodeOne, ListNode? nodeTwo, int remainder)
        {
            if (nodeOne == null && nodeTwo == null && remainder <= 0)
            {
                return null;
            }
            var value = (nodeOne?.val ?? 0) + (nodeTwo?.val ?? 0) + (remainder);
            var newNodeValue = value % 10;
            if (newNodeValue != value)
            {
                remainder = 1;
            }
            else
            {
                remainder = 0;
            }
            var newNode = new ListNode(newNodeValue);
            newNode.next = BuildSolution(nodeOne?.next, nodeTwo?.next, remainder);
            return newNode;
        }


        public void Go()
        {
            var node1 = ListNode.BuildListNodes(new List<int> {2,4,9});

            var node2 = ListNode.BuildListNodes(new List<int> {5,6,4, 9});

            Solve(node1, node2);
        }
    }
}