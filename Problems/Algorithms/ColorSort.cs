using System;

namespace Problems.Algorithms
{
    public class ColorSort : ITest
    {
        void Sort(int[] nums, int l, int r)
        {
            if (l < r)
            {
                // find the middle point
                var m = l+ (r-l)/2;
                
                // sort first and second halves
                Sort(nums, l, m);
                Sort(nums, m + 1, r);

                Merge(nums, l, m, r);
            }
        }
        
        void Merge(int[] nums, int l, int m, int r)
        {
            // Lets find some sizes, huh?
            var n1 = m - l + 1;
            var n2 = r - m;
            
            var L = new int[n1];
            var R = new int[n2];
            int i,j;
            
            // fill these arrays with the nums
            for (i = 0; i < n1; ++i)
                L[i] = nums[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = nums[m + 1 + j];
            
            // Initial indexes to 0
            i = 0;
            j = 0;
            
            var k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    nums[k] = L[i];
                    i++;
                }
                else
                {
                    nums[k] = R[j];
                    j++;
                }
                k++;
            }
            
            while (i < n1)
            {
                nums[k] = L[i];
                i++;
                k++;
            }
            
            while (j < n2)
            {
                nums[k] = R[j];
                j++;
                k++;
            }
        }
        public void Go()
        {
            var nums = new int[] { 2,0,2,1,1,0 };
            Sort(nums, 0, nums.Length - 1);
            Console.WriteLine(String.Join(',', nums));
        }
    }
}