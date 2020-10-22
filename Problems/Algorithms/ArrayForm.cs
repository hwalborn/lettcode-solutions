using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class ArrayForm : ITest
    {
        public string Holt => "HI HOLT";
        public List<int> SolveTwo(int[] A, int K)
        {
            var remainder = 0;
            var i = A.Length - 1;
            var resultArray = new List<int>();
            while (i >= 0 || remainder > 0)
            {
                if (i >= 0)
                {
                    K += A[i];
                }
                resultArray.Add(K % 10);
                K /= 10;
                i -= 1;
            }
            resultArray.Reverse();
            return resultArray;
        }

        public List<int> Solve(int[] A, int K)
        {
            var stringValue = K.ToString();
            var i = A.Length - 1;
            var j = stringValue.Length - 1;
            var remainder = 0;
            var resultArray = new List<int>();
            while(i >= 0 || j >= 0 || remainder > 0)
            {
                var valueOne = i >= 0 ? A[i] : 0;
                var valueTwo = j >= 0 ? GetIntFromString(stringValue[j]) : 0;
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
                resultArray.Add(result);
                i -= 1;
                j -= 1;
            }
            resultArray.Reverse();
            return resultArray;
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
            Console.WriteLine(string.Join(',', Solve(new int[] {1,4,2,5}, 6)));
            Console.WriteLine(string.Join(',', SolveTwo(new int[] {1,4,2,5}, 6)));
        }
    }
}