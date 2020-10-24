// this is an easy

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Algorithms
{
    public class PalindromeNumber : ITest
    {
        public bool Solve(int x)
        {
            if (x < 0)
            {
                return false;
            }
            var temp = x;
            var numArray = new List<int>();
            while (x > 0)
            {
                numArray.Add(x % 10);
                x /= 10;
            }
            while (numArray.Count > 1)
            {
                if (numArray.First() != numArray.Last())
                {
                    return false;
                }
                numArray.RemoveAt(0);
                numArray.RemoveAt(numArray.Count - 1);
            }
            return true;
        }
        public void Go()
        {
            Console.WriteLine(Solve(-1234));
        }
    }
}
