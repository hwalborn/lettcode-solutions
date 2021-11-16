using System.Collections.Generic;
using System.Linq;

namespace Problems.Algorithms
{
    public class ThreeSum : ITest
    {
        public Dictionary<int, List<int>> UsedValues { get; set; }
        public List<IList<int>> ThreeSumList { get; set; }

        private void Solution(int[] nums)
        {
            ThreeSumList = new List<IList<int>>();
            UsedValues = new Dictionary<int, List<int>>();
            var numsList = nums.ToList();
            numsList.Sort();
            for (int i = 0; i < numsList.Count; i++)
            {
                CalculateTwoSum(i, numsList);
            }
        }

        private void CalculateTwoSum(int currentIndex, List<int> nums)
        {
            var i = currentIndex + 1;
            var j = nums.Count - 1;
            var currentVal = nums[currentIndex];
            while(i < j)
            {
                var front = nums[i];
                var back = nums[j];
                var sum = currentVal + front + back;
                if (sum < 0)
                {
                    i++;
                }
                else if (sum > 0)
                {
                    j--;
                }
                else
                {
                    if (UsedValues.ContainsKey(currentVal) && UsedValues[currentVal].Contains(front) && UsedValues[currentVal].Contains(back))
                    {
                        i++;
                        continue;
                    }
                    if (!UsedValues.ContainsKey(currentVal))
                    {
                        UsedValues[currentVal] = new List<int>();
                    }
                    UsedValues[currentVal].AddRange(new List<int> { front, back });
                    ThreeSumList.Add(new List<int> { currentVal, front, back });
                    i++;
                }
            }
        }

        public void Go()
        {
            // -4, -1, -1, 0, 1, 2
            // Solution(new int[] { -1,0,1,2,-1,-4 });
            Solution(new int[] { -1,0,1,2,-1,-4,-2,-3,3,0,4 });
            // var huh = 123;
        }
    }
}