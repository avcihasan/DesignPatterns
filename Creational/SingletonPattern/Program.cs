using SingletonPattern.Entities;

Product p = Product.GetInstance();
Product p2 = Product.GetInstance2;

Console.WriteLine($"Name : {p.Name} \nPrice : {p.Price}");
Console.WriteLine($"Name : {p2.Name} \nPrice : {p2.Price}");

