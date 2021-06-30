*height-balanced BST* -> depth of two subtrees never differs by more than one

- I kind of feel like we want to take the middle most value
- and recursively add nodes

- make a recurssive function that accepts an array of ints as a param
    - the function should grab the middle most value from the array
        - if it's odd, it should be easy (divide by 2 and round up [1,2,3,4,5] => 5)
        - if it's even, let's divide by 2 and take that value ([1,2,3,4] => 3)
    - if the value doesn't exist (i.e. the array is empty), return null
    - make a tree node with the value
    - asign the left property to be all the Result of the function with all the values to the left of the onew
    - do the same for the right
    - return the tree node