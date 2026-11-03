Console.Write("Whats your name? ");
string? name = Console.ReadLine();

Console.Write("Whats your fav hobby? ");
string? hobby = Console.ReadLine();

Console.Write("Where do you live? ");
string? city = Console.ReadLine();

Console.WriteLine($"Hi {name.ToUpper()}, you like doing {hobby}, and you live in {city}");
