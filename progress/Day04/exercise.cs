int secret = Random.Shared.Next(1, 101);
int lives = 7;
bool win = false;
int guesses = 0;

while (lives > 0)
{
	Console.WriteLine($"You have {lives} tries.");
	Console.Write("Guess: ");
	int answer = int.Parse(Console.ReadLine()!);
	lives--;
	guesses++;

	if (answer == secret)
	{
		win = true;
		break;
	}

	if (answer > secret)
	{
		Console.WriteLine("Answer too high!");
	}
	else
	{
		Console.WriteLine("Answer too low!");
	}
	
}

if (win)
{
	Console.WriteLine($"You won! the answer was: {secret}");
	Console.WriteLine($"You guessed it on the {guesses} try.");
}
else
{
	Console.WriteLine($"You ran out of tries! The answer was {secret}");
}
