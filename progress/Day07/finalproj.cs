Console.Clear();

double[] answers = { 2, 4, -112.6716, -5, 79.5924};
int points = 0;

Console.Write("Input name: ");
string name = Console.ReadLine()!.Trim();
Console.WriteLine($"Hi {name}!");


string[] questions = {
	"What is 1+1= ",
	"What is 2*2= ",
	"What is -2¼ × ⅗⁴ + -57¾ + 1.22 - 55.85= ",
	"What is 3 - 8= ",
	"3 ÷ φ⁴ + φ⁹ + π= "
};


string[] inputs = new string[5];
int questionlength = questions.Length;


for (int i = 0; i < questionlength ; i++)
{

	Console.WriteLine("");
	Console.Write(questions[i]);
	inputs[i] = Console.ReadLine()!.Trim().ToLower();

	if (inputs[i] == answers[i].ToString()) //converts answers to string
	{
		Console.WriteLine($"Correct, the answer is {answers[i]}");
		points++;
		Console.WriteLine($"You are on {points} point(s).");
	}
	else
	{
		Console.WriteLine($"Incorrect, its {answers[i]}");
		Console.WriteLine($"You are on {points} point(s).");
	}
}

string getrank(double score)
{

	string rank = score switch
	{
		100 => "Perfect",
		>= 60 => "Passed",
		_ => "Try again"
	};
	return rank;
}

double score = points * 20;
Console.WriteLine($"You got {points} out of 5.");
Console.WriteLine($"You got {score}%.");

string finalRank = getrank(score);
Console.WriteLine($"You rank is {finalRank}");

