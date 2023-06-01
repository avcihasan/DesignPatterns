using StatePattern.Contexts;
using StatePattern.Services.Concretes;

Context context = new();

ModifiedState modifiedState = new();
modifiedState.DoAction(context);
Console.WriteLine(context.GetState().State);

AddedState addedState = new();
addedState.DoAction(context);
Console.WriteLine(context.GetState().State);

DeletedState deletedState= new();
deletedState.DoAction(context);
Console.WriteLine(context.GetState().State);


Console.ReadLine();
