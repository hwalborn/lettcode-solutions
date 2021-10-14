## Beginning Notes
Is Base26 a thing?
* I feel like we could %26 the number until we get something
* first we need to make a dictionary of int, string:
```csharp
var titleDictionary = new Dictionary<int, string>
{
    {0, string.Emtpy}
    {1, "A"}
}
```
* var title = string.Empty;
* I think we need a while loop... while columnNumber > 0;
    * currentBase = columnNumber % 100
    * we are going to calculate the based column
        * startBase = titleDictionary[currentBase % 26];
        * additionaltitles = titleDictionary[Math.Floor(currentBase / 27)];
        * title = additionalTitles + startBase + title;
    * Math.floor(columnNumber / 100);

### during
* that was close but not quite it. What we need is a way to decrypt base 10 into base 26, right?
* title = string.Empty;
* make a variable called currentPow = 0
* We need another while loop, while (columnNumber > 0)
    * make a variable called base = 26;
    * if (Math.Pow(26, currentPow) * base > columnNumber) -> currentPow++, continue;
    * Another while loop in here... while(base >= 0)
        * currentVal = Math.Pow(26, currentPow) * base;
        * if (currentVal > columnNumber) -> base--;
        * else -> title = TitleDictionary[base] + title, currentPow--, columnNumber -= currentVal, break;