using System.Collections.Generic;

namespace Problems
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }

        public static ListNode BuildListNodes(List<int> list)
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
}