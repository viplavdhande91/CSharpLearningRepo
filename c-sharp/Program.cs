using Facade;
using System.Numerics;

Console.Title = "Facade Pattern";
BankAccountCreationFacade accountCreationFacade = new BankAccountCreationFacade();
accountCreationFacade.CreateAccounts("John Doe" , "savings");


Console.ReadKey();