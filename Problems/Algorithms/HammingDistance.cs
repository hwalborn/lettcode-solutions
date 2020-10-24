using System;

namespace Problems.Algorithms
{
    public class HammingDistance : ITest
    {
        public int Solve(int x, int y)
        {
            var bitStringX = Convert.ToString(x, 2);
            var bitStringY = Convert.ToString(y, 2);
            // bitStringX = bitStringX.PadLeft(bitStringY.Length, '0');
            // bitStringY = bitStringY.PadLeft(bitStringX.Length, '0');
            var i = bitStringX.Length - 1;
            var j = bitStringY.Length - 1;
            var result = 0;
            while (i >= 0 && j >= 0)
            {
                if (bitStringX[i] != bitStringY[j])
                {
                    result += 1;
                }
                i -= 1;
                j -= 1;
            }
            return result;
        }

        public void Go()
        {
            Console.WriteLine(Solve(4234,1123));
        }
    }
}