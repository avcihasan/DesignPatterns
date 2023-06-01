using MementoPattern.Entities;

User user = new() { Name="deneme",Surname="deneme",Password="deneme"};
Console.WriteLine("Name : {0} , Surname : {1} , Password : {2}",user.Name,user.Surname,user.Password);

CareTaker careTaker= new();
careTaker.Memento = user.CreateUndo();

user.Name = "DENEME";

Console.WriteLine("Name : {0} , Surname : {1} , Password : {2}", user.Name, user.Surname, user.Password);

user.RestoreFromUndo(careTaker.Memento);

Console.WriteLine("Name : {0} , Surname : {1} , Password : {2}", user.Name, user.Surname, user.Password);


Console.ReadLine();