// add, subtract, multiply and divide.
// each takes 2 doubles(decimals) and returns a double.
// ReadNumber(string prompt) prints the prompt, then reads and returns a dpouble
double a = ReadNumber("Enter number 1: ");
double b = ReadNumber("Enter number 2: ");

Console.Write("Would you like to +, -, * or / : " );
string? op = Console.ReadLine();

switch (op)
{
	case "+":
		Console.WriteLine($"{Add(a,b):F2}");
		break;
	case "-":
		Console.WriteLine($"{Subtract(a,b):F2}");
		break;
	case "*":
		Console.WriteLine($"{Multiply(a,b):F2}");
		break;
	case "/":
		if (b == 0)
		{
			Console.WriteLine("Cant divide by 0");
		}
		else
		{
			Console.WriteLine($"{Divide(a,b):F2}");
		}
		break;
	default:
		Console.WriteLine("Invalid operator.");
		break;
}

double ReadNumber(string prompt)
{
	Console.Write(prompt);
	return double.Parse(Console.ReadLine()!);
}

double Add(double a, double b)
{
	return a + b;
}

double Subtract(double a, double b)
{
	return a - b;
}

double Multiply(double a, double b)
{
	return a * b;
}

double Divide(double a, double b)
{
	return a / b;
}
