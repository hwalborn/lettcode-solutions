using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Algorithms
{
    public class SingleNumber : ITest
    {
        private int Solution(int[] nums)
        {
            var resultsDictionary = new Dictionary<int, int?>();
            foreach (var num in nums)
            {
                if (resultsDictionary.ContainsKey(num))
                {
                    resultsDictionary.Remove(num);
                }
                else
                {
                    resultsDictionary.Add(num, null);
                }
            }
            return resultsDictionary.Keys.First();
        }
        public void Go()
        {
            Console.WriteLine(Solution(new int[] { 2,2,1 }));
            Console.WriteLine(Solution(new int[] { 1 }));
            Console.WriteLine(Solution(new int[] { 4,1,2,1,2 }));
        }
    }
}