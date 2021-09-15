## Using multidimensional arrays
* We have a function `Solution` that takes a string being the input string and an int being the number of rows
    * numOfRows is the length of the outer array
    * make a variable called `nextIndex` that is initiated to null?;
    * make a variable called resultString
    * make a variable i = 0 for while loop
    * make a loop over the string
    * while (s.length > 0)
        * for loop -> i < numOfRows
            * if nextIndex == null -> pull from string (i.e. s[0], then `s = s.Remove(0,1)`) & if nextIndex == null && i == numOfRows - 1 -> nextIndex = i;
            * else if nextIndex == i -> pull from string (i.e. s[0], then `s = s.Remove(0,1)`) -> nextIndex -= 1
            * else put a String.empty