using System;

namespace Problems.Algorithms
{
    public class AddBinary : ITest
    {
        public string Solve(string a, string b)
        {
            var result = string.Empty;
            var i = a.Length - 1;
            var j = b.Length - 1;
            var remainder = 0;
            while (i >= 0 || j >= 0 || remainder > 0)
            {
                var valueA = i >= 0 ? (int)Char.GetNumericValue(a[i]) : 0;
                var valueB = j >= 0 ? (int)Char.GetNumericValue(b[j]) : 0;
                var addedValue = valueA + valueB + remainder;
                if (addedValue > 1)
                {
                    var insertedBinary = addedValue > 2 ? "1" : "0";
                    result = $"{insertedBinary}{result}";
                    remainder = 1;
                }
                else
                {
                    result = $"{addedValue}{result}";
                    remainder = 0;
                }
                i -= 1;
                j -= 1;
            }
            return result;
        }
        public void Go()
        {
            Console.WriteLine(Solve("1111", "1111"));
        }
    }
}