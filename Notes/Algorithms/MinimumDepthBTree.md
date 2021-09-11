Ok, so we just did Balanced B Tree, I think I should be able to use some of that functionality to find the depth... I think we just need a function to go down each way and compare the two

                -9
                /\
              -3  2
              /\  /\
                4 4 0
               /\ /\
              -6 -5

                1
                /\
               2  3
              /\
             4  5

## Answer
Ended up having a look here: https://leetcode.com/problems/minimum-depth-of-binary-tree/discuss/36045/My-4-Line-java-solution/242269 I tried to impliment a BFS, but was missing that for loop