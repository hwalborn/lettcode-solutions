using System;

namespace Problems.Algorithms
{
    public class ClimbStairs : ITest
    {
        private int Solve(int n)
        {
            int prevOptions = 0;
            var currOptions = 1;
            while (n > 0)
            {
                var huh = currOptions + prevOptions;
                prevOptions = currOptions;
                currOptions = huh;
                n--;
            }
            return currOptions;
        }

        public void Go()
        {
            Console.WriteLine(Solve(5));
        }
    }
}
