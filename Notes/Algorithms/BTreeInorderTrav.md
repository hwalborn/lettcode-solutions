Return the *inorder* -> Starts from left most node and then traverses sort of across left to right

          10
          /\
         5  15
        /\    /\
     null 7  12 17
         /\     /\
        4  9  16  25

- recursive function
    - takes a node and a list as a param
    - returns adds the val to the list and returns list
    - break? -> if left node is null