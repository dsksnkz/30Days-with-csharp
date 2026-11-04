// loops

// integer `i` = 1
// until i equals or over 5
// i++ is operator: ++ means add 1

for (int i = 1; i <= 5; i++)
{
	Console.WriteLine(i);
}



//while loop
int lives = 3;

while (lives > 0) // while lives is larger than 0 (it decreases)
{
	Console.WriteLine($"Lives: {lives}");
	lives--; // -- decreases value by 1
}


//do / while loop: do at least once

string? answer; // ? prevents null   and   initialises variable "answer " as string
				// answer is declared out of the loop because "while" is outside the {}
do
{
	Console.Write("Type yes: ");
	answer = Console.ReadLine();
}while (answer != "yes"); //loops if answer is not "yes"


//foreach loop: every item in a group
foreach (char letter in "cat") //foreach: single letter "in" string cat, set by "char"
								// set into the variable letter, writeline "letter"
{
	Console.WriteLine(letter);
}


for (int i = 1; i <= 10; i++)
{
	if (i == 3)
	{
		continue; //skips to print number 3 and goes to 4
	}
	if (i == 6)
	{
		break; // stops at 6. dosent print 6.
	}
	Console.WriteLine(i);
}


//Random Numbers
int secret = Random.Shared.Next(1, 101);
Console.WriteLine(secret);
