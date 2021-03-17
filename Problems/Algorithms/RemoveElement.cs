using System;

namespace Problems.Algorithms
{
    public class RemoveElement : ITest
    {
        public int Solve(int[] nums, int val)
        {
            var numDups = 0;
            var tempArray = -1;
            for (int i = 0, j = nums.Length; i < j; i++)
            {
                var curr = nums[i];
                if (curr == val)
                {
                    tempArray = tempArray >= 0 ? tempArray : i;
                    numDups += 1;
                }
                else if (tempArray >= 0)
                {
                    nums[tempArray] = curr; 
                    tempArray += 1;
                }
            }
            return nums.Length - numDups;
        }
        public void Go()
        {
            // Console.WriteLine(Solve(new int[]{3,2,2,3}, 3));
            Console.WriteLine(Solve(new int[]{0,1,2,2,3,0,4,2}, 2));
        }
    }
}
