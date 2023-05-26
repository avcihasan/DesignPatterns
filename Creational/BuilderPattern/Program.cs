using BuilderPattern.Builders;
using BuilderPattern.Director;
using BuilderPattern.Entity;

ProductDirector director = new();

Product p1 = director.GenerateProduct(new PhoneProductBuilder());
Console.WriteLine("P1 Name : " + p1.Name);
Console.WriteLine("P1 CategoryName : " + p1.CategoryName);
Console.WriteLine("P1 KDV : " + p1.KDV);
Console.WriteLine("P1 Price : " + p1.Price);
Console.WriteLine("P1 PriceWithKDV : " + p1.PriceWithKDV);

Console.WriteLine("------------------");

Product p2 = director.GenerateProduct(new LaptopProdcutBuilder());
Console.WriteLine("P2 Name : " + p2.Name);
Console.WriteLine("P2 CategoryName : " + p2.CategoryName);
Console.WriteLine("P2 KDV : " + p2.KDV);
Console.WriteLine("P2 Price : " + p2.Price);
Console.WriteLine("P2 PriceWithKDV : " + p2.PriceWithKDV);


Console.ReadLine();