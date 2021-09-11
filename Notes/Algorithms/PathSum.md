## starting notes
* declare a variable called 'count' set equal to 0
* make a function that accepts a TreeNode and a count
    * this is our recurring function
* we need a way to search the BST
    * probably recursion
    * add value of node to count
    * break case for recursion is -> we are on a leaf
        * if leaf value == count -> return true;
        * otherwise return false?

^^^ Not the fastest, but it worked!