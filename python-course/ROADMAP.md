# Roadmap: Days 8–30

Each day lists what to learn, the main ideas, and what to build. Read the linked topic in the [official tutorial](https://docs.python.org/3/tutorial/) for the details. Searching `Python <topic name>` also works well.

## Week 2: Data structures, functions and OOP

**Day 8: Dictionaries.** Look up values by a key instead of a position. Learn `d[key]`, `d.get(key, default)`, `in`, `del`, and looping with `.items()`.
```python
ages = {"Alex": 20, "Sam": 25}
ages["Jo"] = 31
for name, age in ages.items():
    print(name, age)
```
**Build:** a contact book with add, find, delete and list, in a menu loop.

**Day 9: Tuples, sets and comprehensions.** Tuples are lists that can't change. Sets have no duplicates. Comprehensions build a list in one line.
```python
squares = [n * n for n in range(10) if n % 2 == 0]
```
**Build:** read a paragraph and print the unique words, sorted, with a count of each. Use a set and a dict comprehension.

**Day 10: Functions, deeper.** Learn scope (local vs. global), `*args` and `**kwargs`, returning several values as a tuple, and `lambda`. Pass functions to `sorted(key=...)`, `map` and `filter`.
**Build:** sort a list of `(name, score)` tuples by score, then by name. Write a `stats(*numbers)` function that returns min, max and average.

**Day 11: Classes and objects.** A class is a blueprint, and an object is one thing made from it. Learn `__init__`, `self`, attributes and methods.
```python
class BankAccount:
    def __init__(self, owner, balance=0):
        self.owner = owner
        self.balance = balance

    def deposit(self, amount):
        self.balance += amount
```
**Build:** `BankAccount` with `deposit`, `withdraw` and `__str__`. Make two accounts and show that they keep separate balances.

**Day 12: Inheritance and dunder methods.** Learn `class Manager(Employee)`, `super().__init__()`, overriding methods, and `__repr__`, `__eq__` and `__lt__`. Use `@property` to protect data.
**Build:** `Employee` with `calculate_pay()`, then `Manager` and `Intern`, which each override it. Make `BankAccount.balance` a read-only property, and reject negative deposits.

**Day 13: Exceptions.** Learn `try`, `except`, `else`, `finally` and `raise`. This is the proper fix for the `abc` crash from Day 2.
```python
try:
    number = int(input("Number? "))
except ValueError:
    print("Not a number")
```
**Build:** a `read_int(prompt)` function that keeps asking until the input is valid. Add a custom `InsufficientFundsError` to `BankAccount`.

**Day 14: Project: library management system.** `Book` and `Member` classes, and a `Library` class. Support adding books, borrowing, returning and listing. A book that's already borrowed can't be borrowed again. Use a console menu in a loop, and handle bad input without crashing.

## Week 3: Real-world Python

**Day 15: Files.** Learn `with open(...) as f`, the modes `"r"`, `"w"` and `"a"`, `.read()`, looping over lines, and `pathlib.Path`.
**Build:** a journal that appends a dated line to a text file, and can print every entry.

**Day 16: JSON and CSV.** Learn `json.dump`, `json.load` and the `csv` module. Dicts and lists map straight to JSON.
**Build:** save the contact book from Day 8 to JSON, and load it on startup. Export it to CSV, and open the CSV in a spreadsheet.

**Day 17: Modules and packages.** Split code into several files and `import` between them. Learn `if __name__ == "__main__":`, and how a folder becomes a package.
**Build:** move the library system's classes into `models.py`, and keep the menu in `main.py`.

**Day 18: The standard library.** Learn `datetime`, `collections` (`Counter`, `defaultdict`), `itertools`, `os`, `sys.argv` and `argparse`.
**Build:** a command-line tool: `python count.py file.txt --top 5` prints the five most common words.

**Day 19: Virtual environments and pip.** Learn `python -m venv`, `pip install`, `pip freeze > requirements.txt`, and why Arch blocks system-wide installs. See [SETUP.md](SETUP.md).
**Build:** install `rich` in a venv, and print a coloured table of your library's books.

**Day 20: Dataclasses, typing and iterators.** Learn `@dataclass`, type hints with `list[str]` and `str | None`, generators with `yield`, and running `mypy` to check types.
**Build:** rewrite `Book` as a dataclass. Write a generator that reads a big file one line at a time.

**Day 21: Project: expense tracker.** Add, list and delete expenses, with totals per category and per month. Save to JSON and load it on startup. Close the program, reopen it, and check that the data is still there. This is also a good time to build your rewards tracker.

## Week 4: Professional tools

**Day 22: HTTP and APIs.** Learn `requests.get`, status codes, `.json()`, and timeouts.
**Build:** a weather app using the free [Open-Meteo API](https://open-meteo.com/), which needs no key. Handle network failures and a city that doesn't exist.

**Day 23: Async.** Learn `async def`, `await`, `asyncio.run`, `asyncio.gather` and `asyncio.sleep`.
**Build:** simulate 3 slow downloads with `asyncio.sleep`. Time them one after another and then together.

**Day 24: Testing.** Install `pytest`, write `test_*.py` files with plain `assert`, and learn `pytest.raises` and `@pytest.mark.parametrize`.
**Build:** tests for the expense tracker, including boundaries and bad input.

**Day 25: Databases.** Learn basic SQL (`SELECT`, `INSERT`, `UPDATE`, `DELETE`) with the built-in `sqlite3` module. Always use `?` placeholders, never f-strings, in SQL.
**Build:** move the expense tracker from JSON to SQLite.

**Day 26: Code quality.** Learn `ruff` for linting and formatting, docstrings, and PEP 8. Set up `pyproject.toml`.
**Build:** run `ruff check` and `ruff format` on all your code, and fix every warning.

**Day 27: Web APIs with FastAPI.** Install `fastapi` and `uvicorn`. Learn `@app.get` and `@app.post`, path and query parameters, Pydantic models, and status codes (200, 201, 404, 422).
**Build:** a to-do REST API. Test it with `curl` and with the docs page at `/docs`.

## Final stretch: capstone

**Day 28: Design.** Split the project into routes, services and a database layer. Learn FastAPI dependencies with `Depends`.
**Build:** the task manager API's data model, SQLite database and project structure.

**Day 29: Finish the features.** Add full create, read, update and delete, filtering by status, validation with clear errors, and tests using FastAPI's `TestClient`.

**Day 30: Ship it.** Add logging and settings from environment variables, write a good README, and push it to GitHub.

**That's the course. Claim your Day 30 prize!**
