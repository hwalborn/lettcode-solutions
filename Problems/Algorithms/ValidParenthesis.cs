using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class ValidParenthesis : ITest
    {
        public Dictionary<char, char> OpenClose => new Dictionary<char, char>
        {
            {')','('},
            {']','['},
            {'}','{'}
        };
        public bool Solve(string s)
        {
            var resultStack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var curr = s[i];
                if (!OpenClose.ContainsKey(curr))
                {
                    resultStack.Push(curr);
                } 
                else
                {
                    if (resultStack.Count == 0)
                    {
                        return false;
                    }
                    var previousOpen = resultStack.Pop();
                    if (previousOpen != OpenClose[curr])
                    {
                        return false;
                    }
                }
            }
            return resultStack.Count == 0;
        }
        public void Go()
        {
            // var correct = "()[]{}";
            // var huh = "([)]";
            // var bop = "((({[{}]})))";
            var boop = "(((({[{}]})))";
            Console.WriteLine(Solve(boop));
            Console.WriteLine(Solve("}"));
        }
    }
}
