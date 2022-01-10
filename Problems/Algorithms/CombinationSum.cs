using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Algorithms
{
    public class CombinationSum : ITest
    {
        public IList<IList<int>> Solve(int[] candidates, int target)
        {
            var candList = candidates.ToList();
            candList.Sort();
            var result = new List<IList<int>>();
            GetVal(result, new List<int>(), candList, target, 0);
            return result;
        }

        private void GetVal(List<IList<int>> result, List<int> cur, List<int> candidates, int target, int start)
        {
            if (target > 0)
            {
                for(var i = start; i < candidates.Count && target >= candidates[i]; i++)
                {
                    cur.Add(candidates[i]);
                    GetVal(result, cur, candidates, target - candidates[i], i);
                    cur.RemoveAt(cur.Count - 1);
                }
            }
            else if (target == 0)
            {
                result.Add(new List<int>(cur));
            }
        }

        public void Go()
        {
            var solution = Solve(new int[] { 2,3,7,6 }, 7);
            var solution2 = Solve(new int[] { 2,3,7,6 }, 14);
            var huh = 123;
        }
    }
}