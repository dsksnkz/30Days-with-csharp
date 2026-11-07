# Week 1: Days 1–7

Do [SETUP.md](SETUP.md) first.

---

# Day 1: Printing, variables and input

**Goal:** a program that asks questions and answers back.

## `print`

```python
print("Hello")
print("A", "B", "C")        # A B C: commas add spaces
print("A", end="")          # stays on the same line
print("B")                  # AB
```

## Variables

```python
name = "Alex"
age = 20
height = 1.75
is_student = True
```

You don't write a type. Python works it out from the value. `type(age)` shows it: `<class 'int'>`.

Names use `snake_case`: lowercase with underscores. They can't start with a digit, and `Name` and `name` are different variables.

## `input`

```python
name = input("What's your name? ")
print("Hi", name)
```

`input()` **always gives back a string**, even if you type `20`. Keep that in mind for Day 2.

## f-strings

```python
name = "Alex"
age = 20
print(f"{name} is {age} years old")
```

The `f` before the quote lets you put variables inside `{ }`.

## Comments

```python
# Python ignores everything after a hash.
```

## Exercise: about me

Ask for the user's name, favorite food and home town. Then print one sentence using all three with an f-string.

| Input | Expected result |
|---|---|
| Alex, pizza, Leeds | `Alex from Leeds loves pizza.` |

**Bonus:** print the same sentence in a box of `*` characters. Hint: `"*" * 10` gives ten stars.

## Check yourself

1. What does `input()` always give back?
2. What does `end=""` do in `print`?
3. Why does `print(f"{name}")` work but `print("{name}")` doesn't?
4. Are `Score` and `score` the same variable?

---

# Day 2: Numbers and converting types

**Goal:** a tip calculator.

## Maths

```python
print(7 + 2)    # 9
print(7 - 2)    # 5
print(7 * 2)    # 14
print(7 / 2)    # 3.5: always a float
print(7 // 2)   # 3: whole-number division
print(7 % 2)    # 1: the remainder
print(2 ** 3)   # 8: power
```

Unlike C#, `7 / 2` gives `3.5`. Use `//` when you want to drop the decimal.

## Converting

```python
age = int(input("Age? "))        # text to whole number
price = float(input("Price? "))  # text to decimal
text = str(42)                   # number to text
```

Typing `abc` into `int(...)` crashes with `ValueError`. You'll learn to handle that on Day 13.

`int(4.9)` gives `4`. It cuts off, it doesn't round. Use `round(4.9)` to round.

## The `str + int` trap

```python
age = 20
print("Age: " + age)       # TypeError
print("Age: " + str(age))  # works
print(f"Age: {age}")       # works, and nicer
```

## Formatting decimals

```python
total = 10 / 3
print(f"{total:.2f}")   # 3.33
```

## Exercise: tip calculator

Ask for the bill amount, the tip percentage and the number of people. Print the tip, the total and what each person pays, all to 2 decimal places.

| Bill | Tip % | People | Tip | Total | Each |
|---|---|---|---|---|---|
| 100 | 10 | 2 | 10.00 | 110.00 | 55.00 |
| 50 | 15 | 3 | 7.50 | 57.50 | 19.17 |
| 80 | 0 | 1 | 0.00 | 80.00 | 80.00 |

**Bonus:** try 0 people. Read the error, and write down what it's called.

## Check yourself

1. What's the difference between `/` and `//`?
2. What does `10 % 3` give?
3. Why does `"5" + 5` fail?
4. What does `int(7.99)` give?

---

# Day 3: Decisions

**Goal:** a grade calculator.

## `if`, `elif`, `else`

```python
score = int(input("Score? "))

if score >= 90:
    print("A")
elif score >= 80:
    print("B")
else:
    print("Keep going")
```

- The line ends with a **colon**.
- The code inside is **indented 4 spaces**. That's how Python knows where the block ends. There are no `{ }`.
- The **first match wins**, so put the largest check first.

## Comparisons and logic

```python
x == 5     # equal (= assigns, == compares)
x != 5     # not equal
x >= 5     # also <, >, <=
age >= 13 and age <= 19
day == "Sat" or day == "Sun"
not is_raining
13 <= age <= 19          # Python lets you chain these
```

