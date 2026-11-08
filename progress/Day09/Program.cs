// object oriented programming DAY09
Console.Clear();

BankAccount acc1 = new BankAccount(300.00m); // tells Compiler using the 'BankAccount' blueprint create
BankAccount acc2 = new BankAccount(20.00m);	 // a 'new' variable 'acc1'.
acc1.Name = "acc1" ;
acc2.Name = "acc2" ;


acc1.Deposit(100.00m);
acc2.Spend(30.00m);

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
