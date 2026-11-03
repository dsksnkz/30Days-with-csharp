# Revision: Days 1–3

Answer from memory first. The answers are at the bottom.

## Predict the output

**1.**
```csharp
Console.Write("A");
Console.WriteLine("B");
Console.Write("C");
```

**2.**
```csharp
Console.WriteLine(9 / 2);
Console.WriteLine(9.0 / 2);
Console.WriteLine((int)4.9);
```

**3.**
```csharp
double price = 3.14159;
Console.WriteLine($"{price:F2}");
```

**4.**
```csharp
int score = 75;
string grade;

if (score >= 60)
{
    grade = "D";
}
else if (score >= 70)
{
    grade = "C";
}
else
{
    grade = "F";
}

Console.WriteLine(grade);
```

**5.**
```csharp
int age = 20;
bool isTeen = age >= 13 && age <= 19;
Console.WriteLine(isTeen);
```

## Spot the bug

Each of these won't compile. Say why.

**6.**
```csharp
int age = "twenty";
```

**7.**
```csharp
string name = "Alex";
string name = "Sam";
```

**8.**
```csharp
int x = 5;

if (x > 3)
{
    string message = "big";
}

Console.WriteLine(message);
```

## Write it

**9.** In one line, read a number from the user into a `double` called `height`.

**10.** Write an `if`/`else` that prints `"Valid"` if `age` is from 0 to 120, and `"Invalid"` otherwise.

---

## Answers

Stop here until you've tried them all.

1. `AB`, then `C` on the next line. `Write` stays on the line and `WriteLine` ends it.
2. `4`, then `4.5`, then `4`. Dividing two `int`s drops the decimal, and a cast cuts it off without rounding.
3. `3.14`
4. `D`. The first match wins, and 75 matches `>= 60` first, so the largest check has to come first. A switch expression written in this order wouldn't compile at all: `>= 70` could never be reached, so you'd get error CS8510.
5. `False`. The `&&` needs both sides to be true, and `20 <= 19` isn't.
6. `"twenty"` is a string, and an `int` can't hold a string.
7. `name` is declared twice. The second line should be `name = "Sam";`.
8. `message` only exists inside the `{ }` where it was created. This is scope.
9. `double height = double.Parse(Console.ReadLine()!);`
10.
```csharp
if (age >= 0 && age <= 120)
{
    Console.WriteLine("Valid");
}
else
{
    Console.WriteLine("Invalid");
}
```

## The main points so far

- **Parsing:** `ReadLine()` always gives text. Use `int.Parse` or `double.Parse` to get a number. Typing `abc` crashes with a `FormatException`, and `null` is a different thing: it means no value at all.
- **`=` vs. `==`:** `=` assigns and `==` compares.
- **Declaring:** writing the type (`string x`) creates a variable, so do that only once.
- **Order:** the first matching branch wins.
- **Scope:** a variable exists only inside the `{ }` where it was created.
- **Semicolons:** blocks end with `}`, and assignments end with `;`, including a switch expression.
- **Testing:** test the boundaries (60 and 59), because compiling doesn't mean correct.
