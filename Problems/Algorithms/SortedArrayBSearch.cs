using System;
using System.Linq;

namespace Problems.Algorithms
{
    public class SortedArrayBSearch : ITest
    {
        private int[] SortedArr => new int[] { -10,-3,0,5,9 };

        private TreeNode Solve(int[] nums) {
            var arrLength = nums.Length;
            if (arrLength <= 0) {
                return null;
            }
            var midPoint = (int) Math.Floor((decimal)(arrLength / 2));
            var node = new TreeNode(nums[midPoint]);
            var leftArr = nums.Skip(0).Take(midPoint).ToArray();
            var rightArr = nums.Skip(midPoint + 1).ToArray();
            node.left = Solve(leftArr);
            node.right = Solve(rightArr);
            return node;
        }

        public void Go()
        {
            var result = Solve(SortedArr);
            Console.WriteLine(result);
        }
    }
}