using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Algorithms
{
    public class MergeSortedArray : ITest
    {
        public void Solve(int[] nums1, int m, int[] nums2, int n)
        {
            var sundaySort = nums1.ToList().GetRange(0, m).Concat(nums2.ToList()).ToList();
            sundaySort.Sort();
            for (int i = 0; i < m + n; i++)
            {
                nums1[i] = sundaySort[i];
            }
        }

        public void Go()
        {
            var listOne = new int[] {1,2,3,0,0,0};
            var bah = new int[] {1,5,6,0,0,0};
            var goh = new int[] {2,3,4};
            var listTwo = new int[] {2,5,6};
            var boop = new int[] {1,2,3,4,0,0,0};
            var bop = new int [] {1,2,0,0,0};
            Solve(listOne, 3, listTwo, 3);
            Solve(boop, 4, listTwo, 3);
            Solve(bop, 2, listTwo, 3);
        }
    }
}
