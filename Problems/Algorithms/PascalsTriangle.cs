using System;
using System.Collections.Generic;

namespace Problems.Algorithms
{
    public class PascalsTriangle : ITest
    {
        private IList<IList<int>> Solution(int numRows)
        {
            IList<IList<int>> pascalsTriangle = new List<IList<int>>();
            if (numRows <= 0)
            {
                return pascalsTriangle;
            }
            pascalsTriangle.Add(new List<int>(){1});
            for (int i = 1; i < numRows; i++)
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
            return pascalsTriangle;
        }
        public void Go()
        {
            var solution = Solution(5);
        }
    }
}