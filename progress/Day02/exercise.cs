const double MilesPerKm = 0.621371;

Console.Write("How many kilometers: ");

double km = double.Parse(Console.ReadLine()!);
double miles = km * MilesPerKm;

Console.WriteLine($"That is {miles:F2} miles!");

Console.Write("How many degrees celsius? ");
double celsius = double.Parse(Console.ReadLine()!);

double fahrenheit = celsius * 9  / 5 + 32;

Console.WriteLine($"{celsius} is {fahrenheit:F2} fahrenheit!");
