# Running C# online

Use this when the computer doesn't have .NET.

## 1. Pick a site

- [OneCompiler](https://onecompiler.com/csharp): simple, and you enter input before running.
- [dotnetfiddle](https://dotnetfiddle.net): set **Compiler** to the newest .NET version in the left panel.
- [Programiz](https://www.programiz.com/csharp-programming/online-compiler/): another option if those are blocked.

## 2. Use this template every time

Delete whatever the site starts with, and paste this:

```csharp
using System;

class Program
{
    static void Main()
    {
        // your code goes here
    }
}
```

Write your code inside `Main`, between its `{ }`. For example:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("What's your name? ");
        string name = Console.ReadLine();

        Console.WriteLine($"Hi {name}");
    }
}
```

## 3. Your own methods

Put them inside `class Program`, next to `Main`, and add `static` in front:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Add(2, 3));
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}
```

## 4. Typing input

On OneCompiler, your program can't stop and wait for you to type. Put your answers in the **STDIN** box before pressing Run, one per line:

```
Alex
95
```

This means you have to decide every answer in advance. For games like Day 4's guessing game, enter your guesses in advance or finish it on your laptop.

## Differences from your laptop

| On your laptop | On these sites |
|---|---|
| `using System;` is added for you | You have to write it |
| Code can sit loose in the file | Code goes inside `Main` |
| You run `dotnet run` | You press Run |

## Common errors online

| Error | Fix |
|---|---|
| `The name 'Console' does not exist` | Add `using System;` at the very top |
| `Unexpected symbol 'Console'` | Put your code inside `Main`, and check the line above for a missing `;` |
| `; expected` | Add the missing `;` |

Newer C# features may not work on an older online compiler. If code from the notes fails but looks right, try another site or your laptop.

Remember to copy your code somewhere before closing the tab, or it may be lost.
