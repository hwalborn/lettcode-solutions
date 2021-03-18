using System;
using System.Text.RegularExpressions;

namespace Problems.Algorithms
{
    public class LengthOfLastWord : ITest
    {
        private int Solve(string s) {
            var length = 0;
            var stringLength = s.Length;
            var hasCharacter = new Regex(@"[^\s]");
            if (!hasCharacter.IsMatch(s))
            {
                return length;
            }
            else if (!s.Contains(" "))
            {
                return stringLength;
            }
            for (int i = stringLength - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && length > 0)
                {
                    return length;
                }
                else if (s[i] == ' ') 
                {
                    continue;
                }
                length++;
            }
            return length;
        }
        public void Go()
        {
            Console.WriteLine(Solve("a "));
        }
    }
}
