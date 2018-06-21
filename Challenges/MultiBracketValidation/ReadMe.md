# Multi-Bracket Validation
Determine if all the brackets in a given string are validly used. 

## Summary of the Challenge
Create a function that should take a string as its only argument, and should return a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets:

* Round Brackets : ()
* Square Brackets : []
* Curly Brackets : {}

## Whiteboard
![WhiteboardChallenge13](https://github.com/cascadianrebel/data-structures-and-algorithms/blob/master/assets/MultiBracketValidationWhiteboard.jpg)

## Explanation

To solve this challenge, we will iterate through the given string, creating a new list for each type of bracket. 

Next, we'd iterate through each list to ensure that each bracket has a match. 

If all lists return true, the function returns true. 

## Tests

* { }						TRUE
* {}(){}					TRUE
* ()[[Extra Characters]]	TRUE
* (){}[[]]					TRUE
* {}{Code}[Fellows](())		TRUE
* [({}]						FALSE
* (](						FALSE


## Author
Anthony Green

## Contributors
Earl Jay Caoile and Jimmy Chang
