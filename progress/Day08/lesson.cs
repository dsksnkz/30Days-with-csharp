// object oriented programming
// NOTES:
// creating a datatype called `BankAccount` that stores money in a 'decimal'

Console.Clear();

BankAccount acc1 = new BankAccount(300.00m); // tells Compiler using the 'BankAccount' blueprint create
BankAccount acc2 = new BankAccount(20.00m);	 // a 'new' variable 'acc1'.

											
acc1.Deposit(100.00m);
acc2.Spend(10.00m);

Console.WriteLine($"   acc1 balance: {acc1.GetBalance()}");
Console.WriteLine($"   acc2 balance: {acc2.GetBalance()}");

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
		balance -= amount;
	}

	public decimal GetBalance()
	{
		return balance;
	}

}

