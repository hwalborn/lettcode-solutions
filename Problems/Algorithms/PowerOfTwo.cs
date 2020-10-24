using System;

namespace Problems.Algorithms
{
    public class PowerOfTwo : ITest
    {
        public bool Solve(int n)
        {
            if (n == 1)
            {
                return true;
            }
            var result = (double)n/2;
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
            Console.WriteLine(Solve(3));
        }
    }
}