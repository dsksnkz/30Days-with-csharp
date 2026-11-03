# Roadmap: Days 8–30

Each day lists what to learn, the main ideas, and what to build. Read the linked topic on [Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/csharp/) for the details. Searching `C# <topic name>` also works well.

From now on, classes usually go in their own file, named after the class.

## Week 2: Object-oriented programming

**Day 8: Classes and objects.** A class is a blueprint, and an object is one thing made from it. Learn fields, methods and constructors.
```csharp
class BankAccount
{
    private decimal balance;

    public BankAccount(decimal startingBalance)
    {
        balance = startingBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
```
**Build:** `BankAccount` with `Deposit`, `Withdraw` and an owner name. Make two accounts and show that they keep separate balances.

**Day 9: Properties and encapsulation.** Learn `public` vs. `private`, and `{ get; private set; }`. Hide data so that only the class can change it.
**Build:** make `BankAccount` reject negative deposits and any withdrawal larger than the balance. Test with 0, a negative amount, and exactly the full balance.

**Day 10: Inheritance.** Learn `class Manager : Employee`, plus `virtual`, `override` and `base`.
**Build:** `Employee` with `CalculatePay()`, then `Manager` and `Intern`, which each override it.

**Day 11: Interfaces and polymorphism.** An interface is a promise of what a class can do. Code can use `IPayment` without knowing which class it has.
**Build:** an `IPayment` interface with `Pay(decimal amount)`, then `CardPayment` and `CashPayment`. Loop through an array of `IPayment`.

**Day 12: Abstract classes, `static` and enums.** An abstract class can't be created directly. `static` members belong to the class rather than to an object. Enums are named options.
**Build:** abstract `Shape` with `Area()`, then `Circle` and `Rectangle`. Add a static counter of the shapes created.

**Day 13: Structs, records and nullable types.** Value types get copied, and reference types share one object. Records give you easy immutable data. Learn `string?`, `??` and `?.`, which finally explains warning CS8602 from Day 1.
**Build:** a `record Book(string Title, string Author)`. Show what `==` does on records vs. classes, and handle a `null` from `ReadLine()` with `??`.

**Day 14: Project: library management system.** `Book` and `Member` classes, and a `Library` class. Support adding books, borrowing, returning and listing. A book that's already borrowed can't be borrowed again. Use a console menu in a loop.

## Week 3: Writing real C#

**Day 15: Collections.** `List<T>` grows as needed, `Dictionary<K,V>` looks up by key, `HashSet<T>` has no duplicates, `Queue<T>` is first in, first out, and `Stack<T>` is last in, first out.
**Build:** a contact book with add, find, delete and list, using a `Dictionary`.

**Day 16: Generics.** Write one class that works with any type: `class Repository<T>`. Constraints limit which types are allowed: `where T : class`.
**Build:** `Repository<T>` with `Add`, `GetAll` and `Remove`, used with two different classes.

**Day 17: Exceptions.** Learn `try`, `catch` and `finally`, `throw`, and `int.TryParse`. This is the proper fix for the `abc` crash from Day 2.
```csharp
if (int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Not a number");
}
```
**Build:** a `ReadInt` method that keeps asking until the input is valid. Add a custom `InsufficientFundsException` to `BankAccount`.

**Day 18: Delegates, lambdas and events.** `Func<int, int>` and `Action<string>` hold methods in variables. A lambda is a short method: `x => x * 2`. Events let objects announce that something happened.
**Build:** a `Notifier` class with an event, and two subscribers that react differently.

**Day 19: LINQ basics.** Learn `Where`, `Select`, `OrderBy`, `First`, `Any` and `ToList`.
```csharp
var cheap = products.Where(p => p.Price < 10).OrderBy(p => p.Name).ToList();
```
**Build:** a list of 10 products, with search by name, a price filter and sorting.

**Day 20: Advanced LINQ.** Learn `GroupBy`, `Join`, `Sum`, `Average`, `Max` and `Count`.
**Build:** a sales report showing total per category, best seller and average order.

**Day 21: Project: expense tracker.** Add, list and delete expenses, with totals per category. Save to JSON with `System.Text.Json` and `File.WriteAllText`, and load it on startup. Close the program, reopen it, and check that the data is still there. This is also a good time to build your rewards tracker.

## Week 4: Professional tools

**Day 22: Async.** `async`, `await` and `Task` let your program wait without freezing. Learn `Task.WhenAll` and `Task.Delay`.
**Build:** simulate 3 slow downloads with `Task.Delay`. Time them run one after another and then together.

**Day 23: HTTP and NuGet.** Learn `HttpClient`, how to read JSON from an API, and `dotnet add package`.
**Build:** a weather app using the free [Open-Meteo API](https://open-meteo.com/), which needs no key. Handle network failures.

**Day 24: Modern C#.** Learn pattern matching with `is` and `when`, extension methods, and collection expressions.
**Build:** refactor your library system using what you learned, keeping its behavior the same.

**Day 25: Unit testing.** Run `dotnet new xunit`, then learn `[Fact]`, `[Theory]`, `Assert` and `dotnet test`.
**Build:** tests for the expense tracker, including boundaries and bad input.

**Day 26: Databases.** Learn basic SQL (`SELECT`, `INSERT`, `UPDATE`, `DELETE`), then Entity Framework Core with SQLite.
**Build:** move the expense tracker from JSON to a database.

**Day 27: Web APIs.** Run `dotnet new web`, then learn `MapGet` and `MapPost`, route parameters, and status codes (200, 201, 404, 400).
**Build:** a to-do REST API. Test it with `curl`.

## Final stretch: capstone

**Day 28: Design.** Learn dependency injection and how to split a project into endpoints, services and data.
**Build:** the task manager API's data model, database and project structure.

**Day 29: Finish the features.** Add full create, read, update and delete, filtering by status, validation with clear errors, and tests.

**Day 30: Ship it.** Add logging and configuration, run `dotnet publish`, write a good README, and push it to GitHub.

**That's the course. Claim your Day 30 prize!**
