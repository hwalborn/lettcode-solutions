using System;

namespace Problems.Algorithms
{
    public class ReverseInteger : ITest
    {
        public int Solve(int x)
        {
            double result = 0;
            while (x != 0)
            {
                result = (result * 10) + (x % 10);
                x /= 10;
            }
            if (result > (Math.Pow(2,31) * -1) && (result < Math.Pow(2, 31) - 1))
            {
                return (int)result;
            }
            else
            {
                return 0;
            }
        }

        public void Go()
        {
            Console.WriteLine(Solve(-123));
        }
    }
}