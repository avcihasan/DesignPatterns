using AbstractFactoryPattern.Creator;
using AbstractFactoryPattern.Services;

IService service = new Service(new Creator1());
service.GetAll();

Console.WriteLine("-----------");

IService service2 = new Service(new Creator2());
service2.GetAll();

Console.Read();