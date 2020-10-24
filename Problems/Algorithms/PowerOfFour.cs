using System;

namespace Problems.Algorithms
{
    public class PowerOfFour : ITest
    {
        public bool Solve(int num)
        {
            if (num == 1)
            {
                return true;
            }
            var result = (double)num/4;
            if (result % 1 > 0 || num == 0)
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
            Console.WriteLine(Solve(5));
        }
    }
}