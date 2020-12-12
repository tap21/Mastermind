# Mastermind

This project was a great learning exercise. It was intimidating at first, and took me some time to break into smaller pieces. First, I needed to randomly generate a number. 
Then I needed to store that number, read the user's input, and then store the user's input. I also needed to loop these actions, which I did using a for loop and while loop. 
From there I needed to figure out the main logic of the exercise, which was checking the user's number against the randomly generated number. The remaining details were worked 
out from there.

On Stack Overflow I came across the .Random() function to generate a random number, and later found out that that some developers will argue if this built-in function truly 
provides randomization. The Random() function did appear to slightly favor numbers, or not quickly enough switch up the numbers similarly to lightly shuffling a deck. 
I am curious about other ways to approach this, and I would imagine I could many more clock hours researching it.

The biggest challenge for me in this exercise was determining the logic to check the user's input against the randomly generated number. I set up the randomNumber and userInput 
each as strings, and decided to loop through each string. The program is functional, however I could not get it to account for duplicates. I was able to successfully compare 
the values of both strings, but I ran into issues when comparing the locations.

This is partly because the index location of each string is 0. I needed to start the loops at 0, otherwise it would skip over the first element and wouldn't loop through the
entire string. I tried reassigning the index to 0 when there was a match found. I think if I approached this with the randomNumber and userInput variables as arrays or lists,
I would have more flexibility. Since it's been hours of troubleshooting, at this point in a work environment I would go to mentor or team member for some guidance.

# Functionality and edits
Edits: The program is now functional, and will now have 10 attempts to check against one random generated number 4 digits in length. The first draft of this program was only
giving the user one attempt to guess, since it was generating a random number after each attempted guess. The code has been broken into methods, and is now more loosely coupled
code. Having the code separated in multiple methods definitely simplified the program and overall logic. For example, there are now 6 methods instead of 2 or 3. 
Instead of most logic being in a single CheckNumber() method, there are now separate methods including: a method checking if the user's input is valid, a method checking 
for all plus sign scenarios, checking for all minus sign scenarios, and one for combining the plus and minus scenarios.

When checking for both the minus and plus sign scenarios, I realized I didn't need to set up the loops like I had originally attempted. In other words, I didn't need to
directly compare elements when checking both the value and position of each digit within the strings. I could use the .Contains to check if anywhere in the randomNumber 
contained any of the digits in the user's input (while it also wasn't an equivalent). I could also incorporate the IsUserInputValid() method, and only return the built string
of pluses and minuses when the IsUserInputValid() method was true, otherwise it would return a string letting the user know they entered an incorrect value.

It was interesting finding a way to check if the user's input consisted of numbers between 1-6, since it's a string of characters and not integers. I used a foreach loop
to loop through each character within the string, and only return true if the user's input was between the character's '0' and '6'.

Additionally, I added to the program so that after the 10 attempts were exhausted, the console disclose the random number to the user.

# Overall
This was a great learning experience, and it helped me to realize I need continual practice in deciphering prompts and then breaking them down. 

