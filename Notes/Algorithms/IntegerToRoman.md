## Lets do this

I think we need like a dictionary of <string, int> -> the string is each roman numeral (including IV, IX, XL, CL, CD, CM) and the string is the base representation
* takes param -> num
* declare a variable -> romanNumeralResult
* lets loop over the keys
    * I guess we'll do another loop in there... a while loop... while (num / dictionary int >= 0) Add the roman numeral to the front of romanNumeralResult
    * subtract the value in the dictionary from the number