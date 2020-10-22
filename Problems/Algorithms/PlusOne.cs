using System;
using System.Linq;

namespace Problems.Algorithms
{
    public class PlusOne : ITest
    {
        public int[] Solve(int[] digits)
        {
            var digitLength = digits.Length - 1;
            var remainder = 1;
            while (remainder > 0)
            {
                if (digitLength < 0)
                {
                    Array.Resize(ref digits, digits.Length + 1);
                    digits[0] = remainder;
                    return digits;
                }
                var result = digits[digitLength] + 1;
                remainder = result >= 10 ? 1 : 0;
                digits[digitLength] = result % 10;
                digitLength -= 1;
            }
            return digits;
        }

        public void Go()
        {
            Console.WriteLine(string.Join(',', Solve(new int[] {9, 9})));
        }
    }
}