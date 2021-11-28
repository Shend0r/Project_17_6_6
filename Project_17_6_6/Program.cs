// See https://aka.ms/new-console-template for more information

using Project_17_6_6;

Account account = new Account();
account.Type = "default";
account.Balance = 5000;
account.Interest = 0;

Calculator Calculator = new Calculator();
Calculator.CalculateIntrested(account);
