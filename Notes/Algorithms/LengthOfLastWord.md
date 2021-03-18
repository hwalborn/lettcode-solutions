## Starting notes
* If the entire input is empty space, return 0
* I think if we do `input.indexof(' ') < 0` return the input
* Start at end and and count until you hit whitespace?

## After thoughts
I think that I did it a pretty convoluted way. I probably could've done something like `s.Trim().Length - s.Trim().LastIndexOf(" ") - 1`... But what are you going to do?