using System;
using System.Linq;
using Utils;

namespace Problems.Algorithms
{
    public class RepeatedSubstringPattern : ITest
    {
        public bool Solve(string s)
        {
            var str = s + s;
            var huh = str.Substring(1, str.Length - 2);
            return str.Substring(1, str.Length - 2).Contains(s);
        }

        public bool Recurse(string s, int num = 2)
        {
            var split = Math.Ceiling((decimal)s.Length / num);
            var subString = s.Substring(0, (int)split);
            if (String.Concat(Enumerable.Repeat(subString, num)) == s)
            {
                return true;
            }
            if (num > s.Length / 2 || s.Length == 1)
            {
                return false;
            }
            return Recurse(s, num + 1);
        }
        public bool SolveTwo(string s) 
        {
            if (s.Length == 1)
            {
                return false;
            }
            else if(s.Distinct().Count()  == 1)
            {
                return true;
            }
            var isValid = false;
            var j = (int)Math.Ceiling((double)s.Length / 2);
            while (j > 0 && !isValid)
            {
                isValid = IsValidSubstring(s.Substring(0, j), s);
                j -= 1;
            }
            return isValid;
        }

        public bool IsValidSubstring(string subString, string s)
        {
            var temp = subString;
            while (temp.Length <= s.Length && s.StartsWith(temp))
            {
                if (temp == s)
                {
                    return true;
                }
                temp += subString;
            }
            return false;
        }

        public void Go()
        {
            // var huh = Recurse("abab");
            // var bop = Recurse("aba");
            Console.WriteLine(Solve("abab"));
            Console.WriteLine(Solve("aba"));
            Console.WriteLine(Solve("ababababab"));
            Console.WriteLine(Solve("bb"));
            Console.WriteLine(Solve("aaaaaaaaaaaab"));
            Console.WriteLine(Solve("abcabcabcabc"));
            Console.WriteLine(Solve("ab"));
            Console.WriteLine(Solve("a"));
            Console.WriteLine(Solve("aaaaaaaaa"));
        }
    }
}
