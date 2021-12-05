using ProtoClass;

var account = new Account(1, "Ivanov");
var account1 = account.Copy();
var account2 = (Account)account1.Clone();

Console.WriteLine($"Account {account}");
Console.WriteLine($"IMyCloneable {account1}");
Console.WriteLine($"ICloneable {account2}");
Console.WriteLine();

var credit = new CreditAccount(2, "Petrov", Int32.MaxValue);
var credit1 = credit.Copy();
var credit2 = (CreditAccount)credit1.Clone();

Console.WriteLine($"Account {credit}");
Console.WriteLine($"IMyCloneable {credit1}");
Console.WriteLine($"ICloneable {credit2}");
Console.WriteLine();

var deposit = new DepositAccount(3, "Sidorov", Int32.MinValue);
var deposit1 = deposit.Copy();
var deposit2 = (DepositAccount)deposit1.Clone();

Console.WriteLine($"Account {deposit}");
Console.WriteLine($"IMyCloneable {deposit1}");
Console.WriteLine($"ICloneable {deposit2}");
Console.WriteLine();