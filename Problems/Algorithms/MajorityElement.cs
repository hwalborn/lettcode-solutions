using System;
using System.Linq;

namespace Problems.Algorithms
{
    public class MajorityElement : ITest
    {
        private int Solution(int[] nums)
        {
            var groupedNums = nums
            .GroupBy(num => num, (key, num) => new { num = key, count = num.Count() })
            .OrderByDescending(num => num.count);
            return groupedNums.FirstOrDefault().num;
        }

        public void Go()
        {
            Console.WriteLine(Solution(new int[] { 2,2,1,1,1,2,2 }));
            Console.WriteLine(Solution(new int[] { 3,2,3 }));
            Console.WriteLine(Solution(new int[] { 5, 5, 1, 1, 2, 1, 1, 10 }));
        }
    }
}