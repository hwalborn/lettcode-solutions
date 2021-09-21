## Solution
* Seems like we have a class called `MinStack`
    * we'll need a list of <int> where it starts out as an empty list call it `minValueIndexes`
    * we'll need a property `stack` that is a List<int> starts at empty
    * Some methods:
        * MinStack -> ctor -> sets `minValueIndexes = new List<int>();` and sets `stack = new List<int>();`
        * Push -> accepts an `int` and does some things:
            * checks if !minValueIndexes.Any() || int is < stack[minValueIndexes.First()];
                * do minValueIndexes.Add(stack.Count);
            * stack.Add(int)
        * Pop -> Remove the last element of the stack (we're gonna handle the minValueIndex in the getMin method)
        * top -> if (stack.Any()) -> return stack.Last();
        * getMin -> 
            * if (!minValueIndexes.Any()) -> return; -> Do we return something?
            * var i = 0 -> while stack.Count < minValueIndexes[i]  && minValueIndexes.Count >= 0 -> shift first value out of minValueIndexes
            * if (minValueIndexes.Any()) -> return stack[minValueIndexes.First()]

## afterthoughts
I had to end up doing the check for incorrect elements in the pop method. Otherwise I would have had to do it in the getMin and the Push method

Saw someone using nodes in the discussion, that makes more sense I think