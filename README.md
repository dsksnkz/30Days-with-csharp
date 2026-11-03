# 30 Days with C#

A 30-day C# course, built to work with no AI help. Plan on 1–2 hours a day.

**Progress:** Days 1–3 done. **Next up: Day 4.**

## Where to go

| File | What it's for |
|---|---|
| [REVISION.md](REVISION.md) | Start here: quiz on Days 1–3, with answers |
| [WEEK1.md](WEEK1.md) | Full lessons for Days 4–7 |
| [ROADMAP.md](ROADMAP.md) | Goals, key ideas and exercises for Days 8–30 |
| [ERRORS.md](ERRORS.md) | What common compiler errors mean and how to fix them |
| [REWARDS.md](REWARDS.md) | Points and rewards |
| [my-code/](my-code/) | The code you've written so far |

## Getting stuck without AI

Work through these in order:

1. **Read the error.** Note the file, the line and column, and the error code.
2. **Look it up** in [ERRORS.md](ERRORS.md).
3. **Check the line above too.** A missing `;` or `}` is often reported one line late.
4. **Use `Console.WriteLine`** to print your variables and see what they really hold.
5. **Search the error code**, for example `C# CS0165`. Good sources are [Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/csharp/) and Stack Overflow.
6. **Still stuck after 20 minutes?** Write down the problem, move on, and bring it back later.

## If the computer has no .NET

See [ONLINE.md](ONLINE.md) to run your code in a browser.

If you can't get online either, write the code on paper and trace it by hand. It's great practice.

## Starting each day

```bash
cd ~ && dotnet new console -o Day04 && cd Day04
```

Only one file in a project can have top-level code. Rename old experiments so they don't end in `.cs`, or use a new project.

## The daily routine

1. **Learn (20–30 min):** read the lesson and run the examples.
2. **Build (45–60 min):** do the exercise without copying.
3. **Test:** run every test value, especially the boundaries.
4. **Break it (10 min):** change something, read the error, and fix it.
5. **Answer the check-yourself questions** from memory.
6. **Log it:** add your points in [REWARDS.md](REWARDS.md).

## Saving your work

Copy your project into `my-code/` first, then run this from the repo folder:

```bash
git add . && git commit -m "Finish Day 4" && git push
```

To get this repo on another computer:

```bash
gh repo clone dsksnkz/30Days-with-csharp
```

## The plan

| Week | Topic | Project |
|---|---|---|
| 1 | Fundamentals | Console quiz game |
| 2 | Object-oriented programming | Library management system |
| 3 | Collections, generics, LINQ, files | Expense tracker that saves its data |
| 4 | Async, APIs, testing, databases, web | To-do REST API |
| Days 28–30 | Putting it all together | Task manager API on GitHub |
