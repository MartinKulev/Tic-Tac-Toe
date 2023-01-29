# Tic-tac-toe-game
A recreation of the famous game called Tic-tac-toe.

# How to use the program?
The user(s) take turn writing the numbers between 1 and 9. Each number represents one of the nine boxes.
The boxes on the 1st row are 1,2,3. The boxes on 2nd row are 4,5,6. The boxes on the 3rd row are 7,8,9.
![Screenshot_3](https://user-images.githubusercontent.com/56129939/215359672-a484fa9d-1803-4d2b-ba15-039250ca6325.png)
The symbol changes each turn automatically.
Let's say user 1 types "5" - a "X" appears in the middle, then user 2 types "3" - a "O" appear on the top right corner.
Then user 1 types "4" - a "X" appear on the left middle box. Then user 2 types "6" - a "O" appear on the right middle box. And so on...
If the user has typed the number of a box, which is already occupied or if the user has typed a number greater than 9 or if the user has typed a text, 
the symbol stays the same for the next turn too, and that repeats until they fill an empty box or type a number smaller than 10.
The game continues until someone has won by 3 of the same symbol on one collumn, on one row, or by on of the 2 diagonals.

# How does the code work?
I created 3 List<char>. One for the 1st row, one for the 2nd row, one for the 3rd row. Then they are printed on the screen.
A for cycle is implemented, which itterates 9 times to ensure the program has stopped after the 9 turns played and after the 9 boxes are filled.
I've used a "a % 2 == 0" if else statement in the loop so every 2nd turn the symbol is the same.
Then I've created 9 if else statments which Insert the symbol in the correct List, in the correct spot.
If the user has typed a number of box, that is already occupied, or if the number is greater than 9, or if the user has typed a text - 
it takes one away from the number of loops completed, so it stays the same turn the next time the loop is looped. 
An error message is displayed and the symbol isn't changed.
Then the Console is cleared and the new updated Lists are printed on the screen. If the input is incorect the Console isn't cleared.
Then I've created 8 if else statements for every winning scenario, that print the way the player has won.

