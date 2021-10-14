using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{    public class TitleToNumber : ITest
    {
        private Dictionary<char, int> NumberDictionary => new Dictionary<char, int>()
        {
            { 'A', 1 },
            { 'B', 2 },
            { 'C', 3 },
            { 'D', 4 },
            { 'E', 5 },
            { 'F', 6 },
            { 'G', 7 },
            { 'H', 8 },
            { 'I', 9 },
            { 'J', 10 },
            { 'K', 11 },
            { 'L', 12 },
            { 'M', 13 },
            { 'N', 14 },
            { 'O', 15 },
            { 'P', 16 },
            { 'Q', 17 },
            { 'R', 18 },
            { 'S', 19 },
            { 'T', 20 },
            { 'U', 21 },
            { 'V', 22 },
            { 'W', 23 },
            { 'X', 24 },
            { 'Y', 25 },
            { 'Z', 26 }
        };

        private int Solution(string columnTitle)
        {
            var columnNumber = 0;
            var baseNum = 0;
            for (int i = columnTitle.Length - 1; i >= 0 ; i--)
            {
                columnNumber += (int)(NumberDictionary[columnTitle[i]] * Math.Pow(26, baseNum));
                baseNum++;
            }
            return columnNumber;
        }

        public void Go()
        {
            Console.WriteLine(Solution("A"));
            Console.WriteLine(Solution("AB"));
            Console.WriteLine(Solution("ZY"));
            Console.WriteLine(Solution("ZZ"));
            Console.WriteLine(Solution("AA"));
            Console.WriteLine(Solution("FXSHRXW"));
        }
    }
}