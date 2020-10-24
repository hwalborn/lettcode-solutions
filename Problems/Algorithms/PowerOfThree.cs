using System;

namespace Problems.Algorithms
{
    public class PowerOfThree : ITest
    {
        public bool Solve(int n)
        {
            if (n == 1)
            {
                return true;
            }
            var result = (double)n/3;
            if (result % 1 > 0 || n == 0)
            {
                return false;
            }
            else
            {
                return Solve((int)result);
            }
        }


        public void Go()
        {
            Console.WriteLine(Solve(45));
        }
    }
}