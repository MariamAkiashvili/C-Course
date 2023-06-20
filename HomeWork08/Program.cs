// See https://aka.ms/new-console-template for more information
using HomeWork08.Task01;
using HomeWork08.Task02;


double numbSqrt = Calculator.Sqrt(40);
Console.WriteLine(numbSqrt);

double sum = Calculator.Add(40,-10);
Console.WriteLine(sum);

Console.ReadLine();



BankAccount bankAccount = new BankAccount("1111111");
Balance balance = new Balance();
balance.Currency = Currency.USD;
bankAccount.Balance = balance;
bankAccount.Deposit("USD", 150);

Console.WriteLine(bankAccount.BalanceCheck());

BankAccount bankAccount2 = new BankAccount("2222222");
Balance balance2 = new Balance();
balance2.Currency = Currency.GELL;
bankAccount2.Balance = balance2;
bankAccount2.Deposit("EUR", 150);

bankAccount.TransferFunds(bankAccount2, "USD", 10);

Console.WriteLine(bankAccount2.BalanceCheck());

Console.WriteLine(bankAccount.BalanceCheck());

Console.ReadLine();
