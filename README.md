# .NET 24 LABB 1

This is the first submitted project made through my education as a .NET developer in C#. 

The task is to create a console application that asks the user to enter a text (string) into the console. The entered string must then be searched for all substrings that are numbers that begin and ends on the same number, without the start/end number, or any other character numbers appear in between.

### Planning/ thoughtprocess

- Create an iteration on users input string which is resolved through two for-loops with the entire string as length.
- Iterate through numbers and look for the next one like it. Start by comparing indexes. Break when found.
- When i == j, make text red. when the next one is encountered, resetcolor.
- Exception case, if letter or other type of text comes between string, break and start next iteration.
- Save a total of the combined sum when every red substing is found. Initialize two seperate integers to keep track - one for total sum, one for substring. 
- Type out full string with red substring after every completed loop.
