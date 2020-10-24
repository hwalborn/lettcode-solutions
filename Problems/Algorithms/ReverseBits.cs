using System;

namespace Problems.Algorithms
{
    public class ReverseBits : ITest
    {
        public uint Solve(uint n)
        {
            var bitString = Convert.ToString(n, 2);
            if (bitString.Length < 32)
            {
                bitString = bitString.PadLeft(32, '0');
            }
            var boop = Convert.ToString((int)n, 2);
            var result = string.Empty;
            var i = bitString.Length - 1;
            while (i >= 0)
            {
                result += bitString[i];
                i -= 1;
            }
            var intResult = Convert.ToInt32(result, 2);
            return (uint)intResult;
        }

        public void Go()
        {
            Console.WriteLine(Solve(43261596));
        }
    }
}