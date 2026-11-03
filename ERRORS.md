# Common errors

An error looks like this: `Program.cs(5,50): error CS1002: ; expected`. That's the file, line 5, column 50, the code, and the message.

**Fix the first error first.** One mistake can cause many errors further down, as you saw when CS1003 and CS8504 appeared together on Day 3. **Errors** stop the build, and **warnings** don't.

## Compiler errors

| Code | What it says | What it usually means | Fix |
|---|---|---|---|
| CS1002 | `; expected` | Missing semicolon | Add `;` at the end of that line or the one above |
| CS1003 | `',' expected` | Missing comma, often in a switch expression | Add a comma between the arms |
| CS1513 | `} expected` | A `{` was never closed | Match up your braces, and indenting helps |
| CS1525 | Invalid expression term | Something unfinished just before this point | Check the line above for a missing `;` |
| CS0103 | Name doesn't exist | A typo, wrong capitals, or out of scope | Check the spelling, and whether it's inside the right `{ }` |
| CS0117 | Doesn't contain a definition | Wrong capitals or name, like `Writeline` | Use the exact name: `WriteLine` |
| CS0128 | Already defined in this scope | You declared the same variable twice | Rename it, or drop the type to reassign |
| CS0136 | Name already used in an enclosing scope | You redeclared a variable inside a block | Drop the type: `grade = "A";` |
| CS0165 | Use of unassigned variable | Some path never gives it a value | Assign it in every branch, usually with a final plain `else` |
| CS0029 | Can't implicitly convert type | Wrong type, like `int x = "5";` | Use `int.Parse`, or fix the type |
| CS0266 | Can't implicitly convert (cast needed) | A conversion that could lose data, like `int x = 2.5;` | Add a cast, `(int)`, or use `double` |
| CS0161 | Not all code paths return a value | A method can finish without `return` | Add a `return` for every path |
| CS8510 | The pattern is unreachable | A switch arm can never match, like `>= 70` after `>= 60` | Put the largest or most specific check first |
| CS8802 | Only one file can have top-level statements | Two files contain loose code | Rename the extra file, or use a new project |
| CS8504 | Pattern missing | A switch arm is broken | Often caused by a missing comma: fix CS1003 first |

## Warnings

| Code | Meaning |
|---|---|
| CS0219 | A variable is assigned but never used. It's often a sign of a scope mistake or a typo. |
| CS8602 | You might be calling a method on `null`. This is covered on Day 13. |
| CS8604 | You might be passing `null` to something that needs a value. |

## Crashes while running

| Exception | Cause | Fix |
|---|---|---|
| `FormatException` | `int.Parse("abc")` | Use `TryParse` (Day 17) |
| `IndexOutOfRangeException` | An index past the end of an array | The last index is `Length - 1` |
| `NullReferenceException` | Using something that's `null` | Check for `null` first (Day 13) |
| `DivideByZeroException` | Dividing an `int` by 0 | Check before dividing |

## Compiles but gives the wrong answer

These are logic errors, so only testing finds them.

| Symptom | Likely cause |
|---|---|
| The boundary value is wrong | `>` where you meant `>=` |
| Everything gets the same grade | Checks are in the wrong order |
| A decimal result is missing | `int / int` |
| A loop never ends | The variable in the check never changes |
| A loop runs one time too many or too few | `<` vs. `<=` |
| A string doesn't change | You forgot to store the result: `text = text.Trim();` |
