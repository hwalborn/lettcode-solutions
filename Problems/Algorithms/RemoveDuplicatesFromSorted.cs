using System;
using System.Linq;

namespace Problems.Algorithms
{
    public class RemoveDuplicatesFromSorted : ITest
    {
        public int Solve(int[] nums)
        {
            var result = 0;
            var tempIndex = -1;
            for (int i = 1; i < nums.Length; i++)
            {
                var curr = nums[i];
                if (curr == nums[i - 1])
                {
                    result += 1;
                    tempIndex = tempIndex < 0 ? i : tempIndex;
                }
                else if (tempIndex >= 0)
                {
                    nums[tempIndex] = curr;
                    tempIndex += 1;
                }
            }
            return nums.Length - result;
        }

        public void Go()
        {
            // input = [0,0,1,1,1,2,2,3,3,4]
            // [0,1,2,3,4,4,4,5,6,7,8,8]
            // output = 5, array should be [0,1,2,3,4]
            Console.WriteLine(Solve(new int[] { 0,0,1,1,1,2,2,3,3,4} ));
            Console.WriteLine(Solve(new int[] { 0,1,2,3,4,4,4,5,6,7,8,8} ));
            Console.WriteLine(Solve(new int[] { -15,-15,-5,-5,-5,-5,6,7,8,8} ));
            Console.WriteLine(Solve(new int[0] {}));
        }
    }
}
