using System;

namespace Problems.Algorithms
{
    public class HammingWeight : ITest
    {
        public int Solve(uint n)
        {
            var bitString = Convert.ToString(n, 2);
            var numOfOnes = 0;
            for (int i = 0; i < bitString.Length; i++)
            {
                if (bitString[i] == '1')
                {
                    numOfOnes += 1;
                }
            }
            return numOfOnes;
        }
        public void Go()
        {
            Console.WriteLine(Solve(3));
        }
    }
}