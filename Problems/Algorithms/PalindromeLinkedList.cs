using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Algorithms
{
    public class PalindromeLinkedList : ITest
    {
        public bool Solve(ListNode head)
        {
            var listVals = GetLinkedListValues(head, new List<int>());
            return RecursivePalindrome(listVals);
        }

        public bool RecursivePalindrome(List<int> list)
        {
            if (list.Count <= 1)
            {
                return true;
            }
            if (list.First() != list.Last())
            {
                return false;
            }
            list.RemoveAt(0);
            list.RemoveAt(list.Count -1);
            return RecursivePalindrome(list);
        }

        public List<int> GetLinkedListValues(ListNode? node, List<int> list)
        {
            if (node == null)
            {
                return list;
            }
            else
            {
                list.Add(node.val);
                return GetLinkedListValues(node.next, list);
            }
        }

        public void Go()
        {
            var listNode = ListNode.BuildListNodes(new List<int> {1,0,1});
            var badListNode = ListNode.BuildListNodes(new List<int> {2,6,4,6,4,3,6,2,8});
            var huh = ListNode.BuildListNodes(new List<int> {1,2,2,1});
            Console.WriteLine(Solve(listNode));
            Console.WriteLine(Solve(badListNode));
            Console.WriteLine(Solve(huh));
        }
    }
}