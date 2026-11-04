Console.Write("Student name: ");
string name = Console.ReadLine()!;

Console.Write("Score is: ");
int score = int.Parse(Console.ReadLine()!);


if (score < 0 || score > 100)
{
	Console.WriteLine("Non valid Score");
}
else
{
	
	string grade = score switch
	{
		>= 90 => "A",
		>= 80 => "B",
		>= 70 => "C",
		>= 60 => "D",
		_ => "F"
	};
	
	
	string passed;
	if (score >= 60)
	{
		passed = "Passed";
	}
	else
	{
		passed = "Failed";
	}
	
	Console.WriteLine($"Student {name} got {grade} and {passed}.");
}
