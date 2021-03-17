using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class LengthOfLongestSubstring : ITest
    {
        public int Solve(string s)
        {
            var longestString = string.Empty;
            for (int i = 0, j = s.Length; i < j; i++)
            {
                var k = i + 1;
                var newString = s[i].ToString();
                while(k < s.Length && !newString.Contains(s[k]))
                {
                    newString += s[k];
                    k += 1;
                }
                i = k - 1;
                if (newString.Length > longestString.Length)
                {
                    longestString = newString;
                }
            }
            return longestString.Length;
        }

        public void Go()
        {
            // "abcabcbb" -> 3... ("abc")
            // Console.WriteLine(Solve("abcabcbb"));
            // Console.WriteLine(Solve("bbbbb"));
            // Console.WriteLine(Solve("pwwkew"));
            Console.WriteLine(Solve("aab"));
        }
    }
}
