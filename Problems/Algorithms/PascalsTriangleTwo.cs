using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Algorithms
{
    public class PascalsTriangleTwo : ITest
    {
        private IList<int> Solution(int rowIndex)
        {
            IList<IList<int>> pascalsTriangle = new List<IList<int>>();
            pascalsTriangle.Add(new List<int>(){1});
            for (int i = 1; i < rowIndex + 1; i++)
            {
                var currentRow = new List<int>(){1};
                if(pascalsTriangle.Count == 1)
                {
                    currentRow.Add(1);
                    pascalsTriangle.Add(currentRow);
                    continue;
                }
                var previousRow = pascalsTriangle[i - 1];
                var j = 0;
                while(j < previousRow.Count - 1)
                {
                    var result = previousRow[j] + previousRow[j + 1];
                    currentRow.Add(result);
                    j++;
                }

                currentRow.Add(1);
                pascalsTriangle.Add(currentRow);
            }
            return pascalsTriangle.Last();
        }
        public void Go()
        {
            var huh = Solution(0).ToList().Select(i => i.ToString()).ToArray();
            var bah = Solution(3).ToList().Select(i => i.ToString()).ToArray();
            Console.WriteLine(String.Join(", ", huh));
            Console.WriteLine(String.Join(", ", bah));
        }
    }
}