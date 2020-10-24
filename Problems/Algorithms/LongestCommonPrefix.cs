using System;
using System.Linq;

namespace Problems.Algorithms
{
    public class LongestCommonPrefix : ITest
    {
        public string Solve(string[] strs)
        {
            var longestCommonPrefix = strs.FirstOrDefault() ?? string.Empty;
            for (int i = 1; i < strs.Length; i++)
            {
                var curr = strs[i];
                // Substring? just continue
                if (curr.StartsWith(longestCommonPrefix))
                {
                    continue;
                }
                GetSubstring(ref longestCommonPrefix, curr);
            }
            return longestCommonPrefix;
        }

        public void GetSubstring(ref string x, string y)
        {
            for (int j = 0; j < x.Length; j++)
            {
                if (y.Length - 1 < j)
                {
                    x = y;
                    return;
                }
                if (x[j] != y[j])
                {
                    x = x.Substring(0, j);
                    return;
                }
            }
            x = string.Empty;
        }

        public void Go()
        {
            Console.WriteLine(Solve(new string[] {}));
        }
    }
}