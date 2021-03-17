using System;

namespace Problems.Algorithms
{
    public class StrStr : ITest
    {
        public int Solve(string haystack, string needle)
        {
            if (needle == string.Empty)
            {
                return 0;
            }
            if (!haystack.Contains(needle))
            {
                return -1;
            }
            var i = 0;
            while (i < haystack.Length)
            {
                if (haystack.Substring(i).StartsWith(needle))
                {
                    return i;
                }
                i += 1;
            }
            return -1;
        }

        public void Go()
        {
            Console.WriteLine(Solve("aaaaa", "bba"));
        }
    }
}
