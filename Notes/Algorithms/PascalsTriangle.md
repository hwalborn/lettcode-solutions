## brute force?
* declare a variable called `pascalsTriangle`, set it equal to a `new List<List<int>>({new List<int>(){1}})`
* make a for loop right?
    * the test for this loop is `i < numRows`
    * make a new variable called `currentRow = new List<int>(){1}`
    * if the length of pascalsTriangle is 1, just add a 1 to current row and continue
    * while loop (while previous array [j + 1] != undefined) over the previous array 
        * add current element and next element in previous array together and add to pascalsTriangle

^^ LOl, faster than 5% of everyone else but it works I can refactor at another time