# 30 Days of Python

A 30-day Python course, built to work with no AI help. Plan on 1–2 hours a day.

**Progress:** not started. **Next up: Day 1.**

## Where to go

| File | What it's for |
|---|---|
| [SETUP.md](SETUP.md) | Start here: install Python on Arch and run your first file |
| [WEEK1.md](WEEK1.md) | Full lessons for Days 1–7 |
| [ROADMAP.md](ROADMAP.md) | Goals, key ideas and exercises for Days 8–30 |
| [ERRORS.md](ERRORS.md) | What common Python errors mean and how to fix them |
| [REWARDS.md](REWARDS.md) | Points and rewards |
| [ONLINE.md](ONLINE.md) | Running Python in a browser |
| [prompt.md](prompt.md) | A tutor prompt that gives hints, never answers |
| [my-code/](my-code/) | The code you write, one folder per day |

## Getting stuck without AI

Work through these in order:

1. **Read the traceback from the bottom up.** The last line says what went wrong. The line above it says where.
2. **Look it up** in [ERRORS.md](ERRORS.md).
3. **Check the line above too.** A missing `)` or `:` is often reported on the next line.
4. **Use `print()`** to show your variables and see what they really hold. `print(type(x))` shows what kind of value it is.
5. **Try it in the REPL.** Type `python` and test one line at a time.
6. **Search the error message**, for example `Python TypeError can only concatenate str`. Good sources are the [official docs](https://docs.python.org/3/) and Stack Overflow.
7. **Still stuck after 20 minutes?** Write down the problem, move on, and bring it back later.

## Starting each day

```bash
mkdir -p ~/30Days-of-python/my-code/Day01 && cd ~/30Days-of-python/my-code/Day01
nvim lesson.py      # or any editor
python lesson.py
```

No project files and no compiling: a `.py` file is the whole program.

## The daily routine

1. **Learn (20–30 min):** read the lesson and run the examples.
2. **Build (45–60 min):** do the exercise without copying.
3. **Test:** run every test value, especially the boundaries.
4. **Break it (10 min):** change something, read the error, and fix it.
5. **Answer the check-yourself questions** from memory.
6. **Log it:** add your points in [REWARDS.md](REWARDS.md).

## Saving your work

From the repo folder:

```bash
git add . && git commit -m "Finish Day 1" && git push
```

To get this repo on another computer:

```bash
gh repo clone dsksnkz/30Days-of-python
```

## The plan

| Week | Topic | Project |
|---|---|---|
| 1 | Fundamentals | Console quiz game |
| 2 | Data structures, functions and OOP | Library management system |
| 3 | Files, JSON, modules, errors and the standard library | Expense tracker that saves its data |
| 4 | APIs, testing, databases and the web | To-do REST API |
| Days 28–30 | Putting it all together | Task manager API on GitHub |

## The site

`python3 site/build.py` rebuilds `docs/index.html`, a dark reader for these notes. Turn on GitHub Pages from the `docs/` folder to read it on your phone.
