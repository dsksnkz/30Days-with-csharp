using System.Text;

var sb = new StringBuilder();


string sentence = Console.ReadLine();

int words = sentence.Split(' ').Length;

int vowels = 0;

foreach (char letter in sentence.ToLower())
{
	if ("aeiou".Contains(letter)) // if the vowels 'aeiou' is contained in 'letter': vowels+1
	{
		vowels++;
	}
}

Console.WriteLine($"word length: {sentence.Length}"); // .Length is case sensitive with capital L.
Console.WriteLine($"words: {words}");
Console.WriteLine($"vowels: {vowels}");

// reverse sentence:
// total num of letters
// prints from last letter
// count down and print letter
// until lettercount = 0

for (int i = sentence.Length -1; i >= 0; i--) // for: integer i equals length of the sentence -1 because it counts from 0 and up.
{                                             // until `i` is 0. i-1.
	sb.Append(sentence[i]);
	
}
Console.WriteLine(sb);
