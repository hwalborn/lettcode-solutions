## pre work
* So I think I need like a combination approach of using twosum inside of a loop?
* It doesn't explicitly say that it's sorted, but I'm going to run with the assumption that it is
* define a property on the class and set it equal to an empty List, call the property ThreeSumList -> List<IList<int>>
* make a function that takes "currentVal", and a list of ints "arr"
    * this function will do a twoSum-esque technique to find all that's good;
    * var i = 0; var j = arr.Length -1;
    * while (i < j)
        * var sum = currentval + arr[i] + arr[j];
        * if (sum < 0) -> i++
        * else if (sum > 0) -> j--
        * else if (currentVal == arr[i] || currentVal == arr[j] || arr[i] == arr[j]) -> i++
        * else -> i++ ThreeSumList.Add(new List<int>{currentVal, arr[i], arr[j]})
* make a for loop
    * gets the current val
    * passes current val and subArr of arr from i -> end ionto function