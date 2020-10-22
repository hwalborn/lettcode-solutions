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
            var node1 = BuildNodes(new List<int> {2,4,9});

            var node2 = BuildNodes(new List<int> {5,6,4, 9});

            Solve(node1, node2);
        }
        
        public ListNode BuildNodes(List<int> list)
        {
            var head = new ListNode(list[0]);
            ListNode node = null;
            for (int i = 1; i < list.Count; i++)
            {
                var nextNode = new ListNode(list[i]);
                if (node == null)
                {
                    head.next = nextNode;
                }
                else
                {
                    node.next = nextNode;
                }
                node = nextNode;
            }
            return head;
        }
    }

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
}