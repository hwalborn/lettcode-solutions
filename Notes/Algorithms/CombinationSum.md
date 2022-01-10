## Thoughts
I feel like the first thing we want to do is sort the array
[2,3,6,7] -> 7 -> [[2,2,3], [7]]
[2,3,6,7] -> 14 -> [[2,2,2,2,2,2,2], [7]]

[2,2,2]

2,2,2,2,2,2,2 Y
2,2,2,2,2,2,2,2 X
2,2,2,2,2,2,3 X
2,2,2,2,2,3,3 X
2,2,2,2,3,3 Y
2,2,2,3,3,3 X
2,2,3,3,3,3 X
2,3,3,3,3 Y
2,3,6,6 X
2,3,6,7 X
3,3,3,3,3 X
3,3,3,3,6 X
3,3,3,6,6 X
3,3,6,6 X
3,6,6 X
3,6,7 X

I feel like we need to loop over the array and recursively add things that sum correctly

Ugh, New Years brain... I had to look at the discussions and found this Java solution: https://leetcode.com/problems/combination-sum/discuss/16521/Java-solution-using-recursive