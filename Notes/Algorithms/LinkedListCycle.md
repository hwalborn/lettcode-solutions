## Approach
* So, I'm unclear if there can be multiple of the same values in a linked list
    * The dumb way to do this would be to keep an array of values that we've accessed
    * if the current value already exists in our array, then return true, otherwise return false;
    * THIS DOES NOT WORK
* maybe there's a way we can find the reference?
    * I ended up keeping an array of GetHashCode values and checking to see if already exists. Not the fastest approach, but it works... I'm seeing something like this in the discussions (using a walker and runner):
```csharp
public bool Solution(ListNode head)
{
    if (head == null)
    {
        return false;
    }
    var walker = head;
    var runner = head;
    while(runner.next != null && runner.next.next != null)
    {
        walker = walker.next;
        runner = runner.next.next;
        if (walker == runner)
        {
            return true;
        }
    }
    return false;
}
```
I like that approach, it makes sense. Just keep going until one equals the other