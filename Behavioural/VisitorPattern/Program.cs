using VisitorPattern.Entities;
using VisitorPattern.Services.Concretes;

Manager manager1 = new() { Name = "Manager1", Salary = 1000 };
Manager manager2 = new() { Name = "Manager2", Salary = 1300 };

Worker worker1 = new() { Name = "Worker1", Salary = 750 };
Worker worker2 = new() { Name = "Worker2", Salary = 850 };

manager1.Subordinates.Add(manager2);
manager2.Subordinates.Add(worker1);
manager2.Subordinates.Add(worker2);

OrganisationalStructure organisationalStructure = new(manager1);

PayrollVisitor payrollVisitor = new();
PayriseVisitor payriseVisitor=new();

organisationalStructure.Accept(payrollVisitor);
organisationalStructure.Accept(payriseVisitor);

Console.ReadLine();
