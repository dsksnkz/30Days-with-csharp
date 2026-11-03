# Week 1, continued: Days 4–7

---

# Day 4: Loops

**Goal:** build a number guessing game.

## `for`: when you know how many times

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

This prints 1 to 5. The three parts are the start (`int i = 1`), the check that keeps it going (`i <= 5`), and the step after each run (`i++`, which adds 1).

## `while`: until something changes

```csharp
int lives = 3;

while (lives > 0)
{
    Console.WriteLine($"Lives: {lives}");
    lives--;
}
```

The check runs before each loop. If you forget `lives--`, it never ends, which is an infinite loop. Press **Ctrl+C** to stop one.

## `do`/`while`: run at least once

```csharp
string? answer;

do
{
    Console.Write("Type yes: ");
    answer = Console.ReadLine();
} while (answer != "yes");
```

`answer` is declared outside the loop because of scope: the `while` line sits outside the `{ }`.

## `foreach`: every item in a group

```csharp
string word = "cat";

foreach (char letter in word)
{
    Console.WriteLine(letter);
}
```

## `break` and `continue`

```csharp
for (int i = 1; i <= 10; i++)
{
    if (i == 3)
    {
        continue; // skip the rest of this run and go to 4
    }

    if (i == 6)
    {
        break; // leave the loop completely
    }

    Console.WriteLine(i);
}
```

This prints 1, 2, 4, 5.

## Random numbers

```csharp
int secret = Random.Shared.Next(1, 101);
```

This gives a number from 1 to 100. **The upper limit isn't included**, which is why it's 101.

## Exercise: number guessing game

1. Pick a secret number from 1 to 100.
2. Keep asking for a guess until the player gets it.
3. After each wrong guess, print `Too high` or `Too low`.
4. Count the guesses, and print the total when the player wins.

**Hint:** you need one `int` for the guess and one for the count. Declare them before the loop.

While testing, print `secret` at the start so you know the answer, and remove that line when you're done.

| Secret | Input | Expected result |
|---|---|---|
| 50 | 75 | Too high |
| 50 | 25 | Too low |
| 50 | 50 | You win, 3 guesses |

**Bonus 1:** give the player only 7 guesses, then reveal the number.

**Bonus 2:** ask `Play again?` at the end, using `do`/`while` around the whole game.

## Check yourself

1. When would you pick `while` over `for`?
2. What's the difference between `while` and `do`/`while`?
3. What's the difference between `break` and `continue`?
4. Can `Random.Shared.Next(1, 10)` ever give 10?
5. How do you stop a program stuck in an infinite loop?

---

# Day 5: Methods

**Goal:** split your code into reusable, named pieces.

## Writing a method

```csharp
Greet("Alex");
int total = Add(2, 3);
Console.WriteLine(total);

void Greet(string name)
{
    Console.WriteLine($"Hi {name}");
}

int Add(int a, int b)
{
    return a + b;
}
```

- **Return type:** `void` returns nothing, and `int` promises to return an `int`.
- **Parameters:** `name`, `a` and `b` are the inputs. Each needs a type.
- **`return`:** this sends the answer back and ends the method immediately.
- **Top-level order:** put your main code first and your methods at the bottom. Local methods work anywhere in the file, but this order is tidier.

## Overloads and default values

Methods can share a name if their parameters differ:

```csharp
int Square(int n)
{
    return n * n;
}

double Square(double n)
{
    return n * n;
}
```

Note: real overloads go inside a class, which you'll do on Day 8. **In top-level code, this example gives error CS0128**, because local methods can't be overloaded. For now, use different names like `SquareInt` and `SquareDouble`.

Default values make a parameter optional:

```csharp
void Say(string text, int times = 1)
{
    for (int i = 0; i < times; i++)
    {
        Console.WriteLine(text);
    }
}
```

`Say("hi");` prints once, and `Say("hi", 3);` prints three times.

## Exercise: calculator

Write these methods: `Add`, `Subtract`, `Multiply` and `Divide`, each taking two `double`s and returning a `double`. Add `ReadNumber(string prompt)`, which prints the prompt and returns the parsed number.

Then ask for two numbers and an operator (`+`, `-`, `*`, `/`), use a switch expression to pick the method, and print the result to 2 decimal places.

