using MultitonPattern.Entities;

Brand brand1 = Brand.GetBrand("Nike");
Brand brand2 = Brand.GetBrand("Nike");
Brand brand3 = Brand.GetBrand("Puma");
Brand brand4 = Brand.GetBrand("Puma");

Console.WriteLine(brand1.Id);
Console.WriteLine(brand2.Id);
Console.WriteLine(brand3.Id);
Console.WriteLine(brand4.Id);

Console.ReadLine();