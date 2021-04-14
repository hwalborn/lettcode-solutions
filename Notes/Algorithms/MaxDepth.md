## Starting notes
We should probably just traverse down the BST and keep track of how many nodes we've hit. Once there are no options to go left or right, return the number.

## Afterwards
Looks like the easiest way would've been something like:
`return root == null ? 0 : Math.max(Solve(root.left), Solve(root.right))`

Not sure how many solving notes we need, it's pretty straight forward.
Start with a root
Call FindMax with the left and right nodes.
Optional parameter is set to 1
If left and right are null, then the count is the deepest it can go at that point
return the count
Otherwise, check the depth of the left and the depth of the right
Return the one that's deeper