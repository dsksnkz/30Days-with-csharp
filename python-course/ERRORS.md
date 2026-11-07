# Common errors

An error in Python is called a **traceback**:

```
Traceback (most recent call last):
  File "/home/you/Day02/tip.py", line 3, in <module>
    total = bill + tip
            ~~~~~^~~~~
TypeError: unsupported operand type(s) for +: 'int' and 'str'
```

**Read it from the bottom up.** The last line is the error type and message. The lines above show the file, the line number, and the code that broke.

Unlike C#, Python finds most errors only **when that line runs**. Code in an `if` branch you never take can hide a bug, so test every path.

## Errors before anything runs

| Error | What it usually means | Fix |
|---|---|---|
| `SyntaxError: expected ':'` | Missing colon after `if`, `for`, `while`, `def` or `class` | Add `:` at the end of the line |
| `SyntaxError: '(' was never closed` | A bracket isn't closed | Count your brackets. The real mistake is often on the line above |
| `SyntaxError: invalid syntax. Maybe you meant '==' ...` | `=` inside an `if` | Use `==` to compare |
| `SyntaxError: unterminated string literal` | A missing closing quote | Add the quote |
| `IndentationError: expected an indented block` | Nothing indented after a line ending in `:` | Indent the body 4 spaces |
| `IndentationError: unexpected indent` | A line is indented when it shouldn't be | Line it up with the code around it |
| `TabError: inconsistent use of tabs and spaces` | You mixed tabs and spaces | Set your editor to always insert 4 spaces |

## Errors while running

| Error | Example cause | Fix |
|---|---|---|
| `NameError: name 'x' is not defined` | A typo, wrong capitals, or using it before it's created | Check spelling, and put `def` above the call |
| `TypeError: can only concatenate str (not "int") to str` | `"Age: " + 20` | Use an f-string, or `str(20)` |
| `TypeError: unsupported operand type(s)` | Maths on a string from `input()` | Convert with `int()` or `float()` |
| `TypeError: f() missing 1 required positional argument` | Calling a function with too few arguments | Pass every argument, or give it a default |
| `TypeError: 'NoneType' object is not subscriptable` | Using the result of a function that has no `return` | Add a `return` |
| `ValueError: invalid literal for int()` | `int("abc")` or `int("2.5")` | Use `try`/`except` (Day 13), or `float()` first |
| `IndexError: list index out of range` | `items[5]` on a 5-item list | The last index is `len(items) - 1` |
| `KeyError: 'Sam'` | A dict has no such key | Check with `in`, or use `.get()` |
| `AttributeError: 'str' object has no attribute 'push'` | The method doesn't exist for that type | Check the name: lists use `append` |
| `ZeroDivisionError: division by zero` | Dividing by 0 | Check before dividing |
| `ModuleNotFoundError: No module named 'requests'` | The package isn't installed, or your venv isn't active | `source .venv/bin/activate`, then `pip install` |
| `RecursionError: maximum recursion depth exceeded` | A function calls itself forever | Add a stopping case |
| `error: externally-managed-environment` | `pip install` outside a venv on Arch | Use a venv. See [SETUP.md](SETUP.md) |

## Runs but gives the wrong answer

These are logic errors, so only testing finds them.

| Symptom | Likely cause |
|---|---|
| The boundary value is wrong | `>` where you meant `>=` |
| Everything gets the same grade | Checks are in the wrong order |
| `"5" + "5"` gives `55` | You forgot to convert `input()` |
| A loop never ends | The variable in the check never changes |
| A loop runs one time too many or too few | `range` stops before its end value |
| A string doesn't change | You forgot to store the result: `text = text.strip()` |
| Code after a loop runs inside it | It's indented one level too far |
| A function prints `None` | It uses `print` instead of `return` |
| Changing one list changes another | `b = a` shares the list. Use `b = a.copy()` |
