using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Algorithms
{
    public class MinStackReal
    {
        public List<int> stack { get; set; }
        public List<int> minValuesIndexes { get; set; }

        public MinStackReal()
        {
            stack = new List<int>();
            minValuesIndexes = new List<int>();
        }
    
        public void Push(int val) {
            if(!minValuesIndexes.Any() || val < stack[minValuesIndexes.First()])
            {
                minValuesIndexes.Insert(0, stack.Count);
            }
            stack.Add(val);
        }
        
        public void Pop() {
            if (stack.Any())
            {
                stack.RemoveAt(stack.Count - 1);
            }
            while(minValuesIndexes.Any() && stack.Count <= minValuesIndexes.First())
            {
                minValuesIndexes.RemoveAt(0);
            }
        }
        
        public int? Top() {
            if (stack.Any())
            {
                return stack.Last();
            }
            return null;
        }
        
        public int? GetMin() {
            if (minValuesIndexes.Any())
            {
                return stack[minValuesIndexes.First()];
            }
            return null;
        }
    }
    public class MinStack : ITest
    {
        public void Go()
        {
            var minStack = new MinStackReal();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Console.WriteLine(minStack.GetMin()); // return -)3
            minStack.Pop();
            Console.WriteLine(minStack.Top());    // return )0
            Console.WriteLine(minStack.GetMin()); // return -)2
            Console.WriteLine("YOU GOTTA IMPLEMENT THE GO METHOD, HOLT!");
        }
    }
}