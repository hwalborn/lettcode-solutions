using System;

namespace Problems.Algorithms
{
    public class MySqrt : ITest
    {
        public int Solve(int x)
        {
            return (int)Math.Floor(Math.Sqrt(x));
        }

        public void Go()
        {
            Console.WriteLine(Solve(4));
            Console.WriteLine(Solve(8));
        }
    }
}
