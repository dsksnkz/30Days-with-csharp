// ARRAYS AND STRINGS

int[] scores = { 90, 75, 60}；

Console.WriteLine(scores[0]); // prints scores with first one [0]
Console.WriteLine(scores.Length); // built in function .length, length of `scores`
scores[1] = 80; // changes the second array to `80`. counts from 0 and up.

int[] empty = new int[5]; // creates a new "integer array" with 5 different arrays. default as 0.

foreach (int score in scores) // loops to replace the 'temporary' 
{
	Console.WriteLine(scores);
}

// OUTPUT:
// 90
// 3
// 90
// 80
// 60

// STRINGS

string text  = " Hello, World! ";

Console.WriteLine(text.Trim()); // removes spaces
Console.WriteLine(text.ToLower()); //converts to lowercase
Console.Writeline(text.Contains("World")); // prints "True" because it contains `World`.
Console.Writeline(text.Replace("World", "C#")); //Replaces "World" with "C#"
Console.Writeline(text.Trim().Length); //prints length of string.
Console.Writeline(text.Trim()[0]); // trims everything but first char : `h`

string[] words = "one two three".Split(' ');
Console.WriteLine(words.Length);  // prints '3'    also case sensitive with capital L

// trim could be used for data e.g names that is strictly typed and does not need spaces.




// stringbuilder
// used for building text in loop
// faster than adding string over and over

using System.Text;

var builder = new StringBuilder();

for (int i = 0; i < 3; i++) // loops and add 1 to the integer i  until its 3.
{
	builder.Append(i);  // builder adds the variable i into string
	builder.Append(' '); // space added.
}

Console.WriteLine(builder.ToString());

// prints '0 1 2'
