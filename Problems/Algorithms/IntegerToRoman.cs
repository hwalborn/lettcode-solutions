using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Algorithms
{
    public class IntegerToRoman : ITest
    {
        private Dictionary<string, int> RomanDict => new Dictionary<string, int>()
        {
            {"M", 1000},
            {"CM", 900},
            {"D", 500},
            {"CD", 400},
            {"C", 100},
            {"XC", 90},
            {"L", 50},
            {"XL", 40},
            {"X", 10},
            {"IX", 9},
            {"V", 5},
            {"IV", 4},
            {"I", 1}
        };

        private string Solution(int num)
        {
            var romanNumeral = string.Empty;

            foreach (var romanNum in RomanDict.Keys)
            {
                var romanVal = RomanDict[romanNum];
                while(num - romanVal >= 0)
                {
                    romanNumeral = romanNumeral + romanNum;
                    num -= romanVal;
                }
            }

            return romanNumeral;
        }

        public void Go()
        {
            Console.WriteLine(Solution(3));
            Console.WriteLine(Solution(4));
            Console.WriteLine(Solution(9));
            Console.WriteLine(Solution(58));
            Console.WriteLine(Solution(1994));
        }
    }
}