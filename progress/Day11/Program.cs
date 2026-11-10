namespace Day11;
// Interfaces and polymorphism
// interface is like smth that would provide the inner logic for the actual method
// its like a socket, it only provides electricity when plugged.

// =================================
// #region 1: STARTING CODE
// =================================
#region entry

BankAccount acc1 = new BankAccount(300.00m); // tells Compiler using the 'BankAccount' blueprint create
BankAccount acc2 = new BankAccount(20.00m);	 // a 'new' variable 'acc1'.

Employee emp1 = new Employee("emp1", 100.00m);
Manager man1 = new Manager("manager", 200.00m, 50.00m);
Intern intern1 = new Intern("intern", 50.00m, 2);

acc1.Name = "acc1" ;
acc2.Name = "acc2" ;

acc1.Deposit(100.00m);
acc2.Spend(30.00m);

Console.WriteLine($"   acc1 balance: {acc1.GetBalance()}");
Console.WriteLine($"   acc2 balance: {acc2.GetBalance()}");
Console.WriteLine($"   Manager pays: {man1.calculatePay()}");
Console.WriteLine($"   Employee pays: {emp1.calculatePay()}");
Console.WriteLine($"   Intern pays: {intern1.calculatePay()}");

// =================================
// #region 2: CLASSES & METHODS
// =================================
#region bank classes & methods


static(string, decimal) GetPaymentInput()
{
    Console.Write("Paying using account: ");
    string payAccount = Console.ReadLine()!;

    Console.Write("Paying amount: ");
    decimal payAmount = Convert.ToDecimal(Console.ReadLine()!);

    if (payAccount == "acc1")
    {
        acc1.Spend(payAmount);
    }
    else if (payAccount == "acc2")
    {
        acc2.Spend(payAmount);
    }
    else
    {
        Console.WriteLine("Must be a valid account name!");
    }

    return
}

class BankAccount // new datatype called 'BankAccount'
{
	private decimal balance; // creates decimal balance, but only accessible in this class.

	public BankAccount(decimal startingBalance)
	{
		balance = startingBalance; // balance in acc is the starting / default amount
	}

	public void Deposit(decimal amount) // e.g
	{
		balance += amount; // basically `balance = balance + amount`
	}

	public void Spend(decimal amount)
	{
	    if (balance < amount)
		{
		Console.WriteLine($"You dont have enough money to subtract {amount} on account {Name}");
		}

		else
		{
		balance -= amount;
		}
	}

	public string Name{ get; set; } = "N/A account name";

	public decimal GetBalance()
	{
		return balance;
	}
}

class Employee
{
    public string Name{ get; set; }
    public decimal Salary{ get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public virtual decimal calculatePay() // virtual' allows child classes to change method
    {
        return Salary;
    }
}

class Manager : Employee
{
    public decimal Bonus{ get; set;}

    public Manager(string name, decimal salary, decimal bonus):base(name, salary)
    {
        Bonus = bonus;
    }

    public override decimal calculatePay()
    {
        return Salary + Bonus;
    }
}

class Intern : Employee
{
    public int paySplit{ get; set; }

    public Intern(string name, decimal salary, int PaySplit):base(name,salary)
    {
        paySplit = PaySplit;
    }

    public override decimal calculatePay()
    {
        return Salary / paySplit;
    }
}

public interface IPayment // interface for IPayment
{
    void Pay(decimal amount);
}

public class CardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Payment successful: ");
    }
}
