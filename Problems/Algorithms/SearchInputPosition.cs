using System;

namespace Problems.Algorithms
{
    public class SearchInputPosition : ITest
    {
        public int Solve(int[] nums, int target)
        {
            var huh = FindIndex(nums, target, 0, nums.Length - 1);
            var index = Array.BinarySearch(nums, target);
            if (index < 0) {
                index = (index * -1) - 1;
            }
            return index;
        }

        public int FindIndex(int[] nums, int target, int min, int max)
        {
            // Doesn't work every time.
            int mid = (min+max)/2;  
            if (min > max)  
            {
                return mid == 0 ? mid : ++mid;  
            }

            if (target == nums[mid])  
            {
                return mid;  
            }
            else if (target < nums [mid])  
            {
                return FindIndex(nums, target, min, mid - 1);  
            }
            else  
            {
                return FindIndex(nums, target, mid + 1, max);  
            }
        }

        public void Go()
        {
            var test1 = new int[] {1,3,5,6};
            var test2 = new int[] {1,3};
            var test3 = new int[] {5,7};
            Console.WriteLine(Solve(test1, 3));
            Console.WriteLine(Solve(test1, 5));
            Console.WriteLine(Solve(test1, 2));
            Console.WriteLine(Solve(test1, 7));
            Console.WriteLine(Solve(test1, 0));
            Console.WriteLine(Solve(test2, 0));
            Console.WriteLine(Solve(test3, 8));
            // Console.WriteLine(Solve(test1, 4));
        }
    }
}
