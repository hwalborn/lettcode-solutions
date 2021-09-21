## Notes
* starting from the end case -> linkedList a == linkedList b -> return linkedList a (either doesn't matter)
* Maybe some sort of recurring function that we use to step through one linkedList while stepping through another ->
    * rucursion for runningNode -> 
        * break case -> nodeA == nodeB
            return nodeA
        * break case -> nodeB.next == null
            return
    * recyrsuib for walkingNode ->
        * break -> if runningRecur(nodeB, nodeA) != null
            * return val
        * break -> if nodeA == null
            * return null -> this wasn't original what I though, but apparently when the test says that the return value is "ListNode" it means a nullable type?
        * recur -> return walkingNode(nodeA.next, nodeB);