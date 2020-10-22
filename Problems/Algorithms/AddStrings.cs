using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class AddStrings : ITest
    {

        public string Solve(string num1, string num2)
        {
            var remainder = 0;
            var i = num1.Length - 1;
            var j = num2.Length - 1;
            var resultArray = new List<string>();
            while(i >= 0 || j >= 0 || remainder > 0)
            {
                var valueOne = i >= 0 ? GetIntFromString(num1[i]) : 0;
                var valueTwo = j >= 0 ? GetIntFromString(num2[j]) : 0;
                var valueToIncrease = valueOne + valueTwo + remainder;
                var result = 0;
                if (valueToIncrease > 9)
                {
                    remainder = 1;
                    result = valueToIncrease % 10;
                }
                else
                {
                    remainder = 0;
                    result = valueToIncrease;
                }
                resultArray.Add(result.ToString());
                i -= 1;
                j -= 1;
            }
            resultArray.Reverse();
            return string.Join("", resultArray);
        }

        public int GetIntFromString(char num)
        {
            switch (num)
            {
                case '0': return 0;
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9; 
                default: return 0;
            }
        }
        public void Go()
        {
            Console.WriteLine(Solve("498828660196", "840477629533"));
        }
    }
}