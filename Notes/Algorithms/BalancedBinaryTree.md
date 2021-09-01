Height Balanced BTree -> left and right subtrees don't differ more than 1 at most

* start at root
* accept count and node
    * increments count if can go down
    * recursively calls the method on both left and right
* returns the count that's greatest
* compares the return to see if they differ by more than 1


            1
            /\
          2    2
         /\    /\
        3 *    * 3
       /\        /\
      4  *      *  4