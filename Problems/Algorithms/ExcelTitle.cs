using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class ExcelTitle : ITest
    {
        private Dictionary<int, string> TitleDictionary => new Dictionary<int, string>()
        {
            {0, string.Empty},
            {1, "A"},
            {2, "B"},
            {3, "C"},
            {4, "D"},
            {5, "E"},
            {6, "F"},
            {7, "G"},
            {8, "H"},
            {9, "I"},
            {10, "J"},
            {11, "K"},
            {12, "L"},
            {13, "M"},
            {14, "N"},
            {15, "O"},
            {16, "P"},
            {17, "Q"},
            {18, "R"},
            {19, "S"},
            {20, "T"},
            {21, "U"},
            {22, "V"},
            {23, "W"},
            {24, "X"},
            {25, "Y"},
            {26, "Z"}
        };
        private string Solution(int columnNumber)
        {
            var title = string.Empty;
            var currentPow = 0;
            while(columnNumber > 0)
            {
                var baseNum = 27;
                if ((Math.Pow(26, currentPow) * baseNum < columnNumber) ||
                    (Math.Pow(26, currentPow) * baseNum == columnNumber && columnNumber <= 27))
                {
                    currentPow++;
                    continue;
                }
                while(baseNum > 0)
                {
                    var currentVal = Math.Pow(26, currentPow) * baseNum;
                    if ((currentVal > columnNumber) ||
                        (!TitleDictionary.ContainsKey(baseNum) ||
                        // if this is the final round, we shouldn't keep decreasing
                        (currentVal == columnNumber && columnNumber > 26)))
                    {
                        baseNum--;
                    }
                    else
                    {
                        title = title + TitleDictionary[baseNum];
                        currentPow--;
                        columnNumber -= (int)currentVal;
                        break;
                    }
                }
            }
            return title;
        }

        public void Go()
        {
            Console.WriteLine(Solution(702));
            Console.WriteLine(Solution(52));
            Console.WriteLine(Solution(1));
            Console.WriteLine(Solution(28));
            Console.WriteLine(Solution(27));
            Console.WriteLine(Solution(701));
            Console.WriteLine(Solution(2147483647));
        }
    }
}