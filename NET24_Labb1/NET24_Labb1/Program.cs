
// Create a console application that asks the user to enter a text (string) into the console.
// The entered string must then be searched for all substrings that are numbers that begin
// and ends on the same number, without the start/end number, or any other character
// numbers appear in between. The program must also add up all the numbers it found according to
// above and print it last in the program.


static void Labb1(string userString)
{
    ulong totSum = 0;
    ulong currentSum = 0;

    for (int i = 0; i < userString.Length; i++)
    {
        Console.ResetColor();
        int substringCount = 0;
        string substring = "";
        
        for (int j = i + 1; j < userString.Length; j++)
        {
            if (char.IsDigit(userString[j]))
            {
                substringCount++;
                substring = userString.Substring(i, substringCount +1);

                if (userString[j] == userString[i] && j != i)
                {
                    currentSum = ulong.Parse(substring);
                    totSum += currentSum;
                    PrintUserString(userString, substring, i);
                    break;
                }
            }   
            else
            {
                break;
            }
        }
    }
    Console.WriteLine($"\nThe total sum of all highlighted numbers = {totSum} ");
}

// Console.Write("Please input any type of string: ");
// string userInput = Console.ReadLine();

Labb1("29535123p48723487597645723645");


// Function PrintUserString() -- Helper to print full string with red substring for Labb1().
static void PrintUserString(string userString, string substring, int i)
{   
    string numbersBeforeSubstring = userString.Substring(0, i);
    string numbersAfterSubstring = userString.Substring(i + substring.Length);

    Console.Write(numbersBeforeSubstring);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(substring);
    Console.ResetColor();
    Console.Write(numbersAfterSubstring);
    Console.WriteLine();
}
