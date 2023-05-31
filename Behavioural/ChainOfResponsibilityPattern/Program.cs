using ChainOfResponsibilityPattern.Services.Concretes;

Manager manager = new();
VicePresident vicePresident = new();
President president = new();

manager.SetSuccessor(vicePresident);
vicePresident.SetSuccessor(president);

manager.HandleExpense(new() { Detail="xxxx",Amount=50});
manager.HandleExpense(new() { Detail = "xxxx", Amount = 500 });
manager.HandleExpense(new() { Detail = "xxxx", Amount = 5000 });

Console.ReadLine();