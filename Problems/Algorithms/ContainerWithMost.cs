using System;

namespace Problems.Algorithms
{
    public class ContainerWithMost : ITest
    {
        private int Solution(int[] height)
        {
            var i = 0;
            var j = height.Length - 1;
            int mostContainer = 0;
            while (i < j)
            {
                var currentVolume = (j - i) * Math.Min(height[j], height[i]);
                mostContainer = Math.Max(mostContainer, currentVolume);
                if (height[j] > height[i])
                {
                    i++;
                }
                else 
                {
                    j--;
                }
            }
            return mostContainer;
        }
        private int Solution2(int[] height)
        {
            int? mostContainer = null;
            // int? nextHeighestIndex = null;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    var heightToMultiply = height[i] > height[j] ? height[j] : height[i];
                    var multiplier = j - i;
                    if (mostContainer == null || multiplier * heightToMultiply > mostContainer)
                    {
                        mostContainer = multiplier * heightToMultiply;
                    }
                }
            }

            return mostContainer ?? 0;
        }
        public void Go()
        {
            Console.WriteLine(Solution(new int[] {1,8,6,2,5,4,8,3,7}));
            Console.WriteLine(Solution(new int[] {1,1}));
            Console.WriteLine(Solution(new int[] {4,3,2,1,4}));
            Console.WriteLine(Solution(new int[] {1,2,1}));
            Console.WriteLine(Solution(new int[] {1,2,4,3}));
        }
    }
}