| Input | Expected result |
|---|---|
| 6, +, 3 | 9.00 |
| 6, -, 3 | 3.00 |
| 6, *, 3 | 18.00 |
| 7, /, 2 | 3.50 |
| 6, /, 0 | See bonus |

Dividing a `double` by 0 doesn't crash. Run it and see what prints.

**Bonus:** make it print a clear error when dividing by 0.

## Check yourself

1. What does `void` mean?
2. What happens to code after a `return` in the same block?
3. What's the difference between a parameter and a local variable?
4. Why is `ReadNumber` better than repeating two lines each time?

---

# Day 6: Arrays and strings

**Goal:** work with lists of values and text.

## Arrays

```csharp
int[] scores = { 90, 75, 60 };

Console.WriteLine(scores[0]);     // 90: counting starts at 0
Console.WriteLine(scores.Length); // 3
scores[1] = 80;

int[] empty = new int[5];         // five zeros

foreach (int score in scores)
{
    Console.WriteLine(score);
}
```

An array's size is fixed. `scores[3]` here crashes with `IndexOutOfRangeException`, because the last index is `Length - 1`.

## Strings

```csharp
string text = "  Hello World  ";

Console.WriteLine(text.Trim());            // removes outer spaces
Console.WriteLine(text.ToLower());
Console.WriteLine(text.Contains("World")); // True
Console.WriteLine(text.Replace("World", "C#"));
Console.WriteLine(text.Trim().Length);     // 11
Console.WriteLine(text.Trim()[0]);         // H: a single char

string[] words = "one two three".Split(' ');
Console.WriteLine(words.Length);           // 3
```

Strings can't be changed. `text.ToUpper();` on its own does nothing useful, so store the result: `text = text.ToUpper();`.

`Trim()` would also have fixed your double-space problem on Day 3.

## `StringBuilder`

Use this when building text in a loop. It's faster than adding to a string over and over.

```csharp
using System.Text;

var builder = new StringBuilder();

for (int i = 0; i < 3; i++)
{
    builder.Append(i);
    builder.Append(' ');
}

Console.WriteLine(builder.ToString()); // 0 1 2
```

`using` lines go at the very top of the file.

## Exercise: text analyzer

Ask for a sentence, then print:
1. The number of characters.
2. The number of words.
3. The number of vowels (a, e, i, o, u), counting capitals too.
4. The sentence reversed. Use `StringBuilder` and a `for` loop counting down.

| Input | Characters | Words | Vowels | Reversed |
|---|---|---|---|---|
| `Hello World` | 11 | 2 | 3 | `dlroW olleH` |
| `C# is fun` | 9 | 3 | 2 | `nuf si #C` |

**Bonus:** say whether the input is a palindrome, ignoring capitals. `Level` should say yes.

## Check yourself

1. What's the index of the last item in an array of 10?
2. Why doesn't `text.ToUpper();` change `text`?
3. What's the difference between `'a'` and `"a"`?
4. When is `StringBuilder` worth using?

---

# Day 7: Project: console quiz game

No new topics today. You're combining everything, without a walkthrough.

## Requirements

1. Ask for the player's name, and use `Trim()` on it.
2. Store at least 5 questions in a `string[]`, with the correct answers in a second `string[]` at matching positions.
3. Loop through the questions and ask each one.
4. Compare answers while ignoring capitals and extra spaces.
5. Say whether each answer was right, and show the correct one if not.
6. At the end, print the score and percentage to 1 decimal place.
7. Print a rank using a switch expression: 100% is `Perfect`, 60% or above is `Passed`, and anything else is `Try again`.
8. Use at least 2 methods of your own, such as `AskQuestion` and `GetRank`.

## Watch out

- `score / total * 100` with two `int`s gives 0 for most scores, because of the `7 / 2` trap. Use `(double)score / total * 100`.
- If `GetRank` needs to return a result, its return type can't be `void`.

## Test it

| Scenario (5 questions) | Expected result |
|---|---|
| All correct | 100.0%, Perfect |
| 3 correct | 60.0%, Passed |
| 2 correct | 40.0%, Try again |
| All wrong | 0.0%, Try again |
| Answer typed as `  PARIS  ` when correct is `Paris` | Counts as correct |

## Bonus

- Ask whether to play again.
- Allow only numbers 1–4 for multiple-choice answers, and ask again for anything else.

**Well done: that's Week 1. Check [REWARDS.md](REWARDS.md) for your milestone reward.**
