## While Solving thoughts

* So, I think that I need to use the look ahead algorithm. I can't remember what it's called:(
    * KMP (Knuth Morris Pratt).. But now that I'm looking at it, I'm not sure

I ended up looking at the discussion and taking some advice from there. I left my old, bad code in the repo so that I can look at it later and cry. Let me try and write out the steps of how the algorithm works... Lets use [-1,-2,-2,-2,3,2,-2,0] as our example array

* Set two variables
    * maxSum -> will be the return and holds the highest sum
    * currentMax -> calculates the max for the current run of numbers, picks betweeen existing `maxSum` and `currentSum` on each iteration to assign the value for `maxSum`
* create a for loop, to iterate over each element in the array
* the first thing the for loop does is increment the currentMax (sum for this run) by the element that we are iterating over
* Next, it decideds if the sum of currentMax and current element is less than the current element value itself (i.e. `currentMax = -5, currentElement = 5`, it would set `currentMax` as 5, because 5 + -5 = 0)
* Final step of iteration is to assign the value of maxSum to be either the existing value of maxSum or the currentMax value

## Iterations
starting with index 1....

|-------------------------------------------------|----------------------|--------|-------------------------------|
|maxSum = -1, currentMax = -1, currentElement = -2| -1 + -2 = -3, -2 < -3| -1 > -3| currentMax = -1, maxumSum = -1|
|maxSum = -1, currentMax = -1, currentElement = -2| -1 + -1 = -3, -2 < -3| -1 > -3| currentMax = -1, maxSum = -1  |
|maxSum = -1, currentMax = -1, currentElement = -2| -1 + -1 = -3, -2 < -3| -1 > -3| currentMax = -1, maxSum = -1  |
|maxSum = -1, currentMax = -1, currentElement = 3 | -1 + 3 = 2, 3 > 2    | -1 < 3 | currentMax = 3, maxSum = 3    |
|maxsum = 3, currentMax = 3, currentElement = 2   | 2 + 3 = 5, 5 > 2     | 3 < 5  | currentMax = 5, maxSum = 5    |
|maxSum = 5, currentMax = 5, currentElement = -2  | -2 + 5 = 3, 3 > -2   | 5 > 3  | currentMax =  3, maxSum = 5   |
|maxSum = 5, currentMax = 3, currentElement = 0   | 0 + 3 = 3, 3 > 0     | 5 > 3  | currentMax = 3, maxSum = 5    |
|   |   |   |   |   |
|---|---|---|---|---|
|   |   |   |   |   |
|   |   |   |   |   |
|   |   |   |   |   |