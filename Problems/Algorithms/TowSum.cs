using System;

namespace Problems.Algorithms
{
    public class TwoSum : ITest
    {
        public int[] Solve(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++) 
            {
                for (var j = 0; j < nums.Length; j++) 
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] {i, j};
                    }
                }
            }
            return new int[0];
        }
        public void Go()
        {
            Console.WriteLine(Solve(new int[] {3,2,4}, 6));
        }
    }
}