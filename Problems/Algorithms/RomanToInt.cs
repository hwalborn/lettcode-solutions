using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class RomanToInt : ITest
    {
        public Dictionary<char, int> RomanIntDict => new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int Solve(string s)
        {
            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var roman = s[i];
                var isLastElm = i == s.Length - 1;
                if (!RomanIntDict.ContainsKey(roman))
                {
                    continue;
                }
                if (i < s.Length - 1 && RomanIntDict[roman] < RomanIntDict[s[i + 1]])
                {
                    result -= RomanIntDict[roman];
                }
                else
                {
                    result += RomanIntDict[roman];
                }
            }
            return result;
        }
        public void Go()
        {
            Console.WriteLine(Solve("MCMXCIV"));
        }
    }
}