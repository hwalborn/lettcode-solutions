## Starting
* Do we want the two largest points? No not really.
* we could have a walker and a runner, right?
    * mostContainer = null;
    * step through array i
        * underneath that do a j -> j = i + 1
            var heightToMultiply = height[i] > height[j] ? height[j] : height[i];
            var multiplier = j - i;
            if (mostContainer == null || multiplier * heightToMultiply > mostContainer) -> mostContainer = multiplier * heightToMultiply;
* return mostContainer

### with memoization?
* maybe like keep track of the next-heighest, once we get to a break case, start i at the next heighiest?

### maybe some sort of sorted array?
* Loop over the array and put [index, value] into new array, but sorted by highest value, then lowest index;

### Discussion
* Ended up having a look here: https://leetcode.com/problems/container-with-most-water/discuss/6100/Simple-and-clear-proofexplanation Makes total sense... No need to loop in loop when we can just go towards eachother step by step