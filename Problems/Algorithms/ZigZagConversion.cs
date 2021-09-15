using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Algorithms
{
    public class ZigZagConversion : ITest
    {
        private string Solution(string s, int numRows)
        {
            int? nextIndex = null;
            var resultsArray = Enumerable.Range(0, numRows).Select(i => new List<string>()).ToList();
            while(s.Length > 0)
            {
                for (var i = 0; i < numRows; i++)
                {
                    if(nextIndex == null && s.Length > 0)
                    {
                        resultsArray[i].Add(s[0].ToString());
                        s = s.Remove(0,1);
                        if (i == numRows - 1 && i > 0)
                        {
                            nextIndex = i - 1;
                        }
                    }
                    else if (nextIndex == i && s.Length > 0)
                    {
                        resultsArray[i].Add(s[0].ToString());
                        s = s.Remove(0,1);
                        if (nextIndex <= 1)
                        {
                            nextIndex = null;
                            continue;
                        }
                        nextIndex -= 1;
                    }
                }
            }
            return String.Join("", resultsArray.Select(arr => String.Join("", arr)));
        }

        public void Go()
        {
            // Console.WriteLine(Solution("PAYPALISHIRING", 3));
            // Console.WriteLine(Solution("PAYPALISHIRING", 4));
            // Console.WriteLine(Solution("AB", 1));
            Console.WriteLine(Solution("ABCD", 2));
        }
    }
}