## `match`

Good for picking from fixed options:

```python
command = input("Command? ")

match command:
    case "start":
        print("Starting")
    case "stop" | "quit":
        print("Stopping")
    case _:
        print("Unknown command")
```

`case _` catches everything else, like `default` in other languages.

## Exercise: grade calculator

Ask for a score from 0 to 100 and print the grade: 90+ is `A`, 80+ is `B`, 70+ is `C`, 60+ is `D`, and anything lower is `F`. Print `Invalid` for anything below 0 or above 100.

| Input | Expected result |
|---|---|
| 95 | A |
| 90 | A |
| 89 | B |
| 60 | D |
| 59 | F |
| 0 | F |
| 101 | Invalid |
| -5 | Invalid |

**Bonus:** ask for a country and print its capital using `match`, with at least 4 countries and a message for unknown ones. Make it work whatever capitals the user types. Hint: `.lower()`.

## Check yourself

1. What happens if you forget the colon after `if`?
2. Why must `>= 90` come before `>= 80`?
3. What's the difference between `=` and `==`?
4. What does `case _` do?

---

# Day 4: Loops

**Goal:** a number guessing game.

## `for` with `range`

```python
for i in range(1, 6):
    print(i)        # 1 to 5
```

`range(1, 6)` stops **before** 6. `range(5)` gives 0 to 4. `range(0, 10, 2)` gives 0, 2, 4, 6, 8.

## `for` over anything

```python
for letter in "cat":
    print(letter)
```

## `while`

```python
lives = 3

while lives > 0:
    print(f"Lives: {lives}")
    lives -= 1
```

If you forget `lives -= 1`, it never ends. Press **Ctrl+C** to stop it.

Python has no `do`/`while`. Use `while True:` with `break` instead:

```python
while True:
    answer = input("Type yes: ")
    if answer == "yes":
        break
```

## `break` and `continue`

```python
for i in range(1, 11):
    if i == 3:
        continue    # skip to 4
    if i == 6:
        break       # leave the loop
    print(i)        # 1 2 4 5
```

## Random numbers

```python
import random

secret = random.randint(1, 100)
```

`randint` **includes both ends**, so this can give 1 or 100. That's the opposite of `range`.

`import` lines go at the top of the file.

## Exercise: number guessing game

1. Pick a secret number from 1 to 100.
2. Keep asking for a guess until the player gets it.
3. After each wrong guess, print `Too high` or `Too low`.
4. Count the guesses, and print the total when the player wins.

While testing, print `secret` at the start, and remove that line when you're done.

| Secret | Input | Expected result |
|---|---|---|
| 50 | 75 | Too high |
| 50 | 25 | Too low |
| 50 | 50 | You win, 3 guesses |

**Bonus 1:** give the player only 7 guesses, then reveal the number.

**Bonus 2:** ask `Play again?` at the end, with a loop around the whole game.

## Check yourself

1. What numbers does `range(2, 5)` give?
2. Can `random.randint(1, 10)` give 10?
3. How do you get the effect of a `do`/`while` in Python?
4. What's the difference between `break` and `continue`?

---

# Day 5: Functions

**Goal:** split your code into reusable, named pieces.

## Writing a function

```python
def greet(name):
    print(f"Hi {name}")

def add(a, b):
    return a + b

greet("Alex")
total = add(2, 3)
print(total)
```

- `def`, the name, the parameters, then a colon and an indented body.
- **Define functions before you call them.** Python runs top to bottom, so calling `greet` above its `def` gives `NameError`.
- `return` sends a value back and ends the function at once. A function with no `return` gives back `None`.

## Default and keyword arguments

```python
def say(text, times=1):
    for _ in range(times):
        print(text)

say("hi")
say("hi", 3)
say(times=2, text="hey")   # named, so order doesn't matter
```

`_` is the usual name for a loop variable you don't use.

## Type hints

Optional, but they make code easier to read:

```python
def add(a: float, b: float) -> float:
    return a + b
```

Python doesn't check them when it runs. They're notes for you and your editor.

## Exercise: calculator

Write `add`, `subtract`, `multiply` and `divide`, each taking two numbers and returning the result. Write `read_number(prompt)`, which asks with the prompt and returns a `float`.

Then ask for two numbers and an operator (`+`, `-`, `*`, `/`), use `match` to pick the function, and print the result to 2 decimal places.

| Input | Expected result |
|---|---|
| 6, +, 3 | 9.00 |
| 6, -, 3 | 3.00 |
| 6, *, 3 | 18.00 |
| 7, /, 2 | 3.50 |
| 6, /, 0 | See bonus |

Unlike C#, dividing by 0 crashes. Run it and read the error.

**Bonus:** print a clear error instead of crashing when dividing by 0.

## Check yourself

1. What does a function give back if it has no `return`?
2. What happens to code after `return` in the same function?
3. Why can't you call a function above its `def`?
4. Why is `read_number` better than repeating `float(input(...))`?

---

# Day 6: Lists and strings

**Goal:** work with groups of values and text.

## Lists

```python
scores = [90, 75, 60]

print(scores[0])      # 90: counting starts at 0
print(scores[-1])     # 60: negative counts from the end
print(len(scores))    # 3
scores[1] = 80
scores.append(100)    # add to the end
scores.remove(60)     # remove by value
print(sum(scores), max(scores), min(scores))

for score in scores:
    print(score)

for i, score in enumerate(scores):
    print(i, score)
```

Unlike a C# array, a list can grow. `scores[10]` still crashes with `IndexError`.

## Slicing

```python
letters = ["a", "b", "c", "d", "e"]
print(letters[1:3])   # ['b', 'c']: stops before 3
print(letters[:2])    # ['a', 'b']
print(letters[::-1])  # reversed
```

Slicing works on strings too.

## Strings

```python
text = "  Hello World  "

print(text.strip())            # removes outer spaces
print(text.lower())
print("World" in text)         # True
print(text.replace("World", "Python"))
print(len(text.strip()))       # 11
print(text.strip()[0])         # H

words = "one two three".split()
print(len(words))              # 3
print("-".join(words))         # one-two-three
```

Strings can't be changed. `text.upper()` on its own does nothing useful, so store it: `text = text.upper()`.

## Exercise: text analyzer

Ask for a sentence, then print:
1. The number of characters.
2. The number of words.
3. The number of vowels (a, e, i, o, u), counting capitals too.
4. The sentence reversed, using a `for` loop that builds a new string. Then do it again with a slice and check they match.

| Input | Characters | Words | Vowels | Reversed |
|---|---|---|---|---|
| `Hello World` | 11 | 2 | 3 | `dlroW olleH` |
| `Python is fun` | 13 | 3 | 3 | `nuf si nohtyP` |

**Bonus:** say whether the input is a palindrome, ignoring capitals. `Level` should say yes.

## Check yourself

1. What's `scores[-1]`?
2. What does `"hello"[1:4]` give?
3. Why doesn't `text.upper()` change `text`?
4. What's the difference between `split()` and `join()`?

---

# Day 7: Project: console quiz game

No new topics today. You're combining everything, without a walkthrough.

## Requirements

1. Ask for the player's name, and use `strip()` on it.
2. Store at least 5 questions in a list, with the answers in a second list at matching positions.
3. Loop through the questions and ask each one.
4. Compare answers while ignoring capitals and extra spaces.
5. Say whether each answer was right, and show the correct one if not.
6. At the end, print the score and percentage to 1 decimal place.
7. Print a rank: 100% is `Perfect`, 60% or above is `Passed`, and anything else is `Try again`.
8. Use at least 2 functions of your own, such as `ask_question` and `get_rank`.

## Watch out

- `get_rank` needs to `return` the rank, not `print` it, if you want to use it in an f-string.
- Use `zip(questions, answers)` to loop over both lists together, or `range(len(questions))`.

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
- Make it multiple choice. Only allow 1–4, and ask again for anything else. Hint: `.isdigit()`.

**Well done: that's Week 1. Check [REWARDS.md](REWARDS.md) for your milestone reward.**
